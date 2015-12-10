using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab9
{
    class RelativesList
    {
        static void Main(string[] args)
        {
            string name, relationship, userInput;
            int month, day, year, a;
            bool match = false;

            //create an array of 12 relative objects
            Relative[] relatives = new Relative[12];

            //populate each object with data
            relatives[0] = new Relative("Samantha Wadley", "Aunt", 6, 27, 1980);
            relatives[1] = new Relative("Allysia Long", "Mother", 7, 20, 1969);
            relatives[2] = new Relative("Michael Solomon Sr", "Father", 5, 10, 1963);
            relatives[3] = new Relative("Michael Solomon Jr", "Brother", 7, 28, 1992);
            relatives[4] = new Relative("Michael Starks", "Brother", 4, 10, 1988);
            relatives[5] = new Relative("Glenda Wadley", "Grandmother", 6, 3, 1945);
            relatives[6] = new Relative("Teffany Wadley", "Aunt", 3, 21, 1978);
            relatives[7] = new Relative("Cedric Washington", "Cousin", 5, 27, 1994);
            relatives[8] = new Relative("Cameron Washington", "Cousin", 8, 27, 1997);

            //loop twice to ask user for a relative's info; add each new relative
            for (int x = relatives.Length - 2; x < relatives.Length; ++x)
            {
                Write("Enter Relative's Name: ");
                name = ReadLine();

                Write("Enter Relative's Relationship to You: ");
                relationship = ReadLine();

                WriteLine();
                WriteLine("Enter the Relative's birthday int the proper fields!");

                Write("Month: ");
                int.TryParse(ReadLine(), out month);

                Write("Day: ");
                int.TryParse(ReadLine(), out day);

                Write("Year: ");
                int.TryParse(ReadLine(), out year);

                relatives[x] = new Relative(name, relationship, month, day, year);
                WriteLine();
            }

            //sort relative's in alphabetical order by name
            Array.Sort(relatives);

            //display each relative
            Display(relatives);
            WriteLine();

            //search relatives by name
            do
            {
                Write("Enter a Relative's Name: ");
                userInput = ReadLine();
                WriteLine();

                for(a = 0; a < relatives.Length; ++a)
                {
                    if (userInput == relatives[a].Name)
                    {
                        Display(relatives[a]);
                        match = true;
                    }
                }

                if (match == false)
                    WriteLine("No Relative Found!");
                WriteLine();

            } while (match == false);

        }

        static void Display(params Relative[] relatives)
        {
            foreach(Relative relative in relatives)
            {
                WriteLine("{0}", relative.ToString());
            }
        }
    }
}
