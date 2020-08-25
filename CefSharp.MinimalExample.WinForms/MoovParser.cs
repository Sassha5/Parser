using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    class MoovParser<T> where T : class
    {
        Song[] songArray;
        IHtmlDocument document;
        public Song[] Parse(IHtmlDocument document, out ImageList imageList)
        {
            //string[] selectors = { "div.l-r div.song", "div.l-r div.artist", "div.l-r div.album", "div.l-r div.duration" };
            var items = document.QuerySelectorAll("div.l-r");
            imageList = null;
            
            this.document = document;
            songArray = new Song[items.Length];
            
            ParseSongNames();

            return songArray;
        }

        private void ParseSongNames()
        {
            var items = document.QuerySelectorAll("div.l-r div.song, div.artist, div.album, div.duration");
            for (int i = 0; i < items.Length; i++)
            {
                songArray[i] = new Song(items[i].TextContent);
            }
        }
    }
}
