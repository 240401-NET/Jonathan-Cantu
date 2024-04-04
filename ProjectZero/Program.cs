namespace projectZero;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program Started!");

    
    List<NationalPark> nationalParksList = new();

        Data.LoadParks(ref nationalParksList);

        //Add  hardcoded national Parks, append them to list
        NationalPark GrandCanyon = new("GrandCanyon", "Arizona", "earths butt crack");
        NationalPark JoshuaTree = new("JoshuaTree", "California", "Desert with huge rocks");
        NationalPark SeqoiaNationalPark = new("Seqoia National Park", "California", "big ass trees");

        //Appending characters to the list 
        nationalParksList.Add(GrandCanyon);
        nationalParksList.Add(JoshuaTree);
        nationalParksList.Add(SeqoiaNationalPark);
    

    // Code for Parks ive been too
    //List<NationalPark> parksIveBeenToo = new();
        // load parksIveBeenToo here
        //Data.LoadPIBT(ref parksIveBeenToo);
    
    
    
    
    
    
    
    int userInput =0;

    while (userInput !=9){
        // show menu
        Menu.PrintMenu();
        //store input into userInput
        userInput = Menu.UserChoice();

        // isue to address, when you print out all national parks more than once, it adds duplicates to the json file


        switch(userInput){
            //Show All National Parks
            case 1: Console.WriteLine("A bunch of National Parks");
            Logic.DisplayParks(nationalParksList);
                
            break;
            //Tell me how many parks ive been too
            case 2: Console.WriteLine("Invalid choice, please enter again!");
            // create method to count parks ive been too
            // Display parks ive been too


            break;
            // add/remove parks to bucket List -- shows bucket list parks
            case 3:Console.WriteLine("Invalid choice, please enter again!");
            // create secondary menu, Displays options and displays current bucket list parks
            // add or remove bucket list items( system basicaly will recreate list 
            //and overwrite existing json file)



            
            break;
            // add/remove personal notes to a park
            case 5: Console.WriteLine("Invalid choice, please enter again!");
            


            
            break;
            case 9:Console.WriteLine("Goodbye!");
            break;
            default:
            Console.WriteLine("Invalid choice, please enter again!");
            break;

        }
    }
Data.PersistNationalParks(nationalParksList);
    }

}
