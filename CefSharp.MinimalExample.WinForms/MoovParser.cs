using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        IHtmlDocument document;
        public List<Song> Parse(IHtmlDocument document)
        {
            this.document = document;
            var items = document.QuerySelectorAll("div.l-r").Select(x => new Song()
            {
                Name = x.QuerySelector(".song").TextContent,
                Artist = x.QuerySelector(".artist").TextContent,
                Album = x.QuerySelector(".album").TextContent,
                Duration = TimeSpan.Parse(x.QuerySelector(".duration").TextContent)
            }).ToList();

            return items;
        }

        public async Task<ImageList> ParseImagesAsync()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);

            var src = document.QuerySelectorAll("div.l-r .cover img[src]:not(.play)");
            List<string> source = new List<string>();
            foreach (IElement item in src)
            {
                source.Add(((IHtmlImageElement)item).Source);
            }

            List<Task<Bitmap>> bitmaps = new List<Task<Bitmap>>();
            foreach (string link in source)
            {
                bitmaps.Add(Task.Run(() => GetImage(link))) ;
            }
            
            Bitmap[] bmpList = await Task.WhenAll(bitmaps);
            foreach (Bitmap bmp in bmpList)
            {
                imageList.Images.Add(bmp);
            }
            return imageList;
        }

        private Bitmap GetImage(string link)
        {
                WebRequest request = WebRequest.Create(link);
                WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();
                return bmp;
        }
    }
}
