
namespace Users
{
    partial class Frm_Users
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Users));
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.logo_app = new System.Windows.Forms.Panel();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.txtbox_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_number_error = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_intents = new System.Windows.Forms.Label();
            this.timer_progress = new System.Windows.Forms.Timer(this.components);
            this.loading_bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(332, 85);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(45, 21);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "User:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(301, 122);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(79, 21);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password:";
            // 
            // logo_app
            // 
            this.logo_app.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo_app.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_app.BackgroundImage")));
            this.logo_app.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_app.Location = new System.Drawing.Point(48, 54);
            this.logo_app.Margin = new System.Windows.Forms.Padding(2);
            this.logo_app.Name = "logo_app";
            this.logo_app.Size = new System.Drawing.Size(212, 169);
            this.logo_app.TabIndex = 2;
            // 
            // txtbox_user
            // 
            this.txtbox_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_user.Location = new System.Drawing.Point(378, 88);
            this.txtbox_user.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(151, 20);
            this.txtbox_user.TabIndex = 3;
            // 
            // txtbox_pass
            // 
            this.txtbox_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_pass.Location = new System.Drawing.Point(378, 124);
            this.txtbox_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_pass.Name = "txtbox_pass";
            this.txtbox_pass.PasswordChar = '*';
            this.txtbox_pass.Size = new System.Drawing.Size(151, 20);
            this.txtbox_pass.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(301, 172);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(227, 51);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(534, 8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 22);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_number_error
            // 
            this.lbl_number_error.AutoSize = true;
            this.lbl_number_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_number_error.Location = new System.Drawing.Point(361, 149);
            this.lbl_number_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_number_error.Name = "lbl_number_error";
            this.lbl_number_error.Size = new System.Drawing.Size(13, 13);
            this.lbl_number_error.TabIndex = 7;
            this.lbl_number_error.Text = "0";
            this.lbl_number_error.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(370, 149);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(82, 13);
            this.lbl_error.TabIndex = 8;
            this.lbl_error.Text = "intent/s erroni/s";
            this.lbl_error.Visible = false;
            // 
            // lbl_intents
            // 
            this.lbl_intents.AutoSize = true;
            this.lbl_intents.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lbl_intents.ForeColor = System.Drawing.Color.Red;
            this.lbl_intents.Location = new System.Drawing.Point(9, 242);
            this.lbl_intents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_intents.Name = "lbl_intents";
            this.lbl_intents.Size = new System.Drawing.Size(459, 36);
            this.lbl_intents.TabIndex = 9;
            this.lbl_intents.Text = "Ha probat masses intents d\'inici :(";
            this.lbl_intents.Visible = false;
            // 
            // timer_progress
            // 
            this.timer_progress.Interval = 40;
            this.timer_progress.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading_bar
            // 
            this.loading_bar.Location = new System.Drawing.Point(9, 8);
            this.loading_bar.Margin = new System.Windows.Forms.Padding(2);
            this.loading_bar.Name = "loading_bar";
            this.loading_bar.Size = new System.Drawing.Size(94, 19);
            this.loading_bar.TabIndex = 10;
            this.loading_bar.Visible = false;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(600, 292);
            this.Controls.Add(this.loading_bar);
            this.Controls.Add(this.lbl_intents);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_number_error);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_pass);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.logo_app);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Users";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Panel logo_app;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.TextBox txtbox_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_number_error;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_intents;
        private System.Windows.Forms.Timer timer_progress;
        private System.Windows.Forms.ProgressBar loading_bar;
    }
}

