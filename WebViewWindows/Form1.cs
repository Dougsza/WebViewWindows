﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewWindows {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        private void Form_Resize(object sender,EventArgs e) {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);

        }
    }
}
