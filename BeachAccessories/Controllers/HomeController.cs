using BeachAccessories.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeachAccessories.Controllers
{
    public class HomeController : Controller
    {
        BeachAccessoriesDbContext db = new BeachAccessoriesDbContext() { };
        public ActionResult Index()
        {
            ViewBag.Title = "Главная";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "О нас";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Контакты";
            return View();
        }


        [HttpGet]
        public ActionResult Buy(int? id, string name)
        {
            if (id != null && name != null && id is Int32 )
            {

                if (name == "Коврики")
                {
                    ViewBag.Product = db.Mats.Find(id);
                    return View();
                }
                else if (name == "Зонты")
                {
                    ViewBag.Product = db.Umbrellas.Find(id);
                    return View();
                }
                else if (name == "Полотенца")
                {
                    ViewBag.Product = db.Towels.Find(id);
                    return View();
                }
                else if (name == "Шляпы")
                {
                    ViewBag.Product = db.Hats.Find(id);
                    return View();
                }
                else if (name == "Матрасы")
                {
                    ViewBag.Product = db.Mattresses.Find(id);
                    return View();
                }
                else if (name == "Круги")
                {
                    ViewBag.Product = db.Rings.Find(id);
                    return View();
                }
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Buy(Purchase purchase)
        {
            if (purchase.ProductId != null && purchase.ProductCategory != null && purchase.ProductPrice != null &&
                purchase.ProductName != null && purchase.PersonName != null && purchase.EmailAdress != null &&
                purchase.PhoneNumber != null)
            {
                purchase.Date = DateTime.Now;
                db.Purchases.Add(purchase);
                db.SaveChanges();
                var deal = db.Purchases.Find(purchase.ProductId);
                ViewBag.Deal = deal;
                return View("Congrats");
            }
            return RedirectToAction("Index");
        }

        
        public ActionResult Categories(string id)
        {
            if(id == "Rings")
            {
                IEnumerable<Ring> Rings = db.Rings;
                ViewBag.Products = Rings;
                ViewBag.Category = "Круги";
                ViewBag.Title = "Круги";
                return View();
            }
            else if (id == "Hats")
            {
                IEnumerable<Hat> Hats = db.Hats;
                ViewBag.Products = Hats;
                ViewBag.Category = "Шляпы";
                ViewBag.Title = "Шляпы";
                return View();
            }
            else if(id == "Mats")
            {
                IEnumerable<Mat> Mats = db.Mats;
                ViewBag.Products = Mats;
                ViewBag.Category = "Коврики";
                ViewBag.Title = "Коврики";
                return View();
            }
            else if (id == "Mattresses")
            {
                IEnumerable<Mattress> Mattresses = db.Mattresses;
                ViewBag.Products = Mattresses;
                ViewBag.Category = "Матрасы";
                ViewBag.Title = "Матрасы";
                return View();
            }
            else if (id == "Umbrellas")
            {
                IEnumerable<Umbrella> Umbrellas = db.Umbrellas;
                ViewBag.Products = Umbrellas;
                ViewBag.Category = "Зонты";
                ViewBag.Title = "Зонты";
                return View();
            }
            else if (id == "Towels")
            {
                IEnumerable<Towel> Towels = db.Towels;
                ViewBag.Products = Towels;
                ViewBag.Category = "Полотенца";
                ViewBag.Title = "Полотенца";
                return View();
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Description(int? id, string name)
        {
            if (id != null && name != null && id is Int32)
            {

                if (name == "Коврики")
                {
                    ViewBag.Title = "Описание товара";
                    ViewBag.Category = "Коврики";
                    ViewBag.Product = db.Mats.Find(id);
                    return View();
                }
                else if (name == "Зонты")
                {
                    ViewBag.Category = "Коврики";
                    ViewBag.Title = "Описание товара";
                    ViewBag.Product = db.Umbrellas.Find(id);
                    return View();
                }
                else if (name == "Полотенца")
                {
                    ViewBag.Category = "Полотенца";
                    ViewBag.Title = "Описание товара";
                    ViewBag.Product = db.Towels.Find(id);
                    return View();
                }
                else if (name == "Шляпы")
                {
                    ViewBag.Category = "Шляпы";
                    ViewBag.Title = "Описание товара";
                    ViewBag.Product = db.Hats.Find(id);
                    return View();
                }
                else if (name == "Матрасы")
                {
                    ViewBag.Category = "Матрасы";
                    ViewBag.Title = "Описание товара";
                    ViewBag.Product = db.Mattresses.Find(id);
                    return View();
                }
                else if (name == "Круги")
                {
                    ViewBag.Category = "Круги";
                    ViewBag.Title = "Описание товара";
                    ViewBag.Product = db.Rings.Find(id);
                    return View();
                }
            }
            return RedirectToAction("Index");
        }

    }
}