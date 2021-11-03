
namespace Gestor_de_Asistencia
{
    partial class FrmSelectorDeFechas
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
            this.grpBoxFechas = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtmpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtmpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.labFechaFin = new System.Windows.Forms.Label();
            this.grpBoxFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxFechas
            // 
            this.grpBoxFechas.Controls.Add(this.labFechaFin);
            this.grpBoxFechas.Controls.Add(this.lblFechaInicio);
            this.grpBoxFechas.Controls.Add(this.dtmpFechaFin);
            this.grpBoxFechas.Controls.Add(this.dtmpFechaInicio);
            this.grpBoxFechas.Location = new System.Drawing.Point(12, 12);
            this.grpBoxFechas.Name = "grpBoxFechas";
            this.grpBoxFechas.Size = new System.Drawing.Size(307, 82);
            this.grpBoxFechas.TabIndex = 0;
            this.grpBoxFechas.TabStop = false;
            this.grpBoxFechas.Text = "Fechas";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(244, 100);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtmpFechaInicio
            // 
            this.dtmpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpFechaInicio.Location = new System.Drawing.Point(95, 19);
            this.dtmpFechaInicio.Name = "dtmpFechaInicio";
            this.dtmpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtmpFechaInicio.TabIndex = 0;
            this.dtmpFechaInicio.ValueChanged += new System.EventHandler(this.dtmpFechaInicio_ValueChanged);
            // 
            // dtmpFechaFin
            // 
            this.dtmpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpFechaFin.Location = new System.Drawing.Point(95, 46);
            this.dtmpFechaFin.Name = "dtmpFechaFin";
            this.dtmpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtmpFechaFin.TabIndex = 1;
            this.dtmpFechaFin.ValueChanged += new System.EventHandler(this.dtmpFechaFin_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 25);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // labFechaFin
            // 
            this.labFechaFin.AutoSize = true;
            this.labFechaFin.Location = new System.Drawing.Point(6, 52);
            this.labFechaFin.Name = "labFechaFin";
            this.labFechaFin.Size = new System.Drawing.Size(72, 13);
            this.labFechaFin.TabIndex = 3;
            this.labFechaFin.Text = "Fecha de Fin:";
            // 
            // FrmSelectorDeFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 130);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpBoxFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectorDeFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rango de Fechas";
            this.grpBoxFechas.ResumeLayout(false);
            this.grpBoxFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxFechas;
        private System.Windows.Forms.Label labFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtmpFechaFin;
        private System.Windows.Forms.DateTimePicker dtmpFechaInicio;
        private System.Windows.Forms.Button btnAceptar;
    }
}