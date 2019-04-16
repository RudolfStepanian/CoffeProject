using coffee.DataAccessLayer;
using coffee.DataAccessLayer.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace coffee.CTypes
{
    public class Coffee
    {
        public decimal coffee { get; set; }
        public decimal sugar { get; set; }
        public decimal water { get; set; }
        public decimal milk { get; set; }
        public decimal cup { get; set; }
        public int price { get; set; }

        public void Serve()
        {
            List<SPParam> list = new List<SPParam>()
            {
                new SPParam("@QuantityC", this.coffee),
                new SPParam("@QuantityW", this.water),
                new SPParam("@QuantityS", this.sugar),
                new SPParam("@QuantityM", this.milk),
                new SPParam("@QuantityCup", this.cup)
            };
            DataAccess.ExecuteSPWithNoResult("ReduceStore", list);
            DataAccess.ExecuteSPWithNoParam("CheckStore");
        }
    }
}
