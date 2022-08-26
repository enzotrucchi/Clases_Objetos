namespace AlbumFotos
{
    internal class AlbumTest
    {
        static void Main()
        {
            AlbumFotos album = new();
            AlbumFotos albumFotos = new(24);
            AlbumFotosGrande albumFotosGrande = new();

            Console.WriteLine("Comun" + album.NumeroDePaginas);
            Console.WriteLine("Sobrecarga" + albumFotos.NumeroDePaginas);
            Console.WriteLine("Grande" + albumFotosGrande.NumeroDePaginas);

        }
    }
}
