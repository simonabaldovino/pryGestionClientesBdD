namespace pryGestionClientesBdD
{
    partial class BusquedaClientes
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
            this.lblCodCli = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDeud = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblLimiteCred = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(41, 33);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(91, 13);
            this.lblCodCli.TabIndex = 0;
            this.lblCodCli.Text = "Código del cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(175, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(175, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(117, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblDeud
            // 
            this.lblDeud.AutoSize = true;
            this.lblDeud.Location = new System.Drawing.Point(29, 93);
            this.lblDeud.Name = "lblDeud";
            this.lblDeud.Size = new System.Drawing.Size(39, 13);
            this.lblDeud.TabIndex = 3;
            this.lblDeud.Text = "Deuda";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(29, 44);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nombre";
            // 
            // lblLimiteCred
            // 
            this.lblLimiteCred.AutoSize = true;
            this.lblLimiteCred.Location = new System.Drawing.Point(29, 146);
            this.lblLimiteCred.Name = "lblLimiteCred";
            this.lblLimiteCred.Size = new System.Drawing.Size(89, 13);
            this.lblLimiteCred.TabIndex = 5;
            this.lblLimiteCred.Text = "Límite de crédito ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLimite);
            this.groupBox1.Controls.Add(this.lblDeuda);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblLimiteCred);
            this.groupBox1.Controls.Add(this.lblDeud);
            this.groupBox1.Location = new System.Drawing.Point(44, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(128, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 6;
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuda.Location = new System.Drawing.Point(126, 92);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(100, 23);
            this.lblDeuda.TabIndex = 7;
            // 
            // lblLimite
            // 
            this.lblLimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimite.Location = new System.Drawing.Point(128, 136);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(100, 23);
            this.lblLimite.TabIndex = 8;
            // 
            // BusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodCli);
            this.Name = "BusquedaClientes";
            this.Text = "BusquedaClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDeud;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblLimiteCred;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
    }
}