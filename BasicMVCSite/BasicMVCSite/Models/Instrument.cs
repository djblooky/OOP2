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
            return $"This {Material} {this} costs ${Cost} and makes a {Sound} sound. \n{GetIsPlayingString()}";
        }

        public Instrument()
        {
            IsPlaying = false;
        }

        public void Play()
        {
            IsPlaying = true;
            MakeSound();
        }

        public void StopPlaying()
        {
            IsPlaying = false;
        }

        public string GetSound()
        {
            SoundCount++;
            return Sound;
        }

        public string MakeSound() 
        {
            return MakeSound(3); //by default instruments make 3 sounds
        }

        public string MakeSound(int HowManyTimes)
        {
            string soundString = "";
            for (int i = 0; i < HowManyTimes; i++)
            {
                soundString += GetSound() + soundSplit;
            }

            return soundString;
        }

        public string GetIsPlayingString()
        {
            if (IsPlaying)
            {
                return this + " is playing!";
            }
            else
            {
                return this + " is not playing!";
            }
        }


    }
}
