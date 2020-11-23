using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        public List<Product> LoadProducts()
        {
            var productDAL = new ProductDAL();
            var dt = productDAL.ShowList();
            var result = new List<Product>();

            foreach(DataRow aux in dt.Rows)
            {
                result.Add(new Product
                {
                    Id = Convert.ToInt32(aux["id"].ToString()),
                    Sku = aux["sku"].ToString(),
                    Brand = aux["brand"].ToString(),
                    Name = aux["name"].ToString(),
                    Price = Convert.ToDouble(aux["price"].ToString()),
                    IsEnabled = Convert.ToBoolean(aux["is_enabled"].ToString()),
                    MinQuantity = Convert.ToInt32(aux["min_quantity"].ToString()),
                    MaxQuantity = Convert.ToInt32(aux["max_quantity"].ToString()),
                    ProductType = (EProductType)Convert.ToInt32(aux["product_type_id"].ToString())
                });
            }

            return result;
        }
    }
}
