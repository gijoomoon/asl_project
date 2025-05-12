namespace asl_project
{
    partial class MainWindow
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
            this.tmrH = new System.Windows.Forms.Timer(this.components);
            this.tmrTR = new System.Windows.Forms.Timer(this.components);
            this.tmrST = new System.Windows.Forms.Timer(this.components);
            this.tmrGrow = new System.Windows.Forms.Timer(this.components);
            this.lbGrow = new System.Windows.Forms.Label();
            this.lbH = new System.Windows.Forms.Label();
            this.lbTR = new System.Windows.Forms.Label();
            this.lbST = new System.Windows.Forms.Label();
            this.pgbGrow = new System.Windows.Forms.ProgressBar();
            this.pgbH = new System.Windows.Forms.ProgressBar();
            this.pgbTR = new System.Windows.Forms.ProgressBar();
            this.pgbST = new System.Windows.Forms.ProgressBar();
            this.lbGrowState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RicePBX = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EatingPBX = new System.Windows.Forms.PictureBox();
            this.pbCh = new System.Windows.Forms.PictureBox();
            this.withRicelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RicePBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EatingPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCh)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrH
            // 
            this.tmrH.Interval = 2400;
            this.tmrH.Tick += new System.EventHandler(this.tmrH_Tick);
            // 
            // tmrTR
            // 
            this.tmrTR.Interval = 5400;
            this.tmrTR.Tick += new System.EventHandler(this.tmrTR_Tick);
            // 
            // tmrST
            // 
            this.tmrST.Interval = 2400;
            this.tmrST.Tick += new System.EventHandler(this.tmrST_Tick);
            // 
            // tmrGrow
            // 
            this.tmrGrow.Tick += new System.EventHandler(this.tmrGrow_Tick);
            // 
            // lbGrow
            // 
            this.lbGrow.AutoSize = true;
            this.lbGrow.Location = new System.Drawing.Point(151, 41);
            this.lbGrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrow.Name = "lbGrow";
            this.lbGrow.Size = new System.Drawing.Size(106, 24);
            this.lbGrow.TabIndex = 1;
            this.lbGrow.Text = "성장률값";
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Location = new System.Drawing.Point(534, 33);
            this.lbH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(106, 24);
            this.lbH.TabIndex = 2;
            this.lbH.Text = "배고픔값";
            // 
            // lbTR
            // 
            this.lbTR.AutoSize = true;
            this.lbTR.Location = new System.Drawing.Point(537, 84);
            this.lbTR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTR.Name = "lbTR";
            this.lbTR.Size = new System.Drawing.Size(106, 24);
            this.lbTR.TabIndex = 3;
            this.lbTR.Text = "피로도값";
            // 
            // lbST
            // 
            this.lbST.AutoSize = true;
            this.lbST.Location = new System.Drawing.Point(534, 140);
            this.lbST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbST.Name = "lbST";
            this.lbST.Size = new System.Drawing.Size(130, 24);
            this.lbST.TabIndex = 4;
            this.lbST.Text = "스트레스값";
            // 
            // pgbGrow
            // 
            this.pgbGrow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbGrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbGrow.Location = new System.Drawing.Point(39, 84);
            this.pgbGrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbGrow.Name = "pgbGrow";
            this.pgbGrow.Size = new System.Drawing.Size(216, 29);
            this.pgbGrow.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbGrow.TabIndex = 5;
            // 
            // pgbH
            // 
            this.pgbH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbH.Location = new System.Drawing.Point(633, 31);
            this.pgbH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbH.Name = "pgbH";
            this.pgbH.Size = new System.Drawing.Size(216, 29);
            this.pgbH.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbH.TabIndex = 6;
            // 
            // pgbTR
            // 
            this.pgbTR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbTR.Location = new System.Drawing.Point(633, 84);
            this.pgbTR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbTR.Name = "pgbTR";
            this.pgbTR.Size = new System.Drawing.Size(216, 29);
            this.pgbTR.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTR.TabIndex = 7;
            // 
            // pgbST
            // 
            this.pgbST.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbST.Location = new System.Drawing.Point(633, 140);
            this.pgbST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbST.Name = "pgbST";
            this.pgbST.Size = new System.Drawing.Size(216, 29);
            this.pgbST.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbST.TabIndex = 8;
            // 
            // lbGrowState
            // 
            this.lbGrowState.AutoSize = true;
            this.lbGrowState.Location = new System.Drawing.Point(35, 41);
            this.lbGrowState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrowState.Name = "lbGrowState";
            this.lbGrowState.Size = new System.Drawing.Size(58, 24);
            this.lbGrowState.TabIndex = 9;
            this.lbGrowState.Text = "유아";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "배고픔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "피로도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "스트레스";
            // 
            // RicePBX
            // 
            this.RicePBX.Image = global::asl_project.Properties.Resources.pixil_frame_0__22_;
            this.RicePBX.Location = new System.Drawing.Point(62, 388);
            this.RicePBX.Name = "RicePBX";
            this.RicePBX.Size = new System.Drawing.Size(130, 130);
            this.RicePBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RicePBX.TabIndex = 20;
            this.RicePBX.TabStop = false;
            this.RicePBX.Visible = false;
            this.RicePBX.Click += new System.EventHandler(this.click_RicePBX);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(679, 666);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 130);
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(473, 666);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 130);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(276, 666);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 130);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(649, 588);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(0, 0);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(459, 588);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(276, 588);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // EatingPBX
            // 
            this.EatingPBX.Image = global::asl_project.Properties.Resources.food;
            this.EatingPBX.Location = new System.Drawing.Point(62, 666);
            this.EatingPBX.Name = "EatingPBX";
            this.EatingPBX.Size = new System.Drawing.Size(130, 130);
            this.EatingPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EatingPBX.TabIndex = 13;
            this.EatingPBX.TabStop = false;
            this.EatingPBX.Click += new System.EventHandler(this.click_eatingPBX);
            // 
            // pbCh
            // 
            this.pbCh.Image = global::asl_project.Properties.Resources.ch1;
            this.pbCh.Location = new System.Drawing.Point(318, 372);
            this.pbCh.Margin = new System.Windows.Forms.Padding(4);
            this.pbCh.Name = "pbCh";
            this.pbCh.Size = new System.Drawing.Size(256, 268);
            this.pbCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCh.TabIndex = 0;
            this.pbCh.TabStop = false;
            // 
            // withRicelbl
            // 
            this.withRicelbl.AutoSize = true;
            this.withRicelbl.Location = new System.Drawing.Point(208, 447);
            this.withRicelbl.Name = "withRicelbl";
            this.withRicelbl.Size = new System.Drawing.Size(34, 24);
            this.withRicelbl.TabIndex = 21;
            this.withRicelbl.Text = "▶";
            this.withRicelbl.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 859);
            this.Controls.Add(this.withRicelbl);
            this.Controls.Add(this.RicePBX);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EatingPBX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGrowState);
            this.Controls.Add(this.pgbST);
            this.Controls.Add(this.pgbTR);
            this.Controls.Add(this.pgbH);
            this.Controls.Add(this.pgbGrow);
            this.Controls.Add(this.lbST);
            this.Controls.Add(this.lbTR);
            this.Controls.Add(this.lbH);
            this.Controls.Add(this.lbGrow);
            this.Controls.Add(this.pbCh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "마스다치";
            ((System.ComponentModel.ISupportInitialize)(this.RicePBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EatingPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrH;
        private System.Windows.Forms.Timer tmrTR;
        private System.Windows.Forms.Timer tmrST;
        private System.Windows.Forms.Timer tmrGrow;
        private System.Windows.Forms.PictureBox pbCh;
        private System.Windows.Forms.Label lbGrow;
        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.Label lbTR;
        private System.Windows.Forms.Label lbST;
        private System.Windows.Forms.ProgressBar pgbGrow;
        private System.Windows.Forms.ProgressBar pgbH;
        private System.Windows.Forms.ProgressBar pgbTR;
        private System.Windows.Forms.ProgressBar pgbST;
        private System.Windows.Forms.Label lbGrowState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox EatingPBX;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox RicePBX;
        private System.Windows.Forms.Label withRicelbl;
    }
}

