namespace Presentacion
{
    partial class FrmLibrosView
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
            this.btnAgragarLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnBorrarLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgragarLibro
            // 
            this.btnAgragarLibro.BackColor = System.Drawing.Color.DimGray;
            this.btnAgragarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarLibro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragarLibro.ForeColor = System.Drawing.Color.White;
            this.btnAgragarLibro.Location = new System.Drawing.Point(748, 273);
            this.btnAgragarLibro.Name = "btnAgragarLibro";
            this.btnAgragarLibro.Size = new System.Drawing.Size(112, 32);
            this.btnAgragarLibro.TabIndex = 0;
            this.btnAgragarLibro.Text = "Agregar";
            this.btnAgragarLibro.UseVisualStyleBackColor = false;
            this.btnAgragarLibro.Click += new System.EventHandler(this.btnAgragarLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Libro...";
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLibro.Location = new System.Drawing.Point(164, 59);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(543, 27);
            this.txtBuscarLibro.TabIndex = 2;
            this.txtBuscarLibro.TextChanged += new System.EventHandler(this.txtBuscarLibro_TextChanged);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(28, 114);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(679, 372);
            this.dgvLibros.TabIndex = 3;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            // 
            // btnBorrarLibro
            // 
            this.btnBorrarLibro.BackColor = System.Drawing.Color.DimGray;
            this.btnBorrarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLibro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLibro.ForeColor = System.Drawing.Color.White;
            this.btnBorrarLibro.Location = new System.Drawing.Point(748, 396);
            this.btnBorrarLibro.Name = "btnBorrarLibro";
            this.btnBorrarLibro.Size = new System.Drawing.Size(112, 32);
            this.btnBorrarLibro.TabIndex = 4;
            this.btnBorrarLibro.Text = "Borrar";
            this.btnBorrarLibro.UseVisualStyleBackColor = false;
            this.btnBorrarLibro.Click += new System.EventHandler(this.btnBorrarLibro_Click);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLibro.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLibro.ForeColor = System.Drawing.Color.White;
            this.btnModificarLibro.Location = new System.Drawing.Point(748, 454);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(112, 32);
            this.btnModificarLibro.TabIndex = 5;
            this.btnModificarLibro.Text = "Modificar";
            this.btnModificarLibro.UseVisualStyleBackColor = false;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DimGray;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(748, 56);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 32);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmLibrosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificarLibro);
            this.Controls.Add(this.btnBorrarLibro);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.txtBuscarLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgragarLibro);
            this.Name = "FrmLibrosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros Registrados";
            this.Load += new System.EventHandler(this.FrmLibrosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgragarLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnBorrarLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.Button btnRegresar;
    }
}