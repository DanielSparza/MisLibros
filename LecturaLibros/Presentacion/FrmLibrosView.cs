using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace Presentacion
{
    public partial class FrmLibrosView : Form
    {
        ManejadorLibros ml;
        EntidadLibro libro = new EntidadLibro("", "", 0, "", "", "");
        int fila = 0;
        string r = "";

        public FrmLibrosView()
        {
            InitializeComponent();
            ml = new ManejadorLibros();
        }

        void Actualizar()
        {
            dgvLibros.DataSource = ml.Listado(string.Format(
                "select * from Libros where Titulo like '%{0}%'", txtBuscarLibro.Text), "Libros").Tables[0];

            for (int i = 0; i < dgvLibros.Columns.Count; i++)
            {
                dgvLibros.Columns[i].ReadOnly = true;
            }
        }

        private void FrmLibrosView_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgragarLibro_Click(object sender, EventArgs e)
        {
            FrmLibrosAdd al = new FrmLibrosAdd();
            al.ShowDialog();
            Actualizar();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                libro.ISBN = dgvLibros.Rows[fila].Cells[0].Value.ToString();
                libro.Titulo = dgvLibros.Rows[fila].Cells[1].Value.ToString();
                libro.Paginas = int.Parse(dgvLibros.Rows[fila].Cells[2].Value.ToString());
                libro.Autor = dgvLibros.Rows[fila].Cells[3].Value.ToString();
                libro.Genero = dgvLibros.Rows[fila].Cells[4].Value.ToString();
                libro.Status = dgvLibros.Rows[fila].Cells[5].Value.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("La fila seleccionada esta vacia.");
            }
        }

        private void btnBorrarLibro_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                DialogResult rs = MessageBox.Show("¿Esta seguro de que desea borrar el libro " + libro.Titulo +
                "?", "!ATENCION¡", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    r = ml.Borrar(libro);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste ningún libro para borrar.");
            }
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                FrmLibrosAdd la = new FrmLibrosAdd(libro, false);
                la.ShowDialog();
                Actualizar();
            }
            else
            {
                MessageBox.Show("No seleccionaste ningún Libro para modificar.");
            }
        }

        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
