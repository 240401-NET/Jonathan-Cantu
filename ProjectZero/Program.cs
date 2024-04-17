namespace projectZero;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program Started!");

    
    List<NationalPark> nationalParksList = new();

        Data.LoadParks(ref nationalParksList);

        //Add  hardcoded national Parks, append them to list
        //NationalPark GrandCanyon = new("GrandCanyon", "Arizona", "earths butt crack", true, true);
        //1NationalPark JoshuaTree = new("JoshuaTree", "California", "Desert with huge rocks", false, false);
        

        //Appending characters to the list 
        //nationalParksList.Add(GrandCanyon);
        //nationalParksList.Add(JoshuaTree);
        
    

    // Code for Parks ive been too
    //List<NationalPark> parksIveBeenToo = new();
        // load parksIveBeenToo here
        //Data.LoadPIBT(ref parksIveBeenToo);
    
    
    
    int userInput =0;
    string input="";
    while (userInput !=9){
        // show menu
        Menu.PrintMenu();
        //store input into userInput
        userInput = Menu.UserChoice();

        // isue to address, when you print out all national parks more than once, it adds duplicates to the json file


        switch(userInput){
            //Show All National Parks
            case 1: Console.WriteLine("***National Parks List***");
            Logic.DisplayParks(nationalParksList);    
            break;
            
            //Tell me how many parks ive been too
            // create method to count parks ive been too
            // Display parks ive been too
            case 2: Console.WriteLine("Parks you been too!");
            Logic.RetrievePIBT(nationalParksList);
            break;

            // create secondary menu, Displays options and displays current bucket list parks
            // add or remove bucket list items( system basicaly will recreate list 
            //and overwrite existing json file
            // add/remove parks to bucket List -- shows bucket list parks
            case 3:Console.WriteLine("Invalid choice, please enter again!");
            while (userInput !=4){
            Menu.SecondMenu();
            userInput = Menu.UserChoice();
                switch(userInput){
                    //Displays Bucket List Parks
                    case 1: Console.WriteLine("option1");
                    break;
                    //adds Parks to bucket List
                    case 2: Console.WriteLine("option 2");
                    break;
                    case 4: //exit
                    break;
                }
            }
            break;

            // add/remove personal notes to a park
            case 5: Console.WriteLine("Invalid choice, please enter again!");
            
            break;
            case 6:
                    Console.WriteLine("Add National Park");
                    Console.WriteLine("What is the name of your new park? ");
                    string newName = Console.ReadLine();
                    Console.WriteLine(" What State is your park in?");
                    string newsta = Console.ReadLine();
                    Console.WriteLine(" what is a summary of your park?");
                    string newsum = Console.ReadLine();
                    
                    
                    NationalPark newpark = new(newName,newsta,newsum,false,false);
                    nationalParksList.Add(newpark);
            break;
            case 7:
                    Console.WriteLine("Remove National Park From DataBase");
                    bool parkcheck = false;
                    while (parkcheck == false){
                    System.Console.WriteLine( "Which park would you like to remove?");
                    input = Console.ReadLine();
                    parkcheck = Logic.ParkCheck(input,nationalParksList);
                    Logic.RemovePark(input,nationalParksList);
                    } 

                    
                    


            break;
            case 8: 
                    Console.WriteLine("National Park Editor");
                    parkcheck = false;
                    
                    while (parkcheck == false){
                    Console.WriteLine("Choose your park to edit");
                    input = Console.ReadLine();
                    parkcheck = Logic.ParkCheck(input,nationalParksList);
                    }
                    
                    string nationalpark = input;
                    Console.WriteLine(" Type your new Summary here"
                                        +"\n"+ "If you dont want to change leave blank ");
                    input = Console.ReadLine();
                    string newSum = input;
                    Console.WriteLine(" Type your new State here"
                                        +"\n"+ "If you dont want to change leave blank ");
                    input = Console.ReadLine();
                    string newSta = input;
                    Logic.NationalParkEditor(nationalParksList,nationalpark,newSum,newSta);

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
