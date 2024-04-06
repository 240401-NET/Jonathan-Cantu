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
                            "   5- Add/Remove notes to MyParks" + "\n" +
                            "   8- National Park Editor" + "\n" +
                            "   9- Exit & Persist Data" + "\n");


    }
    public static int UserChoice(){
       try{
            return Convert.ToInt32(Console.ReadLine());
        } catch(Exception e){
            Console.WriteLine(e.Message + " Entry was invalid. Please try again!");
            return -1;
        
        }
    }

    public static void SecondMenu(){
        Console.WriteLine(" Your Bucket List National Parks");
        Console.WriteLine(" Choose an option: " + "\n"+
                            "   1- View Available Parks" + "\n"+
                            "   2- Add parks to bucket list" + "\n" +
                            "   3- Remove parks from bucket list" + "\n" +
                            "   4- exit Bucket List Editor" + "\n");
    }



}