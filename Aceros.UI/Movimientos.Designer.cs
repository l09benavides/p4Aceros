namespace Aceros.UI
{
    partial class frmMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbMovimientos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMovDoc = new System.Windows.Forms.Label();
            this.txtMovDoc = new System.Windows.Forms.TextBox();
            this.cbMovTipoDoc = new System.Windows.Forms.ComboBox();
            this.dtpMovfecha = new System.Windows.Forms.DateTimePicker();
            this.lblMovFecha = new System.Windows.Forms.Label();
            this.btnMovSalir = new System.Windows.Forms.Button();
            this.btnMovAgregar = new System.Windows.Forms.Button();
            this.btnMovModificar = new System.Windows.Forms.Button();
            this.btnMovEliminar = new System.Windows.Forms.Button();
            this.dgvMovDetalles = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMovProv = new System.Windows.Forms.Label();
            this.lblMovTipoDoc = new System.Windows.Forms.Label();
            this.txtMovProv = new System.Windows.Forms.TextBox();
            this.grbMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMovimientos
            // 
            this.grbMovimientos.Controls.Add(this.btnBuscar);
            this.grbMovimientos.Controls.Add(this.lblMovDoc);
            this.grbMovimientos.Controls.Add(this.txtMovDoc);
            this.grbMovimientos.Controls.Add(this.cbMovTipoDoc);
            this.grbMovimientos.Controls.Add(this.dtpMovfecha);
            this.grbMovimientos.Controls.Add(this.lblMovFecha);
            this.grbMovimientos.Controls.Add(this.btnMovSalir);
            this.grbMovimientos.Controls.Add(this.btnMovAgregar);
            this.grbMovimientos.Controls.Add(this.btnMovModificar);
            this.grbMovimientos.Controls.Add(this.btnMovEliminar);
            this.grbMovimientos.Controls.Add(this.dgvMovDetalles);
            this.grbMovimientos.Controls.Add(this.lblMovProv);
            this.grbMovimientos.Controls.Add(this.lblMovTipoDoc);
            this.grbMovimientos.Controls.Add(this.txtMovProv);
            this.grbMovimientos.Location = new System.Drawing.Point(31, 44);
            this.grbMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.grbMovimientos.Name = "grbMovimientos";
            this.grbMovimientos.Padding = new System.Windows.Forms.Padding(4);
            this.grbMovimientos.Size = new System.Drawing.Size(788, 483);
            this.grbMovimientos.TabIndex = 1;
            this.grbMovimientos.TabStop = false;
            this.grbMovimientos.Text = "Existencias";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(606, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 54);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMovDoc
            // 
            this.lblMovDoc.AutoSize = true;
            this.lblMovDoc.Location = new System.Drawing.Point(91, 39);
            this.lblMovDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovDoc.Name = "lblMovDoc";
            this.lblMovDoc.Size = new System.Drawing.Size(154, 17);
            this.lblMovDoc.TabIndex = 31;
            this.lblMovDoc.Text = "Numero de Documento";
            // 
            // txtMovDoc
            // 
            this.txtMovDoc.Location = new System.Drawing.Point(280, 39);
            this.txtMovDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovDoc.Name = "txtMovDoc";
            this.txtMovDoc.Size = new System.Drawing.Size(199, 22);
            this.txtMovDoc.TabIndex = 30;
            // 
            // cbMovTipoDoc
            // 
            this.cbMovTipoDoc.FormattingEnabled = true;
            this.cbMovTipoDoc.Items.AddRange(new object[] {
            "Entrada",
            "Salida",
            "Nota de Credito",
            "Nota de Debito\t",
            "Ajuste Positivo",
            "Ajuste Negativo"});
            this.cbMovTipoDoc.Location = new System.Drawing.Point(280, 75);
            this.cbMovTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbMovTipoDoc.Name = "cbMovTipoDoc";
            this.cbMovTipoDoc.Size = new System.Drawing.Size(199, 24);
            this.cbMovTipoDoc.TabIndex = 29;
            // 
            // dtpMovfecha
            // 
            this.dtpMovfecha.Location = new System.Drawing.Point(280, 145);
            this.dtpMovfecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMovfecha.Name = "dtpMovfecha";
            this.dtpMovfecha.Size = new System.Drawing.Size(265, 22);
            this.dtpMovfecha.TabIndex = 28;
            // 
            // lblMovFecha
            // 
            this.lblMovFecha.AutoSize = true;
            this.lblMovFecha.Location = new System.Drawing.Point(91, 150);
            this.lblMovFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovFecha.Name = "lblMovFecha";
            this.lblMovFecha.Size = new System.Drawing.Size(47, 17);
            this.lblMovFecha.TabIndex = 27;
            this.lblMovFecha.Text = "Fecha";
            // 
            // btnMovSalir
            // 
            this.btnMovSalir.Location = new System.Drawing.Point(671, 135);
            this.btnMovSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovSalir.Name = "btnMovSalir";
            this.btnMovSalir.Size = new System.Drawing.Size(100, 32);
            this.btnMovSalir.TabIndex = 26;
            this.btnMovSalir.Text = "Salir";
            this.btnMovSalir.UseVisualStyleBackColor = true;
            // 
            // btnMovAgregar
            // 
            this.btnMovAgregar.Location = new System.Drawing.Point(563, 96);
            this.btnMovAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovAgregar.Name = "btnMovAgregar";
            this.btnMovAgregar.Size = new System.Drawing.Size(100, 32);
            this.btnMovAgregar.TabIndex = 23;
            this.btnMovAgregar.Text = "Agregar";
            this.btnMovAgregar.UseVisualStyleBackColor = true;
            // 
            // btnMovModificar
            // 
            this.btnMovModificar.Location = new System.Drawing.Point(563, 135);
            this.btnMovModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovModificar.Name = "btnMovModificar";
            this.btnMovModificar.Size = new System.Drawing.Size(100, 32);
            this.btnMovModificar.TabIndex = 24;
            this.btnMovModificar.Text = "Modificar";
            this.btnMovModificar.UseVisualStyleBackColor = true;
            // 
            // btnMovEliminar
            // 
            this.btnMovEliminar.Location = new System.Drawing.Point(671, 96);
            this.btnMovEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovEliminar.Name = "btnMovEliminar";
            this.btnMovEliminar.Size = new System.Drawing.Size(100, 32);
            this.btnMovEliminar.TabIndex = 25;
            this.btnMovEliminar.Text = "Eliminar";
            this.btnMovEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvMovDetalles
            // 
            this.dgvMovDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.CostoUnidad,
            this.CostoTotal});
            this.dgvMovDetalles.Location = new System.Drawing.Point(16, 207);
            this.dgvMovDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMovDetalles.Name = "dgvMovDetalles";
            this.dgvMovDetalles.Size = new System.Drawing.Size(755, 268);
            this.dgvMovDetalles.TabIndex = 22;
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Format = "###-###-####";
            dataGridViewCellStyle1.NullValue = null;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // CostoUnidad
            // 
            this.CostoUnidad.HeaderText = "CostoUnidad";
            this.CostoUnidad.Name = "CostoUnidad";
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "CostoTotal";
            this.CostoTotal.Name = "CostoTotal";
            // 
            // lblMovProv
            // 
            this.lblMovProv.AutoSize = true;
            this.lblMovProv.Location = new System.Drawing.Point(91, 110);
            this.lblMovProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovProv.Name = "lblMovProv";
            this.lblMovProv.Size = new System.Drawing.Size(74, 17);
            this.lblMovProv.TabIndex = 18;
            this.lblMovProv.Text = "Proveedor";
            // 
            // lblMovTipoDoc
            // 
            this.lblMovTipoDoc.AutoSize = true;
            this.lblMovTipoDoc.Location = new System.Drawing.Point(91, 71);
            this.lblMovTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovTipoDoc.Name = "lblMovTipoDoc";
            this.lblMovTipoDoc.Size = new System.Drawing.Size(68, 17);
            this.lblMovTipoDoc.TabIndex = 17;
            this.lblMovTipoDoc.Text = "Concepto";
            // 
            // txtMovProv
            // 
            this.txtMovProv.Location = new System.Drawing.Point(280, 110);
            this.txtMovProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovProv.Name = "txtMovProv";
            this.txtMovProv.Size = new System.Drawing.Size(199, 22);
            this.txtMovProv.TabIndex = 15;
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 565);
            this.Controls.Add(this.grbMovimientos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMovimientos";
            this.ShowIcon = false;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Existencias_Load);
            this.grbMovimientos.ResumeLayout(false);
            this.grbMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbMovimientos;
        private System.Windows.Forms.Label lblMovProv;
        private System.Windows.Forms.Label lblMovTipoDoc;
        private System.Windows.Forms.TextBox txtMovProv;
        private System.Windows.Forms.DataGridView dgvMovDetalles;
        private System.Windows.Forms.Button btnMovSalir;
        private System.Windows.Forms.Button btnMovAgregar;
        private System.Windows.Forms.Button btnMovModificar;
        private System.Windows.Forms.Button btnMovEliminar;
        private System.Windows.Forms.Label lblMovDoc;
        private System.Windows.Forms.TextBox txtMovDoc;
        private System.Windows.Forms.ComboBox cbMovTipoDoc;
        private System.Windows.Forms.DateTimePicker dtpMovfecha;
        private System.Windows.Forms.Label lblMovFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
    }
}

