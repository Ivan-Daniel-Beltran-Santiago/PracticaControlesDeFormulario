using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaControlesDeFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sep = "---------------------------------------\n";
            String proc = "";
            String ram = "";
            String os = cboxOS.Text;
            String dd = "";
            String gc = "";
            String ac = "";

            if (rbICi7.Checked)
            {
                proc = rbICi7.Text;
            }
            if (rbICi9.Checked)
            {
                proc = rbICi9.Text;
            }
            if (rbAMDR7.Checked)
            {
                proc = rbAMDR7.Text;
            }
            if (rbAMDR9.Checked)
            {
                proc = rbAMDR9.Text;
            }
            if (rbCEU.Checked)
            {
                proc = rbCEU.Text;
            }
            if (rbCEUX.Checked)
            {
                proc = rbCEUX.Text;
            }

            if (rb4gb.Checked)
            {
                ram = rb4gb.Text;
            }
            if (rb8gb.Checked)
            {
                ram = rb8gb.Text;
            }
            if (rb16gb.Checked)
            {
                ram = rb16gb.Text;
            }
            if (rb32gb.Checked)
            {
                ram = rb32gb.Text;
            }
            if (rb64gb.Checked)
            {
                ram = rb64gb.Text;
            }

            if (cboxADATA.Checked == true)
            {
                dd = dd + cboxADATA.Text + "\n";
            }
            if (cboxWD.Checked == true)
            {
                dd = dd + cboxWD.Text + "\n";
            }
            if (cboxToshiba.Checked == true)
            {
                dd = dd + cboxToshiba.Text + "\n";
            }
            if (cboxSeagate.Checked == true)
            {
                dd = dd + cboxSeagate.Text + "\n";
            }

            if (cboxRadeon.Checked == true)
            {
                gc = gc + cboxRadeon.Text + "\n";
            }
            if (cboxGeForce.Checked == true)
            {
                gc = gc + cboxGeForce.Text + "\n";
            }
            if (cboxOmegaS.Checked == true)
            {
                gc = gc + cboxOmegaS.Text + "\n";
            }

            if (cboxAorus.Checked == true)
            {
                ac = ac + cboxAorus.Text + "\n";
            }
            if (cboxCase.Checked == true)
            {
                ac = ac + cboxCase.Text + "\n";
            }

            MessageBox.Show(sep + "Ticket:\n" + sep + "\nCliente: " + txtboxclient.Text + 
            "\nTeléfono: " + txtboxtelefono.Text + "\nDirección: " + txtboxaddress.Text
            + "\nCódigo Postal: " + txtboxcp.Text + "\n\nProcesador escogido: " + proc
            + "\nCantidad de RAM seleccionada: " + ram + "\nSistema operativo seleccionado: " + os
            + "\n\nDisco(s) duro(s) seleccionado(s): \n\n" + dd + "\nComponentes extra:\n\nTarjetas gráficas: \n\n"
            + gc + "\nOtros: \n\n" + ac);
        }
    }
}
