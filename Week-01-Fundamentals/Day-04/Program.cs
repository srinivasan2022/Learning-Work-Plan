using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Loops!");
      //forLoop();
      //whileLoop();
      //doWhileLoop();
      forEachLoop();  
    }
    static void forLoop(){
        for(int i=1;i<=5;i++){
            Console.WriteLine(i);
        }
    }

    static void whileLoop(){
        int i=1;
        while(i<=4){
            Console.WriteLine(i);
            i++;
        } 
    }

    static void doWhileLoop(){
        int i=1;
        do{
            Console.WriteLine("do " + i);
            i++;
        }
        while(i<=5);
    }

    static void forEachLoop(){  // --> Its used to Get the value from Array .
        int[] nums = {1,3,5,7,9};
        foreach(int num in nums){
            Console.WriteLine(num);
        }
    }
  }
}
