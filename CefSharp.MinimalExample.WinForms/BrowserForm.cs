// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser browser;
        ParserWorker<string[]> parser;

        public BrowserForm()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new MoovParser<string[]>());
            browser = new ChromiumWebBrowser("https://moov.hk/#/chart/PC1000000014");
            toolStripContainer.ContentPanel.Controls.Add(browser);
            listView.View = View.Details;
            //listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.GridLines = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.OnNewData += Parser_OnNewData;
            parser.Start(browser);
        }

        private void Parser_OnNewData(object arg1, List<Song> arg2, ImageList arg3)
        {
            listView.SmallImageList = arg3;
            for (int i = 0; i< arg2.Count; i++)
            {
                listView.Items.Add(new ListViewItem(arg2[i].ToStringArray(), i));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
            Close();
        }
    }
}
