using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeIntro myObject = new NodeIntro();

           
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\NodeIntro.txt");
            while ((line = file.ReadLine()) != ";")
            {
                System.Console.WriteLine(line);
               
            }

            file.Close();
      
            // Suspend the screen.  
            System.Console.ReadLine();

            System.Console.ReadKey();
        }
    }

}
