using System;
using System.Windows.Forms;
using Manejador;
using Entidades;

namespace Presentacion
{
    public partial class FrmLecturasAdd : Form
    {
        ManejadorLecturas ml = new ManejadorLecturas();
        ManejadorLibros lm = new ManejadorLibros();
        EntidadLecturas lecturas;
        int id = 0;
        string fkid = "";

        public FrmLecturasAdd()
        {
            InitializeComponent();
        }

        public FrmLecturasAdd(EntidadLecturas lecturas)
        {
            InitializeComponent();
            id = int.Parse(lecturas.IdLectura.ToString());

            txtLibro.Text = lecturas.FKLibro.ToString();
            dtpFechaLectura.Text = lecturas.Fecha.ToString();
            txtPaginas.Text = lecturas.NumeroPaginas.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                fkid = lm.GetISBN(cmbLibros.Text);
                if (fkid != "")
                {
                    if (id != 0)
                    {
                        lecturas = new EntidadLecturas(id, fkid, dtpFechaLectura.Text, int.Parse(txtPaginas.Text));
                        string rn = ml.Modificar(lecturas, id);
                        Close();
                    }
                    else
                    {
                        string rc = ml.Guardar(lecturas = new EntidadLecturas(id, fkid, dtpFechaLectura.Text, int.Parse(txtPaginas.Text)));

                        MessageBox.Show("Lectura guardada correctamente");
                        Close();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los campos requeridos no tienen el formato correcto.");
            }
        }

        private void FrmLecturasAdd_Load(object sender, EventArgs e)
        {
            lm.LlenarLibros(cmbLibros, "select Titulo from libros", "libros");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
