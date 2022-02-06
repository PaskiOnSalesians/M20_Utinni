
namespace MESSI_M20
{
    partial class Frm_GestioUsuaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestioUsuaris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbox_users = new System.Windows.Forms.ComboBox();
            this.txt_hostname = new System.Windows.Forms.TextBox();
            this.txtbox_mac = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelHostName = new System.Windows.Forms.Label();
            this.labelMac = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.cmbox_users);
            this.panel1.Controls.Add(this.txt_hostname);
            this.panel1.Controls.Add(this.txtbox_mac);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Controls.Add(this.labelHostName);
            this.panel1.Controls.Add(this.labelMac);
            this.panel1.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(44, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 106);
            this.panel1.TabIndex = 0;
            // 
            // cmbox_users
            // 
            this.cmbox_users.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_users.FormattingEnabled = true;
            this.cmbox_users.Location = new System.Drawing.Point(365, 15);
            this.cmbox_users.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbox_users.Name = "cmbox_users";
            this.cmbox_users.Size = new System.Drawing.Size(138, 32);
            this.cmbox_users.TabIndex = 1;
            // 
            // txt_hostname
            // 
            this.txt_hostname.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hostname.Location = new System.Drawing.Point(112, 63);
            this.txt_hostname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.ReadOnly = true;
            this.txt_hostname.Size = new System.Drawing.Size(153, 30);
            this.txt_hostname.TabIndex = 4;
            // 
            // txtbox_mac
            // 
            this.txtbox_mac.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_mac.Location = new System.Drawing.Point(112, 15);
            this.txtbox_mac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_mac.Name = "txtbox_mac";
            this.txtbox_mac.ReadOnly = true;
            this.txtbox_mac.Size = new System.Drawing.Size(153, 30);
            this.txtbox_mac.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(317, 21);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 24);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User";
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostName.ForeColor = System.Drawing.Color.White;
            this.labelHostName.Location = new System.Drawing.Point(36, 66);
            this.labelHostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(72, 24);
            this.labelHostName.TabIndex = 1;
            this.labelHostName.Text = "HostName";
            // 
            // labelMac
            // 
            this.labelMac.AutoSize = true;
            this.labelMac.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMac.ForeColor = System.Drawing.Color.White;
            this.labelMac.Location = new System.Drawing.Point(36, 21);
            this.labelMac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMac.Name = "labelMac";
            this.labelMac.Size = new System.Drawing.Size(48, 24);
            this.labelMac.TabIndex = 0;
            this.labelMac.Text = "M.A.C.";
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(44, 206);
            this.btn_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(79, 34);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(138, 206);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(79, 34);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(236, 206);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 34);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_return
            // 
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.Image")));
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_return.Location = new System.Drawing.Point(10, 11);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(96, 34);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "BACK";
            this.btn_return.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_apanel_Click);
            // 
            // Frm_GestioUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(676, 384);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_GestioUsuaris";
            this.Text = "Trusted Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_GestioUsuaris_FormClosing);
            this.Load += new System.EventHandler(this.Frm_GestioUsuaris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_hostname;
        private System.Windows.Forms.TextBox txtbox_mac;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Label labelMac;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmbox_users;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button btn_return;
    }
}