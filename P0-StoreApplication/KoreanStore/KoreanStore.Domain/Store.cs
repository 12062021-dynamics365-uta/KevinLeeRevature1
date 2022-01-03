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

        public Store ()
        { }

        
        public Store(int sId, string sLocation)
        {
            this.StoreId = sId;
            this.StoreLocation = sLocation;
        }      
    }
}
