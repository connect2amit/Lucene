using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexing
{
    public class Airlines
    {
        public string Name { get;  set; }
        public string IataIdentifier { get;  set; }
        public string Description { get;  set; }

        public static List<Airlines> GetSampleData()
        {
            Airlines indigo = new Airlines("Indigo Airlines", "IATA001", "A LCC Running domestic passenger flights in India");
            Airlines spiceJet = new Airlines("SpiceJet", "IATA002", "A LCC Running domestic passenger flights in India");
            Airlines airIndia = new Airlines("Air India", "IATA003", "A Fully operating airlines operating domestic flights in India, and International flights all over the world");
            return
                (
                    new List<Airlines>()
                    {
                        indigo,
                        spiceJet,
                        airIndia
                    }
                );
        }

        public Airlines(string name, string iataIdentifier, string description)
        {
            Name = name;
            IataIdentifier = iataIdentifier;
            Description = description;
        }
    }
}
