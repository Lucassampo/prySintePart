namespace SintePart
{
    partial class frmAcceso
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
            this.lblAccesoSintepart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccesoSintepart
            // 
            this.lblAccesoSintepart.AutoSize = true;
            this.lblAccesoSintepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesoSintepart.Location = new System.Drawing.Point(44, 178);
            this.lblAccesoSintepart.Name = "lblAccesoSintepart";
            this.lblAccesoSintepart.Size = new System.Drawing.Size(479, 39);
            this.lblAccesoSintepart.TabIndex = 0;
            this.lblAccesoSintepart.Text = "Has accedido a SINTEPART";
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.lblAccesoSintepart);
            this.Name = "frmAcceso";
            this.Text = "Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccesoSintepart;
    }
}