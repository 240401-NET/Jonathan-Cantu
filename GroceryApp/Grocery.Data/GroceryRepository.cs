using Grocery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
namespace Grocery.Data;

public class GroceryRepository
{
    private readonly GroceryDbContext _context;
    public GroceryRepository(GroceryDbContext context){
        _context = context;
    }

    public IEnumerable<Item> GetAllGroceries(){
        return _context.Groceries.ToList();
    }
    
    public  Item CreateNewItem(Item item){
        _context.Groceries.Add(item);
        _context.SaveChanges();
        return item;
    }

}
