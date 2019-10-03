using System;

namespace homework_week_1_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
         rectangle firstrectangle = new rectangle(34,25);
         Console.WriteLine("The Area is {0}",firstrectangle.area());    

         rectangle secondrectangle = new rectangle(10,5);
         Console.WriteLine("The Area is {0}",secondrectangle.area());    

         rectangle thirdrectangle = new rectangle(15,30);
         Console.WriteLine("The Area is {0}",thirdrectangle.area());    
        }
        
    }
}
