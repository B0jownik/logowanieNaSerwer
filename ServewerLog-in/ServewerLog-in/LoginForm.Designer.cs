namespace ServewerLog_in
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Logowanie = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimise = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaximise = new System.Windows.Forms.PictureBox();
            this.groupBoxControlButtons = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.labelPodajEmail = new System.Windows.Forms.Label();
            this.labelPodajHaslo = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelWrongAnnouncer = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximise)).BeginInit();
            this.groupBoxControlButtons.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Logowanie
            // 
            this.label_Logowanie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Logowanie.AutoSize = true;
            this.label_Logowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Logowanie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Logowanie.Location = new System.Drawing.Point(338, 91);
            this.label_Logowanie.Name = "label_Logowanie";
            this.label_Logowanie.Size = new System.Drawing.Size(123, 25);
            this.label_Logowanie.TabIndex = 0;
            this.label_Logowanie.Text = "Zaloguj się:";
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
            // groupBoxControlButtons
            // 
            this.groupBoxControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControlButtons.Controls.Add(this.pictureBoxMaximise);
            this.groupBoxControlButtons.Controls.Add(this.pictureBoxClose);
            this.groupBoxControlButtons.Controls.Add(this.pictureBoxMinimise);
            this.groupBoxControlButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxControlButtons.ForeColor = System.Drawing.Color.Beige;
            this.groupBoxControlButtons.Location = new System.Drawing.Point(703, 12);
            this.groupBoxControlButtons.Name = "groupBoxControlButtons";
            this.groupBoxControlButtons.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxControlButtons.Size = new System.Drawing.Size(85, 25);
            this.groupBoxControlButtons.TabIndex = 7;
            this.groupBoxControlButtons.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(20, 41);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(171, 26);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(20, 124);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(171, 26);
            this.textBoxHaslo.TabIndex = 9;
            // 
            // labelPodajEmail
            // 
            this.labelPodajEmail.AutoSize = true;
            this.labelPodajEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodajEmail.Location = new System.Drawing.Point(20, 18);
            this.labelPodajEmail.Name = "labelPodajEmail";
            this.labelPodajEmail.Size = new System.Drawing.Size(101, 20);
            this.labelPodajEmail.TabIndex = 10;
            this.labelPodajEmail.Text = "Podaj E-mail:";
            // 
            // labelPodajHaslo
            // 
            this.labelPodajHaslo.AutoSize = true;
            this.labelPodajHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodajHaslo.Location = new System.Drawing.Point(20, 101);
            this.labelPodajHaslo.Name = "labelPodajHaslo";
            this.labelPodajHaslo.Size = new System.Drawing.Size(99, 20);
            this.labelPodajHaslo.TabIndex = 11;
            this.labelPodajHaslo.Text = "Podaj Hasło:";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelPodajEmail);
            this.panelLogin.Controls.Add(this.labelPodajHaslo);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.textBoxHaslo);
            this.panelLogin.Location = new System.Drawing.Point(111, 139);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(393, 170);
            this.panelLogin.TabIndex = 12;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFinish.Location = new System.Drawing.Point(350, 370);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(100, 30);
            this.buttonFinish.TabIndex = 13;
            this.buttonFinish.Text = "Zatwierdź";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelWrongAnnouncer
            // 
            this.labelWrongAnnouncer.AutoSize = true;
            this.labelWrongAnnouncer.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWrongAnnouncer.Location = new System.Drawing.Point(274, 411);
            this.labelWrongAnnouncer.Name = "labelWrongAnnouncer";
            this.labelWrongAnnouncer.Size = new System.Drawing.Size(19, 13);
            this.labelWrongAnnouncer.TabIndex = 14;
            this.labelWrongAnnouncer.Text = "    ";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(624, 285);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 15;
            this.buttonTest.Text = "test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.labelWrongAnnouncer);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.groupBoxControlButtons);
            this.Controls.Add(this.label_Logowanie);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximise)).EndInit();
            this.groupBoxControlButtons.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Logowanie;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimise;
        private System.Windows.Forms.PictureBox pictureBoxMaximise;
        private System.Windows.Forms.GroupBox groupBoxControlButtons;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label labelPodajEmail;
        private System.Windows.Forms.Label labelPodajHaslo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelWrongAnnouncer;
        private System.Windows.Forms.Button buttonTest;
    }
}

