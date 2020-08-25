using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Text;

namespace CefSharp.MinimalExample.WinForms
{
    class MoovParser : IParser<string[]>
    {
        string[] IParser<string[]>.Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("div.song");//.Where(item => item.ClassName != null );//&& item.ClassName.Contains("l-r")

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
