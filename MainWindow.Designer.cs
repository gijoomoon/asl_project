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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tmrH = new System.Windows.Forms.Timer(this.components);
            this.tmrTR = new System.Windows.Forms.Timer(this.components);
            this.tmrST = new System.Windows.Forms.Timer(this.components);
            this.tmrGrow = new System.Windows.Forms.Timer(this.components);
            this.lbH = new System.Windows.Forms.Label();
            this.lbTR = new System.Windows.Forms.Label();
            this.lbST = new System.Windows.Forms.Label();
            this.pgbH = new System.Windows.Forms.ProgressBar();
            this.pgbTR = new System.Windows.Forms.ProgressBar();
            this.pgbST = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.withRicelbl = new System.Windows.Forms.Label();
            this.withNoodlelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pgbGrow = new System.Windows.Forms.ProgressBar();
            this.lbGrow = new System.Windows.Forms.Label();
            this.lbGrowState = new System.Windows.Forms.Label();
            this.ddongPBX = new System.Windows.Forms.PictureBox();
            this.statusButton = new System.Windows.Forms.Button();
            this.eatingNoodlech = new System.Windows.Forms.PictureBox();
            this.NoodlePBX = new System.Windows.Forms.PictureBox();
            this.eatingRicech = new System.Windows.Forms.PictureBox();
            this.characterPBX = new System.Windows.Forms.PictureBox();
            this.RicePBX = new System.Windows.Forms.PictureBox();
            this.clearPBX = new System.Windows.Forms.PictureBox();
            this.gamePBX = new System.Windows.Forms.PictureBox();
            this.SleepingPBX = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EatingPBX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ddongPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatingNoodlech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoodlePBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatingRicech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RicePBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepingPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EatingPBX)).BeginInit();
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
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Location = new System.Drawing.Point(411, 25);
            this.lbH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(80, 18);
            this.lbH.TabIndex = 2;
            this.lbH.Text = "배고픔값";
            // 
            // lbTR
            // 
            this.lbTR.AutoSize = true;
            this.lbTR.Location = new System.Drawing.Point(412, 63);
            this.lbTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTR.Name = "lbTR";
            this.lbTR.Size = new System.Drawing.Size(80, 18);
            this.lbTR.TabIndex = 3;
            this.lbTR.Text = "피로도값";
            // 
            // lbST
            // 
            this.lbST.AutoSize = true;
            this.lbST.Location = new System.Drawing.Point(411, 105);
            this.lbST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbST.Name = "lbST";
            this.lbST.Size = new System.Drawing.Size(98, 18);
            this.lbST.TabIndex = 4;
            this.lbST.Text = "스트레스값";
            // 
            // pgbH
            // 
            this.pgbH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbH.Location = new System.Drawing.Point(488, 22);
            this.pgbH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pgbH.Name = "pgbH";
            this.pgbH.Size = new System.Drawing.Size(166, 22);
            this.pgbH.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbH.TabIndex = 6;
            // 
            // pgbTR
            // 
            this.pgbTR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbTR.Location = new System.Drawing.Point(488, 63);
            this.pgbTR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pgbTR.Name = "pgbTR";
            this.pgbTR.Size = new System.Drawing.Size(166, 22);
            this.pgbTR.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTR.TabIndex = 7;
            // 
            // pgbST
            // 
            this.pgbST.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbST.Location = new System.Drawing.Point(488, 105);
            this.pgbST.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pgbST.Name = "pgbST";
            this.pgbST.Size = new System.Drawing.Size(166, 22);
            this.pgbST.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbST.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "배고픔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "피로도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "스트레스";
            // 
            // withRicelbl
            // 
            this.withRicelbl.AutoSize = true;
            this.withRicelbl.Location = new System.Drawing.Point(172, 282);
            this.withRicelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.withRicelbl.Name = "withRicelbl";
            this.withRicelbl.Size = new System.Drawing.Size(26, 18);
            this.withRicelbl.TabIndex = 21;
            this.withRicelbl.Text = "▶";
            this.withRicelbl.Visible = false;
            // 
            // withNoodlelbl
            // 
            this.withNoodlelbl.AutoSize = true;
            this.withNoodlelbl.Location = new System.Drawing.Point(172, 390);
            this.withNoodlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.withNoodlelbl.Name = "withNoodlelbl";
            this.withNoodlelbl.Size = new System.Drawing.Size(26, 18);
            this.withNoodlelbl.TabIndex = 25;
            this.withNoodlelbl.Text = "▶";
            this.withNoodlelbl.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-1, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(680, 9);
            this.label4.TabIndex = 28;
            // 
            // pgbGrow
            // 
            this.pgbGrow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbGrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pgbGrow.Location = new System.Drawing.Point(19, 151);
            this.pgbGrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pgbGrow.Name = "pgbGrow";
            this.pgbGrow.Size = new System.Drawing.Size(166, 22);
            this.pgbGrow.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbGrow.TabIndex = 5;
            // 
            // lbGrow
            // 
            this.lbGrow.AutoSize = true;
            this.lbGrow.Location = new System.Drawing.Point(105, 119);
            this.lbGrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGrow.Name = "lbGrow";
            this.lbGrow.Size = new System.Drawing.Size(80, 18);
            this.lbGrow.TabIndex = 1;
            this.lbGrow.Text = "성장률값";
            // 
            // lbGrowState
            // 
            this.lbGrowState.AutoSize = true;
            this.lbGrowState.Location = new System.Drawing.Point(16, 119);
            this.lbGrowState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGrowState.Name = "lbGrowState";
            this.lbGrowState.Size = new System.Drawing.Size(44, 18);
            this.lbGrowState.TabIndex = 9;
            this.lbGrowState.Text = "유아";
            // 
            // ddongPBX
            // 
            this.ddongPBX.Image = global::asl_project.Properties.Resources.dd;
            this.ddongPBX.Location = new System.Drawing.Point(418, 408);
            this.ddongPBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ddongPBX.Name = "ddongPBX";
            this.ddongPBX.Size = new System.Drawing.Size(40, 40);
            this.ddongPBX.TabIndex = 29;
            this.ddongPBX.TabStop = false;
            // 
            // statusButton
            // 
            this.statusButton.Image = global::asl_project.Properties.Resources.status;
            this.statusButton.Location = new System.Drawing.Point(12, 12);
            this.statusButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(90, 90);
            this.statusButton.TabIndex = 27;
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // eatingNoodlech
            // 
            this.eatingNoodlech.BackColor = System.Drawing.SystemColors.Control;
            this.eatingNoodlech.Image = global::asl_project.Properties.Resources.eatingNoodlech;
            this.eatingNoodlech.Location = new System.Drawing.Point(245, 290);
            this.eatingNoodlech.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.eatingNoodlech.Name = "eatingNoodlech";
            this.eatingNoodlech.Size = new System.Drawing.Size(198, 201);
            this.eatingNoodlech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eatingNoodlech.TabIndex = 26;
            this.eatingNoodlech.TabStop = false;
            this.eatingNoodlech.Visible = false;
            // 
            // NoodlePBX
            // 
            this.NoodlePBX.Image = global::asl_project.Properties.Resources.Noodle;
            this.NoodlePBX.Location = new System.Drawing.Point(48, 352);
            this.NoodlePBX.Margin = new System.Windows.Forms.Padding(2);
            this.NoodlePBX.Name = "NoodlePBX";
            this.NoodlePBX.Size = new System.Drawing.Size(100, 98);
            this.NoodlePBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoodlePBX.TabIndex = 24;
            this.NoodlePBX.TabStop = false;
            this.NoodlePBX.Visible = false;
            // 
            // eatingRicech
            // 
            this.eatingRicech.BackColor = System.Drawing.SystemColors.Control;
            this.eatingRicech.Image = global::asl_project.Properties.Resources.eatingRicech;
            this.eatingRicech.Location = new System.Drawing.Point(245, 290);
            this.eatingRicech.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.eatingRicech.Name = "eatingRicech";
            this.eatingRicech.Size = new System.Drawing.Size(198, 201);
            this.eatingRicech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eatingRicech.TabIndex = 23;
            this.eatingRicech.TabStop = false;
            this.eatingRicech.Visible = false;
            // 
            // characterPBX
            // 
            this.characterPBX.Image = global::asl_project.Properties.Resources.ch2;
            this.characterPBX.Location = new System.Drawing.Point(245, 290);
            this.characterPBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.characterPBX.Name = "characterPBX";
            this.characterPBX.Size = new System.Drawing.Size(198, 201);
            this.characterPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterPBX.TabIndex = 22;
            this.characterPBX.TabStop = false;
            // 
            // RicePBX
            // 
            this.RicePBX.Image = global::asl_project.Properties.Resources.Rice;
            this.RicePBX.Location = new System.Drawing.Point(48, 237);
            this.RicePBX.Margin = new System.Windows.Forms.Padding(2);
            this.RicePBX.Name = "RicePBX";
            this.RicePBX.Size = new System.Drawing.Size(100, 98);
            this.RicePBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RicePBX.TabIndex = 20;
            this.RicePBX.TabStop = false;
            this.RicePBX.Visible = false;
            // 
            // clearPBX
            // 
            this.clearPBX.Image = ((System.Drawing.Image)(resources.GetObject("clearPBX.Image")));
            this.clearPBX.Location = new System.Drawing.Point(522, 500);
            this.clearPBX.Margin = new System.Windows.Forms.Padding(2);
            this.clearPBX.Name = "clearPBX";
            this.clearPBX.Size = new System.Drawing.Size(108, 105);
            this.clearPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearPBX.TabIndex = 19;
            this.clearPBX.TabStop = false;
            // 
            // gamePBX
            // 
            this.gamePBX.Image = global::asl_project.Properties.Resources.ggame;
            this.gamePBX.Location = new System.Drawing.Point(368, 500);
            this.gamePBX.Margin = new System.Windows.Forms.Padding(2);
            this.gamePBX.Name = "gamePBX";
            this.gamePBX.Size = new System.Drawing.Size(108, 105);
            this.gamePBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePBX.TabIndex = 18;
            this.gamePBX.TabStop = false;
            this.gamePBX.Click += new System.EventHandler(this.gamePBX_Click);
            // 
            // SleepingPBX
            // 
            this.SleepingPBX.Image = global::asl_project.Properties.Resources.btn_sleep;
            this.SleepingPBX.Location = new System.Drawing.Point(212, 500);
            this.SleepingPBX.Margin = new System.Windows.Forms.Padding(2);
            this.SleepingPBX.Name = "SleepingPBX";
            this.SleepingPBX.Size = new System.Drawing.Size(108, 105);
            this.SleepingPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SleepingPBX.TabIndex = 17;
            this.SleepingPBX.TabStop = false;
            this.SleepingPBX.Click += new System.EventHandler(this.SleepingPBX_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(499, 452);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(0, 0);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(352, 452);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(212, 452);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // EatingPBX
            // 
            this.EatingPBX.Image = global::asl_project.Properties.Resources.food;
            this.EatingPBX.Location = new System.Drawing.Point(48, 500);
            this.EatingPBX.Margin = new System.Windows.Forms.Padding(2);
            this.EatingPBX.Name = "EatingPBX";
            this.EatingPBX.Size = new System.Drawing.Size(108, 105);
            this.EatingPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EatingPBX.TabIndex = 13;
            this.EatingPBX.TabStop = false;
            this.EatingPBX.Click += new System.EventHandler(this.click_eatingPBX);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.ddongPBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.eatingNoodlech);
            this.Controls.Add(this.withNoodlelbl);
            this.Controls.Add(this.NoodlePBX);
            this.Controls.Add(this.eatingRicech);
            this.Controls.Add(this.characterPBX);
            this.Controls.Add(this.withRicelbl);
            this.Controls.Add(this.RicePBX);
            this.Controls.Add(this.clearPBX);
            this.Controls.Add(this.gamePBX);
            this.Controls.Add(this.SleepingPBX);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainWindow";
            this.Text = "마스다치";
            ((System.ComponentModel.ISupportInitialize)(this.ddongPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatingNoodlech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoodlePBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatingRicech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RicePBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepingPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EatingPBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrH;
        private System.Windows.Forms.Timer tmrTR;
        private System.Windows.Forms.Timer tmrST;
        private System.Windows.Forms.Timer tmrGrow;
        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.Label lbTR;
        private System.Windows.Forms.Label lbST;
        private System.Windows.Forms.ProgressBar pgbH;
        private System.Windows.Forms.ProgressBar pgbTR;
        private System.Windows.Forms.ProgressBar pgbST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox EatingPBX;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox SleepingPBX;
        private System.Windows.Forms.PictureBox gamePBX;
        private System.Windows.Forms.PictureBox clearPBX;
        private System.Windows.Forms.PictureBox RicePBX;
        private System.Windows.Forms.Label withRicelbl;
        private System.Windows.Forms.PictureBox characterPBX;
        private System.Windows.Forms.PictureBox eatingRicech;
        private System.Windows.Forms.PictureBox NoodlePBX;
        private System.Windows.Forms.Label withNoodlelbl;
        private System.Windows.Forms.PictureBox eatingNoodlech;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ddongPBX;
        private System.Windows.Forms.ProgressBar pgbGrow;
        private System.Windows.Forms.Label lbGrow;
        private System.Windows.Forms.Label lbGrowState;
    }
}

