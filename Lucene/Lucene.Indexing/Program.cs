using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indexing;

namespace Lucene.Indexing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Airlines> airlineList = Airlines.GetSampleData();
            CustomLuceneSearch.AddUpdateLuceneIndex(airlineList);
            while (true)
            {
                Console.WriteLine("Enter your search query...");
                string querry = Console.ReadLine();
                IEnumerable<Airlines> airlineResults = CustomLuceneSearch.Search(querry);
                if (airlineResults.Count<Airlines>() > 0)
                {
                    Console.WriteLine($"{airlineResults.Count<Airlines>()} Record(s) Found\n");
                    int i = 1;
                    foreach (Airlines airline in airlineResults)
                    {
                        Console.WriteLine($"Record ({i++})\n");
                        Console.WriteLine($"Name : {airline.Name}\nIata Identification : {airline.IataIdentifier}\nDescription : {airline.Description}");
                    }
                }
                else Console.WriteLine("No such record found");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}
