
namespace MESSI_M20
{
    partial class frm_Planols
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlueprints = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(554, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "tittle";
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(423, 249);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(365, 192);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "text";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(83, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 48);
            this.panel1.TabIndex = 2;
            // 
            // btnBlueprints
            // 
            this.btnBlueprints.Location = new System.Drawing.Point(30, 12);
            this.btnBlueprints.Name = "btnBlueprints";
            this.btnBlueprints.Size = new System.Drawing.Size(103, 32);
            this.btnBlueprints.TabIndex = 5;
            this.btnBlueprints.Text = "Blueprints";
            this.btnBlueprints.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(224, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 48);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(55, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 48);
            this.panel3.TabIndex = 7;
            // 
            // picBig
            // 
            this.picBig.Image = global::MESSI_M20.Properties.Resources.detall3;
            this.picBig.Location = new System.Drawing.Point(30, 76);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(266, 238);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 8;
            this.picBig.TabStop = false;
            // 
            // frm_Planols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBlueprints);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBig);
            this.Name = "frm_Planols";
            this.Text = "Weapon Blueprints and Information";
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlueprints;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBig;
    }
}