﻿namespace MESSI_M20
{
    partial class Frm_Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_code = new System.Windows.Forms.Panel();
            this.txt_box_code = new System.Windows.Forms.TextBox();
            this.pnl_keypad = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.pnl_coord = new System.Windows.Forms.Panel();
            this.txt_box_coord = new System.Windows.Forms.TextBox();
            this.pnl_down = new System.Windows.Forms.Panel();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_code.SuspendLayout();
            this.pnl_keypad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_coord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_code);
            this.panel1.Controls.Add(this.pnl_keypad);
            this.panel1.Controls.Add(this.pnl_coord);
            this.panel1.Controls.Add(this.pnl_down);
            this.panel1.Controls.Add(this.pnl_up);
            this.panel1.Controls.Add(this.pnl_right);
            this.panel1.Controls.Add(this.pnl_left);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 620);
            this.panel1.TabIndex = 0;
            // 
            // pnl_code
            // 
            this.pnl_code.Controls.Add(this.txt_box_code);
            this.pnl_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_code.Location = new System.Drawing.Point(148, 489);
            this.pnl_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_code.Name = "pnl_code";
            this.pnl_code.Size = new System.Drawing.Size(284, 101);
            this.pnl_code.TabIndex = 6;
            // 
            // txt_box_code
            // 
            this.txt_box_code.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_box_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_code.Location = new System.Drawing.Point(43, 26);
            this.txt_box_code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_box_code.MaxLength = 4;
            this.txt_box_code.Name = "txt_box_code";
            this.txt_box_code.PasswordChar = '*';
            this.txt_box_code.ReadOnly = true;
            this.txt_box_code.Size = new System.Drawing.Size(204, 53);
            this.txt_box_code.TabIndex = 1;
            this.txt_box_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_keypad
            // 
            this.pnl_keypad.Controls.Add(this.tableLayoutPanel1);
            this.pnl_keypad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_keypad.Location = new System.Drawing.Point(148, 169);
            this.pnl_keypad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_keypad.Name = "pnl_keypad";
            this.pnl_keypad.Size = new System.Drawing.Size(284, 320);
            this.pnl_keypad.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_plus, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_10, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_c, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 320);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(192, 244);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(88, 72);
            this.btn_plus.TabIndex = 11;
            this.btn_plus.Text = "*";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_10
            // 
            this.btn_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_10.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10.Location = new System.Drawing.Point(98, 244);
            this.btn_10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(86, 72);
            this.btn_10.TabIndex = 10;
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_c
            // 
            this.btn_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_c.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(4, 244);
            this.btn_c.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(86, 72);
            this.btn_c.TabIndex = 9;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_9
            // 
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(192, 164);
            this.btn_9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(88, 72);
            this.btn_9.TabIndex = 8;
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_8.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(98, 164);
            this.btn_8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(86, 72);
            this.btn_8.TabIndex = 7;
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(4, 164);
            this.btn_7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(86, 72);
            this.btn_7.TabIndex = 6;
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(192, 84);
            this.btn_6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(88, 72);
            this.btn_6.TabIndex = 5;
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(98, 84);
            this.btn_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(86, 72);
            this.btn_5.TabIndex = 4;
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(4, 84);
            this.btn_4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(86, 72);
            this.btn_4.TabIndex = 3;
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(192, 4);
            this.btn_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(88, 72);
            this.btn_3.TabIndex = 2;
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(98, 4);
            this.btn_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(86, 72);
            this.btn_2.TabIndex = 1;
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(4, 4);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(86, 72);
            this.btn_1.TabIndex = 0;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // pnl_coord
            // 
            this.pnl_coord.Controls.Add(this.txt_box_coord);
            this.pnl_coord.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_coord.Location = new System.Drawing.Point(148, 43);
            this.pnl_coord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_coord.Name = "pnl_coord";
            this.pnl_coord.Size = new System.Drawing.Size(284, 126);
            this.pnl_coord.TabIndex = 4;
            // 
            // txt_box_coord
            // 
            this.txt_box_coord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_coord.Location = new System.Drawing.Point(43, 26);
            this.txt_box_coord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_box_coord.Name = "txt_box_coord";
            this.txt_box_coord.Size = new System.Drawing.Size(204, 75);
            this.txt_box_coord.TabIndex = 0;
            this.txt_box_coord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_down
            // 
            this.pnl_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_down.Location = new System.Drawing.Point(148, 590);
            this.pnl_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_down.Name = "pnl_down";
            this.pnl_down.Size = new System.Drawing.Size(284, 30);
            this.pnl_down.TabIndex = 3;
            // 
            // pnl_up
            // 
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(148, 0);
            this.pnl_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(284, 43);
            this.pnl_up.TabIndex = 2;
            // 
            // pnl_right
            // 
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(432, 0);
            this.pnl_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(135, 620);
            this.pnl_right.TabIndex = 1;
            // 
            // pnl_left
            // 
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(148, 620);
            this.pnl_left.TabIndex = 0;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 620);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Admin";
            this.Text = "Frm_Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Admin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.pnl_code.ResumeLayout(false);
            this.pnl_code.PerformLayout();
            this.pnl_keypad.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_coord.ResumeLayout(false);
            this.pnl_coord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_coord;
        private System.Windows.Forms.Panel pnl_down;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_keypad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Panel pnl_code;
        private System.Windows.Forms.TextBox txt_box_code;
        private System.Windows.Forms.TextBox txt_box_coord;
    }
}