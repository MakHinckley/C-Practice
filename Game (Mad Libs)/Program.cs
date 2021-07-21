using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game__Mad_Libs_
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, Pluralnoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a  plural noun: ");
            Pluralnoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color );
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("You love " + Pluralnoun);
            Console.WriteLine("And I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
