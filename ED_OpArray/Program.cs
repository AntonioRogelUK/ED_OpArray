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
                Agregar("Cero");
                Agregar("Cero");
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
        private static bool ValidaLleno() 
        {
            if (Arreglo[Arreglo.Length -1] != null) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        private static bool ValidaExiste(string Dato)
        {
            if (!ValidaVacio()) //Si el arreglo no está vacío
            {
                foreach(string registro in Arreglo) 
                {
                    if (registro == null) 
                    {
                        return false;
                    }

                    if (registro.ToUpper() == Dato.ToUpper()) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private static void Agregar(string Dato) 
        {
            try
            {
                if (ValidaLleno()) 
                {
                    throw new Exception("El arreglo está lleno!");
                }

                if (!ValidaExiste(Dato)) 
                {
                    int arregloLength = Arreglo.Length;
                    for (int i = 0; i < arregloLength; i++) 
                    {
                        if (Arreglo[i] == null) 
                        {
                            Arreglo[i] = Dato;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
