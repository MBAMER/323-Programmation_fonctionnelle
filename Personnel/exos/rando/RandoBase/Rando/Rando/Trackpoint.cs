using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rando
{
    public class TrackPoint
    {
        public double Latitude { get;  }
        public double Longitude { get;  }
        public double? Elevation { get;  }

        public TrackPoint(double latitude, double longitude, double? elevation = null)
        {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
        }
    }
}
