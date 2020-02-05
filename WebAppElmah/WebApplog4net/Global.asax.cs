using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplog4net
{
    public class Global : HttpApplication
    {
        static log4net.ILog log;
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //log4net configuration
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //log written on  application start
            log.Info("application started");
            

        }
        void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError().GetBaseException();
            //log written on any error occurence
            log.Error(exception.Message);
        }

        void Session_Start(object sender, EventArgs e)
        {
            //log written on every new session start
            log.Info("session started");
        }
        void Session_End(object sender, EventArgs e)
        {
            //log written on everysession end
            log.Info("session expired");
        }

    }
}