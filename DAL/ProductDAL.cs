using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        public DataTable ShowList()
        {
            var data = new Data();

            return data.ShowDataTable("SELECT * FROM Product", null);
        }

        public int Delete(string sku)
        {
            var data = new Data();
            var skuParameter = new SqlParameter("@pSku", sku);

            var allParams = new SqlParameter[] { skuParameter };

            return data.ExecuteWithoutResult("DELETE FROM Product WHERE sku = @pSku", allParams);
        }

        public int Update(string sku, string name, double price, bool enabled, int minQuantity, int maxQuantity)
        {
            var data = new Data();

            var pSku = new SqlParameter("@pSku", sku);
            var pName = new SqlParameter("@pName", name);
            var pPrice = new SqlParameter("@pPrice", price);
            var pEnabled = new SqlParameter("@pEnabled", enabled);
            var pMinQuantity = new SqlParameter("@pMinQuantity", minQuantity);
            var pMaxQuantity = new SqlParameter("@pMaxQuantity", maxQuantity);

            var allParams = new SqlParameter[] { pSku, pName, pPrice, pEnabled, pMinQuantity, pMaxQuantity };

            return data.ExecuteWithoutResult("UPDATE PRODUCT SET name = @pName, price = @pPrice, is_enabled = @pEnabled, min_quantity = @pMinQuantity, max_quantity = @pMaxQuantity WHERE sku = @pSku", allParams);
        }

        public DataTable Search(string productName, string sku, string brand)
        {
            var data = new Data();

            var pName = new SqlParameter("@pName", productName);
            var pSku = new SqlParameter("@pSku", sku);
            var pBrand = new SqlParameter("@pBrand", brand);

            var allParams = new SqlParameter[] { pName, pSku, pBrand };

            if(string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(sku) && string.IsNullOrEmpty(brand))
            {
                return data.ShowDataTable("SELECT * FROM Product", null);
            }else
            {
                return data.ShowDataTable("SELECT * FROM Product WHERE name = ISNULL(@pName,name) OR sku = ISNULL(@pSku,sku) OR brand = ISNULL(@pBrand, brand)", allParams);
            }
        }

        public int Insert(string sku, string brand, string name, double price, bool isEnabled, int minQuantity, int maxQuantity, int productTypeId)
        {
            var data = new Data();

            var pSku = new SqlParameter("@pSku", sku);
            var pBrand = new SqlParameter("pBrand", brand);
            var pName = new SqlParameter("@pName", name);
            var pPrice = new SqlParameter("@pPrice", price);
            var pEnabled = new SqlParameter("@pEnabled", isEnabled);
            var pMinQuantity = new SqlParameter("@pMinQuantity", minQuantity);
            var pMaxQuantity = new SqlParameter("@pMaxQuantity", maxQuantity);
            var pProductType = new SqlParameter("@pProductTypeId", productTypeId);

            var allParams = new SqlParameter[] { pSku, pBrand, pName, pPrice, pEnabled, pMinQuantity, pMaxQuantity, pProductType };

            return data.ExecuteWithoutResult("INSERT INTO Product (sku, brand, name, price, is_enabled, min_quantity, max_quantity, product_type_id) VALUES (@pSku, @pBrand, @pName, @pPrice, @pEnabled, @pMinQuantity, @pMaxQuantity, @pProductTypeId)", allParams);
        }

        public DataTable GetProductBySku(string sku)
        {
            var data = new Data();

            var pSku = new SqlParameter("@pSku", sku);

            var allParams = new SqlParameter[] { pSku };
            return data.ShowDataTable("SELECT TOP 1 * FROM Product WHERE sku = @pSku", allParams);
        }
    }
}
