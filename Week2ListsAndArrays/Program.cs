using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Week2ListsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allthenumbers = { 5, 19, 9, 91, 77 };
            Array.ForEach(allthenumbers, Console.WriteLine);
            Array.Reverse(allthenumbers);
            Console.WriteLine();

            Array.ForEach(allthenumbers, Console.WriteLine);
            Console.WriteLine();
           
            //cant figure out the copy array, trying to research online but still getting stuck

            int[] morenumbers = new int[5];

            allthenumbers.CopyTo(morenumbers, 1);

            foreach (int element in allthenumbers)
            {
                Console.WriteLine(morenumbers);

            }
            Console.ReadLine();
            


            string[] favCities = new string[3];
            Console.WriteLine("What is your most favorite city?");
            favCities[0] = Console.ReadLine();
            Console.WriteLine("Awesome, you love " + favCities[0] + "!!");
            Console.WriteLine();
            Console.WriteLine("What is your next favorite city?");
            favCities[1] = Console.ReadLine();
            Console.WriteLine("Awesome, you really like " + favCities[1] + "!");
            Console.WriteLine();
            Console.WriteLine("What is your third-most favorite city?");
            favCities[2] = Console.ReadLine();
            Console.WriteLine("Awesome, you like " + favCities[2] + ".");
            Console.WriteLine();


            Console.WriteLine("Here are your favorite three cities:");
            Array.ForEach(favCities, Console.WriteLine);
            Console.ReadLine();

            List<string> listOfNames = new List<string>();
            listOfNames.Add("Dan");
            listOfNames.Add("Sara");
            listOfNames.Add("Vicki");
            listOfNames.Add("Nicole");
            listOfNames.Add("Jack");
            foreach(string name in listOfNames)
            {
                Console.WriteLine(name);

            }
            Console.ReadLine();

            listOfNames.Add("Ryan");
            listOfNames.Add("Steph");
            listOfNames.Add("Hanna");

            foreach(string name in listOfNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            for(int i=0;i<listOfNames.Count;i++)
            {
                if (listOfNames[i].Contains("Vicki"))
                    listOfNames[i] = "Marley";
            }
           foreach(string name in listOfNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
