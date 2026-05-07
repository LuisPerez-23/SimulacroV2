public class Libro
{
    public string titulo { get; set; }
    public string autor { get; set; }
    public int anyoPublicacion { get; set; }
    public bool disponible { get; set; } = true;
    public Libro(string titulo, string autor, int anyoPublicacion,bool disponible)
    {
        titulo = titulo;
        autor = autor;
        anyoPublicacion = anyoPublicacion;
        disponible = disponible;
    }
    public override string ToString()
    {
        return $"{titulo} - {autor} ({anyoPublicacion})";
    }

}