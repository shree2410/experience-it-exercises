using System;

namespace Boolean_Variable
{
    class Program
    {
        

        static void testDevi(string value)
        {
            bool a = Convert.ToBoolean(value);
            if (a)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }

      
        public static void Main(string[] args)
        {
           Console.WriteLine("Boolean Variable");
           Program.testDevi("true");
            Program.testDevi("false");
           
            /*
           if (args.Length<=0)
                {

                Console.WriteLine("No args passed");

            } else { 
            bool a = Convert.ToBoolean(args[0]);
            
            if (a)
            {
                Console.WriteLine("Yes");
            } else if (!a)
            {
                Console.WriteLine("No");
            }
            }
            */

        }
    }
}
