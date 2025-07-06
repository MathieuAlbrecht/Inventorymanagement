using System.Diagnostics;
using Inventorymanagement;

class Program
{
    static void Main()
    {
        bool addMore = true;

        Console.WriteLine("Welcome to the Inventory Management System!");
        Console.WriteLine("This program will help you manage your inventory effectively.");

        Console.WriteLine("Do you want to add an item to the inventory or view the inventory? (add/view)");
        string action = Console.ReadLine().ToLower();
        if (action == "add")
        {
            while (addMore)
            {
                AddItem.RunAddItem();
                Console.WriteLine("Would you like to add another item? (yes/no)");
                string input = Console.ReadLine().ToLower();
                if (input == "no")
                {
                    addMore = false;
                    Console.WriteLine("Thank you for using the Inventory Management System!");
                    Debug.WriteLine("Exiting the program.");
                }
                else if (input != "yes")
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
                else
                {
                    Debug.WriteLine("Adding another item to the inventory.");
                }
            }
            Main();
        }
        else if (action == "view")
        {
            showInventory.RunShowInventory();
            Console.WriteLine("If you want to add an item, press any key to return to the main menu.");
            Console.ReadKey();
            Main();
        }
        else
        {
            Console.WriteLine("Invalid action. Please enter 'add' or 'view'.");
        }
    }
}