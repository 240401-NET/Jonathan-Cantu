namespace projectZero;

class Menu
{
    public static void PrintMenu(){
        // write menu items
        Console.WriteLine(" Welcome To National Parks Bucket List App");
        Console.WriteLine(" Choose an option :" + "\n"+ 
                            "   1- Display National Parks" + "\n" +
                            "   2- Count How Many Parks ive been to" + "\n" +
                            "   3- My Bucket List Parks" + "\n" +
                            "   5- Add/Remove notes to MyParks");


    }
    public static int UserChoice(){
       try{
            return Convert.ToInt32(Console.ReadLine());
        } catch(Exception e){
            Console.WriteLine(e.Message + " Entry was invalid. Please try again!");
            return -1;
        
        }
    }
}