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
    */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var foodWarehouse = new Warehouse<FoodItem>();
            var weaponWarehouse = new Warehouse<WeaponItem>();
            var medicalWarehouse = new Warehouse<MedicalItem>();

            var potatoes = new FoodItem("Bulves", 10, new DateOnly(2030, 07, 19), 300);
            var carrots = new FoodItem("Morkos", 15, new DateOnly(2045, 01, 22), 500);

            var sword = new WeaponItem("Kalavijas", 6, 60);
            var knife = new WeaponItem("Peilis", 0.8, 20);

            var bandage = new MedicalItem("Bintas", 0.2, new DateOnly(2034, 08, 15), "Minor cuts. Burns. Sprains.");
            var painkiller = new MedicalItem("Nuskausminamieji", 0.1, new DateOnly(2028, 01, 01), "Sprains. Sunburns. Arthritis.");

            foodWarehouse.AddItem(potatoes);
            foodWarehouse.AddItem(carrots);

            weaponWarehouse.AddItem(sword);
            weaponWarehouse.AddItem(knife);

            medicalWarehouse.AddItem(bandage);
            medicalWarehouse.AddItem(painkiller);

            var allFood = foodWarehouse.GetItems();
            var allWeapons = weaponWarehouse.GetItems();
            var allMedical = medicalWarehouse.GetItems();

            var carrotsItem = foodWarehouse.GetItem("morkos");
            var knifeItem = weaponWarehouse.GetItem("peilis");
            var painkillerItem = medicalWarehouse.GetItem("nuskausminamieji");
        }
    }
}
