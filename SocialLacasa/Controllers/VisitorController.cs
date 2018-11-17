using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialLacasa.Controllers
{
    public class VisitorController : Controller
    {
        // GET: Visitor
        public ActionResult Index()
        {
        
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            //String strConnString = ConfigurationManager.ConnectionStrings["DBSocialLacasa"].ConnectionString;
            //SqlConnection nwindConn = new SqlConnection(strConnString);
            //SqlCommand selectCMD = new SqlCommand("SELECT * from UserDetails", nwindConn);
            //selectCMD.CommandTimeout = 30;
            //SqlDataAdapter customerDA = new SqlDataAdapter();
            //customerDA.SelectCommand = selectCMD;
            //nwindConn.Open();
            //DataSet customerDS = new DataSet();
            //customerDA.Fill(customerDS, "Customers");
            //nwindConn.Close();
            return View();
        }
        public ActionResult Terms()
        {
            return View();
        }
        
        public ActionResult SignIn()
        {
            return View();
        }
       
        public ActionResult Services()
        {
            return View();
        }
    }
}