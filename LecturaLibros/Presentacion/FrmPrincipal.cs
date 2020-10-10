using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsbLibros_Click(object sender, EventArgs e)
        {
            FrmLibrosView lv = new FrmLibrosView();
            lv.MdiParent = this;
            lv.Show();
        }

        private void tsbLecturas_Click(object sender, EventArgs e)
        {
            FrmLecturasView le = new FrmLecturasView();
            le.MdiParent = this;
            le.Show();
        }
    }
}
