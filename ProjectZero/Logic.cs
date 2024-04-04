namespace projectZero;

class Logic{
public static void DisplayParks(List<NationalPark> nationalParksList){

        foreach(NationalPark np in nationalParksList)
        {
            Console.WriteLine(np.ToString());
        }

    }
}