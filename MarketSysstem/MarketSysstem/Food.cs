using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSysstem
{
    class Food
    {
        private string Name;
        private int Id=0;
        private double Weight;
        private double Price;
        private DateTime Exdt;
        private string CategoryName;

        public string _Name
        {
            get { return Name; }
            set
            {
                Name = value;
                //if((Na_Nameme.Length > 3) && (Name.Length < 50))
                //{
                //    Name = value;
                //}
            }
        }

        

        public double _Weight
        {
            get { return Weight; }
            set
            {
                if (Weight >= 0)
                {
                    Weight = value;
                }
            }
        }

        public DateTime _EXDT
        {
            get { return Exdt; }
            set
            {
                Exdt = value;
            }
        }

        public int _Id
        {
            get { return Id; }
        }
        public Food()
        {
            Id ++;
           
        }

        public string _CategoryName
        {
            get { return CategoryName; }
            set
            {
                CategoryName = value;
            }
        }

        public double _Price
        {
            get { return Price; }
            set
            {
                Price = value;
            }
        }

    }
    


}
