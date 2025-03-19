namespace Herencia
{
    internal class Alumno : Persona
    {
        public Alumno() { }
        public Alumno(string nombre, int edad, string genero, int matricula, string carrera)
            :base(nombre,edad,genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Matricula = matricula;
            Carrera = carrera;
        }

        public int Matricula { get; set; }

        public string Carrera { get; set; }
    }
}
