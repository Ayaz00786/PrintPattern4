using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPattern4
{
    internal class Class1
    {
        public static void pattern4()
        {
            
            for (int  i = 1; i <=5; i++)
            {
                for(char j = 'a'; j <='f'-i; j++)
                {
                    Console.Write(j);
                    
                }
           
                Console.WriteLine();
            }
          
            Console.ReadLine();
        }
    }
}
