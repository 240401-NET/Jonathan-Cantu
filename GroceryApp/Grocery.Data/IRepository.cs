using Grocery.Models;
namespace Grocery.Data;

public interface IRepository
{
    IEnumerable<Item> GetAllGroceries();
    
    Item CreateNewItem(Item item);

}
