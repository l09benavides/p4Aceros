namespace Aceros.UI
{
    partial class FrmClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnCliAgregar = new System.Windows.Forms.Button();
            this.btnCliModificar = new System.Windows.Forms.Button();
            this.btnCliEliminar = new System.Windows.Forms.Button();
            this.txtCliNombre = new System.Windows.Forms.TextBox();
            this.txtCLiCedula = new System.Windows.Forms.TextBox();
            this.txtCliTelefono = new System.Windows.Forms.TextBox();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.lblCliCedula = new System.Windows.Forms.Label();
            this.lblCliTelefono = new System.Windows.Forms.Label();
            this.lblCliEmail = new System.Windows.Forms.Label();
            this.txtCliEmail = new System.Windows.Forms.TextBox();
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.btnCliBuscar = new System.Windows.Forms.Button();
            this.btnCliSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(10, 202);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(682, 281);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseClick);
            // 
            // btnCliAgregar
            // 
            this.btnCliAgregar.Location = new System.Drawing.Point(239, 24);
            this.btnCliAgregar.Name = "btnCliAgregar";
            this.btnCliAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnCliAgregar.TabIndex = 3;
            this.btnCliAgregar.Text = "Agregar";
            this.btnCliAgregar.UseVisualStyleBackColor = true;
            this.btnCliAgregar.Click += new System.EventHandler(this.btnCliAgregar_Click);
            // 
            // btnCliModificar
            // 
            this.btnCliModificar.Enabled = false;
            this.btnCliModificar.Location = new System.Drawing.Point(239, 56);
            this.btnCliModificar.Name = "btnCliModificar";
            this.btnCliModificar.Size = new System.Drawing.Size(75, 23);
            this.btnCliModificar.TabIndex = 4;
            this.btnCliModificar.Text = "Modificar";
            this.btnCliModificar.UseVisualStyleBackColor = true;
            this.btnCliModificar.Click += new System.EventHandler(this.btnCliModificar_Click);
            // 
            // btnCliEliminar
            // 
            this.btnCliEliminar.Enabled = false;
            this.btnCliEliminar.Location = new System.Drawing.Point(239, 85);
            this.btnCliEliminar.Name = "btnCliEliminar";
            this.btnCliEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnCliEliminar.TabIndex = 5;
            this.btnCliEliminar.Text = "Eliminar";
            this.btnCliEliminar.UseVisualStyleBackColor = true;
            this.btnCliEliminar.Click += new System.EventHandler(this.btnCliEliminar_Click);
            // 
            // txtCliNombre
            // 
            this.txtCliNombre.Location = new System.Drawing.Point(124, 24);
            this.txtCliNombre.Name = "txtCliNombre";
            this.txtCliNombre.Size = new System.Drawing.Size(100, 20);
            this.txtCliNombre.TabIndex = 6;
            // 
            // txtCLiCedula
            // 
            this.txtCLiCedula.Location = new System.Drawing.Point(124, 59);
            this.txtCLiCedula.Name = "txtCLiCedula";
            this.txtCLiCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCLiCedula.TabIndex = 7;
            // 
            // txtCliTelefono
            // 
            this.txtCliTelefono.Location = new System.Drawing.Point(124, 88);
            this.txtCliTelefono.Name = "txtCliTelefono";
            this.txtCliTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtCliTelefono.TabIndex = 8;
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Location = new System.Drawing.Point(32, 31);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(44, 13);
            this.lblCliNombre.TabIndex = 9;
            this.lblCliNombre.Text = "Nombre";
            // 
            // lblCliCedula
            // 
            this.lblCliCedula.AutoSize = true;
            this.lblCliCedula.Location = new System.Drawing.Point(32, 62);
            this.lblCliCedula.Name = "lblCliCedula";
            this.lblCliCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCliCedula.TabIndex = 10;
            this.lblCliCedula.Text = "Cedula";
            // 
            // lblCliTelefono
            // 
            this.lblCliTelefono.AutoSize = true;
            this.lblCliTelefono.Location = new System.Drawing.Point(32, 91);
            this.lblCliTelefono.Name = "lblCliTelefono";
            this.lblCliTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblCliTelefono.TabIndex = 11;
            this.lblCliTelefono.Text = "Telefono";
            // 
            // lblCliEmail
            // 
            this.lblCliEmail.AutoSize = true;
            this.lblCliEmail.Location = new System.Drawing.Point(32, 124);
            this.lblCliEmail.Name = "lblCliEmail";
            this.lblCliEmail.Size = new System.Drawing.Size(38, 13);
            this.lblCliEmail.TabIndex = 13;
            this.lblCliEmail.Text = "Correo";
            // 
            // txtCliEmail
            // 
            this.txtCliEmail.Location = new System.Drawing.Point(124, 121);
            this.txtCliEmail.Name = "txtCliEmail";
            this.txtCliEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCliEmail.TabIndex = 12;
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.btnCliBuscar);
            this.grbDatosClientes.Controls.Add(this.btnCliSalir);
            this.grbDatosClientes.Controls.Add(this.lblCliEmail);
            this.grbDatosClientes.Controls.Add(this.btnCliAgregar);
            this.grbDatosClientes.Controls.Add(this.txtCliEmail);
            this.grbDatosClientes.Controls.Add(this.btnCliModificar);
            this.grbDatosClientes.Controls.Add(this.lblCliTelefono);
            this.grbDatosClientes.Controls.Add(this.btnCliEliminar);
            this.grbDatosClientes.Controls.Add(this.lblCliCedula);
            this.grbDatosClientes.Controls.Add(this.txtCliNombre);
            this.grbDatosClientes.Controls.Add(this.lblCliNombre);
            this.grbDatosClientes.Controls.Add(this.txtCLiCedula);
            this.grbDatosClientes.Controls.Add(this.txtCliTelefono);
            this.grbDatosClientes.Location = new System.Drawing.Point(87, 27);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Size = new System.Drawing.Size(482, 168);
            this.grbDatosClientes.TabIndex = 14;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos Cliente";
            // 
            // btnCliBuscar
            // 
            this.btnCliBuscar.Location = new System.Drawing.Point(354, 24);
            this.btnCliBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliBuscar.Name = "btnCliBuscar";
            this.btnCliBuscar.Size = new System.Drawing.Size(112, 53);
            this.btnCliBuscar.TabIndex = 15;
            this.btnCliBuscar.Text = "Buscar";
            this.btnCliBuscar.UseVisualStyleBackColor = true;
            this.btnCliBuscar.Click += new System.EventHandler(this.btnCliBuscar_Click);
            // 
            // btnCliSalir
            // 
            this.btnCliSalir.Location = new System.Drawing.Point(239, 118);
            this.btnCliSalir.Name = "btnCliSalir";
            this.btnCliSalir.Size = new System.Drawing.Size(75, 23);
            this.btnCliSalir.TabIndex = 14;
            this.btnCliSalir.Text = "Salir";
            this.btnCliSalir.UseVisualStyleBackColor = true;
            this.btnCliSalir.Click += new System.EventHandler(this.btnCliSalir_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 504);
            this.Controls.Add(this.grbDatosClientes);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmClientes";
            this.ShowIcon = false;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnCliAgregar;
        private System.Windows.Forms.Button btnCliModificar;
        private System.Windows.Forms.Button btnCliEliminar;
        private System.Windows.Forms.TextBox txtCliNombre;
        private System.Windows.Forms.TextBox txtCLiCedula;
        private System.Windows.Forms.TextBox txtCliTelefono;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.Label lblCliCedula;
        private System.Windows.Forms.Label lblCliTelefono;
        private System.Windows.Forms.Label lblCliEmail;
        private System.Windows.Forms.TextBox txtCliEmail;
        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.Button btnCliSalir;
        private System.Windows.Forms.Button btnCliBuscar;
    }
}