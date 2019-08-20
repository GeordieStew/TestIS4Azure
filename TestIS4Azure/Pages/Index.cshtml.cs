using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TestIS4Azure.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private string Username => _contextAccessor.HttpContext.User.Identity.Name;

        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpContextAccessor _contextAccessor;

        public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        public void OnGet()
        {
            _logger.LogWarning($"USER - {Username}");
        }
    }
}
