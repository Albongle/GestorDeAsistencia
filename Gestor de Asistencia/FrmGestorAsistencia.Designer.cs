
namespace Gestor_de_Asistencia
{
    partial class FrmGestorAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestorAsistencia));
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbTipoNovedad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.paneLateral = new System.Windows.Forms.Panel();
            this.btnBorrarNovedades = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnNovedadesPorDia = new System.Windows.Forms.Button();
            this.btnFeriados = new System.Windows.Forms.Button();
            this.btnIntegrantes = new System.Windows.Forms.Button();
            this.cmbTipoTurno = new System.Windows.Forms.ComboBox();
            this.lstBoxEmpleados = new System.Windows.Forms.ListBox();
            this.dgvRegistroDeTrabajo = new System.Windows.Forms.DataGridView();
            this.menuConexion = new System.Windows.Forms.MenuStrip();
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarConBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBarraDeEstado = new System.Windows.Forms.StatusStrip();
            this.barraEstadoTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraEstadoProgreso = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCantidad)).BeginInit();
            this.paneLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroDeTrabajo)).BeginInit();
            this.menuConexion.SuspendLayout();
            this.ssBarraDeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendario
            // 
            this.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendario.Location = new System.Drawing.Point(406, 25);
            this.calendario.MaxSelectionCount = 31;
            this.calendario.Name = "calendario";
            this.calendario.ShowToday = false;
            this.calendario.TabIndex = 1;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 32);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Elminar Registros";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbTipoNovedad
            // 
            this.cmbTipoNovedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNovedad.FormattingEnabled = true;
            this.cmbTipoNovedad.Location = new System.Drawing.Point(666, 27);
            this.cmbTipoNovedad.Name = "cmbTipoNovedad";
            this.cmbTipoNovedad.Size = new System.Drawing.Size(120, 21);
            this.cmbTipoNovedad.TabIndex = 2;
            this.cmbTipoNovedad.SelectedIndexChanged += new System.EventHandler(this.cmbTipoNovedad_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(666, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Registros";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nUpDownCantidad
            // 
            this.nUpDownCantidad.Location = new System.Drawing.Point(666, 81);
            this.nUpDownCantidad.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownCantidad.Name = "nUpDownCantidad";
            this.nUpDownCantidad.Size = new System.Drawing.Size(56, 20);
            this.nUpDownCantidad.TabIndex = 4;
            this.nUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // paneLateral
            // 
            this.paneLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneLateral.Controls.Add(this.btnBorrarNovedades);
            this.paneLateral.Controls.Add(this.btnImportar);
            this.paneLateral.Controls.Add(this.btnNovedadesPorDia);
            this.paneLateral.Controls.Add(this.btnFeriados);
            this.paneLateral.Controls.Add(this.btnIntegrantes);
            this.paneLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLateral.Location = new System.Drawing.Point(0, 24);
            this.paneLateral.Name = "paneLateral";
            this.paneLateral.Size = new System.Drawing.Size(140, 504);
            this.paneLateral.TabIndex = 9;
            // 
            // btnBorrarNovedades
            // 
            this.btnBorrarNovedades.FlatAppearance.BorderSize = 0;
            this.btnBorrarNovedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarNovedades.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNovedades.Location = new System.Drawing.Point(3, 85);
            this.btnBorrarNovedades.Name = "btnBorrarNovedades";
            this.btnBorrarNovedades.Size = new System.Drawing.Size(120, 37);
            this.btnBorrarNovedades.TabIndex = 18;
            this.btnBorrarNovedades.Text = "Borrar Novedades";
            this.btnBorrarNovedades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarNovedades.UseVisualStyleBackColor = true;
            this.btnBorrarNovedades.Click += new System.EventHandler(this.btnBorrarNovedades_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(3, 113);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(131, 37);
            this.btnImportar.TabIndex = 17;
            this.btnImportar.Text = "Importar Novedades";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNovedadesPorDia
            // 
            this.btnNovedadesPorDia.FlatAppearance.BorderSize = 0;
            this.btnNovedadesPorDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovedadesPorDia.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedadesPorDia.Location = new System.Drawing.Point(3, 57);
            this.btnNovedadesPorDia.Name = "btnNovedadesPorDia";
            this.btnNovedadesPorDia.Size = new System.Drawing.Size(120, 32);
            this.btnNovedadesPorDia.TabIndex = 16;
            this.btnNovedadesPorDia.Text = "Novedades por dia";
            this.btnNovedadesPorDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovedadesPorDia.UseVisualStyleBackColor = true;
            this.btnNovedadesPorDia.Click += new System.EventHandler(this.btnNovedadesPorDia_Click);
            // 
            // btnFeriados
            // 
            this.btnFeriados.FlatAppearance.BorderSize = 0;
            this.btnFeriados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeriados.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeriados.Location = new System.Drawing.Point(3, 30);
            this.btnFeriados.Name = "btnFeriados";
            this.btnFeriados.Size = new System.Drawing.Size(120, 32);
            this.btnFeriados.TabIndex = 15;
            this.btnFeriados.Text = "Admin Feriados";
            this.btnFeriados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeriados.UseVisualStyleBackColor = true;
            this.btnFeriados.Click += new System.EventHandler(this.btnFeriados_Click);
            // 
            // btnIntegrantes
            // 
            this.btnIntegrantes.FlatAppearance.BorderSize = 0;
            this.btnIntegrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntegrantes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegrantes.Location = new System.Drawing.Point(3, 3);
            this.btnIntegrantes.Name = "btnIntegrantes";
            this.btnIntegrantes.Size = new System.Drawing.Size(120, 32);
            this.btnIntegrantes.TabIndex = 14;
            this.btnIntegrantes.Text = "Admin Integrantes";
            this.btnIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntegrantes.UseVisualStyleBackColor = true;
            this.btnIntegrantes.Click += new System.EventHandler(this.btnIntegrantes_Click);
            // 
            // cmbTipoTurno
            // 
            this.cmbTipoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTurno.FormattingEnabled = true;
            this.cmbTipoTurno.Location = new System.Drawing.Point(666, 54);
            this.cmbTipoTurno.Name = "cmbTipoTurno";
            this.cmbTipoTurno.Size = new System.Drawing.Size(120, 21);
            this.cmbTipoTurno.TabIndex = 3;
            // 
            // lstBoxEmpleados
            // 
            this.lstBoxEmpleados.FormattingEnabled = true;
            this.lstBoxEmpleados.HorizontalScrollbar = true;
            this.lstBoxEmpleados.Location = new System.Drawing.Point(146, 27);
            this.lstBoxEmpleados.Name = "lstBoxEmpleados";
            this.lstBoxEmpleados.Size = new System.Drawing.Size(248, 160);
            this.lstBoxEmpleados.TabIndex = 0;
            this.lstBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.lstBoxEmpleados_SelectedIndexChanged);
            // 
            // dgvRegistroDeTrabajo
            // 
            this.dgvRegistroDeTrabajo.AllowUserToAddRows = false;
            this.dgvRegistroDeTrabajo.AllowUserToDeleteRows = false;
            this.dgvRegistroDeTrabajo.AllowUserToResizeRows = false;
            this.dgvRegistroDeTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroDeTrabajo.Location = new System.Drawing.Point(146, 232);
            this.dgvRegistroDeTrabajo.Name = "dgvRegistroDeTrabajo";
            this.dgvRegistroDeTrabajo.ReadOnly = true;
            this.dgvRegistroDeTrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroDeTrabajo.Size = new System.Drawing.Size(741, 229);
            this.dgvRegistroDeTrabajo.TabIndex = 6;
            this.dgvRegistroDeTrabajo.SelectionChanged += new System.EventHandler(this.dgvRegistroDeTrabajo_SelectionChanged);
            // 
            // menuConexion
            // 
            this.menuConexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexionToolStripMenuItem});
            this.menuConexion.Location = new System.Drawing.Point(0, 0);
            this.menuConexion.Name = "menuConexion";
            this.menuConexion.Size = new System.Drawing.Size(899, 24);
            this.menuConexion.TabIndex = 10;
            this.menuConexion.Text = "menuConexion";
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarConBDToolStripMenuItem});
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.conexionToolStripMenuItem.Text = "Conexion";
            // 
            // conectarConBDToolStripMenuItem
            // 
            this.conectarConBDToolStripMenuItem.Name = "conectarConBDToolStripMenuItem";
            this.conectarConBDToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.conectarConBDToolStripMenuItem.Text = "Conectar con BD";
            this.conectarConBDToolStripMenuItem.Click += new System.EventHandler(this.conectarConBDToolStripMenuItem_Click);
            // 
            // ssBarraDeEstado
            // 
            this.ssBarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraEstadoTexto,
            this.barraEstadoProgreso});
            this.ssBarraDeEstado.Location = new System.Drawing.Point(140, 506);
            this.ssBarraDeEstado.Name = "ssBarraDeEstado";
            this.ssBarraDeEstado.Size = new System.Drawing.Size(759, 22);
            this.ssBarraDeEstado.TabIndex = 11;
            // 
            // barraEstadoTexto
            // 
            this.barraEstadoTexto.Name = "barraEstadoTexto";
            this.barraEstadoTexto.Size = new System.Drawing.Size(0, 17);
            // 
            // barraEstadoProgreso
            // 
            this.barraEstadoProgreso.Name = "barraEstadoProgreso";
            this.barraEstadoProgreso.Size = new System.Drawing.Size(100, 16);
            this.barraEstadoProgreso.Visible = false;
            // 
            // FrmGestorAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 528);
            this.Controls.Add(this.ssBarraDeEstado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nUpDownCantidad);
            this.Controls.Add(this.cmbTipoTurno);
            this.Controls.Add(this.cmbTipoNovedad);
            this.Controls.Add(this.dgvRegistroDeTrabajo);
            this.Controls.Add(this.lstBoxEmpleados);
            this.Controls.Add(this.paneLateral);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.menuConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuConexion;
            this.MaximizeBox = false;
            this.Name = "FrmGestorAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Asistencias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestorAsistencia_FormClosing);
            this.Load += new System.EventHandler(this.FrmGestorAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCantidad)).EndInit();
            this.paneLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroDeTrabajo)).EndInit();
            this.menuConexion.ResumeLayout(false);
            this.menuConexion.PerformLayout();
            this.ssBarraDeEstado.ResumeLayout(false);
            this.ssBarraDeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbTipoNovedad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nUpDownCantidad;
        private System.Windows.Forms.Panel paneLateral;
        private System.Windows.Forms.ComboBox cmbTipoTurno;
        private System.Windows.Forms.ListBox lstBoxEmpleados;
        private System.Windows.Forms.DataGridView dgvRegistroDeTrabajo;
        private System.Windows.Forms.Button btnFeriados;
        private System.Windows.Forms.Button btnIntegrantes;
        private System.Windows.Forms.MenuStrip menuConexion;
        private System.Windows.Forms.ToolStripMenuItem conexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarConBDToolStripMenuItem;
        private System.Windows.Forms.Button btnNovedadesPorDia;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.StatusStrip ssBarraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel barraEstadoTexto;
        private System.Windows.Forms.ToolStripProgressBar barraEstadoProgreso;
        private System.Windows.Forms.Button btnBorrarNovedades;
    }
}

