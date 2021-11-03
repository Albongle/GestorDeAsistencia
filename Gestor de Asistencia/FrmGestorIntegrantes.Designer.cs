
namespace Gestor_de_Asistencia
{
    partial class FrmGestorIntegrantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorIntegrantes));
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblHFin = new System.Windows.Forms.Label();
            this.lblHInicio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblFecNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cmbHoraFin = new System.Windows.Forms.ComboBox();
            this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.grpBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.AllowUserToAddRows = false;
            this.dgvIntegrantes.AllowUserToResizeRows = false;
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Location = new System.Drawing.Point(12, 6);
            this.dgvIntegrantes.MultiSelect = false;
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.ReadOnly = true;
            this.dgvIntegrantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntegrantes.Size = new System.Drawing.Size(776, 225);
            this.dgvIntegrantes.TabIndex = 10;
            this.dgvIntegrantes.SelectionChanged += new System.EventHandler(this.dgvIntegrantes_SelectionChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 237);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 237);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grpBoxDatos
            // 
            this.grpBoxDatos.Controls.Add(this.btnCancelar);
            this.grpBoxDatos.Controls.Add(this.btnAceptar);
            this.grpBoxDatos.Controls.Add(this.lblFuncion);
            this.grpBoxDatos.Controls.Add(this.txtFuncion);
            this.grpBoxDatos.Controls.Add(this.lblHFin);
            this.grpBoxDatos.Controls.Add(this.lblHInicio);
            this.grpBoxDatos.Controls.Add(this.lblTelefono);
            this.grpBoxDatos.Controls.Add(this.lblDni);
            this.grpBoxDatos.Controls.Add(this.lblContrato);
            this.grpBoxDatos.Controls.Add(this.lblFecNacimiento);
            this.grpBoxDatos.Controls.Add(this.lblApellido);
            this.grpBoxDatos.Controls.Add(this.lblNombre);
            this.grpBoxDatos.Controls.Add(this.lblLegajo);
            this.grpBoxDatos.Controls.Add(this.cmbHoraFin);
            this.grpBoxDatos.Controls.Add(this.cmbHoraInicio);
            this.grpBoxDatos.Controls.Add(this.dtpFechaDeNacimiento);
            this.grpBoxDatos.Controls.Add(this.txtTelefono);
            this.grpBoxDatos.Controls.Add(this.txtApellido);
            this.grpBoxDatos.Controls.Add(this.txtDni);
            this.grpBoxDatos.Controls.Add(this.txtNombre);
            this.grpBoxDatos.Controls.Add(this.txtContrato);
            this.grpBoxDatos.Controls.Add(this.txtLegajo);
            this.grpBoxDatos.Location = new System.Drawing.Point(12, 282);
            this.grpBoxDatos.Name = "grpBoxDatos";
            this.grpBoxDatos.Size = new System.Drawing.Size(618, 131);
            this.grpBoxDatos.TabIndex = 4;
            this.grpBoxDatos.TabStop = false;
            this.grpBoxDatos.Text = "Datos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(536, 37);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 20);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(109, 88);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(45, 13);
            this.lblFuncion.TabIndex = 18;
            this.lblFuncion.Text = "Funcion";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(112, 104);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 6;
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.Location = new System.Drawing.Point(427, 88);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(62, 13);
            this.lblHFin.TabIndex = 16;
            this.lblHFin.Text = "Hora de Fin";
            // 
            // lblHInicio
            // 
            this.lblHInicio.AutoSize = true;
            this.lblHInicio.Location = new System.Drawing.Point(321, 88);
            this.lblHInicio.Name = "lblHInicio";
            this.lblHInicio.Size = new System.Drawing.Size(73, 13);
            this.lblHInicio.TabIndex = 15;
            this.lblHInicio.Text = "Hora de Inicio";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(215, 89);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(427, 21);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "Dni";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(6, 89);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(47, 13);
            this.lblContrato.TabIndex = 12;
            this.lblContrato.Text = "Contrato";
            // 
            // lblFecNacimiento
            // 
            this.lblFecNacimiento.AutoSize = true;
            this.lblFecNacimiento.Location = new System.Drawing.Point(321, 21);
            this.lblFecNacimiento.Name = "lblFecNacimiento";
            this.lblFecNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFecNacimiento.TabIndex = 11;
            this.lblFecNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(215, 21);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(109, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(6, 21);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "Legajo";
            // 
            // cmbHoraFin
            // 
            this.cmbHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraFin.FormattingEnabled = true;
            this.cmbHoraFin.ItemHeight = 13;
            this.cmbHoraFin.Location = new System.Drawing.Point(430, 104);
            this.cmbHoraFin.Name = "cmbHoraFin";
            this.cmbHoraFin.Size = new System.Drawing.Size(100, 21);
            this.cmbHoraFin.TabIndex = 9;
            // 
            // cmbHoraInicio
            // 
            this.cmbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraInicio.FormattingEnabled = true;
            this.cmbHoraInicio.ItemHeight = 13;
            this.cmbHoraInicio.Location = new System.Drawing.Point(324, 104);
            this.cmbHoraInicio.Name = "cmbHoraInicio";
            this.cmbHoraInicio.Size = new System.Drawing.Size(100, 21);
            this.cmbHoraInicio.TabIndex = 8;
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(324, 37);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaDeNacimiento.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(218, 105);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(218, 37);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(430, 37);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtContrato
            // 
            this.txtContrato.Location = new System.Drawing.Point(6, 105);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(100, 20);
            this.txtContrato.TabIndex = 5;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(6, 37);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(536, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 20);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmGestorIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxDatos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvIntegrantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestorIntegrantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrantes";
            this.Load += new System.EventHandler(this.FrmGestorIntegrantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.grpBoxDatos.ResumeLayout(false);
            this.grpBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grpBoxDatos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.ComboBox cmbHoraInicio;
        private System.Windows.Forms.ComboBox cmbHoraFin;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblFecNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblHFin;
        private System.Windows.Forms.Label lblHInicio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}