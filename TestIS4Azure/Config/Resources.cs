using IdentityServer4.Models;
using System.Collections.Generic;

namespace TestIS4Azure.Config
{
    internal class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource> {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResource {
                Name = "role",
                UserClaims = new List<string> {"role"}
            }
        };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource> {
            new ApiResource {
                Name = "api1",
                DisplayName = "Api 1",
                Description = "Api 1",
                Scopes = new List<Scope> {
                    new Scope("api.xxx"),
                }
            },
            new ApiResource {
                Name = "api2",
                DisplayName = "Api 2",
                Description = "Api 2",
                Scopes = new List<Scope> {
                    new Scope("api2.xxx"),
                }
            }
        };
        }
    }
}
