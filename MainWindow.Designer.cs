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
            this.pbCh = new System.Windows.Forms.PictureBox();
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
            // pbCh
            // 
            this.pbCh.Image = global::asl_project.Properties.Resources.ch1;
            this.pbCh.Location = new System.Drawing.Point(230, 336);
            this.pbCh.Name = "pbCh";
            this.pbCh.Size = new System.Drawing.Size(180, 180);
            this.pbCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCh.TabIndex = 0;
            this.pbCh.TabStop = false;
            // 
            // lbGrow
            // 
            this.lbGrow.AutoSize = true;
            this.lbGrow.Location = new System.Drawing.Point(116, 31);
            this.lbGrow.Name = "lbGrow";
            this.lbGrow.Size = new System.Drawing.Size(80, 18);
            this.lbGrow.TabIndex = 1;
            this.lbGrow.Text = "성장률값";
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Location = new System.Drawing.Point(413, 25);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(80, 18);
            this.lbH.TabIndex = 2;
            this.lbH.Text = "배고픔값";
            // 
            // lbTR
            // 
            this.lbTR.AutoSize = true;
            this.lbTR.Location = new System.Drawing.Point(415, 63);
            this.lbTR.Name = "lbTR";
            this.lbTR.Size = new System.Drawing.Size(80, 18);
            this.lbTR.TabIndex = 3;
            this.lbTR.Text = "피로도값";
            // 
            // lbST
            // 
            this.lbST.AutoSize = true;
            this.lbST.Location = new System.Drawing.Point(413, 105);
            this.lbST.Name = "lbST";
            this.lbST.Size = new System.Drawing.Size(98, 18);
            this.lbST.TabIndex = 4;
            this.lbST.Text = "스트레스값";
            // 
            // pgbGrow
            // 
            this.pgbGrow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbGrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbGrow.Location = new System.Drawing.Point(30, 63);
            this.pgbGrow.Name = "pgbGrow";
            this.pgbGrow.Size = new System.Drawing.Size(166, 22);
            this.pgbGrow.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbGrow.TabIndex = 5;
            // 
            // pgbH
            // 
            this.pgbH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbH.Location = new System.Drawing.Point(487, 23);
            this.pgbH.Name = "pgbH";
            this.pgbH.Size = new System.Drawing.Size(166, 22);
            this.pgbH.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbH.TabIndex = 6;
            // 
            // pgbTR
            // 
            this.pgbTR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbTR.Location = new System.Drawing.Point(487, 63);
            this.pgbTR.Name = "pgbTR";
            this.pgbTR.Size = new System.Drawing.Size(166, 22);
            this.pgbTR.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTR.TabIndex = 7;
            // 
            // pgbST
            // 
            this.pgbST.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbST.Location = new System.Drawing.Point(487, 105);
            this.pgbST.Name = "pgbST";
            this.pgbST.Size = new System.Drawing.Size(166, 22);
            this.pgbST.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbST.TabIndex = 8;
            // 
            // lbGrowState
            // 
            this.lbGrowState.AutoSize = true;
            this.lbGrowState.Location = new System.Drawing.Point(27, 31);
            this.lbGrowState.Name = "lbGrowState";
            this.lbGrowState.Size = new System.Drawing.Size(44, 18);
            this.lbGrowState.TabIndex = 9;
            this.lbGrowState.Text = "유아";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "배고픔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "피로도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "스트레스";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
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
            this.Name = "MainWindow";
            this.Text = "마스다치";
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
    }
}

