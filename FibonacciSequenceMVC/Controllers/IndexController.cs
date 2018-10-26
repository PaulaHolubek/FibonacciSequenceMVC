using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciSequenceMVC.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            int[] array = new int[20];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <=19; i++)
            {
                array[i] = array[i-1] + array[i-2];    
            }
            ViewBag.MyArray = array;
            return View();
        }
    }
}