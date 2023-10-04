using RickGuitarApp.Models;

namespace RickGuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            AddDetailsGuitar(inventory);

            String searchSerialNumber = "76531";
            Console.WriteLine(SearchGuitarSerailNumber(searchSerialNumber));
           

            GuitarSpecClass PersonNeedSpec= new GuitarSpecClass(BuilderType.Fender, "Stratocaster", GuitarType.Electric,
                                                                WoodType.Adirondack,WoodType.Sitka );

            List<GuitarClass> matchingGuitarFinded = inventory.FindMatchGuitar(PersonNeedSpec);

            if (matchingGuitarFinded.Count > 0)
            {

                foreach (var item in matchingGuitarFinded)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else { Console.WriteLine("sorry you have no guitar"); }



            string SearchGuitarSerailNumber(string serialNumber)
            {
              string detailsFound=  inventory.GetGuitar(serialNumber);
                return detailsFound;
            }

            void AddDetailsGuitar(Inventory inventory)
            {
                inventory.AddGuitar("11277", 3999.95, new GuitarSpecClass(BuilderType.Collings, "CJ", GuitarType.Acoustic, WoodType.IndianRosewood, WoodType.Maple));
                inventory.AddGuitar("V95693", 1499.95, new GuitarSpecClass(BuilderType.Fender, "Stratocaster", GuitarType.Electric, WoodType.Adirondack, WoodType.Sitka));
                inventory.AddGuitar("V9512", 1549.95, new GuitarSpecClass(BuilderType.Fender, "Stratocaster", GuitarType.Electric, WoodType.Cocobolo, WoodType.BrazilianRosewood));
                inventory.AddGuitar("122784", 5495.95, new GuitarSpecClass(BuilderType.Martin, "D-18", GuitarType.Acoustic, WoodType.Sitka, WoodType.Alder));
                inventory.AddGuitar("76531", 6295.95, new GuitarSpecClass(BuilderType.Collings, "OM-28", GuitarType.Electric, WoodType.BrazilianRosewood, WoodType.Cedar));
                inventory.AddGuitar("70108276", 2295.95, new GuitarSpecClass(BuilderType.Ryan, "Les Paul", GuitarType.Acoustic, WoodType.Mahogany, WoodType.Maple));

            }
        }
    }
}