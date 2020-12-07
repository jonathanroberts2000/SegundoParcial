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
        public List<Product> LoadProducts(int order)
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

            switch(order)
            {
                case 0:
                    return result.OrderBy(x => x.Id).ToList();
                case 1:
                    return result.OrderBy(x => x.Name).ToList();
                case 2:
                    return result.OrderBy(x => x.ProductType).ToList();
                default:
                    return result;
            }
        }

        public List<Product> Search(string productName, string sku, string brand)
        {
            var productDAL = new ProductDAL();
            var dt = productDAL.Search(productName, sku, brand);
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

        public void DeleteProduct(string sku)
        {
            var productDAL = new ProductDAL();
            productDAL.Delete(sku);
        }

        public void UpdateProduct(string sku, string name, double price, bool enabled, int minQuantity, int maxQuantity)
        {
            var productDAL = new ProductDAL();
            productDAL.Update(sku, name, price, enabled, minQuantity, maxQuantity);
        }

        public void InsertNewProduct(string sku, string brand, double price, string name, bool enabled, int minQuantity, int maxQuantity, int productTypeId)
        {
            var productDAL = new ProductDAL();
            productDAL.Insert(sku, brand, name, price, enabled, minQuantity, maxQuantity, productTypeId);
        }

        public Product GetProductBySku(string sku)
        {
            var productDAL = new ProductDAL();
            var dt = productDAL.GetProductBySku(sku);

            foreach(DataRow aux in dt.Rows)
            {
                return new Product
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
                };
            }
            return null;
        }
    }
}
