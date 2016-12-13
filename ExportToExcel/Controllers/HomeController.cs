using ExportToExcel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ExportToExcel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
       
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Download()
        {

            //List<MyObject> myList = new List<MyObject>();
            //myList.Add(new MyObject(1, "Tables"));
            //myList.Add(new MyObject(2, "Cups"));
            //myList.Add(new MyObject(3, "Chairs"));
            //myList.Add(new MyObject(4, "Bottles"));
            //myList.Add(new MyObject(5, "Spoons"));
           
           
            //var gv = new GridView();
            //gv.DataSource = myList;
            return new GetExcel();

        }
    }


    public class MyObject
    {
        public MyObject(int myInt, string myString)
        {
            _myInt = myInt;
            _myString = myString;
        }
        private int _myInt;
        public int MyInt
        {
            get { return _myInt; }
            set { _myInt = value; }
        }
        private string _myString;
        public string MyString
        {
            get { return _myString; }
            set { _myString = value; }
        }
    }
}
