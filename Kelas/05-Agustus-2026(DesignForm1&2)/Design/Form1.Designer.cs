namespace Design
{
    partial class LoginForm1
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
            this.formlogin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buatakun = new System.Windows.Forms.Label();
            this.DaftarAkun = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formlogin
            // 
            this.formlogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.formlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlogin.Location = new System.Drawing.Point(440, 331);
            this.formlogin.Name = "formlogin";
            this.formlogin.Size = new System.Drawing.Size(75, 29);
            this.formlogin.TabIndex = 1;
            this.formlogin.Text = "Login";
            this.formlogin.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(179, 289);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(107, 25);
            this.password.TabIndex = 0;
            this.password.Text = "password :";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(177, 257);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(109, 25);
            this.username.TabIndex = 0;
            this.username.Text = "username :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buatakun
            // 
            this.buatakun.AutoSize = true;
            this.buatakun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buatakun.Location = new System.Drawing.Point(222, 383);
            this.buatakun.Name = "buatakun";
            this.buatakun.Size = new System.Drawing.Size(111, 15);
            this.buatakun.TabIndex = 3;
            this.buatakun.Text = "Belum punya akun?";
            // 
            // DaftarAkun
            // 
            this.DaftarAkun.AutoSize = true;
            this.DaftarAkun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaftarAkun.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DaftarAkun.Location = new System.Drawing.Point(413, 383);
            this.DaftarAkun.Name = "DaftarAkun";
            this.DaftarAkun.Size = new System.Drawing.Size(70, 15);
            this.DaftarAkun.TabIndex = 4;
            this.DaftarAkun.Text = "Daftar Akun";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Design.Properties.Resources.garuda_indonesia_logo_png_seeklogo_283969;
            this.pictureBox1.Location = new System.Drawing.Point(234, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DaftarAkun);
            this.Controls.Add(this.buatakun);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.formlogin);
            this.Controls.Add(this.username);
            this.Name = "LoginForm1";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button formlogin;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label buatakun;
        private System.Windows.Forms.Label DaftarAkun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

