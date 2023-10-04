using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickGuitarApp.Models
{
     public class Inventory
    {
      
        List<GuitarClass> guitarClasses;

        public Inventory() 
        {
            guitarClasses = new List<GuitarClass>();
        }

        public void AddGuitar(string snumber,double price,GuitarSpecClass spec)
        {
            GuitarClass guitarClassObj=new GuitarClass(snumber, price, spec);
            guitarClasses.Add(guitarClassObj);
        }


        public string GetGuitar(string serialNumber)
        {
            foreach (var item in guitarClasses)
            {
                if(item.serialNumber==serialNumber)
                {
                    return item.ToString();
                }
            }
            return $"Invalid search check the  Serial Number searched";
        }

        public List<GuitarClass> FindMatchGuitar(GuitarSpecClass personNeedSpec)
        {
            List<GuitarClass> matchCheckedGuitar = new List<GuitarClass>();

            foreach (var guitar in guitarClasses)
            {
                if (guitar.Spec.CheckMatches(personNeedSpec))
                    matchCheckedGuitar.Add(guitar);
            }


            return matchCheckedGuitar;
        }
    }

   
}
