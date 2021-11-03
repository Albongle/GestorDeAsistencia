
namespace Gestor_de_Asistencia
{
    partial class FrmGestorFeriados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorFeriados));
            this.dgvFeriados = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.calendarioFeriados = new System.Windows.Forms.MonthCalendar();
            this.txtFechaSeleccionada = new System.Windows.Forms.TextBox();
            this.grpFeriado = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaSeleccionada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).BeginInit();
            this.grpFeriado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeriados
            // 
            this.dgvFeriados.AllowUserToAddRows = false;
            this.dgvFeriados.AllowUserToDeleteRows = false;
            this.dgvFeriados.AllowUserToResizeRows = false;
            this.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeriados.Location = new System.Drawing.Point(280, 12);
            this.dgvFeriados.MultiSelect = false;
            this.dgvFeriados.Name = "dgvFeriados";
            this.dgvFeriados.ReadOnly = true;
            this.dgvFeriados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeriados.Size = new System.Drawing.Size(302, 426);
            this.dgvFeriados.TabIndex = 0;
            this.dgvFeriados.SelectionChanged += new System.EventHandler(this.dgvFeriados_SelectionChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(20, 205);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(193, 205);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(6, 110);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(119, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 72);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // calendarioFeriados
            // 
            this.calendarioFeriados.Location = new System.Drawing.Point(20, 12);
            this.calendarioFeriados.MaxSelectionCount = 31;
            this.calendarioFeriados.Name = "calendarioFeriados";
            this.calendarioFeriados.ShowToday = false;
            this.calendarioFeriados.TabIndex = 1;
            this.calendarioFeriados.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioFeriados_DateSelected);
            // 
            // txtFechaSeleccionada
            // 
            this.txtFechaSeleccionada.Enabled = false;
            this.txtFechaSeleccionada.Location = new System.Drawing.Point(6, 30);
            this.txtFechaSeleccionada.Name = "txtFechaSeleccionada";
            this.txtFechaSeleccionada.Size = new System.Drawing.Size(188, 20);
            this.txtFechaSeleccionada.TabIndex = 1;
            // 
            // grpFeriado
            // 
            this.grpFeriado.Controls.Add(this.lblDescripcion);
            this.grpFeriado.Controls.Add(this.lblFechaSeleccionada);
            this.grpFeriado.Controls.Add(this.txtFechaSeleccionada);
            this.grpFeriado.Controls.Add(this.txtDescripcion);
            this.grpFeriado.Controls.Add(this.btnCancelar);
            this.grpFeriado.Controls.Add(this.btnAceptar);
            this.grpFeriado.Location = new System.Drawing.Point(20, 252);
            this.grpFeriado.Name = "grpFeriado";
            this.grpFeriado.Size = new System.Drawing.Size(200, 139);
            this.grpFeriado.TabIndex = 10;
            this.grpFeriado.TabStop = false;
            this.grpFeriado.Text = "Datos";
            this.grpFeriado.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 56);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblFechaSeleccionada
            // 
            this.lblFechaSeleccionada.AutoSize = true;
            this.lblFechaSeleccionada.Location = new System.Drawing.Point(6, 16);
            this.lblFechaSeleccionada.Name = "lblFechaSeleccionada";
            this.lblFechaSeleccionada.Size = new System.Drawing.Size(37, 13);
            this.lblFechaSeleccionada.TabIndex = 10;
            this.lblFechaSeleccionada.Text = "Fecha";
            // 
            // FrmGestorFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.grpFeriado);
            this.Controls.Add(this.calendarioFeriados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvFeriados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestorFeriados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feriados";
            this.Load += new System.EventHandler(this.FrmGestorFeriados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).EndInit();
            this.grpFeriado.ResumeLayout(false);
            this.grpFeriado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeriados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MonthCalendar calendarioFeriados;
        private System.Windows.Forms.TextBox txtFechaSeleccionada;
        private System.Windows.Forms.GroupBox grpFeriado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaSeleccionada;
    }
}