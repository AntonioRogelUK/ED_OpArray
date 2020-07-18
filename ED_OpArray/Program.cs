using System;

namespace ED_OpArray
{
    class Program
    {
        static string[] Arreglo = new string[10];
        static void Main(string[] args)
        {
            try
            {
                ValidaVacio();

                Arreglo[0] = "Cero";

                ValidaVacio();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool ValidaVacio() 
        {
            if (Arreglo[0] == null) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
