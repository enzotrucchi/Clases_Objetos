namespace Escuela
{
    internal class Alumno : Persona
    {

        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }

        public void MostrarEdad()
        {
            Console.WriteLine("Tengo {0} años", edad);
        }
    }
}
