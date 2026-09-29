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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxControlButtons = new System.Windows.Forms.GroupBox();
            this.pictureBoxMaximise = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimise = new System.Windows.Forms.PictureBox();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.richTextBoxProfileDecription = new System.Windows.Forms.RichTextBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBoxMaximise.Click += new System.EventHandler(this.pictureBoxMaximise_Click);
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
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
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
            this.pictureBoxMinimise.Click += new System.EventHandler(this.pictureBoxMinimise_Click);
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.BackColor = System.Drawing.Color.Beige;
            this.textBoxProfileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxProfileName.ForeColor = System.Drawing.Color.BurlyWood;
            this.textBoxProfileName.Location = new System.Drawing.Point(339, 66);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.Size = new System.Drawing.Size(206, 31);
            this.textBoxProfileName.TabIndex = 10;
            this.textBoxProfileName.Text = "Nazwa Profilu";
            // 
            // richTextBoxProfileDecription
            // 
            this.richTextBoxProfileDecription.BackColor = System.Drawing.Color.Beige;
            this.richTextBoxProfileDecription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxProfileDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxProfileDecription.ForeColor = System.Drawing.Color.Brown;
            this.richTextBoxProfileDecription.Location = new System.Drawing.Point(339, 135);
            this.richTextBoxProfileDecription.Name = "richTextBoxProfileDecription";
            this.richTextBoxProfileDecription.Size = new System.Drawing.Size(356, 259);
            this.richTextBoxProfileDecription.TabIndex = 11;
            this.richTextBoxProfileDecription.Text = resources.GetString("richTextBoxProfileDecription.Text");
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Bisque;
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Location = new System.Drawing.Point(82, 345);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(208, 49);
            this.buttonLogOut.TabIndex = 12;
            this.buttonLogOut.Text = "Wyloguj się";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServewerLog_in.Properties.Resources.defaultProfile;
            this.pictureBox1.Location = new System.Drawing.Point(82, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.richTextBoxProfileDecription);
            this.Controls.Add(this.textBoxProfileName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxControlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Nazwa Profilu";
            this.groupBoxControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControlButtons;
        private System.Windows.Forms.PictureBox pictureBoxMaximise;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.RichTextBox richTextBoxProfileDecription;
        private System.Windows.Forms.Button buttonLogOut;
    }
}