
namespace Gestor_de_Asistencia
{
    partial class FrmNovedadesEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovedadesEmpleado));
            this.dtpFechaDeTrabajo = new System.Windows.Forms.DateTimePicker();
            this.lstBoxNovovedades = new System.Windows.Forms.ListBox();
            this.rchTextDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dtpFechaDeTrabajo
            // 
            this.dtpFechaDeTrabajo.Location = new System.Drawing.Point(12, 21);
            this.dtpFechaDeTrabajo.Name = "dtpFechaDeTrabajo";
            this.dtpFechaDeTrabajo.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDeTrabajo.TabIndex = 0;
            // 
            // lstBoxNovovedades
            // 
            this.lstBoxNovovedades.FormattingEnabled = true;
            this.lstBoxNovovedades.Location = new System.Drawing.Point(12, 47);
            this.lstBoxNovovedades.Name = "lstBoxNovovedades";
            this.lstBoxNovovedades.Size = new System.Drawing.Size(200, 95);
            this.lstBoxNovovedades.TabIndex = 1;
            this.lstBoxNovovedades.SelectedIndexChanged += new System.EventHandler(this.lstBoxNovovedades_SelectedIndexChanged);
            // 
            // rchTextDatos
            // 
            this.rchTextDatos.Location = new System.Drawing.Point(12, 148);
            this.rchTextDatos.Name = "rchTextDatos";
            this.rchTextDatos.ReadOnly = true;
            this.rchTextDatos.Size = new System.Drawing.Size(547, 202);
            this.rchTextDatos.TabIndex = 2;
            this.rchTextDatos.Text = "";
            // 
            // FrmNovedadesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 362);
            this.Controls.Add(this.rchTextDatos);
            this.Controls.Add(this.lstBoxNovovedades);
            this.Controls.Add(this.dtpFechaDeTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovedadesEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novedades";
            this.Load += new System.EventHandler(this.FrmNovedadesEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDeTrabajo;
        private System.Windows.Forms.ListBox lstBoxNovovedades;
        private System.Windows.Forms.RichTextBox rchTextDatos;
    }
}