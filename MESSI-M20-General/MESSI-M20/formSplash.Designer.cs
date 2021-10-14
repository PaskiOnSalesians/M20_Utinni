
namespace MESSI_M20
{
    partial class formSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.labelSplash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // pgbSplash
            // 
            this.pgbSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgbSplash.Location = new System.Drawing.Point(245, 226);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(299, 24);
            this.pgbSplash.TabIndex = 0;
            // 
            // labelSplash
            // 
            this.labelSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSplash.AutoSize = true;
            this.labelSplash.BackColor = System.Drawing.Color.Transparent;
            this.labelSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSplash.Location = new System.Drawing.Point(550, 226);
            this.labelSplash.Name = "labelSplash";
            this.labelSplash.Size = new System.Drawing.Size(35, 24);
            this.labelSplash.TabIndex = 1;
            this.labelSplash.Text = "0%";
            // 
            // formSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSplash);
            this.Controls.Add(this.pgbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formSplash_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label labelSplash;
    }
}

