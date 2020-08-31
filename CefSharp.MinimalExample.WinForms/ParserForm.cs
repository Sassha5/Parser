// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoovParserApp
{
    public partial class MoovParser : Form
    {
        private ChromiumWebBrowser browser;
        ParserWorker<string[]> parser;
        public MoovParser()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new MoovParser<string[]>());
            listView.View = View.Details;
            listView.GridLines = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (browser != null)
            {
                browser.Dispose();
            }
            Cef.Shutdown();
            Close();
        }
        private async void buttonParse_Click(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(textBoxToParse.Text);
            toolStripContainer.ContentPanel.Controls.Add(browser);

            parser.OnNewData += Parser_OnNewData;
            parser.OnNewImages += Parser_OnNewImages;
            parser.ParserError += Parser_Error;

            await Task.Run(() => IsBrowserInitialized()); //waiting for browser to initialize
            parser.Start(browser);
        }

        private void IsBrowserInitialized()
        {
            for (int i = 0; i < 10; i++)
            {
                if (browser.IsBrowserInitialized)
                {
                    return;
                }
                else Thread.Sleep(1000);
            }
        }

        private void Parser_OnNewData(object arg1, List<Song> arg2)
        {
            for (int i = 0; i < arg2.Count; i++)
            {
                listView.Items.Add(new ListViewItem(arg2[i].ToStringArray(), i));
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Parser_OnNewImages(object arg1, ImageList arg2)
        {
            arg2.ImageSize = new Size(64, 64);
            listView.SmallImageList = arg2;
        }

        private void Parser_Error(object arg1, string arg2)
        {
            MessageBox.Show(arg2);
        }
    }
}
