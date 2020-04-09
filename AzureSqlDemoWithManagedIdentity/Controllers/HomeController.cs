using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureSqlDemoWithManagedIdentity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string ConnectionString = @"Data Source=msidemoserver.database.windows.net; Authentication=Active Directory Integrated; Initial Catalog=emp;";
             string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            
            SqlConnection conn = new SqlConnection(ConnectionString);
          //  conn.AccessToken = (new Microsoft.Azure.Services.AppAuthentication.AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net/").Result;
            conn.Open();
            return Content("Congrats....db connection was successful!");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}