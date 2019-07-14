using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchanQueue
{
    public partial class PrintQueue : Form
    {
        public PrintQueue(string Qnumber, string Qservice)
        {
            InitializeComponent();
            date_show.Text = DateTime.Now.ToString();
            txtQ.Text = Qnumber;
            txtS.Text = Qservice;
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            
            Bitmap bmp = new Bitmap(this.QueueCard.Width, this.QueueCard.Height);
            this.QueueCard.DrawToBitmap(bmp, new Rectangle(0, 0, this.QueueCard.Width, this.QueueCard.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);

            this.Close();
        }

        private void PrintQueue_Load(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0,0,0,0);
            printDocument1.Print();
        }
    }
}
