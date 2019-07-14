﻿namespace WatchanQueue
{
    partial class Form_Kiosk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kiosk));
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_dental = new System.Windows.Forms.Button();
            this.btn_pcu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_show = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textPR = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackColor = System.Drawing.Color.Yellow;
            this.btn_doctor.Font = new System.Drawing.Font("Segoe UI", 60F);
            this.btn_doctor.Location = new System.Drawing.Point(50, 34);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(408, 185);
            this.btn_doctor.TabIndex = 0;
            this.btn_doctor.Text = "ตรวจทั่วไป";
            this.btn_doctor.UseVisualStyleBackColor = false;
            this.btn_doctor.Click += new System.EventHandler(this.Btn_doctor_Click);
            // 
            // btn_dental
            // 
            this.btn_dental.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_dental.Font = new System.Drawing.Font("Segoe UI", 60F);
            this.btn_dental.Location = new System.Drawing.Point(50, 260);
            this.btn_dental.Name = "btn_dental";
            this.btn_dental.Size = new System.Drawing.Size(408, 185);
            this.btn_dental.TabIndex = 1;
            this.btn_dental.Text = "ห้องฟัน";
            this.btn_dental.UseVisualStyleBackColor = false;
            this.btn_dental.Click += new System.EventHandler(this.Btn_dental_Click);
            // 
            // btn_pcu
            // 
            this.btn_pcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_pcu.Font = new System.Drawing.Font("Segoe UI", 60F);
            this.btn_pcu.Location = new System.Drawing.Point(50, 484);
            this.btn_pcu.Name = "btn_pcu";
            this.btn_pcu.Size = new System.Drawing.Size(408, 185);
            this.btn_pcu.TabIndex = 2;
            this.btn_pcu.Text = "คลินิก PCU";
            this.btn_pcu.UseVisualStyleBackColor = false;
            this.btn_pcu.Click += new System.EventHandler(this.Btn_pcu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pcu);
            this.groupBox1.Controls.Add(this.btn_dental);
            this.groupBox1.Controls.Add(this.btn_doctor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(734, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 703);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกรับบริการ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(215, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "ยินดีต้อนรับ";
            // 
            // date_show
            // 
            this.date_show.AutoSize = true;
            this.date_show.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_show.Location = new System.Drawing.Point(60, 9);
            this.date_show.Name = "date_show";
            this.date_show.Size = new System.Drawing.Size(111, 30);
            this.date_show.TabIndex = 10;
            this.date_show.Text = "date_show";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textPR
            // 
            this.textPR.AutoSize = true;
            this.textPR.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.textPR.ForeColor = System.Drawing.Color.Green;
            this.textPR.Location = new System.Drawing.Point(76, 707);
            this.textPR.Name = "textPR";
            this.textPR.Size = new System.Drawing.Size(652, 45);
            this.textPR.TabIndex = 11;
            this.textPR.Text = "พกบัตรประจำตัวประชาชน เมื่อมาเข้ารับบริการทุกครั้ง";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 270);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label5.Location = new System.Drawing.Point(43, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 51);
            this.label5.TabIndex = 13;
            this.label5.Text = "3. รอการเรียกคิวเข้ารับบริการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label4.Location = new System.Drawing.Point(43, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 51);
            this.label4.TabIndex = 12;
            this.label4.Text = "2. รอรับบัตรคิวจากตู้";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label3.Location = new System.Drawing.Point(43, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "1. เลือกรายการเข้ารับบริการ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(687, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "ขั้นตอนการใช้งานระบบคิวเพื่อรับบริการ";
            // 
            // Form_Kiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textPR);
            this.Controls.Add(this.date_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form_Kiosk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watchan Kiosk";
            this.Load += new System.EventHandler(this.Form_Kiosk_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_dental;
        private System.Windows.Forms.Button btn_pcu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date_show;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label textPR;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

