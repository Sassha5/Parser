// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp.Internals;
using CefSharp.MinimalExample.WinForms.Controls;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser browser;

        public BrowserForm()
        {
            InitializeComponent();

            browser = new ChromiumWebBrowser("https://moov.hk/#/chart/PC1000000014");
            toolStripContainer.ContentPanel.Controls.Add(browser);
            //browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged; ;
        }

        //private void Browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        //{
        //    button1_Click(this, new EventArgs());
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ParserWorker<ListViewItem[]> parser = new ParserWorker<ListViewItem[]>(new MoovParser<ListViewItem[]>());

            parser.OnNewData += Parser_OnNewData;

            parser.Start(browser);
        }

        private void Parser_OnNewData(object arg1, ListViewItem[] arg2)
        {
            listView.Items.AddRange(arg2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
            Close();
        }
    }
}
