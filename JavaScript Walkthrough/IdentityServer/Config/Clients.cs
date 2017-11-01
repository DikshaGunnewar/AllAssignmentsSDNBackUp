namespace IdentityServer.Config
{
    using IdentityServer3.Core.Models;
    using System.Collections.Generic;

    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "JS Client",
                    ClientId = "js",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:44300/popup.html",
                        "http://localhost:44300/silent-renew.html"
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:44300/index.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:44300"
                    },

                    AllowAccessToAllScopes = true,
                    AccessTokenLifetime = 60
                }
            };
        }
    }
}