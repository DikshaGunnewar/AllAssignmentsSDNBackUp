﻿using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Web_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            

            //var setting = config.Formatters.JsonFormatter.SerializerSettings;
            //setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //setting.Formatting = Newtonsoft.Json.Formatting.Indented;


            // Web API configuration and services


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
