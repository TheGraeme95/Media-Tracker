using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTrackerLibrary
{
    [Serializable]
    public class Game : Asset
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Boolean PlayStatus { get; set; }
        public DateTime LastPlayed { get; set; }
        public Boolean Owned { get; set; }
        public int Rating { get; set; }
        public string Platform { get; set; }
        
        public Game()
        {

        }

        public Game(string _title, Boolean _playstatus, DateTime _lastplayed, Boolean _owned, int _rating,
            string _platform)
        {
            Title = _title;
            PlayStatus = _playstatus;
            LastPlayed = _lastplayed;
            Owned = _owned;
            Rating = _rating;
            Platform = _platform;
        }


    }
}
