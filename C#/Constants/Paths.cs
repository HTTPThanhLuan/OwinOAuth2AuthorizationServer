using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public static class Paths
    {
        /// <summary>
        /// AuthorizationServer project should run on this URL
        /// </summary>
       
        //public const string AuthorizationServerBaseAddress = "http://localhost:11625";
        public const string AuthorizationServerBaseAddress = "https://localhost:44356";
        // public const string AuthorizationServerBaseAddress = "https://oauth2server.azurewebsites.net";

        /// <summary>
        /// ResourceServer project should run on this URL
        /// </summary>
        public const string ResourceServerBaseAddress = "http://localhost:38385";
        //public const string ResourceServerBaseAddress = "https://auth2resourceserver.azurewebsites.net";

        public const string ResourceServerNetCoreBaseAddress = "http://localhost:60247";

        /// <summary>
        /// ImplicitGrant project should be running on this specific port '38515'
        /// </summary>
        //public const string ImplicitGrantCallBackPath = "http://localhost:38515/Home/SignIn";
        //public const string ImplicitGrantCallBackPath = "https://localhost:44322/Home/SignIn";
        public const string ImplicitGrantCallBackPath = "https://authimplicitgrant.azurewebsites.net/Home/SignIn";

        /// <summary>
        /// AuthorizationCodeGrant project should be running on this URL.
        /// </summary>
        // public const string AuthorizeCodeCallBackPath = "https://localhost:44335/";
        public const string AuthorizeCodeCallBackPath = "http://localhost:38500/";

       // public const string AuthorizeCodeCallBackPath = "https://authorizationcodegrant.azurewebsites.net/";



        public const string AngularJsCallBackURL = "https://localhost:44363";

        public const string AuthorizePath = "/OAuth/Authorize";
        public const string TokenPath = "/OAuth/Token";
        public const string LoginPath = "/Account/Login";
        public const string LogoutPath = "/Account/Logout";
        public const string MePath = "/api/Me";
        public const string MeNetCorePath = "/api/values";
    }
}