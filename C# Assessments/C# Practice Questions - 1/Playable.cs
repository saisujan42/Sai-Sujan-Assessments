using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    interface Playable
    {
        void Play();
    }

    class MusicPlayer : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music...");
        }
    }

    class VideoPlayer : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing Video...");
        }
    }
}
