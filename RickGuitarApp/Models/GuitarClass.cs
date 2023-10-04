using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarApp.Models
{
    public  class GuitarClass
    {
        private string SerialNumber;

        private double Price; 


        public GuitarSpecClass Spec;


        public GuitarClass(string serialNumber, double price, GuitarSpecClass spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            this.Spec = spec;
        }

        public string serialNumber
        {
            get { return SerialNumber; }
        }

        public double price
        {
            get
            {return Price; }
        }
        public override string ToString()
        {
            return $" We have a  SerialNumber :{SerialNumber},You can have it for only ${Price},\nGuitarType :{Spec.getGuitarType()},\nBuilder " +
                 $":{Spec.getBuilder()},\nBackWood :{Spec.getBackWood()}\nTopWoodModel :{Spec.getTopWood()}\nModel :{Spec.getModel()},\n ----------------------------";
        }
    }
}
