using Ejercicio5Mix_obligatorio_.Servicios;

namespace Ejercicio5Mix_obligatorio_{
    /// <summary>
    /// Clase principal
    /// <author>msm - 311023</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main, contiene el procedimiento de la aplicacion
        /// <author>msm - 311023</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            //Creacion Variables
            short mes;
            short año;
            string añoGuardado;
            //Objetos
            PeticionInterfaz pet = new PeticionImplementacion();
            AñoInterfaz añ = new AñoImplementacion();

            //Creacion de variable para control del bucle 
            bool cerrarBucle = false;

            while (!cerrarBucle)
            {
                mes = pet.peticion(0);
                año = pet.peticion(1);

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 2:
                        añoGuardado = añ.año(año);

                        //Con este if, se mostrara los dias que tiene febrero dependiendo de si el año es bisiesto
                        if (añoGuardado == "y")
                        {
                            Console.WriteLine("Tiene 29 dias");

                        }
                        else
                        {
                            Console.WriteLine("Tiene 28 dias");

                        }
                        Console.WriteLine("Quieres hacer otra consulta s/n");

                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 8:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 10:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 11:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 12:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    default:
                        Console.WriteLine("No existe");
                        break;
                }
            }


        }
    }
}