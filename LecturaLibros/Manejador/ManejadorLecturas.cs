using Entidades;
using AccesoDatos;
using System.Data;

namespace Manejador
{
    class ManejadorLecturas
    {
        ConexionLecturaLibros cl = new ConexionLecturaLibros();

        //Guardar Lectura
        public string Guardar(EntidadLecturas lectura)
        {
            return cl.Comando(string.Format("insert into lecturas values" +
                "(NULL, '{0}', '{1}', {2})", lectura.FKLibro, lectura.Fecha, lectura.NumeroPaginas));
        }

        //Borrar Lectura
        public string Borrar(EntidadLecturas lectura)
        {
            return cl.Comando(string.Format("delete from lecturas where Id_Lectura={0}", lectura.IdLectura));
        }

        //Modificar Lectura
        public string Modificar(EntidadLecturas lectura, string id2)
        {
            return cl.Comando(string.Format("update lecturas set FKLibro='{0}'," +
                " Fecha='{1}', NumeroPaginas={2} where Id_Lectura={5}",
                lectura.FKLibro, lectura.Fecha, lectura.NumeroPaginas, id2));
        }

        //Mostrar Informacion
        public DataSet Listado(string q, string tabla)
        {
            return cl.Mostrar(q, tabla);
        }

    }
}
