namespace Presentacion
{
    partial class FrmLecturasView
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
            this.btnModificarLectura = new System.Windows.Forms.Button();
            this.btnBorrarLectura = new System.Windows.Forms.Button();
            this.dgvLecturas = new System.Windows.Forms.DataGridView();
            this.btnAgragarLectura = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarLectura
            // 
            this.btnModificarLectura.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLectura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLectura.ForeColor = System.Drawing.Color.White;
            this.btnModificarLectura.Location = new System.Drawing.Point(742, 435);
            this.btnModificarLectura.Name = "btnModificarLectura";
            this.btnModificarLectura.Size = new System.Drawing.Size(112, 32);
            this.btnModificarLectura.TabIndex = 11;
            this.btnModificarLectura.Text = "Modificar";
            this.btnModificarLectura.UseVisualStyleBackColor = false;
            this.btnModificarLectura.Click += new System.EventHandler(this.btnModificarLectura_Click);
            // 
            // btnBorrarLectura
            // 
            this.btnBorrarLectura.BackColor = System.Drawing.Color.DimGray;
            this.btnBorrarLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLectura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLectura.ForeColor = System.Drawing.Color.White;
            this.btnBorrarLectura.Location = new System.Drawing.Point(742, 377);
            this.btnBorrarLectura.Name = "btnBorrarLectura";
            this.btnBorrarLectura.Size = new System.Drawing.Size(112, 32);
            this.btnBorrarLectura.TabIndex = 10;
            this.btnBorrarLectura.Text = "Borrar";
            this.btnBorrarLectura.UseVisualStyleBackColor = false;
            this.btnBorrarLectura.Click += new System.EventHandler(this.btnBorrarLectura_Click);
            // 
            // dgvLecturas
            // 
            this.dgvLecturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLecturas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvLecturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturas.Location = new System.Drawing.Point(22, 40);
            this.dgvLecturas.Name = "dgvLecturas";
            this.dgvLecturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLecturas.Size = new System.Drawing.Size(679, 427);
            this.dgvLecturas.TabIndex = 9;
            this.dgvLecturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecturas_CellClick);
            // 
            // btnAgragarLectura
            // 
            this.btnAgragarLectura.BackColor = System.Drawing.Color.DimGray;
            this.btnAgragarLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarLectura.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragarLectura.ForeColor = System.Drawing.Color.White;
            this.btnAgragarLectura.Location = new System.Drawing.Point(742, 249);
            this.btnAgragarLectura.Name = "btnAgragarLectura";
            this.btnAgragarLectura.Size = new System.Drawing.Size(112, 32);
            this.btnAgragarLectura.TabIndex = 6;
            this.btnAgragarLectura.Text = "Agregar";
            this.btnAgragarLectura.UseVisualStyleBackColor = false;
            this.btnAgragarLectura.Click += new System.EventHandler(this.btnAgragarLectura_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DimGray;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(742, 40);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 32);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmLecturasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(873, 506);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificarLectura);
            this.Controls.Add(this.btnBorrarLectura);
            this.Controls.Add(this.dgvLecturas);
            this.Controls.Add(this.btnAgragarLectura);
            this.Name = "FrmLecturasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturas";
            this.Load += new System.EventHandler(this.FrmLecturasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarLectura;
        private System.Windows.Forms.Button btnBorrarLectura;
        private System.Windows.Forms.DataGridView dgvLecturas;
        private System.Windows.Forms.Button btnAgragarLectura;
        private System.Windows.Forms.Button btnRegresar;
    }
}