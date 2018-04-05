﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace TexBilling
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            App_Start.IocConfig.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
