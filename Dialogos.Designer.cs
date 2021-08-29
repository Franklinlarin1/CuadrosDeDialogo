
namespace Formulariomdi
{
    partial class Dialogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialogos));
            this.baceptar = new System.Windows.Forms.Button();
            this.binterrogacion = new System.Windows.Forms.Button();
            this.berror = new System.Windows.Forms.Button();
            this.bexclamacion = new System.Windows.Forms.Button();
            this.bsi_no = new System.Windows.Forms.Button();
            this.baceptar_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baceptar
            // 
            this.baceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.baceptar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar.ForeColor = System.Drawing.Color.Black;
            this.baceptar.Location = new System.Drawing.Point(135, 129);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(172, 73);
            this.baceptar.TabIndex = 0;
            this.baceptar.Text = "Aceptar";
            this.baceptar.UseVisualStyleBackColor = false;
            this.baceptar.Click += new System.EventHandler(this.baceptar_Click);
            // 
            // binterrogacion
            // 
            this.binterrogacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.binterrogacion.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binterrogacion.ForeColor = System.Drawing.Color.Black;
            this.binterrogacion.Location = new System.Drawing.Point(345, 264);
            this.binterrogacion.Name = "binterrogacion";
            this.binterrogacion.Size = new System.Drawing.Size(197, 73);
            this.binterrogacion.TabIndex = 4;
            this.binterrogacion.Text = "Interrogación";
            this.binterrogacion.UseVisualStyleBackColor = false;
            this.binterrogacion.Click += new System.EventHandler(this.binterrogacion_Click);
            // 
            // berror
            // 
            this.berror.BackColor = System.Drawing.Color.DodgerBlue;
            this.berror.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berror.ForeColor = System.Drawing.Color.Black;
            this.berror.Location = new System.Drawing.Point(565, 264);
            this.berror.Name = "berror";
            this.berror.Size = new System.Drawing.Size(172, 73);
            this.berror.TabIndex = 5;
            this.berror.Text = "Error";
            this.berror.UseVisualStyleBackColor = false;
            this.berror.Click += new System.EventHandler(this.berror_Click);
            // 
            // bexclamacion
            // 
            this.bexclamacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.bexclamacion.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexclamacion.ForeColor = System.Drawing.Color.Black;
            this.bexclamacion.Location = new System.Drawing.Point(135, 264);
            this.bexclamacion.Name = "bexclamacion";
            this.bexclamacion.Size = new System.Drawing.Size(172, 73);
            this.bexclamacion.TabIndex = 3;
            this.bexclamacion.Text = "Exclamación";
            this.bexclamacion.UseVisualStyleBackColor = false;
            this.bexclamacion.Click += new System.EventHandler(this.bexclamacion_Click);
            // 
            // bsi_no
            // 
            this.bsi_no.BackColor = System.Drawing.Color.DodgerBlue;
            this.bsi_no.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsi_no.ForeColor = System.Drawing.Color.Black;
            this.bsi_no.Location = new System.Drawing.Point(565, 129);
            this.bsi_no.Name = "bsi_no";
            this.bsi_no.Size = new System.Drawing.Size(172, 73);
            this.bsi_no.TabIndex = 2;
            this.bsi_no.Text = "Si/No";
            this.bsi_no.UseVisualStyleBackColor = false;
            this.bsi_no.Click += new System.EventHandler(this.bsi_no_Click_1);
            // 
            // baceptar_cancelar
            // 
            this.baceptar_cancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.baceptar_cancelar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar_cancelar.ForeColor = System.Drawing.Color.Black;
            this.baceptar_cancelar.Location = new System.Drawing.Point(345, 129);
            this.baceptar_cancelar.Name = "baceptar_cancelar";
            this.baceptar_cancelar.Size = new System.Drawing.Size(197, 73);
            this.baceptar_cancelar.TabIndex = 1;
            this.baceptar_cancelar.Text = "Aceptar/Cancelar ";
            this.baceptar_cancelar.UseVisualStyleBackColor = false;
            this.baceptar_cancelar.Click += new System.EventHandler(this.baceptar_cancelar_Click_1);
            // 
            // Dialogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.berror);
            this.Controls.Add(this.binterrogacion);
            this.Controls.Add(this.bexclamacion);
            this.Controls.Add(this.bsi_no);
            this.Controls.Add(this.baceptar_cancelar);
            this.Controls.Add(this.baceptar);
            this.IsMdiContainer = true;
            this.Name = "Dialogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cuadros de Dialogo en C#";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.Button binterrogacion;
        private System.Windows.Forms.Button berror;
        private System.Windows.Forms.Button bexclamacion;
        private System.Windows.Forms.Button bsi_no;
        private System.Windows.Forms.Button baceptar_cancelar;
    }
}

