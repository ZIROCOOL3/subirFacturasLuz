using MySqlX.XDevAPI;
using SubirFacturasLuz.Clases;
using SubirFacturasLuz.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubirFacturasLuz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        string mensaje= string.Empty;
        string DireccionArchivo = string.Empty;
        private void BtnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OfdSelecionarArchivo.FileName= string.Empty;
            OfdSelecionarArchivo.Filter = "Facturas de luz (*.pdf)|*.pdf";
    
            DialogResult dlgRes = OfdSelecionarArchivo.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                txtRutaARchivo.Text = OfdSelecionarArchivo.FileName;
            }
            else
            {
                txtRutaARchivo.Text = "";
            }
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            //Direccion del archivo
            int idgenerado = LuzLogica.Instancia.Registrar(new Luz()
            {
                Periodo = DateTime.Parse("01-"+ DtpPeriodo.Value.Month+"-"+DtpPeriodo.Value.Year),
                Consumo = decimal.Parse(txtConsumo.Text),
                Importe = decimal.Parse(TxtImporte.Text),
                Factura = File.ReadAllBytes(txtRutaARchivo.Text),
            }, out mensaje);

            if (idgenerado < 1)
            {
                //cliente con error
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRutaARchivo.Text = "";
                txtConsumo.Text = "";
                TxtImporte.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] arch;
            string NombreArchivo = string.Empty;
            string RutaArchivo = string.Empty;
            List<Luz> lista = LuzLogica.Instancia.Listar();

            foreach (Luz cl in lista)
            {
                arch = cl.Factura;
                NombreArchivo = cl.Periodo.Year.ToString()+"-"+cl.Periodo.Month.ToString();
                //verificar si existe carpeta
                RutaArchivo = @"C:\img\" + NombreArchivo + ".pdf";
                try
                {
                    // Determine whether the directory exists.
                    if (!Directory.Exists(@"C:\img\"))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(RutaArchivo);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error: " + ex.Message);
                }

                File.WriteAllBytes(RutaArchivo, arch);
                Process.Start(RutaArchivo);
            }

        }
    }
}
