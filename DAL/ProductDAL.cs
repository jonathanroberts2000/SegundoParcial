using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
