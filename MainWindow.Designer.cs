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
            this.tmrSL = new System.Windows.Forms.Timer(this.components);
            this.tmrST = new System.Windows.Forms.Timer(this.components);
            this.tmrGrow = new System.Windows.Forms.Timer(this.components);
            this.pbCh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCh
            // 
            this.pbCh.Image = global::asl_project.Properties.Resources.ch1;
            this.pbCh.Location = new System.Drawing.Point(230, 336);
            this.pbCh.Name = "pbCh";
            this.pbCh.Size = new System.Drawing.Size(180, 180);
            this.pbCh.TabIndex = 0;
            this.pbCh.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.pbCh);
            this.Name = "MainWindow";
            this.Text = "마스다치";
            ((System.ComponentModel.ISupportInitialize)(this.pbCh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrH;
        private System.Windows.Forms.Timer tmrSL;
        private System.Windows.Forms.Timer tmrST;
        private System.Windows.Forms.Timer tmrGrow;
        private System.Windows.Forms.PictureBox pbCh;
    }
}

