using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTrackerLibrary
{
    [Serializable]
    public class Film : Asset
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Boolean Seen { get; set; }
        public DateTime LastSeen { get; set; }
        public Boolean Owned { get; set; }
        public int Rating { get; set; }
        public Boolean BluRay { get; set; }

        public Film()
        {

        }

        public Film(string _title, Boolean _seen, DateTime _lastseen, Boolean _owned, int _rating, Boolean _bluray)
        {
            Title = _title;
            Seen = _seen;
            LastSeen = _lastseen;
            Owned = _owned;
            Rating = _rating;
            BluRay = _bluray;

        }

        public void PrintAll()
        {
            Console.WriteLine(ID);
            Console.WriteLine(Title);
            Console.WriteLine(Seen);
            Console.WriteLine(LastSeen);
            Console.WriteLine(Owned);
            Console.WriteLine(Rating);
            Console.WriteLine(BluRay);

        }

    }
}
