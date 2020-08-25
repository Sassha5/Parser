using AngleSharp.Html.Parser;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CefSharp.MinimalExample.WinForms
{
    class ParserWorker<T> where T : class
    {
        public IParser<T> Parser { get; set; }


        public event Action<object, T> OnNewData;

        public ParserWorker(IParser<T> parser)
        {
            this.Parser = parser;
        }

        public async void Start(ChromiumWebBrowser browser)
        {
            var source = await browser.GetSourceAsync();
            var domParser = new HtmlParser();

            var document = await domParser.ParseDocumentAsync(source);

            var result = Parser.Parse(document);
            OnNewData?.Invoke(this, result);
        }
    }
}
