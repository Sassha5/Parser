using AngleSharp.Html.Parser;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    class ParserWorker<T> where T : class
    {
        public MoovParser<T> Parser { get; set; }

        public event Action<object, Song[], ImageList> OnNewData;

        public ParserWorker(MoovParser<T> parser)
        {
            this.Parser = parser;
        }

        public async void Start(ChromiumWebBrowser browser)
        {
            var source = await browser.GetSourceAsync();
            var domParser = new HtmlParser();

            var document = await domParser.ParseDocumentAsync(source);

            ImageList imageList;
            var result = Parser.Parse(document, out imageList);
            OnNewData?.Invoke(this, result, imageList);
        }
    }
}
