namespace SintePart
{
    partial class formSintePart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSintePart));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.cmdEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(97, 64);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(409, 42);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO A SINTEPART";
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.cmdEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdEntrar.Location = new System.Drawing.Point(205, 228);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(199, 97);
            this.cmdEntrar.TabIndex = 1;
            this.cmdEntrar.Text = "ENTRAR";
            this.cmdEntrar.UseVisualStyleBackColor = false;
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // formSintePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.cmdEntrar);
            this.Controls.Add(this.lblBienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSintePart";
            this.Text = "SintePart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button cmdEntrar;
    }
}

