namespace ServewerLog_in
{
    partial class MainForm
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
            this.groupBoxControlButtons = new System.Windows.Forms.GroupBox();
            this.pictureBoxMaximise = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimise = new System.Windows.Forms.PictureBox();
            this.groupBoxControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxControlButtons
            // 
            this.groupBoxControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxControlButtons.Controls.Add(this.pictureBoxMaximise);
            this.groupBoxControlButtons.Controls.Add(this.pictureBoxClose);
            this.groupBoxControlButtons.Controls.Add(this.pictureBoxMinimise);
            this.groupBoxControlButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxControlButtons.ForeColor = System.Drawing.Color.Beige;
            this.groupBoxControlButtons.Location = new System.Drawing.Point(703, 12);
            this.groupBoxControlButtons.Name = "groupBoxControlButtons";
            this.groupBoxControlButtons.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxControlButtons.Size = new System.Drawing.Size(85, 25);
            this.groupBoxControlButtons.TabIndex = 8;
            this.groupBoxControlButtons.TabStop = false;
            // 
            // pictureBoxMaximise
            // 
            this.pictureBoxMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaximise.Image = global::ServewerLog_in.Properties.Resources.maximise;
            this.pictureBoxMaximise.Location = new System.Drawing.Point(30, -1);
            this.pictureBoxMaximise.Name = "pictureBoxMaximise";
            this.pictureBoxMaximise.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMaximise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaximise.TabIndex = 6;
            this.pictureBoxMaximise.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::ServewerLog_in.Properties.Resources.close;
            this.pictureBoxClose.Location = new System.Drawing.Point(61, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            // 
            // pictureBoxMinimise
            // 
            this.pictureBoxMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimise.Image = global::ServewerLog_in.Properties.Resources.minimise;
            this.pictureBoxMinimise.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxMinimise.Name = "pictureBoxMinimise";
            this.pictureBoxMinimise.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimise.TabIndex = 5;
            this.pictureBoxMinimise.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxControlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControlButtons;
        private System.Windows.Forms.PictureBox pictureBoxMaximise;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimise;
    }
}