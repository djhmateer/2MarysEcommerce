using Ploeh.Samples.Mary.ECommerce.Data.Sql;
using Ploeh.Samples.Mary.ECommerce.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebMVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            bool isPreferredCustomer = this.User.IsInRole("PreferredCustomer");

            var service = new ProductService();
            IEnumerable<Product> products = service.GetFeaturedProducts(isPreferredCustomer);
            this.ViewData["Products"] = products;

            return this.View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}