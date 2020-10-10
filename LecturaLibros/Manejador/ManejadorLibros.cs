using Entidades;
using AccesoDatos;
using System.Data;
using System;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorLibros
    {
        ConexionLecturaLibros cl = new ConexionLecturaLibros();

        //Extraes ISBN
        public string GetISBN(string libro)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = cl.Mostrar(string.Format("select ISBN from libros where Titulo = '{0}'",
                    libro), "libros").Tables[0];

                DataRow r = dt.Rows[0];
                return r["ISBN"].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No seleccionaste ningún libro.");
                return "";
            }
        }

        //Guardar Libro
        public string Guardar(EntidadLibro libro)
        {
            return cl.Comando(string.Format("insert into libros values" +
                "('{0}', '{1}', {2}, '{3}', '{4}', '{5}')", libro.ISBN, libro.Titulo, libro.Paginas, libro.Autor, libro.Genero, libro.Status));
        }

        //Borrar Libro
        public string Borrar(EntidadLibro libro)
        {
            return cl.Comando(string.Format("delete from libros where ISBN='{0}'", libro.ISBN));
        }

        //Modificar Libro
        public string Modificar(EntidadLibro libro, string id2)
        {
            return cl.Comando(string.Format("update libros set Titulo='{0}'," +
                " Paginas={1}, Autor='{2}', Genero='{3}', Status='{4}' where ISBN='{5}'",
                libro.Titulo, libro.Paginas, libro.Autor, libro.Genero, libro.Status, id2));
        }

        //Mostrar Informacion
        public DataSet Listado(string q, string tabla)
        {
            return cl.Mostrar(q, tabla);
        }

        //Mostrar Libros en combobox
        public void LlenarLibros(ComboBox combo, string q, string tabla)
        {
            combo.DataSource = cl.Mostrar(q, tabla).Tables[0];
            combo.DisplayMember = "Titulo";
        }
    }
}
