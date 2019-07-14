namespace WatchanQueue
{
    partial class PrintQueue
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
            this.txtQ = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.Label();
            this.hosname = new System.Windows.Forms.Label();
            this.QueueCard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_show = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.QueueCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQ
            // 
            this.txtQ.AutoSize = true;
            this.txtQ.BackColor = System.Drawing.Color.Transparent;
            this.txtQ.Font = new System.Drawing.Font("Segoe UI", 38F);
            this.txtQ.Location = new System.Drawing.Point(150, 62);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(110, 68);
            this.txtQ.TabIndex = 0;
            this.txtQ.Text = "100";
            // 
            // txtS
            // 
            this.txtS.AutoSize = true;
            this.txtS.BackColor = System.Drawing.Color.Transparent;
            this.txtS.Font = new System.Drawing.Font("Segoe UI", 38F);
            this.txtS.Location = new System.Drawing.Point(-8, 62);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(170, 68);
            this.txtS.TabIndex = 1;
            this.txtS.Text = "ห้องฟัน";
            // 
            // hosname
            // 
            this.hosname.AutoSize = true;
            this.hosname.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.hosname.Location = new System.Drawing.Point(6, 22);
            this.hosname.Name = "hosname";
            this.hosname.Size = new System.Drawing.Size(247, 15);
            this.hosname.TabIndex = 2;
            this.hosname.Text = "โรงพยาบาลวันจันทร์เฉลิมพระเกียรติ ๘๐ พรรษา";
            // 
            // QueueCard
            // 
            this.QueueCard.Controls.Add(this.label1);
            this.QueueCard.Controls.Add(this.date_show);
            this.QueueCard.Controls.Add(this.hosname);
            this.QueueCard.Controls.Add(this.txtQ);
            this.QueueCard.Controls.Add(this.txtS);
            this.QueueCard.Location = new System.Drawing.Point(12, 12);
            this.QueueCard.Name = "QueueCard";
            this.QueueCard.Size = new System.Drawing.Size(260, 205);
            this.QueueCard.TabIndex = 3;
            this.QueueCard.TabStop = false;
            this.QueueCard.Text = "บัตรคิวรับบริการ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "เวลาเข้ารับบริการ : ";
            // 
            // date_show
            // 
            this.date_show.AutoSize = true;
            this.date_show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_show.Location = new System.Drawing.Point(126, 153);
            this.date_show.Name = "date_show";
            this.date_show.Size = new System.Drawing.Size(69, 17);
            this.date_show.TabIndex = 11;
            this.date_show.Text = "date_show";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.QueueCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintQueue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintQueue";
            this.Load += new System.EventHandler(this.PrintQueue_Load);
            this.QueueCard.ResumeLayout(false);
            this.QueueCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtQ;
        private System.Windows.Forms.Label txtS;
        private System.Windows.Forms.Label hosname;
        private System.Windows.Forms.GroupBox QueueCard;
        private System.Windows.Forms.Label date_show;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
    }
}