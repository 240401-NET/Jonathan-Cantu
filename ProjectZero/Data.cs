using System.IO;
using System.Reflection.PortableExecutable;
using System.Text.Json;


namespace projectZero;

public class Data{

    //Read the file
    public static void LoadParks(ref List<NationalPark> nationalParksList){

        try{
            string filePath = "NationalParks.json";
            string jsonParks = File.ReadAllText(filePath);
            //debuging
            //Console.WriteLine( jsonParks);
           

            // characters is assigned the deserialized list of characters from the jsonCharacters string. ~ Ricardo PenaMcKnight
             nationalParksList = JsonSerializer.Deserialize<List<NationalPark>>(jsonParks);
            
            foreach(NationalPark np in nationalParksList){
                np.ToString();
                //debugging
                //Console.WriteLine(np);
            }

        }catch(Exception e){
            Console.WriteLine("File not generated, first time execution!");
        }

    }



    //Write to the file
    public static void PersistNationalParks(List<NationalPark> nationalParks){

        //Serializing the list of Character objects to a JSON string
        string jsonParks = JsonSerializer.Serialize(nationalParks);

        //Verified that we created a JSON representation of our list
        //Console.WriteLine(jsonCharacters);

        string filePath = "NationalParks.json";

        File.WriteAllText(filePath, jsonParks);

    }

}