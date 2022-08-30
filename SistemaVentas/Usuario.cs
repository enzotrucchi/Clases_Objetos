namespace SistemaVentas
{
    internal class Usuario
    {
        protected string nombre;
        protected string password;

        public bool Login(string nombre, string password)
        {
            if (this.nombre == "user" && this.password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            //código
        }
    }
}
