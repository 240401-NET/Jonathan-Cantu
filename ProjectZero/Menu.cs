namespace projectZero;

class Menu
{
    public static void PrintMenu(){
        // write menu items
        Console.WriteLine(" your code is working");
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