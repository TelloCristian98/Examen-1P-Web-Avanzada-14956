class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public float Calificacion { get; set; }

    public Estudiante()
    {
        Nombre = "Sin nombre";
        Edad = 0;
        Calificacion = 0.0f;
    }

    public Estudiante(string nombre, int edad, float calificacion)
    {
        Nombre = nombre;
        Edad = edad;
        Calificacion = calificacion;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Calificacion: {Calificacion}");
    }
}