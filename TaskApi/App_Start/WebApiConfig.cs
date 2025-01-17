﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TaskApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Enable cors for the reactjs client
            var cors = new EnableCorsAttribute("http://localhost:3000", "*", "GET,POST,DELETE");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{date}/{id}",
                defaults: new { id = RouteParameter.Optional, date = RouteParameter.Optional }
            );

        }
    }
}
