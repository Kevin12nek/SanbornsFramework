using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class EmpleadoController : Controller
    {
       

        // GET: Empleado

        [HttpGet]
        public ActionResult Report()
        {
            int Year = 0;
            ML.Result result = BL.Empleado.GetReport(Year);
            
            ML.Result result1 = BL.Empleado.AnyosGet();
            
            ML.Orders orders = new ML.Orders();

            orders.Anyos = new ML.Anyo();
            orders.Anyos.Anyos = result1.Objects;

            orders.OrderS = result.Objects;

            

            return View(orders);
        }

        [HttpPost]
        public ActionResult Report(int? Year)
        {

            ML.Result result = BL.Empleado.GetReport(Year.Value);

            ML.Result result1 = BL.Empleado.AnyosGet();

            ML.Orders orders = new ML.Orders();

            orders.Anyos = new ML.Anyo();
            orders.Anyos.Anyos = result1.Objects;

            orders.OrderS = result.Objects;



            return View(orders);
        }


        public ActionResult Report3()
        {
            ML.Result result = BL.Empleado.GetAllTercer0();
            ML.Orders orders = new ML.Orders();
            orders.OrderS = result.Objects;
            return View(orders);
        }

        public ActionResult ReportDescontinuado()
        {
            ML.Result result = BL.Empleado.GetPrimero();
            ML.Products products = new ML.Products();
            products.ProductS = result.Objects;
            return View(products);
        }

        public ActionResult ReportPromedio()
        {
            ML.Result result = BL.Empleado.GetPromedio();
            ML.Products products = new ML.Products();

            products.ProductS = result.Objects;
            return View(products);
        }

    }
}