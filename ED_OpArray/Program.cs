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
                Imprimir();
                Console.WriteLine("-------------------");
                
                Agregar("Cero");
                Agregar("Uno");
                Agregar("Uno");
                Agregar("Dos");
                Console.WriteLine("-------------------");

                Imprimir();
                Console.WriteLine("-------------------");

                Buscar("Seis", true);
                Console.WriteLine("-------------------");

                Buscar("Dos", true);
                Console.WriteLine("-------------------");
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

                if (ValidaExiste(Dato)) 
                {
                    Console.WriteLine($"ya existe el dato '{Dato}' en el arreglo");
                    return;
                }

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private static void Imprimir() 
        {
            try
            {
                if (ValidaVacio()) 
                {
                    Console.WriteLine("El arreglo está vacío");
                    return;
                }

                int arregloLenght = Arreglo.Length;
                for (int i = 0; i < arregloLenght; i++) 
                {
                    if (Arreglo[i] == null) 
                    {
                        Console.WriteLine("Fin del arreglo");
                        break;
                    }

                    Console.WriteLine($"[{i}] - {Arreglo[i]}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private static int Buscar(string Dato, bool MostrarMensajes = false) 
        {
            try
            {
                if (ValidaVacio()) 
                {
                    if (MostrarMensajes) 
                    {
                        Console.WriteLine("El arreglo está vacío");
                    }
                    return -1;
                }

                int arregloLenght = Arreglo.Length;
                for (int i = 0; i < arregloLenght; i++)
                {
                    if (Arreglo[i] == null) 
                    {
                        break;
                    }
                    
                    if (Arreglo[i].ToUpper() == Dato.ToUpper()) 
                    {
                        if (MostrarMensajes) 
                        {
                            Console.WriteLine($"Encontrado [{i}] - {Arreglo[i]}");
                        }

                        return i;
                    }
                }

                if (MostrarMensajes)
                {
                    Console.WriteLine($"El dato '{Dato}' no se encontró");
                }

                return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
