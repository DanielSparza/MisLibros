using System.Data;
using Bases;

namespace AccesoDatos
{
    public class ConexionLecturaLibros
    {
        Conectar c = new Conectar("localhost", "root", "1234567890", "LecturaLibros");

        //Metodo para insertar, eliminar, modificar
        public string Comando(string q)
        {
            return c.Comando(q);
        }

        //Metodo para consultar
        public DataSet Mostrar(string q, string tabla)
        {
            return c.Consultar(q, tabla);
        }
    }
}
