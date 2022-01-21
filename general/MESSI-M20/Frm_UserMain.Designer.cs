
namespace MESSI_M20
{
    partial class Frm_UserMain
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
            this.btnBlueprintsUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlueprintsUser
            // 
            this.btnBlueprintsUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBlueprintsUser.FlatAppearance.BorderSize = 0;
            this.btnBlueprintsUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueprintsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnBlueprintsUser.ForeColor = System.Drawing.Color.White;
            this.btnBlueprintsUser.Location = new System.Drawing.Point(13, 14);
            this.btnBlueprintsUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBlueprintsUser.Name = "btnBlueprintsUser";
            this.btnBlueprintsUser.Size = new System.Drawing.Size(294, 62);
            this.btnBlueprintsUser.TabIndex = 6;
            this.btnBlueprintsUser.Text = "Weapon Blueprints";
            this.btnBlueprintsUser.UseVisualStyleBackColor = false;
            this.btnBlueprintsUser.Click += new System.EventHandler(this.btnBlueprintsUser_Click);
            // 
            // Frm_UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1384, 704);
            this.Controls.Add(this.btnBlueprintsUser);
            this.Name = "Frm_UserMain";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlueprintsUser;
    }
}