using System;

namespace Tabuadas
{
    class Program
    {
        static void Main(string[] args){
        

           for(int y = 2; y <= 10; y++){
             for(int x = 0; x <= 10; x++){
                Console.WriteLine(y+ " X "+x+" = "+y*x);
                

             }
             Console.WriteLine();
             Console.WriteLine("-------------------------");
             Console.WriteLine();
            }
        }    
           
    }  
    
        
    
}
