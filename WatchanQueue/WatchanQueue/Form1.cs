using MySql.Data.MySqlClient;
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
    public partial class Form_Kiosk : Form
    {
        MySqlConnection con = new MySqlConnection("server=172.20.55.10;user=root;password=ura6ubyny;database=watchan_kiosk;charset=utf8;");
        private bool bFullScreen;
        public Form_Kiosk()
        {
            InitializeComponent();
            if (bFullScreen == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                bFullScreen = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                bFullScreen = false;
            }
        }

        private void Form_Kiosk_Load(object sender, EventArgs e)
        {
            date_show.Text = DateTime.Now.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (textPR.Left < 0 && (Math.Abs(textPR.Left) > textPR.Width))
                textPR.Left = this.Width;

            textPR.Left -= 1;

            date_show.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Btn_doctor_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("ยืนยันการเข้ารับบริการ ' ตรวจทั่วไป '", "แจ้งเตือน", "ตกลง", "ยกเลิก") == DialogResult.OK)
            {
                string sql = "INSERT INTO tb_queue SET queue_servicepoint = 'ทั่วไป' , queue_status = 'waiting'";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                string get_q = "SELECT *,COUNT(*) AS QN FROM tb_queue WHERE queue_servicepoint = 'ทั่วไป'";
                MySqlCommand cmd_queue = new MySqlCommand(get_q, con);
                con.Open();
                MySqlDataReader get_queue = cmd_queue.ExecuteReader();
                    

                get_queue.Read();
                string Qnumber = get_queue.GetString("QN");
                string Qservice = get_queue.GetString("queue_servicepoint");
                con.Close();

                string up_qnum = "UPDATE tb_queue SET queue_number ='" + Qnumber + "' WHERE queue_number IS NULL AND queue_servicepoint ='ทั่วไป'";
                MySqlCommand cmd_upq = new MySqlCommand(up_qnum, con);
                con.Open();
                cmd_upq.ExecuteReader();

                PrintQueue preViewQ = new PrintQueue(Qnumber,Qservice);
                preViewQ.Show();
                con.Close();
            }
        }

        private void Btn_dental_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("ยืนยันการเข้ารับบริการ ' ทันตกรรม '", "แจ้งเตือน", "ตกลง", "ยกเลิก") == DialogResult.OK)
            {
                string sql = "INSERT INTO tb_queue SET queue_servicepoint = 'ห้องฟัน' , queue_status = 'waiting'";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                string get_q = "SELECT *,COUNT(*) AS QN FROM tb_queue WHERE queue_servicepoint = 'ห้องฟัน'";
                MySqlCommand cmd_queue = new MySqlCommand(get_q, con);
                con.Open();
                MySqlDataReader get_queue = cmd_queue.ExecuteReader();


                get_queue.Read();
                string Qnumber = get_queue.GetString("QN");
                string Qservice = get_queue.GetString("queue_servicepoint");
                con.Close();

                string up_qnum = "UPDATE tb_queue SET queue_number ='" + Qnumber + "' WHERE queue_number IS NULL AND queue_servicepoint ='ห้องฟัน'";
                MySqlCommand cmd_upq = new MySqlCommand(up_qnum, con);
                con.Open();
                cmd_upq.ExecuteReader();

                PrintQueue preViewQ = new PrintQueue(Qnumber, Qservice);
                preViewQ.Show();
                con.Close();
            }
        }

        private void Btn_pcu_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("ยืนยันการเข้ารับบริการ ' คลีนิค PCU '", "แจ้งเตือน", "ตกลง", "ยกเลิก") == DialogResult.OK)
            {
                string sql = "INSERT INTO tb_queue SET queue_servicepoint = 'คลินิก' , queue_status = 'waiting'";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                string get_q = "SELECT *,COUNT(*) AS QN FROM tb_queue WHERE queue_servicepoint = 'คลินิก'";
                MySqlCommand cmd_queue = new MySqlCommand(get_q, con);
                con.Open();
                MySqlDataReader get_queue = cmd_queue.ExecuteReader();


                get_queue.Read();
                string Qnumber = get_queue.GetString("QN");
                string Qservice = get_queue.GetString("queue_servicepoint");
                con.Close();

                string up_qnum = "UPDATE tb_queue SET queue_number ='" + Qnumber + "' WHERE queue_number IS NULL AND queue_servicepoint ='คลินิก'";
                MySqlCommand cmd_upq = new MySqlCommand(up_qnum, con);
                con.Open();
                cmd_upq.ExecuteReader();

                PrintQueue preViewQ = new PrintQueue(Qnumber, Qservice);
                preViewQ.Show();
                con.Close();
            }
        }
    }
}
