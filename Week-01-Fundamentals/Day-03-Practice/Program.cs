using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Calc();    
    }
    static void Calc(){
        Console.WriteLine("You can perform Arithmetic Operations Here!");
        Console.WriteLine("Enter the Number to perform action :");
        Console.WriteLine("Enter 1 to Addition");
        Console.WriteLine("Enter 2 to Substraction");
        Console.WriteLine("Enter 3 to Multiplication");
        Console.WriteLine("Enter 4 to Division");
        Console.WriteLine("Enter 5 to Modulus");
        int option = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 1st number");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        int  n2 = Convert.ToInt32(Console.ReadLine());

        int result =0;
        Console.WriteLine(option);
        switch(option){
          case 1 :
            result = n1+n2;
            break;
          case 2 :
            result = n1-n2;
            break;
          case 3 :
            result = n1*n2;
            break;
          case 4 :
            result = n1/n2;
            break;
          case 5 :
            result = n1%n2;
            break;
        }
        Console.WriteLine($"Result : {result}");
     }
  }
}
