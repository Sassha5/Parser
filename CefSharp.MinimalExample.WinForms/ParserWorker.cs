using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    class ParserWorker<T> where T : class
    {
        public MoovParser<T> Parser { get; set; }
        public int TimeOut { get; set; }

        public event Action<object, List<Song>> OnNewData;
        public event Action<object, ImageList> OnNewImages;
        public event Action<object, string> ParserError;

        public ParserWorker(MoovParser<T> parser)
        {
            Parser = parser;
            TimeOut = 20;
        }

        public async void Start(ChromiumWebBrowser browser)
        {

            for (int i = 0; i < TimeOut; i++)
            {
                var source = await browser.GetSourceAsync();
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);
                if (Parser.TryParse(document))
                {
                    Worker(document);
                    return;
                }
                else Thread.Sleep(1000);
            }
            ParserError.Invoke(this, "Timed out");
        }

        private async void Worker(IHtmlDocument document)
        {
            List<Song> result = Parser.ParseAsync(document);
            OnNewData?.Invoke(this, result);
            ImageList imageList = await Parser.ParseImagesAsync(document);
            OnNewImages?.Invoke(this, imageList);
        }
    }
}
