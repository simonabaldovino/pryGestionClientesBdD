namespace pryGestionClientesBdD
{
    partial class AgregarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cboAuto = new System.Windows.Forms.ComboBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.cboAuto);
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblLimite);
            this.groupBox1.Controls.Add(this.lblAutomovil);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos ";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(287, 184);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(105, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cboAuto
            // 
            this.cboAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuto.FormattingEnabled = true;
            this.cboAuto.Location = new System.Drawing.Point(168, 135);
            this.cboAuto.Name = "cboAuto";
            this.cboAuto.Size = new System.Drawing.Size(224, 21);
            this.cboAuto.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(168, 87);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(224, 20);
            this.txtLimite.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(36, 90);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(89, 13);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Límite de crédito ";
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(36, 138);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(56, 13);
            this.lblAutomovil.TabIndex = 1;
            this.lblAutomovil.Text = "Automovil ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 272);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAuto;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCargar;
    }
}