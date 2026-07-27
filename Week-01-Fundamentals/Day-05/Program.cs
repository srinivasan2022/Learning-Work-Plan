using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Methods!");
      //FirstMethod(); 
      //ArgMethod("Srini"); 
      //ArgMethod2("Srini" , 24);
      DefaultArgMethod("Tamil Nadu");
      DefaultArgMethod();
    }

    static void FirstMethod(){
        Console.WriteLine("This is my first method");
    }

    static void ArgMethod(string name){
        Console.WriteLine("Name is " + name);
    }

    static void ArgMethod2(string name , int age){
        Console.WriteLine(name + " is " + age);
    }

    static void DefaultArgMethod(string state="Kerala"){  // --> DefaultArgMethod();
        Console.WriteLine("Our state is " + state);
    }
  }
}
