using System;

namespace BibliotecaTPAYP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creación de libros para aplicación
            Libro libro1 = new Libro("El Principito", "Antoine de Saint-Exupéry", "Salamandra");
            Libro libro2 = new Libro("1984", "George Orwell", "Penguin");
            Libro libro3 = new Libro("Matar a un ruiseñor", "Harper Lee", "J.B. Lippincott & Co.");
            Libro libro4 = new Libro("El Gran Gatsby", "F. Scott Fitzgerald", "Scribner");
            Libro libro5 = new Libro("Orgullo y Prejuicio", "Jane Austen", "Penguin");
            Libro libro6 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana");
            Libro libro7 = new Libro("Crimen y Castigo", "Fiódor Dostoyevski", "Penguin");
            Libro libro8 = new Libro("Rayuela", "Julio Cortázar", "Sudamericana");
            Libro libro9 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "Castalia");
            Libro libro10 = new Libro("La Odisea", "Homero", "Alianza");
            Libro libro11 = new Libro("La Casa de los Espíritus", "Isabel Allende", "Plaza & Janés");
            Libro libro12 = new Libro("El Amor en los Tiempos del Cólera", "Gabriel García Márquez", "Sudamericana");
            Libro libro13 = new Libro("Los Miserables", "Victor Hugo", "Penguin");
            Libro libro14 = new Libro("Drácula", "Bram Stoker", "Penguin");
            Libro libro15 = new Libro("La Metamorfosis", "Franz Kafka", "Debolsillo");

            //creación de Socios
            Socio socio1 = new Socio("Juan Pérez", 20123456, 987654321, "Calle Rodriguez", 1);
            Socio socio2 = new Socio("Ana López", 30123457, 123456789, "Av. Corrientes 456", 1);
            Socio socio3 = new Socio("María García", 40123458, 234567890, "Calle Sol 789", 0);
            Socio socio4 = new Socio("Emilse Brizuela", 46009054, 345678901, "Av. Libertad 101", 1);
            Socio socio5 = new Socio("Laura Martínez", 60123450, 456789012, "Calle Luna 202", 1);
            Socio socio6 = new Socio("Carlos Sánchez", 70123451, 567890123, "Av. Colón 303", 1);
            Socio socio7 = new Socio("Lucía Romero", 80123452, 678901234, "Calle 25 de Mayo 404", 0);
            Socio socio8 = new Socio("Jorge Díaz", 90123453, 789012345, "Av. Pampa 505", 1);
            Socio socio9 = new Socio("Sofia Torres", 11123454, 890123456, "Calle Roca 606", 1);
            Socio socio10 = new Socio("Fernando Moreno", 21123455, 901234567, "Av. Rivadavia 707", 0);

            //creación de SocioLectores (mismo constructor que Socio)
            SocioLector socio11 = new SocioLector("Paula Ruiz", 31123456, 123456780, "Calle Belgrano 808", 1);
            SocioLector socio12 = new SocioLector("Miguel Gómez", 41123457, 234567891, "Av. Independencia 909", 1);
            SocioLector socio13 = new SocioLector("Luis Rodríguez", 51123458, 345678902, "Av. Belgrano 111", 0);
            SocioLector socio14 = new SocioLector("Emma Silva", 61123459, 456789013, "Calle Bolívar 212", 1);
            SocioLector socio15 = new SocioLector("Alberto Pérez", 71123460, 567890124, "Av. San Martín 313", 1);

            //creación de Biblioteca
            Biblioteca biblioteca = new Biblioteca("Biblioteca Principal");

            //agregar libros a Biblioteca
            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);
            biblioteca.AgregarLibro(libro4);
            biblioteca.AgregarLibro(libro5);
            biblioteca.AgregarLibro(libro6);
            biblioteca.AgregarLibro(libro7);
            biblioteca.AgregarLibro(libro8);
            biblioteca.AgregarLibro(libro9);
            biblioteca.AgregarLibro(libro10);
            biblioteca.AgregarLibro(libro11);
            biblioteca.AgregarLibro(libro12);
            biblioteca.AgregarLibro(libro13);
            biblioteca.AgregarLibro(libro14);
            biblioteca.AgregarLibro(libro15);

            //agregar socios a Biblioteca
            biblioteca.AgregarSocio(socio1);
            biblioteca.AgregarSocio(socio2);
            biblioteca.AgregarSocio(socio3);
            biblioteca.AgregarSocio(socio4);
            biblioteca.AgregarSocio(socio5);
            biblioteca.AgregarSocio(socio6);
            biblioteca.AgregarSocio(socio7);
            biblioteca.AgregarSocio(socio8);
            biblioteca.AgregarSocio(socio9);
            biblioteca.AgregarSocio(socio10);
            biblioteca.AgregarSocio(socio11);
            biblioteca.AgregarSocio(socio12);
            biblioteca.AgregarSocio(socio13);
            biblioteca.AgregarSocio(socio14);
            biblioteca.AgregarSocio(socio15);


            //se muestra el menú principal, se pide opción, y dependiendo la opción elegida se hacen
            //invocaciones a funciones que realizan las tareas pedidas
            /* menuPrincipal();
             int opcion = int.Parse(Console.ReadLine());
             while(opcion!=0){
                 switch(opcion){
                     case 0:
                         break;
                     case 1:
                         agregarLibro(biblioteca);
                         break;
                     case 2:
                         eliminarLibro(biblioteca);
                         break;
                     case 3:
                         altaSocio(biblioteca);
                         break;
                     case 4:
                         bajaSocio(biblioteca);
                         break;
                     case 5:
                         cantidadLibros(biblioteca);
                         break;
                     case 6:
                         cantidadSocios(biblioteca);
                         break;
                     case 7:
                         existeLibro(biblioteca);
                         break;
                     case 8:
                         existeSocio(biblioteca);
                         break;
                     case 9:
                         verLibro(biblioteca);
                         break;
                     case 10:
                         VerSocio(biblioteca);
                         break;
                     case 11:
                         todosLibros(biblioteca);
                         break;
                     case 12:
                         todosSocios(biblioteca);
                         break;
                     default:
                         Console.WriteLine("opcion incorrecta");
                         break;

                 }

                 menuPrincipal();
                 opcion = int.Parse(Console.ReadLine());
             }


         }

         static void menuPrincipal(){
             Console.WriteLine();
             Console.WriteLine("*******************************************************************************");
             Console.WriteLine("*****                      SISTEMA BIBLIOTECA                            ******");
             Console.WriteLine("*******************************************************************************");
             Console.WriteLine("\nSeleccione una opción del menu:\n\n");
             Console.WriteLine("1. Agregar libro\n2. Eliminar libro\n3. Dar ALTA socio/socio-lector\n4. Dar BAJA socio/socio-lector\n5. Cantidad de Socios\n6. Cantidad de libros\n7. Existe Libro?\n8. Existe Socio?\n9. Ver libro\n10. Ver Socio\n11. Todos los libros\n12. Todos los socios\n0. Salir");
             Console.WriteLine();
         }*/
            MenuPrincipal(biblioteca);

            static void MenuPrincipal(Biblioteca biblioteca)
            {
                int opcion;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("*****                      SISTEMA BIBLIOTECA                            ******");
                    Console.WriteLine("*******************************************************************************");
                    Console.WriteLine("Seleccione una opción del menú:\n");
                    Console.WriteLine("1. Métodos de libros");
                    Console.WriteLine("2. Métodos de socios");
                    Console.WriteLine("3. Pedir prestado un Libro");
                    Console.WriteLine("4. Devolver un Libro");
                    Console.WriteLine("0. Salir");
                    opcion = int.Parse(Console.ReadLine());
                    // agregar excepcion
                    switch (opcion)
                    {
                        case 1:
                            MenuLibros(biblioteca);
                            break;
                        case 2:
                            MenuSocios(biblioteca);
                            break;
                        case 3:
                            PrestarLibro(biblioteca);
                            break;
                        case 4:
                            DevolverLibro(biblioteca);
                            break;
                        case 0:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                } while (opcion != 0);
            }

            static void MenuLibros(Biblioteca biblioteca)
            {
                int opcion;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Menú de libros:\n");
                    Console.WriteLine("1. Agregar libro");
                    Console.WriteLine("2. Eliminar libro");
                    Console.WriteLine("3. Cantidad de Libros");
                    Console.WriteLine("4. Existe el libro?");
                    Console.WriteLine("5. Ver libro");
                    Console.WriteLine("6. Listar todos los libros");
                    Console.WriteLine("0. Volver al menú principal");
                    opcion = int.Parse(Console.ReadLine());
                    //agregar excepcion
                    switch (opcion)
                    {
                        case 1:
                            AgregarLibro(biblioteca);
                            break;
                        case 2:
                            EliminarLibro(biblioteca);
                            break;
                        case 3:
                            CantidadLibros(biblioteca);
                            break;
                        case 4:
                            ExisteLibro(biblioteca);
                            break;
                        case 5:
                            VerLibro(biblioteca);
                            break;
                        case 6:
                            TodosLibros(biblioteca);
                            break;
                        case 0:
                            Console.WriteLine("Volviendo al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                } while (opcion != 0);
            }

            static void MenuSocios(Biblioteca biblioteca)
            {
                int opcion;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Menú de socios:\n");
                    Console.WriteLine("1. Alta socio");
                    Console.WriteLine("2. Baja socio");
                    Console.WriteLine("3. Cantidad de socios");
                    Console.WriteLine("4. Existe el socio?");
                    Console.WriteLine("5. Ver socio");
                    Console.WriteLine("6. Listar todos los socios");
                    Console.WriteLine("0. Volver al menú principal");
                    opcion = int.Parse(Console.ReadLine());
                    //agregar excepcion
                    switch (opcion)
                    {
                        case 1:
                            AltaSocio(biblioteca);
                            break;
                        case 2:
                            BajaSocio(biblioteca);
                            break;
                        case 3:
                            CantidadSocios(biblioteca);
                            break;
                        case 4:
                            ExisteSocio(biblioteca);
                            break;
                        case 5:
                            VerSocio(biblioteca);
                            break;
                        case 6:
                            TodosSocios(biblioteca);
                            break;
                        case 0:
                            Console.WriteLine("Volviendo al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                } while (opcion != 0);
            }

            static void AgregarLibro(Biblioteca biblioteca)

            {
                // Preguntas para el nuevo libro
                Console.WriteLine();
                Console.WriteLine("### AGREGAR LIBRO ###");
                Console.Write("Ingrese el título del libro: ");
                string tituloLibro = Console.ReadLine();
                Console.Write("Ingrese el autor del libro: ");
                string autorLibro = Console.ReadLine();
                Console.Write("Ingrese la editorial del libro: ");
                string editorialLibro = Console.ReadLine();

                // Creación del libro para guardar en Biblioteca
                Libro libro = new Libro(tituloLibro, autorLibro, editorialLibro);

                // Guardado de libro en biblioteca
                biblioteca.AgregarLibro(libro);

                Console.WriteLine();
                Console.WriteLine("¡¡¡ Libro agregado exitosamente !!!");
                Console.WriteLine();
                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void EliminarLibro(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### ELIMINAR LIBRO ###");
                Console.Write("Ingrese el código del libro a eliminar: ");
                int codigoLibro = int.Parse(Console.ReadLine()); 
                //agregar excepcion 

                // Buscar el libro por su código
                Libro libroAEliminar = null;
                foreach (Libro libro in biblioteca.Libros)
                {
                    if (libro.Codigo == codigoLibro)
                    {
                        libroAEliminar = libro;
                        break;
                    }
                }
                //el libro que se intenta eliminar no existe
                if (libroAEliminar == null)
                {
                    Console.WriteLine("¡¡¡ El libro no existe !!!");
                }
                else if (!libroAEliminar.Estado) // el libro que se intenta eliminar lo tiene un socio
                {
                    Console.WriteLine("¡¡¡ Ese libro se encuentra prestado !!!");
                }
                else //el libro se elimina correctamente
                {
                    biblioteca.EliminarLibro(libroAEliminar);
                    Console.WriteLine("¡¡¡ Libro eliminado exitosamente !!!");
                }

                Console.WriteLine();
                volviendoAlMenuPrincipal();
                MenuPrincipal(biblioteca);
                Console.WriteLine();
            }

            static void AltaSocio(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### DAR ALTA A SOCIO ###");
                Console.WriteLine("1. Socio");
                Console.WriteLine("2. Socio-lector");
                Console.WriteLine();
                Console.WriteLine("Elija una opción: ");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1 || opcion == 2)
                {
                    Console.Write("Ingrese nombre completo del socio: ");
                    string nombreApellido = Console.ReadLine();
                    Console.Write("Ingrese dni del socio: ");
                    int dni = int.Parse(Console.ReadLine());

                    //recorrer la lista de socios de la biblioteca para verificar que no se repita el DNI
                    int i = 0;
                    bool dniExiste = false;
                    while (i < biblioteca.Socios.Count && !dniExiste)
                    {
                        Socio socioActual = (Socio)biblioteca.Socios[i];
                        if (socioActual.Dni == dni)
                        {
                            dniExiste = true;
                        }
                        i++;
                    }
                    if (dniExiste) //el socio ya se encuentra registrado
                    {
                        Console.WriteLine("Ya hay un socio registrado con ese dni");
                        Console.WriteLine();
                        volviendoAlMenuPrincipal();
                        Console.WriteLine();
                        MenuPrincipal(biblioteca);
                        return;
                    }
                    Console.Write("Ingrese el teléfono del socio: ");
                    int telefono = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la dirección del socio: ");
                    string direccion = Console.ReadLine();
                    if (opcion == 1)
                    {
                        Socio socio = new Socio(nombreApellido, dni, telefono, direccion,0);
                        biblioteca.AgregarSocio(socio);
                    }

                    else if (opcion == 2)
                    {
                        SocioLector socioLector = new SocioLector(nombreApellido, dni, telefono, direccion,0);
                        biblioteca.AgregarSocio(socioLector);
                    }

                    Console.WriteLine();
                    Console.WriteLine("¡¡¡ Socio dado de alta exitosamente !!!");
                    Console.WriteLine();
                    volviendoAlMenuPrincipal();
                    Console.WriteLine();
                    MenuPrincipal(biblioteca);
                }
                else
                {
                    Console.WriteLine("Opcion ingresada no valida");
                    Console.WriteLine();
                    volviendoAlMenuPrincipal();
                    Console.WriteLine();
                    MenuPrincipal(biblioteca);
                }
            }
           
            static void BajaSocio(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### DAR BAJA A SOCIO ###");
                Console.WriteLine();
                Console.WriteLine("Ingrese el dni del socio: ");
                int dni = int.Parse(Console.ReadLine());
                bool socioEncontrado=false;
                int i = 0;
                while (i < biblioteca.Socios.Count && !socioEncontrado)
                {
                    Socio socioActual = (Socio)biblioteca.Socios[i]; //Casteo de conversion de objetos. de objeto lista biblioteca o socio 
                  if (socioActual.Dni == dni)
                    {
                        socioEncontrado = true;
                        if (socioActual.LibroPrestado!= null )
                        {
                            Console.WriteLine("El socio tiene libro pendientes a devolver y no puede darse de baja");
                        }
                        else
                        {
                            biblioteca.EliminarSocio(socioActual);
                            Console.WriteLine();
                            Console.WriteLine("¡¡¡ Socio dado de baja exitosamente !!!");
                            Console.WriteLine();
                        }
                    }
                    i++;
                }
                if (!socioEncontrado)
                {
                    Console.WriteLine();
                    Console.WriteLine("¡¡¡ No hay ningún socio asociado con ese DNI !!!");
                    Console.WriteLine();
                 }
                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }
            
            static void CantidadLibros(Biblioteca biblioteca)
            {
                int librosPrestados = 0;
                int librosDisponibles = 0;
                int i = 0;

                while (i < biblioteca.Libros.Count)
                {
                    Libro libro = (Libro)biblioteca.Libros[i]; // Casteo de conversión de objeto
                    if (libro.Estado == true) // Si el libro está disponible, sumamos 1 a la lista de disponible
                    {
                        librosDisponibles++;
                    }
                    else
                    {
                        librosPrestados++;
                    }
                    i++;
                }

                Console.WriteLine("cantidad de libros disponibles:" + librosDisponibles);
                Console.WriteLine("cantidad de libros prestados:" + librosPrestados);
                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void CantidadSocios(Biblioteca biblioteca)
            {
                int socios = 0;
                int sociosLectores = 0;
                int i = 0;
                while (i < biblioteca.Socios.Count)
                {
                    if (biblioteca.Socios[i] is SocioLector){
                        sociosLectores++;
                    }
                    else if (biblioteca.Socios[i] is Socio)
                    {
                        socios++;
                    }
                    i++;
                }
                Console.WriteLine("cantidad de Socios: " + socios);
                Console.WriteLine("Cantidad Socio Lector: " + sociosLectores);
                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void ExisteLibro(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### VERIFICAR EXISTENCIA Y DISPONIBILIDAD DE LIBRO ###");
                Console.WriteLine();
                Console.WriteLine("ingrese el título del libro: ");
                string tituloLibro=Console.ReadLine();
                bool libroEncontrado = false;
                //Buscar el libro por titulo
                int i = 0;
                while (i < biblioteca.Libros.Count)
                {
                    Libro libro= (Libro)biblioteca.Libros[i];
                    if(libro.Titulo.Equals(tituloLibro, StringComparison.OrdinalIgnoreCase))
                    {
                        libroEncontrado = true;
                        if (libro.Estado == true)
                        {
                            Console.WriteLine("El libro se encuentra en la Biblioteca y se Encuentra Disponible" + "\nCodigo de Libro: " + libro.Codigo);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El libro se encuentra pero esta de prestamo por un socio " + "\nCodigo de Libro: " + libro.Codigo + "\nDNI socio: " + libro.DniSocio);
                        }
                    }
                     i++;
                }
                if (!libroEncontrado)
                {
                    Console.WriteLine("El libro no existe en la Biblioteca");
                }

                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void ExisteSocio(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("## VERIFICAR EXISTENCIA DE SOCIO ##");
                Console.WriteLine();
                Console.WriteLine("Ingrese DNI de socio a verificar: ");
                int dni=int.Parse(Console.ReadLine());
                bool socioEncontrado= false;
                int i = 0;
                //busca el socio por DNI
                while(i < biblioteca.Socios.Count)
                {
                    Socio socio = (Socio)biblioteca.Socios[i];
                    if (socio.Dni == dni)
                    {
                        socioEncontrado = true;
                        if(socio is SocioLector)
                        {
                            Console.WriteLine("El socio con DNI: " + dni + ", es un Socio Lector.");
                        }
                        else
                        {
                            Console.WriteLine("El socio con DNI: " + dni + ", es un Socio." );
                        }
                        break;
                    }
                    i++;
                }
                if (!socioEncontrado)
                {
                    Console.WriteLine("No existe ningun Socio asociado con ese DNI.");
                }
                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }
            
            static void VerLibro(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### INFORMACION DEL LIBRO ###");
                Console.WriteLine();
                Console.WriteLine("ingrese el código del libro: ");
                int codigoLibro= int.Parse(Console.ReadLine());

                Libro libroEncontrado = null;
                int i = 0;
                while(i< biblioteca.Libros.Count)
                {
                    Libro libro= (Libro)biblioteca.Libros[i];
                    if(libro.Codigo == codigoLibro)
                    {
                        libroEncontrado = libro;
                        break;
                    }
                    i++;
                }
                if (libroEncontrado == null) //No encontro el libro
                {
                    Console.WriteLine("El Codigo es incorrecto o no existe en la Biblioteca");
                }
                else // si encontro el libro y muestra la informacion
                {
                    Console.WriteLine("Código: " + libroEncontrado.Codigo + "\nTítulo: " + libroEncontrado.Titulo + "\nAutor: " + libroEncontrado.Autor + "\nEditorial: " + libroEncontrado.Editorial + "\nEstado: " + libroEncontrado.Estado);
                    if (libroEncontrado.Estado == false)
                    {
                        Console.WriteLine("DNI del Socio:" + libroEncontrado.DniSocio + "\nFecha de prestamo:" + libroEncontrado.FechaPrestamo + "\nFecha de devolucion: " + libroEncontrado.FechaDevolucion);
                    }
                }

                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void VerSocio(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("## INFORMACION DEL SOCIO ##");
                Console.WriteLine();
                Console.Write("Ingrese el DNI del Socio: ");
                int dni = int.Parse(Console.ReadLine());
                Socio socioEncontrado = null;
                int i = 0;

                // Compara y busca el dni ingresado con el de todos los socios
                while (i < biblioteca.Socios.Count)
                {
                    Socio socio = (Socio)biblioteca.Socios[i];
                    if (socio.Dni == dni)
                    {
                        socioEncontrado = socio;
                        break;
                    }
                    i++;
                }

                if (socioEncontrado == null)
                {
                    Console.WriteLine("El dni ingresado es incorrecto o el socio no existe.");
                }
                else // Muestra toda la información del socio
                {
                    Console.WriteLine("Nombre y apellido: " + socioEncontrado.NombreApellido +
                                      "\nDNI: " + socioEncontrado.Dni +
                                      "\nTelefono: " + socioEncontrado.Telefono +
                                      "\nDireccion: " + socioEncontrado.Direccion +
                                      "\nCantidad de libros que pidió: " + socioEncontrado.CantLibrosPrestado);

                    if (socioEncontrado is SocioLector socioLector)
                    {
                        Console.WriteLine("Tipo de Socio: Socio Lector");
                        Console.WriteLine("Libros En prestamo:");
                        int j = 0;
                        while (j < socioLector.LibrosPedidos.Count)
                        {
                            Libro libro = (Libro)socioLector.LibrosPedidos[j];
                            Console.WriteLine("- " + libro.Titulo + " por " + libro.Autor);
                            j++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tipo de socio: Socio");
                        if (socioEncontrado.LibroPrestado != null && !socioEncontrado.LibroPrestado.Estado)
                        {
                            Console.WriteLine("Libro En prestamo: " + socioEncontrado.LibroPrestado.Titulo);
                        }
                        else
                        {
                            Console.WriteLine("Libro En prestamo: Ninguno");
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para volver al menú...");
                Console.ReadKey();
                MenuPrincipal(biblioteca);
            }

            static void TodosLibros(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### LISTA DE TODOS LOS LIBROS ###");
                Console.WriteLine();

                int i = 0;
                while (i < biblioteca.Libros.Count)
                {
                    Libro libro = (Libro)biblioteca.Libros[i];
                    Console.WriteLine("Código: " + libro.Codigo + "\nTítulo: " + libro.Titulo + "\nAutor: " + libro.Autor + "\nEditorial: " + libro.Editorial + "\nEstado: " + (libro.Estado ? "Disponible" : "Prestado") +
                                      (libro.Estado ? "" : "\nDNI del socio: " + libro.DniSocio + "\nFecha de retiro: " + libro.FechaPrestamo.ToShortDateString()));
                    Console.WriteLine("-------------------------------");
                    i++;
                }

                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void TodosSocios(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### LISTA DE TODOS LOS SOCIOS ###");
                Console.WriteLine();

                int i = 0;
                while (i < biblioteca.Socios.Count)
                {
                    Socio socio = (Socio)biblioteca.Socios[i];
                    Console.WriteLine("Nombre y apellido: " + socio.NombreApellido + "\nDNI: " + socio.Dni + "\nTeléfono: " + socio.Telefono + "\nDirección: " + socio.Direccion + "\nCantidad de libros que pidió: " + socio.CantLibrosPrestado);

                    if (socio is SocioLector socioLector)
                    {
                        Console.WriteLine("Tipo de Socio: Socio Lector");
                        Console.WriteLine("Libros prestados:");
                        int j = 0;
                        while (j < socioLector.LibrosPedidos.Count)
                        {
                            Libro libro = (Libro)socioLector.LibrosPedidos[j];
                            Console.WriteLine("- " + libro.Titulo + " por " + libro.Autor);
                            j++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tipo de Socio: Socio");
                        if (socio.LibroPrestado != null)
                        {
                            Console.WriteLine("Libro prestado: " + socio.LibroPrestado.Titulo);
                        }
                        else
                        {
                            Console.WriteLine("Libro prestado: Ninguno");
                        }
                    }
                    Console.WriteLine("-------------------------------");
                    i++;
                }

                volviendoAlMenuPrincipal();
                Console.WriteLine();
                MenuPrincipal(biblioteca);
            }

            static void PrestarLibro(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### PRESTAR LIBRO ###");
                Console.WriteLine();
                Console.Write("Ingrese el código del libro: ");
                int codigoLibro = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el DNI del socio: ");
                int dniSocio = int.Parse(Console.ReadLine());

                // Buscar el libro en la biblioteca
                Libro libroEncontrado = null;
                for (int i = 0; i < biblioteca.Libros.Count; i++)
                {
                    Libro libro = (Libro)biblioteca.Libros[i];
                    if (libro.Codigo == codigoLibro && libro.Estado == true) // Verifica que el libro existe y esté disponible
                    {
                        libroEncontrado = libro;
                        break; // Sale del ciclo cuando encuentra el libro
                    }
                }

                if (libroEncontrado == null)
                {
                    Console.WriteLine("El libro no está disponible o no existe en la biblioteca.");
                    volviendoAlMenuPrincipal();
                    return;
                }

                bool socioEncontrado = false;
                for (int l = 0; l < biblioteca.Socios.Count; l++)
                {
                    Socio socio = (Socio)biblioteca.Socios[l];
                    if (socio.Dni == dniSocio)
                    {
                        socioEncontrado = true;

                        // Manejo del tipo Socio común
                        if (socio is Socio socioComun)
                        {
                            if (socioComun.LibroPrestado == null || socioComun.LibroPrestado.Estado == false)
                            {
                                socioComun.CantLibrosPrestado++;
                                socioComun.LibroPrestado = libroEncontrado;
                                libroEncontrado.Estado = false;
                                libroEncontrado.DniSocio = dniSocio;
                                libroEncontrado.FechaPrestamo = DateTime.Now;
                                libroEncontrado.FechaDevolucion = DateTime.Now.AddDays(15);
                                Console.WriteLine("Libro prestado exitosamente al Socio.");
                            }
                            else
                            {
                                Console.WriteLine("El socio ya tiene un libro prestado y no puede tomar otro.");
                            }
                        }
                        // Manejo del tipo SocioLector
                        else if (socio is SocioLector socioLector)
                        {
                            if (!socioLector.existeLibro(libroEncontrado))
                            {
                                socioLector.agregarLibro(libroEncontrado);
                                libroEncontrado.Estado = false;
                                libroEncontrado.DniSocio = dniSocio;
                                libroEncontrado.FechaPrestamo = DateTime.Now;
                                socioLector.CantLibrosPrestado++;
                                Console.WriteLine("Libro prestado exitosamente al Socio Lector.");
                            }
                            else
                            {
                                Console.WriteLine("El socio ya tiene este libro prestado.");
                            }
                        }
                        volviendoAlMenuPrincipal();
                        break;
                    }
                }

                if (!socioEncontrado)
                {
                    Console.WriteLine("No existe un Socio con ese DNI.");
                    volviendoAlMenuPrincipal();
                }
            }

            static void DevolverLibro(Biblioteca biblioteca)
            {
                Console.WriteLine();
                Console.WriteLine("### DEVOLVER LIBRO ###");
                Console.WriteLine();
                Console.Write("Ingrese el código del libro: ");
                int codigoLibro = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el DNI del socio: ");
                int dniSocio = int.Parse(Console.ReadLine());

                // Buscar el libro en la biblioteca
                Libro libroEncontrado = null;
                for (int i = 0; i < biblioteca.Libros.Count; i++)
                {
                    Libro libro = (Libro)biblioteca.Libros[i];
                    if (libro.Codigo == codigoLibro && libro.DniSocio == dniSocio)
                    {
                        libroEncontrado = libro;
                        break;
                    }
                }

                if (libroEncontrado == null)
                {
                    Console.WriteLine("El libro no está prestado por el socio o no existe en la biblioteca.");
                    volviendoAlMenuPrincipal();
                    return;
                }

                // Buscar al socio en la biblioteca
                Socio socioEncontrado = null;
                for (int i = 0; i < biblioteca.Socios.Count; i++)
                {
                    Socio socio = (Socio)biblioteca.Socios[i];
                    if (socio.Dni == dniSocio)
                    {
                        socioEncontrado = socio;
                        break;
                    }
                }

                if (socioEncontrado == null)
                {
                    Console.WriteLine("No existe ningún socio asociado con ese DNI.");
                    volviendoAlMenuPrincipal();
                    return;
                }

                // Verificar y devolver el libro
                if (socioEncontrado.GetType() == typeof(SocioLector))
                {
                    SocioLector socioLector = (SocioLector)socioEncontrado;
                    if (socioLector.existeLibro(libroEncontrado))
                    {
                        socioLector.eliminarLibro(libroEncontrado); // Se elimina del arraylist
                        Console.WriteLine("Libro devuelto exitosamente por el Socio Lector.");
                    }
                    else
                    {
                        Console.WriteLine("El libro no se encontró en la lista de libros prestados por el Socio Lector.");
                        volviendoAlMenuPrincipal();
                        return;
                    }
                }
                else if (socioEncontrado.LibroPrestado != null && socioEncontrado.LibroPrestado.Codigo == codigoLibro)
                {
                    if (socioEncontrado.CantLibrosPrestado > 0) {
                        socioEncontrado.CantLibrosPrestado--;
                    }
                    Console.WriteLine("Libro devuelto exitosamente por el Socio.");
                }
                else
                {
                    Console.WriteLine("El socio no tiene ese libro prestado.");
                    volviendoAlMenuPrincipal();
                    return;
                }

                // Restablecer el estado del libro
                libroEncontrado.Estado = true;
                libroEncontrado.DniSocio = 0;
                libroEncontrado.FechaPrestamo = DateTime.MinValue;
                libroEncontrado.FechaDevolucion = DateTime.MinValue;

                volviendoAlMenuPrincipal();
            }





            
            //función para dar efecto de carga
            static void volviendoAlMenuPrincipal()
            {
                Console.Write("Volviendo al menú principal");
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                
            }


        }
    }
}


