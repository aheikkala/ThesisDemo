using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin;
//[assembly: OwinStartup(typeof(ThesisDemo.Startup))]

namespace ThesisDemo
{
    /// <summary>
    /// Used by OWIN's startup process. 
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}
