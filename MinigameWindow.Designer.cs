namespace asl_project
{
    partial class MinigameWindow
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
            this.tmr100Millisecond = new System.Windows.Forms.Timer(this.components);
            this.panelMazeView = new System.Windows.Forms.Panel();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tmr100Millisecond
            // 
            this.tmr100Millisecond.Tick += new System.EventHandler(this.tmr100Millisecond_Tick);
            // 
            // panelMazeView
            // 
            this.panelMazeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMazeView.Location = new System.Drawing.Point(0, 30);
            this.panelMazeView.Margin = new System.Windows.Forms.Padding(0);
            this.panelMazeView.Name = "panelMazeView";
            this.panelMazeView.Size = new System.Drawing.Size(782, 748);
            this.panelMazeView.TabIndex = 1;
            this.panelMazeView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMazeView_Paint);
            // 
            // progressBarTime
            // 
            this.progressBarTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarTime.Enabled = false;
            this.progressBarTime.Location = new System.Drawing.Point(0, 0);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(0);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(782, 30);
            this.progressBarTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTime.TabIndex = 4;
            this.progressBarTime.Value = 75;
            // 
            // MinigameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 778);
            this.Controls.Add(this.panelMazeView);
            this.Controls.Add(this.progressBarTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MinigameWindow";
            this.Text = "산책";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MinigameWindow_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinigameWindow_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr100Millisecond;
        private System.Windows.Forms.Panel panelMazeView;
        private System.Windows.Forms.ProgressBar progressBarTime;
    }
}