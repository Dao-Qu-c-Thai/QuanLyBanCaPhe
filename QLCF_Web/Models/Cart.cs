using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLCF_Web.Models
{
  
        public class cartItem
        {
            public THUC_UONG shopping_product { get; set; }
            public int shopping_quantity { get; set; }
        }
        public class Cart
        {
            List<cartItem> items = new List<cartItem>();
            public IEnumerable<cartItem> Items
            {
                get { return items; }
            }
            public void Add(THUC_UONG _pro, int quantity = 1)
            {
                var item = items.FirstOrDefault(s => s.shopping_product.MA_THUC_UONG == _pro.MA_THUC_UONG);
                if (item == null)
                {
                    items.Add(new cartItem
                    {
                        shopping_product = _pro,
                        shopping_quantity = quantity,
                    });

                }
                else
                {
                    item.shopping_quantity += quantity;
                }


            }
            public void update_quantity(int id, int quantity)
            {
                var item = items.Find(x => x.shopping_product.MA_THUC_UONG == id);

                if (item != null)
                {
                    item.shopping_quantity = quantity;
                }
            }
            public double total_money()
            {
                var total = items.Sum(s => s.shopping_product.GIA * s.shopping_quantity);
                return (double)total;
            }
        public int total_quantity_cart()
        {
            return items.Sum(s => s.shopping_quantity);
        }
            public void remove_cart(int id)
            {
                items.RemoveAll(x => x.shopping_product.MA_THUC_UONG == id);

            }

        
        }
}