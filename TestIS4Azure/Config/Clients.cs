using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestIS4Azure.Config
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client> {
            new Client {
                ClientId = "clientA",
                ClientName = "Client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {
                    new Secret("passwordX".Sha256())},
                AllowedScopes = new List<string> { "api.xxx", "api2.xxx"
                }
            }
            };
        }
    }
}
