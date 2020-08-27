using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    class MoovParser<T> where T : class
    {
        public List<Song> ParseAsync(IHtmlDocument document)
        {
            var items = document.QuerySelectorAll("div.l-r").Select(x => new Song()
            {
                Name = x.QuerySelector(".song").TextContent,
                Artist = x.QuerySelector(".artist").TextContent,
                Album = x.QuerySelector(".album").TextContent,
                Duration = x.QuerySelector(".duration").TextContent
            }).ToList();

            return items;
        }

        public bool TryParse(IHtmlDocument document)
        {
            if (document.QuerySelectorAll("div.l-r").Length != 0)
            {
                return true;
            }
            else return false;
        }

        public async Task<ImageList> ParseImagesAsync(IHtmlDocument document)
        {
            var imageList = new ImageList();

            var source = document.QuerySelectorAll("div.l-r .cover img[src]:not(.play)")
                .Select(x => ((IHtmlImageElement)x).Source)
                .ToList();

            await foreach (var bmp in GetImagesAsync(source))
                imageList.Images.Add(bmp);

            return imageList;
        }

        private async IAsyncEnumerable<Bitmap> GetImagesAsync(IEnumerable<string> links)
        {
            foreach (var link in links)
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
