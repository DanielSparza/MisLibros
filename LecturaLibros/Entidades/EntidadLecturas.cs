namespace Entidades
{
    public class EntidadLecturas
    {
        public int IdLectura { get; set; }
        public string FKLibro { get; set; }
        public string Fecha { get; set; }
        public int NumeroPaginas { get; set; }

        public EntidadLecturas(int idlectura, string fklibro, string fecha, int numeropaginas)
        {
            IdLectura = idlectura;
            FKLibro = fklibro;
            Fecha = fecha;
            NumeroPaginas = numeropaginas;
        }
    }
}
