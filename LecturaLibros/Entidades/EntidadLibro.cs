namespace Entidades
{
    public class EntidadLibro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int Paginas { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Status { get; set; }

        public EntidadLibro(string isbn, string titulo, int paginas, string autor, string genero, string status)
        {
            ISBN = isbn;
            Titulo = titulo;
            Paginas = paginas;
            Autor = autor;
            Genero = genero;
            Status = status;
        }
    }
}
