using Escuela;

internal class Program
{
    private static void Main(string[] args)
    {
        //-Crea una nueva Persona y haz que te salude.
        Persona persona = new();
        persona.Saludar();

        //-Cree un nuevo estudiante, establezca una edad, salude y muestre su edad en la pantalla.
        Alumno alumno = new Alumno();
        alumno.setearEdad(26);
        alumno.Saludar();
        alumno.MostrarEdad();

        //-Crea un nuevo Profesor, establece una edad, saluda y comienza la explicación.
        Profesor profesor = new Profesor();
        profesor.setearEdad(31);
        profesor.Saludar();
        profesor.Explicar();
        
    }
}