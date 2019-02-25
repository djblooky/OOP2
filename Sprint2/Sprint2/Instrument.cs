using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public abstract class Instrument
    {
        public string Sound { get; protected set; }
        public string Material { get; protected set; }
        public int Cost { get; protected set; }
        public bool IsPlaying { get; set; }
        public int SoundCount { get; protected set; }

        public char soundSplit = ',';

        public virtual string About()
        {
            return "";
        }

        public Instrument()
        {
            
        }

        public void Play()
        {
            
        }

        public void StopPlaying()
        {
            
        }

        public string GetSound()
        {
            return "";
        }

        public string MakeSound() 
        {
            return "";
        }

        public string MakeSound(int HowManyTimes)
        {
            string soundString = "";
         
            return soundString;
        }

        public string GetIsPlayingString()
        {
            return "";
        }


    }
}
