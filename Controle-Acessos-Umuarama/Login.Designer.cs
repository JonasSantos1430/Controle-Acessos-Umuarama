
namespace Controle_Acessos_Umuarama
{
    partial class Login
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
            this.Txt_Nome_Login = new System.Windows.Forms.TextBox();
            this.Txt_Senha_Login = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nome_Login
            // 
            this.Txt_Nome_Login.Location = new System.Drawing.Point(254, 85);
            this.Txt_Nome_Login.Name = "Txt_Nome_Login";
            this.Txt_Nome_Login.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nome_Login.TabIndex = 0;
            // 
            // Txt_Senha_Login
            // 
            this.Txt_Senha_Login.Location = new System.Drawing.Point(254, 111);
            this.Txt_Senha_Login.Name = "Txt_Senha_Login";
            this.Txt_Senha_Login.Size = new System.Drawing.Size(100, 20);
            this.Txt_Senha_Login.TabIndex = 1;
            this.Txt_Senha_Login.UseSystemPasswordChar = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(254, 161);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 33);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Entrar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_Acessos_Umuarama.Properties.Resources.Login_Img;
            this.pictureBox1.Location = new System.Drawing.Point(24, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Senha_Login);
            this.Controls.Add(this.Txt_Nome_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome_Login;
        private System.Windows.Forms.TextBox Txt_Senha_Login;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}