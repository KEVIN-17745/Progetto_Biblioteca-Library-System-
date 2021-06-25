
namespace Progetto_Biblioteca
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.cb_NomeUtente = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ss_Login = new System.Windows.Forms.StatusStrip();
            this.ss_lbl_Numero_Tentativi = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_lbl_Messaggio_Errore = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_lbl_Utente_Scelto = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ss_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Utente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(75, 218);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(120, 30);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_NomeUtente
            // 
            this.cb_NomeUtente.FormattingEnabled = true;
            this.cb_NomeUtente.Location = new System.Drawing.Point(292, 149);
            this.cb_NomeUtente.Name = "cb_NomeUtente";
            this.cb_NomeUtente.Size = new System.Drawing.Size(130, 24);
            this.cb_NomeUtente.TabIndex = 3;
            this.cb_NomeUtente.SelectedIndexChanged += new System.EventHandler(this.cb_NomeUtente_SelectedIndexChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Enabled = false;
            this.txt_Password.Location = new System.Drawing.Point(292, 219);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(130, 22);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Enabled = false;
            this.btn_Login.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Image = global::Progetto_Biblioteca.Properties.Resources.account_key_login_password_profile_security_user_icon_935673_2_;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(242, 271);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(117, 45);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Progetto_Biblioteca.Properties.Resources.wwewe;
            this.pictureBox1.Location = new System.Drawing.Point(2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ss_Login
            // 
            this.ss_Login.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_Login.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_lbl_Numero_Tentativi,
            this.ss_lbl_Messaggio_Errore,
            this.ss_lbl_Utente_Scelto});
            this.ss_Login.Location = new System.Drawing.Point(0, 327);
            this.ss_Login.Name = "ss_Login";
            this.ss_Login.Size = new System.Drawing.Size(582, 26);
            this.ss_Login.TabIndex = 6;
            this.ss_Login.Text = "statusStrip1";
            // 
            // ss_lbl_Numero_Tentativi
            // 
            this.ss_lbl_Numero_Tentativi.Name = "ss_lbl_Numero_Tentativi";
            this.ss_lbl_Numero_Tentativi.Size = new System.Drawing.Size(151, 20);
            this.ss_lbl_Numero_Tentativi.Text = "toolStripStatusLabel1";
            // 
            // ss_lbl_Messaggio_Errore
            // 
            this.ss_lbl_Messaggio_Errore.ForeColor = System.Drawing.Color.Red;
            this.ss_lbl_Messaggio_Errore.Name = "ss_lbl_Messaggio_Errore";
            this.ss_lbl_Messaggio_Errore.Size = new System.Drawing.Size(0, 20);
            // 
            // ss_lbl_Utente_Scelto
            // 
            this.ss_lbl_Utente_Scelto.Name = "ss_lbl_Utente_Scelto";
            this.ss_lbl_Utente_Scelto.Size = new System.Drawing.Size(0, 20);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.ss_Login);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.cb_NomeUtente);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Bibliotca_Identificazione_Utente";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ss_Login.ResumeLayout(false);
            this.ss_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ComboBox cb_NomeUtente;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.StatusStrip ss_Login;
        private System.Windows.Forms.ToolStripStatusLabel ss_lbl_Numero_Tentativi;
        private System.Windows.Forms.ToolStripStatusLabel ss_lbl_Messaggio_Errore;
        private System.Windows.Forms.ToolStripStatusLabel ss_lbl_Utente_Scelto;
    }
}

