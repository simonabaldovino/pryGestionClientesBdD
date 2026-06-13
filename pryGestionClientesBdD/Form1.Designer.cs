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
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblCantidadClientess = new System.Windows.Forms.Label();
            this.lblPromedioDeudass = new System.Windows.Forms.Label();
            this.lblTotalDeudaa = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblTotDeuda = new System.Windows.Forms.Label();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnGenerarReporte);
            this.groupBox1.Controls.Add(this.lblCantidadClientess);
            this.groupBox1.Controls.Add(this.lblPromedioDeudass);
            this.groupBox1.Controls.Add(this.lblTotalDeudaa);
            this.groupBox1.Controls.Add(this.lblCantidadClientes);
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.btnListarDeudores);
            this.groupBox1.Controls.Add(this.lblCantClientes);
            this.groupBox1.Controls.Add(this.lblPromDeuda);
            this.groupBox1.Controls.Add(this.lblTotDeuda);
            this.groupBox1.Controls.Add(this.dgvDeudores);
            this.groupBox1.Location = new System.Drawing.Point(43, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(589, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(281, 430);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(133, 36);
            this.btnGenerarReporte.TabIndex = 21;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // lblCantidadClientess
            // 
            this.lblCantidadClientess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientess.Location = new System.Drawing.Point(428, 320);
            this.lblCantidadClientess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadClientess.Name = "lblCantidadClientess";
            this.lblCantidadClientess.Size = new System.Drawing.Size(133, 28);
            this.lblCantidadClientess.TabIndex = 20;
            // 
            // lblPromedioDeudass
            // 
            this.lblPromedioDeudass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeudass.Location = new System.Drawing.Point(428, 367);
            this.lblPromedioDeudass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioDeudass.Name = "lblPromedioDeudass";
            this.lblPromedioDeudass.Size = new System.Drawing.Size(133, 28);
            this.lblPromedioDeudass.TabIndex = 19;
            // 
            // lblTotalDeudaa
            // 
            this.lblTotalDeudaa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudaa.Location = new System.Drawing.Point(425, 274);
            this.lblTotalDeudaa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeudaa.Name = "lblTotalDeudaa";
            this.lblTotalDeudaa.Size = new System.Drawing.Size(133, 28);
            this.lblTotalDeudaa.TabIndex = 18;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidadClientes.Location = new System.Drawing.Point(444, 308);
            this.lblCantidadClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadClientes.MaximumSize = new System.Drawing.Size(0, 37);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(0, 37);
            this.lblCantidadClientes.TabIndex = 17;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(444, 354);
            this.lblPromedioDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioDeuda.MaximumSize = new System.Drawing.Size(0, 37);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(0, 37);
            this.lblPromedioDeuda.TabIndex = 16;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalDeuda.Location = new System.Drawing.Point(444, 262);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.MaximumSize = new System.Drawing.Size(0, 37);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(0, 37);
            this.lblTotalDeuda.TabIndex = 15;
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(428, 430);
            this.btnListarDeudores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(131, 36);
            this.btnListarDeudores.TabIndex = 4;
            this.btnListarDeudores.Text = "Listar Deudores ";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            this.btnListarDeudores.Click += new System.EventHandler(this.btnListarDeudores_Click);
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Location = new System.Drawing.Point(277, 332);
            this.lblCantClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(129, 16);
            this.lblCantClientes.TabIndex = 3;
            this.lblCantClientes.Text = "Cantidad de clientes";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Location = new System.Drawing.Point(277, 379);
            this.lblPromDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(127, 16);
            this.lblPromDeuda.TabIndex = 2;
            this.lblPromDeuda.Text = "Promedio de deuda";
            // 
            // lblTotDeuda
            // 
            this.lblTotDeuda.AutoSize = true;
            this.lblTotDeuda.Location = new System.Drawing.Point(277, 287);
            this.lblTotDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotDeuda.Name = "lblTotDeuda";
            this.lblTotDeuda.Size = new System.Drawing.Size(102, 16);
            this.lblTotDeuda.TabIndex = 1;
            this.lblTotDeuda.Text = "Total de deuda ";
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDeudores.Location = new System.Drawing.Point(29, 34);
            this.dgvDeudores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.RowHeadersWidth = 5;
            this.dgvDeudores.Size = new System.Drawing.Size(529, 185);
            this.dgvDeudores.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(129, 430);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(133, 36);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 556);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes deudores ";
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
        private System.Windows.Forms.Label lblTotalDeudaa;
        private System.Windows.Forms.Label lblCantidadClientess;
        private System.Windows.Forms.Label lblPromedioDeudass;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}

