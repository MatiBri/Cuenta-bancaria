using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaBancaria1W1
{
    public partial class frmCuentasBancarias : Form
    {
        private Cuenta c,cmay;
        int cca, ccc;
        double acuCC;

        public frmCuentasBancarias()
        {
            InitializeComponent();
            c = null;
            cca = 0;
            ccc = 0;
            cmay = new Cuenta();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(this.validarRegistracion())
            { 
                Cliente cl = new Cliente();
                cl.pCodigo = Convert.ToInt32(txtCodigoCliente.Text);
                cl.pDocumento = Convert.ToInt32(txtDocCliente.Text);
                cl.pFechaNac = dtpFechaNac.Value;
                cl.pLimiteCredito = Convert.ToDouble(txtLimiteCredito.Text);
                cl.pNombre = txtNombreCliente.Text;
                cl.pSexo = cbSexo.SelectedIndex + 1;
                c = new Cuenta();
                c.pNumero = Convert.ToInt32(txtNumeroCuenta.Text);
                c.pTipo = cbTipoCuenta.SelectedIndex + 1;
                c.pSaldo = Convert.ToDouble(txtSaldo.Text);
                c.pCliente = cl;

                if(c.pTipo==1)
                {
                    cca++;
                    if(c.pCliente.pSexo==2)
                    {
                        if (cmay.pCliente == null)
                        {
                            cmay = c;
                        }
                        else
                        {
                            if (cmay.pCliente.pLimiteCredito < c.pCliente.pLimiteCredito)
                            {
                                cmay = c;
                            }
                        }
                    }
                }
                else
                {
                    ccc++;
                    acuCC += c.pSaldo;
                }
                

                lblPromedioCC.Text = Convert.ToString(Math.Round(acuCC / Convert.ToDouble(ccc), 2));
                lblCantAhorro.Text = Convert.ToString(cca);

                lblCantCorrientes.Text = Convert.ToString(ccc);
                if(cmay.pCliente==null)
                { lblClienta.Text = "Todavia no hay clienta con mayor limite"; }
                else
                {
                    lblClienta.Text = cmay.pCliente.pNombre;
                }
            }

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if(this.validarCuenta())
            { 
            c.depositar(Convert.ToDouble(txtMontoDep.Text));
            MessageBox.Show(c.toString());
            }
        }
        
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if(this.validarCuenta())
            { 
            MessageBox.Show(c.extraccion(Convert.ToDouble(txtMontoExt.Text)));
            MessageBox.Show(c.toString());
            }
        }
        private bool validarRegistracion()
        {
            if (txtNumeroCuenta.Text == "")
            {
                MessageBox.Show("Falta ingresar id de cuenta");
                txtNumeroCuenta.Focus();
                return false;
            }
            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Falta ingresar saldo de la cuenta");
                txtSaldo.Focus();
                return false;
            }
            if (cbTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar tipo de cuenta");
                cbTipoCuenta.Focus();
                return false;
            }
            if (txtCodigoCliente.Text == "")
            {
                MessageBox.Show("Falta ingresar codigo del cliente");
                txtCodigoCliente.Focus();
                return false;
            }
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Falta ingresar nombre del cliente");
                txtNombreCliente.Focus();
                return false;
            }
            if (txtDocCliente.Text == "")
            {
                MessageBox.Show("Falta ingresar documento del cliente");
                txtDocCliente.Focus();
                return false;
            }
            if (cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar sexo del cliente");
                cbSexo.Focus();
                return false;
            }
            if (dtpFechaNac.Value.Date==System.DateTime.Today.Date)
            {
                MessageBox.Show("Falta fecha de nacimiento del cliente");
                dtpFechaNac.Focus();
                return false;
            }
            if (txtLimiteCredito.Text == "")
            {
                MessageBox.Show("Falta ingresar limite de credito del cliente");
                txtLimiteCredito.Focus();
                return false;
            }
            return true;
        }
        private bool validarCuenta()
        {
            if(c==null)
            {
                MessageBox.Show("Falta registrar la cuenta bancaria");
                btnRegistrar.Focus();
                return false;
            }
            return true;
        }
    }
}
