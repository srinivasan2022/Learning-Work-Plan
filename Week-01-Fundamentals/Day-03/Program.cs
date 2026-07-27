using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //condStatements();   
      switchCase(); 
    }
    static void condStatements(){
        int a=10;
        int b=20;
        if(a>b){
            Console.WriteLine("a is big");
        }
        else{
            Console.WriteLine("b is big");
        }
         
         // we can use if only , if-else if only and if-else if-else only

        // Shorten 
             string result = (a>b) ? "A is Bigger" : "B is bigger";
             Console.WriteLine(result);
    }
     
     static void switchCase(){
        int day=6;
        switch(day){
          case 1:
            Console.WriteLine("Sunday");
            break;
          case 2:
            Console.WriteLine("Monday");
            break;
          case 3:
            Console.WriteLine("Tuesday");
            break;
          case 4 :
            Console.WriteLine("Wednesday");
            break;
          case 5 :
            Console.WriteLine("Thursday");
            break;
          case 6 :
            Console.WriteLine("Friday");
            break;
          case 7 :
            Console.WriteLine("Saturday");
            break ;
        }
     }
    
  }
}