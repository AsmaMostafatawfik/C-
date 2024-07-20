namespace Inventort_Managment_System
{
    internal class Program
    {
        const  int NumOfItems = 100;
        static int counterItem = 0;
        static string[,] InventoryItems = new string[NumOfItems, 3];
        static void Main(string[] args)
        {
            //Welcom to user
            //add item
            //update item
            //view all items (id,name,price,quantity)
            //exit

            Console.WriteLine("Welcom to Inventort System .");
            Console.WriteLine("------------------------------");
            while (true)
            {
                Console.WriteLine("Choose one from this list ....");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Update Item");
                Console.WriteLine("3. View All Items");
                Console.WriteLine("4. Exit");

                string chosen=Console.ReadLine();


                switch (chosen)
                {
                    case "1":
                        AddItem();
                        break;
                    case "2":
                        UpdateItem();
                        break;
                    case "3":
                        ViewItems();
                        break;
                    case "4":
                        Console.WriteLine("Good Bye ....");
                        Environment.Exit(0);
                        
                        break;

                    default:
                        Console.WriteLine("You should choose from the list .");
                        break;
                }

               

            }
        }




        public static void AddItem()
        {
            Console.WriteLine("Enter Item Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Item Quantity : ");
            string quantity = Console.ReadLine();

            Console.WriteLine("Enter Item Price : ");
            string price = Console.ReadLine();

            InventoryItems[counterItem, 0] = name;
            InventoryItems[counterItem, 1] = quantity;
            InventoryItems[counterItem, 2] = price;
            counterItem++;

            Console.WriteLine("The item was added successfully .");
            Console.WriteLine("---------------------------------");



        }
        public static void UpdateItem()
        {
            Console.WriteLine("Enter Item ID that you want to update : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            if (ID > counterItem)
            {
                Console.WriteLine(" Item  not found ..");
            }
            else
            {
                Console.WriteLine("Choose one from this list which you want to update ..");
                Console.WriteLine("1. Update Name");
                Console.WriteLine("2. Update Quantity");
                Console.WriteLine("3. Update Price");

                string chosen = Console.ReadLine();


                switch (chosen)
                {
                    case "1":
                        Console.WriteLine("Enter Item New Name : ");
                        string newName = Console.ReadLine();
                        InventoryItems[ID, 0] = newName;
                        Console.WriteLine("Name updated successfully .");
                        break;
                    case "2":
                        Console.WriteLine("Enter Item New Quantity : ");
                        string newQuantity = Console.ReadLine();
                        InventoryItems[ID, 1] = newQuantity;
                        Console.WriteLine("Quantity updated successfully .");
                        break;
                    case "3":
                        Console.WriteLine("Enter Item New Price : ");
                        string newPrice = Console.ReadLine();
                        InventoryItems[ID, 2] = newPrice;
                        Console.WriteLine("Price updated successfully .");
                        break;
                    default:
                        Console.WriteLine("You should choose from the list .");
                        break;
                }
            }
            //Console.WriteLine("The item was updated successfully .");
            Console.WriteLine("---------------------------------");

        }
        public static void ViewItems()
        {
            Console.WriteLine("Item List : ");

            if (counterItem == 0)
            {
                Console.WriteLine("There are no items added currently ز");
            }
            else
            {
                for (int i = 0; i < counterItem; i++)
                {

                    Console.WriteLine($"ID = {i}   Name = {InventoryItems[i, 0]}    Quantity = {InventoryItems[i, 1]}     Price = {InventoryItems[i, 2]} ");

                }
            }
            Console.WriteLine("----------------------------------------");
        }


    }
  
}
