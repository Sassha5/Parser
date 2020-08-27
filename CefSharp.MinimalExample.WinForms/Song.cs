using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MoovParserApp
{
    class Song
    {
        public string Name { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }

        public Song() { }
 
        public string[] ToStringArray()
        {
            return new string[] {Name, Artist, Album, Duration };
        }
    }
}
