using Aloji.JwtSecurity.Options;
using Aloji.Owin.JwtSecurity;
using Microsoft.Owin.Security.OAuth;

using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceServer
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            {
                AccessTokenFormat = new JwtSecureDataFormat(
                 new JwtSecurityOptions
                 {
                     Issuer = "12",
                     IssuerSigningKey = "8E8496D7342EA258526CF6177E04EA7D208E359C95E60CD2A462FC062B9E41B3"
                 })
            });
           // app.UseOAuthBearerAuthentication(new Microsoft.Owin.Security.OAuth.OAuthBearerAuthenticationOptions());
        }
    }

}