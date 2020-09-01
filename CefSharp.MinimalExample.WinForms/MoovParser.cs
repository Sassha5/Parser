using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoovParserApp
{
    class MoovParser<T> where T : class
    {
        public List<Song> Parse(IHtmlDocument document)
        {
            List<IElement> items = document.QuerySelectorAll("div.l-r").ToList();
            List<Song> songs = new List<Song>();

            foreach (IElement element in items)
            {
                Song song = new Song();
                song.Name = element.QuerySelector(".song").TextContent;
                if (element.QuerySelector(".artist") != null) { song.Artist = element.QuerySelector(".artist").TextContent; }
                else if (element.QuerySelector(".singer") != null) { song.Artist = element.QuerySelector(".singer").TextContent; }
                if (element.QuerySelector(".album") != null) { song.Album = element.QuerySelector(".album").TextContent; }
                else if (document.QuerySelector("div.name .title") != null) { song.Album = document.QuerySelector("div.name .title").TextContent; }
                else song.Album = "Not found on this page";
                song.Duration = element.QuerySelector(".duration").TextContent;
                songs.Add(song);
            }

            return songs;
        }

        public bool TryParse(IHtmlDocument document)
        {
            if (document.QuerySelectorAll("div.l-r").Length != 0)
            {
                return true;
            }
            else return false;
        }

        public string ParseDescription(IHtmlDocument document)
        {
            return document.QuerySelector("div.moduleText div.title").TextContent;
        }

        public async Task<ImageList> ParseImagesAsync(IHtmlDocument document)
        {
            var imageList = new ImageList();

            List<string> source = document.QuerySelectorAll("div.l-r .cover img[src]:not(.play)")
                .Select(x => ((IHtmlImageElement)x).Source)
                .ToList();

            
            await foreach (var bmp in GetImagesAsync(source))
                imageList.Images.Add(bmp);

            return imageList;
        }

        private async IAsyncEnumerable<Bitmap> GetImagesAsync(IEnumerable<string> links)
        {
            foreach (var link in links)
                if(link.Contains("http"))
                yield return await GetImage(link);
        }

        private async Task<Bitmap> GetImage(string link)
        {
            var request = (HttpWebRequest)WebRequest.Create(link);
            request.ServicePoint.ConnectionLimit = 20;
            request.Proxy = null;
            request.Method = "GET";

            WebResponse resp = await request.GetResponseAsync();
            Stream respStream = resp.GetResponseStream();
            var bmp = new Bitmap(respStream);

            resp.Close();
            respStream.Dispose();

            return bmp;
        }
    }
}
