namespace projectZero;

class Logic{




    
public static void DisplayParks(List<NationalPark> nationalParksList){

        foreach(NationalPark np in nationalParksList)
        {
            Console.WriteLine(np.ToStringDisplayConverter());
        }

    }
// method for retrieveing & counting parks ive been to
public static void RetrievePIBT(List<NationalPark> nationalParksList){
    List<NationalPark> PIBT = new();
    int count = 0;
    foreach(NationalPark np in nationalParksList){
        if( np.VisitedPark == true){
            PIBT.Add(np);
            count++;
        }
    }
    DisplayParks(PIBT);
    Console.WriteLine( "You have been to " + count + " National Parks");
    
}

public static bool ParkCheck(string input, List<NationalPark> nationalParksList){
    foreach(NationalPark np in nationalParksList){
        if( np.Name == input){
            Console.WriteLine("You have chosen "+ input + "\n");
            return true;
        }else 
        Console.WriteLine("Your Park was not found in the system" + "\n");
        return false;
    }
    return false;
}

//InvalidOperationException, during the foreach loop, I am elimnating one of the list opjects while 
// runnin through it which causes an exception.
public static void RemovePark(string input, List<NationalPark> nationalParksList){
    foreach(NationalPark np in nationalParksList){
        if( np.Name == input){
            Console.WriteLine("You have chosen "+ input + "\n");
            nationalParksList.Remove(np);
            Console.WriteLine("Your Park was removed from system" + "\n");
       }
        
    }       
}

public static List<NationalPark> NationalParkEditor(List<NationalPark> nationalParksList, 
                                                    string nationalpark, string newSum, string newSta){
    List<NationalPark> newList = new();
    Console.Write("Method Started");
foreach(NationalPark np in nationalParksList){
        
        if( np.Name == nationalpark){
            if(newSum != ""){
                np.Summary = newSum;
            }
            if(newSta!= ""){
                np.InState=newSta;
            }  
        }
        newList.Add(np);
        
    }
    DisplayParks(newList);
    Console.Write("Your Modifications Have been made \n");
    return newList;
}
}


