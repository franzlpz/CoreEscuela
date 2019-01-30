namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string Nombre { get; set; }
        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

        
    }
}