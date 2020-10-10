using System;
using System.Windows.Forms;
using Manejador;
using Entidades;

namespace Presentacion
{
    public partial class FrmLibrosAdd : Form
    {
        ManejadorLibros ml = new ManejadorLibros();
        EntidadLibro libro;
        string id2 = null;

        public FrmLibrosAdd()
        {
            InitializeComponent();
        }
        public FrmLibrosAdd(EntidadLibro libro, bool estado)
        {
            InitializeComponent();
            id2 = libro.ISBN.ToString();

            txtISBN.Text = libro.ISBN.ToString();
            txtTitulo.Text = libro.Titulo.ToString();
            txtPaginas.Text = libro.Paginas.ToString();
            txtAutor.Text = libro.Autor.ToString();
            txtGenero.Text = libro.Genero.ToString();
            txtStatus.Text = libro.Status.ToString();
            txtISBN.Enabled = estado;
        }

        private void FrmLibrosAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id2 != null)
                {
                    libro = new EntidadLibro(txtISBN.Text, txtTitulo.Text, int.Parse(txtPaginas.Text), txtAutor.Text,
                        txtGenero.Text, txtStatus.Text);
                    string rn = ml.Modificar(libro, txtISBN.Text);
                    Close();
                }
                else
                {
                    string rc = ml.Guardar(libro = new EntidadLibro(txtISBN.Text, txtTitulo.Text, int.Parse(txtPaginas.Text),
                        txtAutor.Text, txtGenero.Text, txtStatus.Text));

                    MessageBox.Show("Libro guardado correctamente");
                    Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los campos requeridos no tienen el formato correcto.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
