using System;
public class Program_4
{
    public static void Main(string[] args)
    {
        Abs MinustoPlus = new Abs (-1);
        string Input = Input_Num();
        int changer = StringToInt(Input);
        Console.WriteLine("{0}",MinustoPlus.NumToPlus(changer));
        
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
    
    
    
    
}
public class Abs
{
    private int Num;
    public Abs(int Num)
    {
        this.Num = Num;
    }   
    public int NumToPlus(int new_Number)
    {
        return new_Number*this.Num;
    }
}


