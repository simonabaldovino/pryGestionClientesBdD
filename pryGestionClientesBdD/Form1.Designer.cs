namespace pryGestionClientesBdD
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotDeuda = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantidadClientes);
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.btnListarDeudores);
            this.groupBox1.Controls.Add(this.lblCantClientes);
            this.groupBox1.Controls.Add(this.lblPromDeuda);
            this.groupBox1.Controls.Add(this.lblTotDeuda);
            this.groupBox1.Controls.Add(this.dgvDeudores);
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDeudores.Location = new System.Drawing.Point(22, 28);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.RowHeadersWidth = 5;
            this.dgvDeudores.Size = new System.Drawing.Size(397, 150);
            this.dgvDeudores.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // lblTotDeuda
            // 
            this.lblTotDeuda.AutoSize = true;
            this.lblTotDeuda.Location = new System.Drawing.Point(212, 224);
            this.lblTotDeuda.Name = "lblTotDeuda";
            this.lblTotDeuda.Size = new System.Drawing.Size(82, 13);
            this.lblTotDeuda.TabIndex = 1;
            this.lblTotDeuda.Text = "Total de deuda ";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Location = new System.Drawing.Point(212, 299);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(99, 13);
            this.lblPromDeuda.TabIndex = 2;
            this.lblPromDeuda.Text = "Promedio de deuda";
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Location = new System.Drawing.Point(212, 261);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(103, 13);
            this.lblCantClientes.TabIndex = 3;
            this.lblCantClientes.Text = "Cantidad de clientes";
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(327, 337);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(92, 29);
            this.btnListarDeudores.TabIndex = 4;
            this.btnListarDeudores.Text = "Listar Deudores ";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            this.btnListarDeudores.Click += new System.EventHandler(this.btnListarDeudores_Click);
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalDeuda.Location = new System.Drawing.Point(333, 213);
            this.lblTotalDeuda.MaximumSize = new System.Drawing.Size(0, 30);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(76, 24);
            this.lblTotalDeuda.TabIndex = 15;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(333, 288);
            this.lblPromedioDeuda.MaximumSize = new System.Drawing.Size(0, 30);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(76, 24);
            this.lblPromedioDeuda.TabIndex = 16;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidadClientes.Location = new System.Drawing.Point(333, 250);
            this.lblCantidadClientes.MaximumSize = new System.Drawing.Size(0, 30);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(76, 24);
            this.lblCantidadClientes.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 432);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotDeuda;
        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Button btnListarDeudores;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
    }
}

