using Grocery.Models;
namespace Services;

public interface IGroceryService{
    IEnumerable<Item> GetAllGroceries();

    Item CreateNewItem(Item item);
}