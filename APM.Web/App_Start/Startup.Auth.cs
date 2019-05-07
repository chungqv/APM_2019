using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using APM.Common;
using APM.Data;
using APM.Entity.Models;
using APM.Service;
using APM.Web.Infrastructure.Core;

[assembly: OwinStartup(typeof(APM.Web.App_Start.Startup))]

namespace APM.Web.App_Start
{
    public partial class Startup
    {
       
    }
}