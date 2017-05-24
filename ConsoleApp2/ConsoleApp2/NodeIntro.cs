using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NodeIntro
    {
        public NodeIntro()
        {
            String[] action = { "look", "lookaround", "move", "up", "down", "talk", "exit", "kill", "1", "2", "3", "4" };

         
        }
        public void look(String nomObject)
        {
            /**getDescriptionObject(nomObject){

            }**/
        }
        public void getDescriptionObject(String nObjet)
        {
            string text = System.IO.File.ReadAllText(@"C:\" + nObjet + ".txt");
            System.Console.WriteLine("{0}", text);
        }
    }
}
