using DL;
using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {

        public static ML.Result GetPrimero()
        {
            ML.Result result = new ML.Result();

            using (DL.NorthwindEntities context = new DL.NorthwindEntities())
            {
                var query = context.DESCONTINUADO().ToList();

                result.Objects = new List<object>();

                if (query.Count != null)
                {
                    foreach (var obj in query)
                    {
                        ML.Products products = new ML.Products();
                        products.ProductID = obj.ProductID;
                        products.ProductName = obj.ProductName;
                        products.Discontinued = obj.Discontinued;
                        products.SupplierID = (int)obj.SupplierID;
                        products.UnitPrice = (int)obj.UnitPrice;

                        result.Objects.Add(products);
                    }
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                }
                return result;
            }

        }

        public static ML.Result GetPromedio()
        {
            ML.Result result = new ML.Result();

            using (DL.NorthwindEntities context = new DL.NorthwindEntities())
            {
                var query = context.PROMEDIO().ToList();
                result.Objects = new List<object>();

                if (query.Count != null)
                {
                    foreach (var obj in query)
                    {
                        ML.Products products = new ML.Products();
                        products.ProductID = obj.ProductID;
                        products.ProductName = obj.ProductName;

                        products.CategorieS = new ML.Categories();
                        products.CategorieS.CategoryID = (int)obj.CategoryID;

                        products.CategorieS.CategoryName = obj.CategoryName;

                        products.UnitPrice = (int)obj.UnitPrice;

                        result.Objects.Add(products);
                    }
                    result.Correct = true;

                }
                else
                {
                    result.Correct = false;
                }
            }
            return result;
        }

        public static ML.Result GetReport(int Year)
        {
            ML.Result result = new ML.Result();

            using (DL.NorthwindEntities context = new DL.NorthwindEntities())
            {
                var query = context.OrderDate2(Year).ToList();

                result.Objects = new List<object>();

                if (query.Count != null)
                {
                    foreach (var item in query)
                    {
                        ML.Orders orders = new ML.Orders();
                        orders.OrderDate = (DateTime)item.OrderDate;

                        orders.Customers = new ML.Customers();
                        orders.Customers.CompanyName = item.CompanyName;

                        orders.OrderID = item.OrderID;

                        orders.DetailS = new ML.Details();
                        orders.DetailS.Quantity = item.Quantity;

                        orders.ProductS = new ML.Products();
                        orders.ProductS.ProductName = item.ProductName;

                        orders.SupplierS = new ML.Suppliers();
                        orders.SupplierS.CompanyName = item.CompanyNameSuppliers;

                        orders.SupplierS.City = item.City;

                        result.Objects.Add(orders);


                    }
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                }
            }
            return result;

        }

        public static ML.Result GetAllTercer0()
        {
            ML.Result result = new ML.Result();

            using (DL.NorthwindEntities context = new DL.NorthwindEntities())
            {
                var query = context.OrderDate().ToList();

                result.Objects = new List<object>();

                if (query.Count != null)
                {
                    foreach (var item in query)
                    {
                        ML.Orders orders = new ML.Orders();
                        orders.OrderDate = (DateTime)item.OrderDate;

                        orders.Customers = new ML.Customers();
                        orders.Customers.CompanyName = item.CompanyName;

                        orders.OrderID = item.OrderID;

                        orders.DetailS = new ML.Details();
                        orders.DetailS.Quantity = item.Quantity;

                        orders.ProductS = new ML.Products();
                        orders.ProductS.ProductName = item.ProductName;

                        orders.SupplierS = new ML.Suppliers();
                        orders.SupplierS.CompanyName = item.CompanyNameSuppliers;

                        orders.SupplierS.City = item.City;

                        result.Objects.Add(orders);
                    }
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "ERROR";
                }
                return result;
            }
        }

        public static ML.Result AnyosGet()
        {
            ML.Result result = new ML.Result();

            using(DL.NorthwindEntities context = new DL.NorthwindEntities())
            {
                var query = context.AnyosGet().ToList();

                result.Objects = new List<object>();

                if(query.Count != null)
                {
                    foreach(var item in query)
                    {
                        ML.Anyo anyo = new ML.Anyo();

                        anyo.AnyO = item.Value;

                        result.Objects.Add(item);
                    }
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                }
                return result;
            }
        }
    }
}
