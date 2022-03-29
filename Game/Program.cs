using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            Console.WriteLine("Would you like to do some math problems? Press Y for Yes and N for No.");
            operations.OprerationsGameBeginCheck(cki: Console.ReadKey());
            operations.MatProblemsHasSelected(cki: Console.ReadKey());

        }
    }
}