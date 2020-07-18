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
                Agregar("Tres");
                Agregar("Cuatro");
                Agregar("Cinco");
                Agregar("Seis");
                Console.WriteLine("-------------------");

                Imprimir();
                Console.WriteLine("-------------------");

                Buscar("Seis", true);
                Console.WriteLine("-------------------");

                Buscar("Dos", true);
                Console.WriteLine("-------------------");

                //Actualizar("Uno", "Cuatro");
                Console.WriteLine("-------------------");
                Imprimir();
                Console.WriteLine("-------------------");


                Eliminar("Tres");
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
        private static void Actualizar(string Dato, string NuevoValor) 
        {
            try
            {
                int Encontrado = Buscar(Dato);
                if (Encontrado < 0) 
                {
                    Console.WriteLine($"El dato {Dato} no fué encontrado");
                    return;
                }

                Arreglo[Encontrado] = NuevoValor;
                Console.WriteLine($"El dato {Dato} fue actualizado a {Arreglo[Encontrado]}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private static void Eliminar(string Dato) 
        {
            try
            {
                int Encontrado = Buscar(Dato);
                if (Encontrado < 0) 
                {
                    Console.WriteLine($"El dato {Dato} no fué encontrado");
                    return;
                }

                int arregloLenght = Arreglo.Length;
                for (int IndiceActual = Encontrado; IndiceActual < arregloLenght; IndiceActual++) 
                {
                    int IndiceSiguiente = IndiceActual + 1;
                    if (IndiceSiguiente == arregloLenght || Arreglo[IndiceSiguiente] == null) 
                    {
                        Arreglo[IndiceActual] = null;
                        break;
                    }

                    Arreglo[IndiceActual] = Arreglo[IndiceSiguiente];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
