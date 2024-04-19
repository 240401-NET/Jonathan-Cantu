using Grocery.Models;
using Grocery.Data;
using System.Text.RegularExpressions;

namespace Services;

public class GroceryService : IGroceryService {

    private readonly IRepository _itemRepo;

    public GroceryService(IRepository repo) => _itemRepo = repo;
    public IEnumerable<Item> GetAllGroceries() {
        return _itemRepo.GetAllGroceries();
    }

    public Item CreateNewItem(Item item) {
        // Additional data validation logic that doesn't fit in either layers, you could put in here
        return _itemRepo.CreateNewItem(item);
    }
}