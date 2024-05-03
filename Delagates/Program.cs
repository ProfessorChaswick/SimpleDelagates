using System;

delegate int Calc(int x);// declair delegate

public class delEx
{
    static int val = 10;
    public static int add(int x)
    {
        val += x;
        return val;
    }
    public static int subtract(int x)
    { 
        val -= x;
        return val;
    }
    public static int multiply(int x)
    {
        val *= x;
        return val;
    }
    public static int divide(int x)
    {
        val /= x;
        return val;
    }
    public static int getVal()
    {
        return val;
    }
    public static void Main(string[] args)
    {
        Calc addNums = new Calc(add);
        Calc subtractNums = new Calc(subtract);
        Calc multiplyNums = new Calc(multiply);
        Calc divideNums = new Calc(divide);

        Console.WriteLine("Before doing anything the number is 10.");
        addNums(20);
        Console.WriteLine("After the addNums delegate the value s/b 30 and is: " + getVal());
        subtractNums(3);
        Console.WriteLine("After the subtractNums delegate the value s/b 27 and is: " + getVal());
        multiplyNums(5);
        Console.WriteLine("After the multiplyNums delegate the value s/b 135 and is: " + getVal());
        divideNums(9);
        Console.WriteLine("After the divideNums delegate the value s/b 15 and is: ?? " + getVal() + "\nYeah! Delegates!!");
    }
}
