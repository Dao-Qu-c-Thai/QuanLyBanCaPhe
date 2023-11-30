using QLCF_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCF_Web.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        QUANLYCAPHE1Entities3 db=new QUANLYCAPHE1Entities3();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public ActionResult AddtoCart(int id)
        {
            var pro = db.THUC_UONG.SingleOrDefault(x => x.MA_THUC_UONG == id);
            if (pro != null)
            {
                GetCart().Add(pro);
            }

            return RedirectToAction("ShowCart", "Cart");
        }
        public ActionResult ShowCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("ShowCart", "Cart");
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult update_quantity_cart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            int id_pro = Convert.ToInt32(form["id"]);
            int quantity = Convert.ToInt32(form["quantity"]);
            cart.update_quantity(id_pro, quantity);
            return RedirectToAction("ShowCart", "Cart");
        }
        public ActionResult remove(int id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.remove_cart(id);
            return RedirectToAction("ShowCart", "Cart");
        }
        public PartialViewResult BagCart()
        {
            int total_item = 0;
            Cart cart = Session["Cart"] as Cart;
            if(cart != null)
            
                total_item = cart.total_quantity_cart();
                ViewBag.Quantitycart = total_item;
                return PartialView("BagCart");
            

        }
    }
}
