namespace VolControl
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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.controlBnt = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ipBox.Location = new System.Drawing.Point(12, 51);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(350, 20);
            this.ipBox.TabIndex = 0;
            // 
            // controlBnt
            // 
            this.controlBnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBnt.Location = new System.Drawing.Point(367, 51);
            this.controlBnt.Name = "controlBnt";
            this.controlBnt.Size = new System.Drawing.Size(75, 20);
            this.controlBnt.TabIndex = 1;
            this.controlBnt.Text = "Connect";
            this.controlBnt.UseVisualStyleBackColor = true;
            this.controlBnt.Click += new System.EventHandler(this.controlBnt_Click);
            // 
            // trackBar1
            // 
            this.volumeBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.volumeBar.Enabled = false;
            this.volumeBar.Location = new System.Drawing.Point(0, 0);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "trackBar1";
            this.volumeBar.Size = new System.Drawing.Size(454, 45);
            this.volumeBar.TabIndex = 3;
            this.volumeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 78);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.controlBnt);
            this.Controls.Add(this.ipBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Volman";
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button controlBnt;
        private System.Windows.Forms.TrackBar volumeBar;
    }
}

