﻿#region Copyright

// Maxotek CONFIDENTIAL INFORMATION
// © 2007-2016 Maxotek Inc.
// All Rights Reserved
//                                                                   
// This program contains confidential and proprietary information   
// of the Maxotek, Inc.  Any reproduction, disclosure, or use       
// in whole or in part is expressly prohibited, except as may be    
// specifically authorized by prior written agreement.

#endregion

#region Imports

using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using vidly_aspnet_learn.App_Start;

#endregion

namespace vidly_aspnet_learn
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}