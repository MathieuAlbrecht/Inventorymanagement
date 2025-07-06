using System.Diagnostics;
using System.Collections.Generic;
using System;

namespace Inventorymanagement;


public class AddItem
{
    public static List<string> itemNames = new List<string>();
    public static List<string> itemQuantities = new List<string>();

    public static void RunAddItem()
    {
        Console.WriteLine("What is the name of the item you want to add?");
        string itemName = Console.ReadLine();
        itemNames.Add(itemName);
        Console.WriteLine("What is the quantity of the item?");
        int quantity = int.Parse(Console.ReadLine());
        itemQuantities.Add(quantity.ToString());

        // Gesamte Listen ausgeben
        Debug.WriteLine("Alle Namen: " + string.Join(", ", itemNames));
        Debug.WriteLine("Alle Mengen: " + string.Join(", ", itemQuantities));
    }
}