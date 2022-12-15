using System.Windows.Forms;

namespace DijkstraWinform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DIEMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DIEMB = new System.Windows.Forms.Button();
            this.DIEMC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DIEMK = new System.Windows.Forms.Button();
            this.DIEMH = new System.Windows.Forms.Button();
            this.DIEMI = new System.Windows.Forms.Button();
            this.DIEMG = new System.Windows.Forms.Button();
            this.DIEMF = new System.Windows.Forms.Button();
            this.DIEME = new System.Windows.Forms.Button();
            this.DIEMD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DIEMA
            // 
            this.DIEMA.Location = new System.Drawing.Point(200, 700);
            this.DIEMA.Name = "DIEMA";
            this.DIEMA.Size = new System.Drawing.Size(90, 66);
            this.DIEMA.TabIndex = 4;
            this.DIEMA.Text = "A(1,1)";
            this.DIEMA.UseVisualStyleBackColor = true;
            this.DIEMA.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 931);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm đường đi ngắn nhất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DIEMB
            // 
            this.DIEMB.Location = new System.Drawing.Point(500, 700);
            this.DIEMB.Name = "DIEMB";
            this.DIEMB.Size = new System.Drawing.Size(90, 66);
            this.DIEMB.TabIndex = 7;
            this.DIEMB.Text = "B(3,1)";
            this.DIEMB.UseVisualStyleBackColor = true;
            this.DIEMB.Click += new System.EventHandler(this.button2_Click);
            // 
            // DIEMC
            // 
            this.DIEMC.Location = new System.Drawing.Point(610, 438);
            this.DIEMC.Name = "DIEMC";
            this.DIEMC.Size = new System.Drawing.Size(90, 66);
            this.DIEMC.TabIndex = 8;
            this.DIEMC.Text = "C(4,3)";
            this.DIEMC.UseVisualStyleBackColor = true;
            this.DIEMC.Click += new System.EventHandler(this.DIEMC_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::DijkstraWinform.Properties.Resources.Quận_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.DIEMK);
            this.panel1.Controls.Add(this.DIEMH);
            this.panel1.Controls.Add(this.DIEMI);
            this.panel1.Controls.Add(this.DIEMG);
            this.panel1.Controls.Add(this.DIEMF);
            this.panel1.Controls.Add(this.DIEME);
            this.panel1.Controls.Add(this.DIEMD);
            this.panel1.Controls.Add(this.DIEMC);
            this.panel1.Location = new System.Drawing.Point(34, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 881);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DIEMK
            // 
            this.DIEMK.Location = new System.Drawing.Point(1435, 3);
            this.DIEMK.Name = "DIEMK";
            this.DIEMK.Size = new System.Drawing.Size(90, 66);
            this.DIEMK.TabIndex = 15;
            this.DIEMK.Text = "K(9,8)";
            this.DIEMK.UseVisualStyleBackColor = true;
            this.DIEMK.Click += new System.EventHandler(this.button5_Click);
            // 
            // DIEMH
            // 
            this.DIEMH.Location = new System.Drawing.Point(1087, 273);
            this.DIEMH.Name = "DIEMH";
            this.DIEMH.Size = new System.Drawing.Size(90, 66);
            this.DIEMH.TabIndex = 14;
            this.DIEMH.Text = "H(7,5)";
            this.DIEMH.UseVisualStyleBackColor = true;
            this.DIEMH.Click += new System.EventHandler(this.DIEMH_Click);
            // 
            // DIEMI
            // 
            this.DIEMI.Location = new System.Drawing.Point(1239, 675);
            this.DIEMI.Name = "DIEMI";
            this.DIEMI.Size = new System.Drawing.Size(90, 66);
            this.DIEMI.TabIndex = 13;
            this.DIEMI.Text = "I(8,1)";
            this.DIEMI.UseVisualStyleBackColor = true;
            this.DIEMI.Click += new System.EventHandler(this.DIEMI_Click);
            // 
            // DIEMG
            // 
            this.DIEMG.Location = new System.Drawing.Point(321, 273);
            this.DIEMG.Name = "DIEMG";
            this.DIEMG.Size = new System.Drawing.Size(90, 66);
            this.DIEMG.TabIndex = 12;
            this.DIEMG.Text = "G(2,5)";
            this.DIEMG.UseVisualStyleBackColor = true;
            this.DIEMG.Click += new System.EventHandler(this.DIEMG_Click);
            // 
            // DIEMF
            // 
            this.DIEMF.Location = new System.Drawing.Point(610, 131);
            this.DIEMF.Name = "DIEMF";
            this.DIEMF.Size = new System.Drawing.Size(90, 66);
            this.DIEMF.TabIndex = 11;
            this.DIEMF.Text = "F(4,7)";
            this.DIEMF.UseVisualStyleBackColor = true;
            this.DIEMF.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DIEME
            // 
            this.DIEME.Location = new System.Drawing.Point(1239, 438);
            this.DIEME.Name = "DIEME";
            this.DIEME.Size = new System.Drawing.Size(90, 66);
            this.DIEME.TabIndex = 10;
            this.DIEME.Text = "E(8,3)";
            this.DIEME.UseVisualStyleBackColor = true;
            this.DIEME.Click += new System.EventHandler(this.DIEME_Click);
            // 
            // DIEMD
            // 
            this.DIEMD.Location = new System.Drawing.Point(941, 438);
            this.DIEMD.Name = "DIEMD";
            this.DIEMD.Size = new System.Drawing.Size(90, 66);
            this.DIEMD.TabIndex = 9;
            this.DIEMD.Text = "D(6,3)";
            this.DIEMD.UseVisualStyleBackColor = true;
            this.DIEMD.Click += new System.EventHandler(this.DIEMD_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(500, 931);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1134, 132);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 1081);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DIEMB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DIEMA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm đường đi ngắn nhất";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DIEMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DIEMB;
        private System.Windows.Forms.Button DIEMC;
        private Panel panel1;
        private Button DIEMD;
        private Button DIEME;
        private Button DIEMF;
        private Label label1;
        private Button DIEMK;
        private Button DIEMH;
        private Button DIEMI;
        private Button DIEMG;
    }
}

