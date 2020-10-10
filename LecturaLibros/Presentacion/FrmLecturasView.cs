using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace Presentacion
{
    public partial class FrmLecturasView : Form
    {
        ManejadorLecturas ml;
        EntidadLecturas lecturas = new EntidadLecturas(0, "", "", 0);
        int fila = 0;
        string r = "";

        public FrmLecturasView()
        {
            InitializeComponent();
            ml = new ManejadorLecturas();
        }

        private void FrmLecturasView_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            dgvLecturas.DataSource = ml.Listado("SELECT * FROM Lecturas", "Lecturas").Tables[0];

            for (int i = 0; i < dgvLecturas.Columns.Count; i++)
            {
                dgvLecturas.Columns[i].ReadOnly = true;
            }
        }

        private void btnAgragarLectura_Click(object sender, EventArgs e)
        {
            FrmLecturasAdd al = new FrmLecturasAdd();
            al.ShowDialog();
            Actualizar();
        }

        private void dgvLecturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                lecturas.IdLectura = int.Parse(dgvLecturas.Rows[fila].Cells[0].Value.ToString());
                lecturas.FKLibro = dgvLecturas.Rows[fila].Cells[1].Value.ToString();
                lecturas.Fecha = dgvLecturas.Rows[fila].Cells[2].Value.ToString();
                lecturas.NumeroPaginas = int.Parse(dgvLecturas.Rows[fila].Cells[3].Value.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("La fila seleccionada esta vacia.");
            }
        }

        private void btnBorrarLectura_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                DialogResult rs = MessageBox.Show("¿Esta seguro de que desea borrar la lectura " + lecturas.Fecha +
                "?", "!ATENCION¡", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    r = ml.Borrar(lecturas);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna lectura para borrar.");
            }
        }

        private void btnModificarLectura_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                FrmLecturasAdd la = new FrmLecturasAdd(lecturas);
                la.ShowDialog();
                Actualizar();
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna lectura para modificar.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
