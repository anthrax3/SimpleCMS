﻿using System.Web.Routing;

namespace SimpleCMS.Tests.Helpers
{
    public static class RouteDataExtension {
        public static RouteData WithValue(this RouteData routeData, string fieldName, object value) {
            routeData.Values[fieldName] = value;
            return routeData;
        }
    }
}