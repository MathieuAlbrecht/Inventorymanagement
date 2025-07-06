

namespace Inventorymanagement;

public class showInventory
{
    public static void RunShowInventory()
    {
        Console.WriteLine("Current Inventory:");
        if (AddItem.itemNames.Count == 0)
        {
            Console.WriteLine("The inventory is empty.");
        }
        else
        {
            for (int i = 0; i < AddItem.itemNames.Count; i++)
            {
                Console.WriteLine($"Item: {AddItem.itemNames[i]}, Quantity: {AddItem.itemQuantities[i]}");
            }
        }
    }
    
    
}