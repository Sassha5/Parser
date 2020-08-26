using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    class MoovParser<T> where T : class
    {
        IHtmlDocument document;
        public List<Song> Parse(IHtmlDocument document, out ImageList imageList)
        {
            this.document = document;
            var items = document.QuerySelectorAll("div.l-r").Select(x => new Song()
            {
                Name = x.QuerySelector(".song").TextContent,
                Artist = x.QuerySelector(".artist").TextContent,
                Album = x.QuerySelector(".album").TextContent,
                Duration = TimeSpan.Parse(x.QuerySelector(".duration").TextContent)
            }).ToList();
            imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);
            FillImageList(imageList);
            return items;
        }

        private ImageList FillImageList(ImageList imgList)
        {
            var src = document.QuerySelectorAll("div.l-r .cover img[src]:not(.play)");
            List<string> source = new List<string>();
            foreach (IElement item in src)
            {
                source.Add(((IHtmlImageElement)item).Source);
            }
            string link = source[0]; //delete
            //foreach (string link in source)
            //{
                System.Net.WebRequest request = System.Net.WebRequest.Create(link);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                imgList.Images.Add(bmp);
            //}
            return imgList;
            //using (var client = new HttpClient())
            //{
            //    var src = document.QuerySelectorAll("div.l-r .cover img[src]:not(.play)");
            //    foreach (IElement(IHtmlImageElement)item in src)
            //    {
            //        using (var response = await client.GetAsync(item.Source))
            //        {
            //            using (var source = await response.Content.ReadAsStreamAsync())
            //            {
            //                imgList.Images.Add(Image.FromStream(source));
            //            }
            //        }
            //    }
            //}
        }
    }
}
