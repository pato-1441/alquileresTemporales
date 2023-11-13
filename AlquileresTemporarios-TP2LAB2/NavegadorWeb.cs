using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquileresTemporarios_TP2LAB2
{
    public partial class NavegadorWeb : Form
    {
        public NavegadorWeb()
        {
            InitializeComponent();
        }
        private async void NavegadorWeb_Load(object sender, EventArgs e)
        {
            webView21.Dock = DockStyle.Fill;
            Controls.Add(webView21);
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("http://alquilerestemporarios.netlify.app");
        }
    }
}
