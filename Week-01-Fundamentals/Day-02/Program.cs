using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //variables();
      //constvar();
      //multvar();
      //TypeCast();
      //UserInput();
      Operators();
    }

    static void variables()  // Syntax : type variableName = value;
    {
      Console.WriteLine("Hello variables");  
      int n1 = 5;            // int - stores integers (whole numbers), without decimals, such as 123 or -123
      Console.WriteLine(n1);


      double d1 = 19.55;    // double - stores floating point numbers, with decimals, such as 19.99 or -19.99
      Console.WriteLine(d1);

      char c1 = 'D';      // char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
      Console.WriteLine(c1);

      bool b1 = true;    // bool - stores values with two states: true or false
      Console.WriteLine(b1);

      string text = "Hello";  // string - stores text, such as "Hello World". String values are surrounded by double quotes
      Console.WriteLine(text);

    }
    
    static void constvar(){
        const int cn1 = 10;
        //cn1 = 20;  // --> can't changed , its through error
        Console.WriteLine(cn1);
    }

    static void multvar(){
        int x = 5, y = 6, z = 50;
        Console.WriteLine(x + y + z); // --> 61 --> return as int

        int a, b, c;
        a = b = c = 50;
        Console.WriteLine("abc "+ a + b + c); // --> abc 505050 --> return as string

        string name1 = "Srini";
       string name2 = "QS";
       Console.WriteLine("FullName " + name1 + name2); // --> FullName SriniQS
    }

    static void TypeCast(){

      int int1 = 8;
      double doub1 = int1 ;  //Automatic casting --> 8

      Console.WriteLine(int1);
      Console.WriteLine("Automatoc casting : int To double :" + doub1);

      double doub2 = 15.89;
      int int2 = (int) doub2;  // Manual casting --> 15
      Console.WriteLine(doub2);
      Console.WriteLine(int2);

//       C# Type Casting
// Type casting is when you assign a value of one data type to another type.

// In C#, there are two types of casting:

// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char
    
  }

  static void UserInput(){

    Console.WriteLine("Enter the name :");
    String name = Console.ReadLine();
    Console.WriteLine("My name is " + name); // My name is Srini

    Console.WriteLine("Enter the age :");
    //int age = Console.ReadLine();   // Its through Error 
     int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("My age is " + age); 

    //Console.ReadLine() --> Always return as string
  }
  static void Operators(){

    int num1 = 30;
    int num2 = 10;
    //int sub2 = num1- num2; // 20

    Console.WriteLine("Add "+ Convert.ToInt32(num1+num2)); // 40
    //Console.WriteLine("Add "+ num1+num2); // Its return --> Add 3010
    //Console.WriteLine("Sub "+ num1-num2); // Its return Error
    Console.WriteLine("Sub "+ Convert.ToInt32(num1-num2)); // 20
    Console.WriteLine("Mul "+ Convert.ToInt32(num1*num2)); // 300
    Console.WriteLine("Div "+ Convert.ToInt32(num1/num2)); // 3
    Console.WriteLine("Mod "+ Convert.ToInt32(num1%num2)); // 0

  }

  }

}

