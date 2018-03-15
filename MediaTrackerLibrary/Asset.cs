using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTrackerLibrary
{
    interface Asset
    {
        string Title { get; set; }
        int Rating { get; set; }
        Boolean Owned { get; set; }
    }
}
