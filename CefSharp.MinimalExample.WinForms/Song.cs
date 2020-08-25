using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CefSharp.MinimalExample.WinForms
{
    class Song
    {
        //public Image Cover { get; set; }
        public TimeSpan Duration { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }

        public Song() { }
        public string[] ToStringArray()
        {
            return new string[] {Name, Artist, Album, Duration.ToString() };
        }
    }
}
