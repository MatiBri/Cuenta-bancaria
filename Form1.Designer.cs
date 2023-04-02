namespace CuentaBancaria1W1
{
    partial class frmCuentasBancarias
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtDocCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtMontoDep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.txtMontoExt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblClienta = new System.Windows.Forms.Label();
            this.lblCantCorrientes = new System.Windows.Forms.Label();
            this.lblCantAhorro = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPromedioCC = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoCuenta);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.txtNumeroCuenta);
            this.groupBox1.Location = new System.Drawing.Point(40, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Cuenta";
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Items.AddRange(new object[] {
            "Caja de Ahorro",
            "Cuenta Corriente"});
            this.cbTipoCuenta.Location = new System.Drawing.Point(153, 113);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCuenta.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(153, 70);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 1;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(153, 20);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCuenta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLimiteCredito);
            this.groupBox2.Controls.Add(this.txtCodigoCliente);
            this.groupBox2.Controls.Add(this.dtpFechaNac);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(this.txtDocCliente);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Location = new System.Drawing.Point(40, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Limite de Credito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(153, 222);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteCredito.TabIndex = 5;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(153, 37);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 4;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(153, 182);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 3;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(153, 137);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 2;
            // 
            // txtDocCliente
            // 
            this.txtDocCliente.Location = new System.Drawing.Point(153, 100);
            this.txtDocCliente.Name = "txtDocCliente";
            this.txtDocCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDocCliente.TabIndex = 1;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(153, 74);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(141, 507);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar Cuenta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDepositar);
            this.groupBox3.Controls.Add(this.txtMontoDep);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(456, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deposito";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(69, 67);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtMontoDep
            // 
            this.txtMontoDep.Location = new System.Drawing.Point(83, 24);
            this.txtMontoDep.Name = "txtMontoDep";
            this.txtMontoDep.Size = new System.Drawing.Size(100, 20);
            this.txtMontoDep.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Monto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExtraer);
            this.groupBox4.Controls.Add(this.txtMontoExt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(456, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 112);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extraccion";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(69, 76);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 2;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // txtMontoExt
            // 
            this.txtMontoExt.Location = new System.Drawing.Point(83, 36);
            this.txtMontoExt.Name = "txtMontoExt";
            this.txtMontoExt.Size = new System.Drawing.Size(100, 20);
            this.txtMontoExt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Monto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Cantidad de Cajas de Ahorro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cantidad de Cuentas Corrientes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Clienta que tenga mayor Limite de Credito en caja de ahorro";
            // 
            // lblClienta
            // 
            this.lblClienta.AutoSize = true;
            this.lblClienta.Location = new System.Drawing.Point(411, 512);
            this.lblClienta.Name = "lblClienta";
            this.lblClienta.Size = new System.Drawing.Size(70, 13);
            this.lblClienta.TabIndex = 8;
            this.lblClienta.Text = "Desconocida";
            // 
            // lblCantCorrientes
            // 
            this.lblCantCorrientes.AutoSize = true;
            this.lblCantCorrientes.Location = new System.Drawing.Point(559, 409);
            this.lblCantCorrientes.Name = "lblCantCorrientes";
            this.lblCantCorrientes.Size = new System.Drawing.Size(13, 13);
            this.lblCantCorrientes.TabIndex = 9;
            this.lblCantCorrientes.Text = "0";
            // 
            // lblCantAhorro
            // 
            this.lblCantAhorro.AutoSize = true;
            this.lblCantAhorro.Location = new System.Drawing.Point(558, 372);
            this.lblCantAhorro.Name = "lblCantAhorro";
            this.lblCantAhorro.Size = new System.Drawing.Size(13, 13);
            this.lblCantAhorro.TabIndex = 10;
            this.lblCantAhorro.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 449);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Promedio saldos de cuentas Corrientes";
            // 
            // lblPromedioCC
            // 
            this.lblPromedioCC.AutoSize = true;
            this.lblPromedioCC.Location = new System.Drawing.Point(558, 449);
            this.lblPromedioCC.Name = "lblPromedioCC";
            this.lblPromedioCC.Size = new System.Drawing.Size(13, 13);
            this.lblPromedioCC.TabIndex = 12;
            this.lblPromedioCC.Text = "0";
            // 
            // frmCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 556);
            this.Controls.Add(this.lblPromedioCC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblCantAhorro);
            this.Controls.Add(this.lblCantCorrientes);
            this.Controls.Add(this.lblClienta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCuentasBancarias";
            this.Text = "Cuentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTipoCuenta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtDocCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtMontoDep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.TextBox txtMontoExt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblClienta;
        private System.Windows.Forms.Label lblCantCorrientes;
        private System.Windows.Forms.Label lblCantAhorro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPromedioCC;
    }
}

