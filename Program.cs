using System;
public class Program_4
{
    public static void Main(string[] args)
    {
        string Input = Input_Num();
        int changer = StringToInt(Input);
        bool Checker = Check(changer);
        while(Checker == true)
        {
            Console.WriteLine("{0}",-changer);
            break;
        }
        while(Checker == false)
        {
             Console.WriteLine("{0}",changer);
            break;
        }

        
    }
    public static string Input_Num ()
    {
        Console.Write("Pls input you number : ");
        return Console.ReadLine();
    }
    public static int StringToInt(string Input)
    {
        
        int.TryParse(Input,out int Value);
        return Value;
        
    }
    public static bool Check(int x)
    {
        
        return x<0;
        
    }   
    
    
}




