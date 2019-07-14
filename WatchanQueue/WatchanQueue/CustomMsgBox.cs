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
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }
        static CustomMsgBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new CustomMsgBox();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnOK;
            MsgBox.button2.Text = btnCancel;
            MsgBox.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK; MsgBox.Close();
        }
    }
}
