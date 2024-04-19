using Moq;
using Services;
using Grocery.Models;
using Grocery.Data;
namespace Grocery.Tests;

public class UnitTest1
{
    [Fact]
    public void SeriveShouldGetAllGroceries()
    {
        // Arrange
        Mock<IRepository> repoMock = new Mock<IRepository>();

        IEnumerable<Item> testItem = [
            new Item{
                Id = 1,
                Name = "Test Pet"
            }
        ];

        repoMock.Setup(repo => repo.GetAllGroceries()).Returns(testItem);
        GroceryService service = new GroceryService(repoMock.Object);

        //Act
        IEnumerable<Item> allItems = service.GetAllGroceries();
        
        //Assert
        // Check to verify we actually got the data we faked
        Assert.Single(allItems);
        // Also check that GetAllPets of PetRepository was called Only Once
        repoMock.Verify(repo => repo.GetAllGroceries(), Times.Exactly(1));
    }
    
}