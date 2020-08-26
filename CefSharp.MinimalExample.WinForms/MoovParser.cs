using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            await foreach (Bitmap bmp in GetImagesAsync(source))
            {
                imageList.Images.Add(bmp);
            }

            return imageList;
        }

        private async IAsyncEnumerable<Bitmap> GetImagesAsync(List<string> links)
        {
            foreach (string link in links)
            {
                yield return await Task.Run(() =>
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create(link);
                    System.Net.WebResponse resp = request.GetResponse();
                    System.IO.Stream respStream = resp.GetResponseStream();
                    Bitmap bmp = new Bitmap(respStream);
                    respStream.Dispose();
                    return bmp;
                });
            }
        }
    }
}
