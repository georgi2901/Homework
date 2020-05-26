using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Track
    {
        public Racer Racer { get; set; }
        public Racer Racer2 { get; set; }

        public Track(Racer racer, Racer racer2)
        {
            Racer = racer;
            Racer2 = racer2;
        }
        public void TrackA()
        {
            if (Racer.Automobile.AccelerationFrom0To100 < Racer2.Automobile.AccelerationFrom0To100)
                Racer.Points += 3;
        }

        public void TrackB()
        {
            if (Racer.Automobile.AccelerationFrom0To100 + Racer.Automobile.AccelerationFrom100To200 < Racer2.Automobile.AccelerationFrom0To100 + Racer2.Automobile.AccelerationFrom100To200)
                Racer.Points += 3;
        }
    }
}
