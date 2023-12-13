class EstudianteGraduado : Estudiante
{
    public string Titulo { get; set; }

    public EstudianteGraduado()
    {
        Titulo = "Sin titulo";
    }

    public EstudianteGraduado(string nombre, int edad, float calificacion, string titulo) : base(nombre, edad, calificacion)
    {
        Titulo = titulo;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Titulo: {Titulo}");
    }
}