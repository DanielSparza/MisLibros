namespace Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStripSuperior = new System.Windows.Forms.ToolStrip();
            this.tsbLibros = new System.Windows.Forms.ToolStripButton();
            this.tsbLecturas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSuperior
            // 
            this.toolStripSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLibros,
            this.tsbLecturas});
            this.toolStripSuperior.Location = new System.Drawing.Point(0, 0);
            this.toolStripSuperior.Name = "toolStripSuperior";
            this.toolStripSuperior.Size = new System.Drawing.Size(897, 39);
            this.toolStripSuperior.TabIndex = 1;
            this.toolStripSuperior.Text = "toolStrip1";
            // 
            // tsbLibros
            // 
            this.tsbLibros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLibros.Image = ((System.Drawing.Image)(resources.GetObject("tsbLibros.Image")));
            this.tsbLibros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLibros.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbLibros.Name = "tsbLibros";
            this.tsbLibros.Size = new System.Drawing.Size(36, 36);
            this.tsbLibros.Text = "Libros";
            this.tsbLibros.Click += new System.EventHandler(this.tsbLibros_Click);
            // 
            // tsbLecturas
            // 
            this.tsbLecturas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLecturas.Image = ((System.Drawing.Image)(resources.GetObject("tsbLecturas.Image")));
            this.tsbLecturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLecturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLecturas.Name = "tsbLecturas";
            this.tsbLecturas.Size = new System.Drawing.Size(36, 36);
            this.tsbLecturas.Text = "Lecturas";
            this.tsbLecturas.Click += new System.EventHandler(this.tsbLecturas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(897, 511);
            this.Controls.Add(this.toolStripSuperior);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripSuperior.ResumeLayout(false);
            this.toolStripSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSuperior;
        private System.Windows.Forms.ToolStripButton tsbLibros;
        private System.Windows.Forms.ToolStripButton tsbLecturas;
    }
}