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
    public partial class MsgNotifyBox : Form
    {
        public MsgNotifyBox()
        {
            InitializeComponent();
        }
        static MsgNotifyBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text)
        {
            MsgBox = new MsgNotifyBox();
            MsgBox.label1.Text = Text;
            MsgBox.ShowDialog();
            return result;
        }
    }
}
