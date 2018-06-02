using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSysstem
{
    public class Categories
    {
        private string Name;
        private int Id;
        //private static Categories[] categories;

        public string _Name
        {
            get { return Name; }
            set
            {
                Name = value;
            }
        }
        public int _Id
        {
            get { return Id; }
        }
        public Categories()
        {
            Id++;
        }
    }
}
