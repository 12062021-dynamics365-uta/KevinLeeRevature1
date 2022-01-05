using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanStore.Domain
{
    public class Store
    {
        public string StoreLocation { get; set; }
        public int StoreId { get; set; }
        public List<Product> products { get; set; }
        

        
        public Store(int sId, string sLocation)
        {
            this.StoreId = sId;
            this.StoreLocation = sLocation;
            products = new List<Product>();
        }

        public Store()
        {
            products = new List<Product>();

        }       
    }
}
