﻿using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace TutorialSecuringASPNETCore2
{
    public static class Config
    {
        // test users
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser> {
            new TestUser
            {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "Frank",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Frank"),
                        new Claim("family_name", "Underwood"),
                    }
                },
            new TestUser
            {
                SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                Username = "Claire",
                Password = "password",

                Claims = new List<Claim>
                {
                    new Claim("given_name", "Claire"),
                    new Claim("family_name", "Underwood"),
                }
            }
            };
        }

        // identity-related resources (scopes)
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource> {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client
                {
                    ClientName = "Image Gallery",
                    ClientId = "imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RedirectUris = new List<string>()
                    {
                        "https://localhost:44355/sionin-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId
                    },
                    ClientSecrets =
                    {
                        new Secret("Secret".Sha256())
                    }
                }
            };
        }
    }
}
