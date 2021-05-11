using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crawler;
using System.IO;

namespace ClawlerForm1
{
    public partial class Form1 : Form
    {
        SimpleCrawler simpleCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            txtUrl.DataBindings.Add("Text", simpleCrawler, "startUrl");
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            simpleCrawler.StartCrawl();
            for(int i = 0; i < simpleCrawler.urls.Count(); i++)
            {
                dataGridView1.Rows.Add(simpleCrawler.urls[i]);
            }
        }
    }
}
