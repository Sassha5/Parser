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
        public ListViewItem[] Parse(IHtmlDocument document)
        {
            string[] selectors = { "div.l-r div.song", "div.l-r div.artist", "div.l-r div.album", "div.l-r div.duration" };
            int itemCount = document.QuerySelectorAll("div.l-r").Length;
            ListViewItem[] listItems = new ListViewItem[itemCount];
            string[][] array = new string[selectors.Length][];

            for (int i = 0; i < selectors.Length; i++)
            {
                var items = document.QuerySelectorAll(selectors[i]);//.Where(item => item.ClassName != null );
                array[i] = Help(items);
            }

            for (int j = 0; j < itemCount; j++)
            {
                string[] t = new string[selectors.Length];
                for (int i = 0; i < selectors.Length; i++)
                {
                    t[i] = array[i][j];
                }
                ListViewItem listItem = new ListViewItem(t);
                if (listItem != null && listItem.Text != "")
                {
                    listItems[j] = listItem;
                }
            }
            return listItems;
        }

        private string[] Help(IHtmlCollection<IElement> items)// => items.Select(x => x.ToString()).ToArray();
        {
            string[] str = new string[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                str[i] = items[i].TextContent;
            }
            return str;
        }
    }
}
