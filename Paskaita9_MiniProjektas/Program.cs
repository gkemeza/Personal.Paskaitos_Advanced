namespace Paskaita9_MiniProjektas
{
    #region UŽDUOTIS Orientuota į TAIKYMO kognityvinį lygį
    /*mini projektas
    Šiame projekte sukursite programą, kuri tvarkys Doomsday Warehouse inventorių, naudodama paveldėjimą ir System.IO.File klasę.
    Programa leis pridėti naujus dalykus į inventorių, išsaugoti inventoriaus informaciją faile ir ją nuskaityti iš failo.
    - Sukurkite generinę klasę Warehouse<T>, kuri saugos skirtingų tipų prekes.
    - Sukurkite abstrakčią bazinę klasę Inventory Item, kuri apibrėžia bendrus inventoriaus elementų atributus - daikto svorį.
    - Sukurkite kelias klases, paveldinčias iš abstrakčios klasės InventoryItem, pavyzdžiui: FoodItem, WeaponItem ir MedicalItem.
    - Maistas turi papildomus atributus - galiojimo datą ir kalorijas,
                                        - ginklai - žalos dydį,
                                        - medicinina - galiojimo datą ir ligų sąrašą nuo kurių gydo (string).
    - Skirtingi inventoriai turi būti saugomi skirtinguose failuose csv formatu pvz: maistas.csv -> bulvės, 10kg, 2050-01-05, 500kcal
                                                                                                    dešra, 5kg, 2050-11-15, 1000kcal
                                                                                                    ir t.t....
                                                                                     ginklai.scv -> kalavijas, 2kg, 50dmg
                                                                                                    šautuvas, 3kg, 100dmg
                                                                                                    ir t.t....
    - Sukurkite Warehouse metodą AddItem(T item) kurie leis pridėti naujus daiktus į inventorių ir išsaugos turimo inventoriaus informaciją faile.
    - Sukurkite Warehouse metodą List<T> GetItems(), kuris nuskaitys inventoriaus informaciją iš failo ir grąžins visus inventoriaus elementus.
    - Sukurkite Warehouse metodą T GetItem(string name), kuris grąžins vieną atitinkamą inventoriaus elementą pagal pavadinimą.
    - Sukurkite 3 Warehouse klasės objektus, kuriuose saugosite skirtingų tipų (maistas, ginklai, medicina) prekes.
    + iskviesti AddHeader per konstruktoriu
    - panaikinti tuscius konstruktorius (nekurti tusciu objektu metoduose, naudoti typeof?)
    - change date format
    - Name has 1 space in front
    */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var foodWarehouse = new Warehouse<FoodItem>();
            var weaponWarehouse = new Warehouse<WeaponItem>();
            var medicalWarehouse = new Warehouse<MedicalItem>();

            var potatoes = new FoodItem(10, "Bulves", new DateTime(2030, 07, 19), 300);
            var carrots = new FoodItem(15, "Morkos", new DateTime(2045, 01, 22), 500);
            var sword = new WeaponItem(8, "Kalavijas", 60);
            var bandage = new MedicalItem(0.5, "Bintas", new DateTime(2034, 08, 15), "Minor cuts. Burns. Sprains.");

            foodWarehouse.AddItem(potatoes);
            foodWarehouse.AddItem(carrots);
            weaponWarehouse.AddItem(sword);
            medicalWarehouse.AddItem(bandage);

            var allFood = foodWarehouse.GetItems();
            var allWeapons = weaponWarehouse.GetItems();
            var allMedical = medicalWarehouse.GetItems();

            foreach (var food in allFood)
            {
                Console.WriteLine(food);
            }
            foreach (var weapon in allWeapons)
            {
                Console.WriteLine(weapon);
            }
            foreach (var medical in allMedical)
            {
                Console.WriteLine(medical);
            }

            var carrotsItem = foodWarehouse.GetItem("bulves");
            var bandageItem = medicalWarehouse.GetItem("BintaS");

            Console.WriteLine();
            Console.WriteLine(carrotsItem);
            Console.WriteLine(bandageItem);
        }
    }
}
