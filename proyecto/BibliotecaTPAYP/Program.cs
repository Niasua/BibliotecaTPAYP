using System;
using System.Threading.Tasks.Dataflow;

namespace BibliotecaTPAYP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creación de libros para aplicación
            Libro libro1 = new Libro(1, "El Principito", "Antoine de Saint-Exupéry", "Salamandra", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro2 = new Libro(2, "1984", "George Orwell", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro3 = new Libro(3, "Matar a un ruiseñor", "Harper Lee", "J.B. Lippincott & Co.", false, 20123456, new DateTime(2024, 9, 6), new DateTime(2024, 9, 15));
            Libro libro4 = new Libro(4, "El Gran Gatsby", "F. Scott Fitzgerald", "Scribner", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro5 = new Libro(5, "Orgullo y Prejuicio", "Jane Austen", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro6 = new Libro(6, "Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana", false, 30123457, new DateTime(2024, 9, 20), new DateTime(2024, 10, 5));
            Libro libro7 = new Libro(7, "Crimen y Castigo", "Fiódor Dostoyevski", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro8 = new Libro(8, "Rayuela", "Julio Cortázar", "Sudamericana", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro9 = new Libro(9, "Don Quijote de la Mancha", "Miguel de Cervantes", "Castalia", false, 40123458, new DateTime(2024, 9, 25), new DateTime(2024, 10, 10));
            Libro libro10 = new Libro(0, "La Odisea", "Homero", "Alianza", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro11 = new Libro(11, "La Casa de los Espíritus", "Isabel Allende", "Plaza & Janés", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro12 = new Libro(12, "El Amor en los Tiempos del Cólera", "Gabriel García Márquez", "Sudamericana", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro13 = new Libro(13, "Los Miserables", "Victor Hugo", "Penguin", false, 50123459, new DateTime(2024, 10, 3), new DateTime(2024, 10, 20));
            Libro libro14 = new Libro(14, "Drácula", "Bram Stoker", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro15 = new Libro(15, "La Metamorfosis", "Franz Kafka", "Debolsillo", false, 60123450, new DateTime(2024, 10, 1), new DateTime(2024, 10, 2));

            //creación de Socios
            Socio socio1 = new Socio("Juan Pérez", 20123456, 987654321, "Calle Rodriguez", 1);
            Socio socio2 = new Socio("Ana López", 30123457, 123456789, "Av. Corrientes 456", 1);
            Socio socio3 = new Socio("María García", 40123458, 234567890, "Calle Sol 789", 0);
            Socio socio4 = new Socio("Emilse Brizuela", 50123459, 345678901, "Av. Libertad 101", 1);
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
            biblioteca.agregarLibro(libro1);
            biblioteca.agregarLibro(libro2);
            biblioteca.agregarLibro(libro3);
            biblioteca.agregarLibro(libro4);
            biblioteca.agregarLibro(libro5);
            biblioteca.agregarLibro(libro6);
            biblioteca.agregarLibro(libro7);
            biblioteca.agregarLibro(libro8);
            biblioteca.agregarLibro(libro9);
            biblioteca.agregarLibro(libro10);
            biblioteca.agregarLibro(libro11);
            biblioteca.agregarLibro(libro12);
            biblioteca.agregarLibro(libro13);
            biblioteca.agregarLibro(libro14);
            biblioteca.agregarLibro(libro15);

            //agregar socios a Biblioteca
            biblioteca.agregarSocio(socio1);
            biblioteca.agregarSocio(socio2);
            biblioteca.agregarSocio(socio3);
            biblioteca.agregarSocio(socio4);
            biblioteca.agregarSocio(socio5);
            biblioteca.agregarSocio(socio6);
            biblioteca.agregarSocio(socio7);
            biblioteca.agregarSocio(socio8);
            biblioteca.agregarSocio(socio9);
            biblioteca.agregarSocio(socio10);
            biblioteca.agregarSocio(socio11);
            biblioteca.agregarSocio(socio12);
            biblioteca.agregarSocio(socio13);
            biblioteca.agregarSocio(socio14);
            biblioteca.agregarSocio(socio15);
            
            
            //se muestra el menú principal, se pide opción, y dependiendo la opción elegida se hacen
            //invocaciones a funciones que realizan las tareas pedidas
            menuPrincipal();
            int opcion = int.Parse(Console.ReadLine());
            while(opcion!=0){
                switch(opcion){
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
                }

                menuPrincipal();
                opcion = int.Parse(Console.ReadLine());
            }


        }

        static void menuPrincipal(){
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("*****                      SISTEMA BIBLIOTECA                            ******");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("\nSeleccione una opción del menu:\n\n");
			Console.WriteLine("1. Agregar libro\n2. Eliminar libro\n3. Dar ALTA socio/socio-lector\n4. Dar BAJA socio/socio-lector\n5. Prestar libro\n6. Devolver libro\n7. Submenú de impresión\n0. Salir");
            Console.WriteLine();
        }

        static void agregarLibro(Biblioteca biblioteca){
            //cuatro variables definidas suponiendo que el libro está disponible
            bool libroDisponible = true;
            int dniSocio = 0;
            DateTime fechaPrestamo = DateTime.MinValue;
            DateTime fechaDevolucion= DateTime.MinValue;
            //obtener el código del nuevo libro, sumando uno al último libro en la lista de biblioteca
            Libro ultimoLibro = (Libro)biblioteca.Libros[biblioteca.Libros.Count-1];
            int ultimoCodigo = ultimoLibro.Codigo;
            int codigoLibro = ultimoCodigo++;

            //preguntas al usuario
            Console.WriteLine();
            Console.WriteLine("### AGREGAR LIBRO ###");
            Console.Write("Ingrese el título del libro: ");
            string tituloLibro = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            string autorLibro = Console.ReadLine();
            Console.Write("Ingrese la editorial del libro: ");
            string editorialLibro = Console.ReadLine();
            Console.Write("¿Está disponible?: ");
            string preguntaDisponibilidad = Console.ReadLine();
            
            //asegurarse que ingrese "si" o "no"
            while(!preguntaDisponibilidad.ToLower().Equals("si") && !preguntaDisponibilidad.ToLower().Equals("no") ){
                Console.WriteLine("Ingrese 'si' o 'no'");
                Console.Write("¿Está disponible?: ");
                preguntaDisponibilidad = Console.ReadLine();
            } 
            // estableciendo la disponibilidad del libro
            if(preguntaDisponibilidad.ToLower().Equals("si")){
                libroDisponible = false;
            } else if (preguntaDisponibilidad.ToLower().Equals("no")){
                libroDisponible = true;
            }
            //si el libro no está disponible, entonces se llena con los datos del socio que lo posee
            if (!libroDisponible)
            {
                Console.Write("Ingrese dni del socio: ");
                dniSocio = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el año del préstamo: ");
                int añoPrestamo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el mes del préstamo (1-12): ");
                int mesPrestamo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el dia del préstamo: ");
                int diaPrestamo = int.Parse(Console.ReadLine());
                fechaPrestamo = new DateTime(añoPrestamo, mesPrestamo, diaPrestamo);
                Console.Write("Ingrese el año de la devolución: "); 
                int añoDevolucion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el mes del devolución (1-12): ");
                int mesDevolucion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el dia de la devolución: ");
                int diaDevolucion = int.Parse(Console.ReadLine());
                fechaDevolucion = new DateTime(añoDevolucion, mesDevolucion, diaDevolucion);

                //verificar que la fecha de devolución sea mayor que la de préstamo
                while(fechaPrestamo>fechaDevolucion){
                    Console.WriteLine("¡¡¡ La fecha de devolución debe ser mayor a la fecha de préstamo !!!");
                    Console.Write("Vuelva a ingresar la fecha de devolución (AAAA/M/D): ");
                    fechaDevolucion = DateTime.Parse(Console.ReadLine());
                }
            }
            //creación de libro para guardar en Biblioteca
            Libro libro = new Libro(codigoLibro, tituloLibro, autorLibro, editorialLibro, libroDisponible, dniSocio, fechaPrestamo, fechaDevolucion);
            //guardado de libro en biblioteca
            biblioteca.agregarLibro(libro);      
            Console.WriteLine();
            Console.WriteLine("¡¡¡ Libro agregado exitosamente !!!");
            Console.WriteLine();
            volviendoAlMenuPrincipal();


        }

        static void eliminarLibro(Biblioteca biblioteca){
            Console.WriteLine();
            Console.WriteLine("### ELIMINAR LIBRO ###");
            Console.Write("Ingrese el código del libro a eliminar: ");
            int codigoLibro = int.Parse(Console.ReadLine());
            Libro libroAEliminar = biblioteca.verLibro(codigoLibro-1); //los código de libro arrancan de 1
            if(!libroAEliminar.Estado){
                Console.WriteLine("¡¡¡ Ese libro se encuentra prestado !!!");
            } else {
                biblioteca.eliminarLibro(libroAEliminar);
            }
            Console.WriteLine();
            Console.WriteLine("¡¡¡ Libro eliminado exitosamente !!!");
            Console.WriteLine();
            volviendoAlMenuPrincipal();
            
        }
        
        static void altaSocio(Biblioteca biblioteca){
            Console.WriteLine();
            Console.WriteLine("### DAR ALTA A SOCIO ###");
            Console.WriteLine("1. Socio");
            Console.WriteLine("2. Socio-lector");
            Console.WriteLine();
            Console.WriteLine("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion == 1){
                Console.Write("Ingrese nombre completo del socio: ");
                string nombreApellido = Console.ReadLine();
                Console.Write("Ingrese dni del socio: ");
                int dni = int.Parse(Console.ReadLine());
                //recorrer la lista de socios de la biblioteca para verificar
                //que no se repita el DNI
                foreach (Socio s in biblioteca.Socios)
                {
                    if(s.Dni == dni)
                    {
                        Console.WriteLine("Ya hay un socio registrado con ese dni");
                        break;
                    }
                }
                Console.Write("Ingrese el teléfono del socio: ");
                int telefono = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la dirección del socio: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese la cantidad de libros que el socio posee actualmente: ");
                int cantidadLibros = int.Parse(Console.ReadLine());

                Socio socio = new Socio(nombreApellido, dni, telefono, direccion, cantidadLibros);

                biblioteca.agregarSocio(socio);
            } else if (opcion == 2){
                Console.Write("Ingrese nombre completo del socio-lector: ");
                string nombreApellido = Console.ReadLine();
                Console.Write("Ingrese dni del socio-lector: ");
                int dni = int.Parse(Console.ReadLine());
                foreach (SocioLector sl in biblioteca.Socios)
                {
                    if(sl.Dni == dni)
                    {
                        Console.WriteLine("Ya hay un socio registrado con ese dni");
                        volviendoAlMenuPrincipal();
                        break;
                    }
                }
                Console.Write("Ingrese el teléfono del socio-lector: ");
                int telefono = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la dirección del socio-lector: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese la cantidad de libros que el socio-lector posee actualmente: ");
                int cantidadLibros = int.Parse(Console.ReadLine());

                SocioLector socioLector = new SocioLector(nombreApellido, dni, telefono, direccion, cantidadLibros);

                biblioteca.agregarSocio(socioLector);
            }
            Console.WriteLine();
            Console.WriteLine("¡¡¡ Socio dado de alta exitosamente !!!");
            Console.WriteLine();
            volviendoAlMenuPrincipal();
        }

        static void bajaSocio(Biblioteca biblioteca){
            Console.WriteLine();
            Console.WriteLine("### DAR BAJA A SOCIO ###");
            Console.WriteLine();
            Console.WriteLine("Ingrese el dni del socio: ");
            int dni = int.Parse(Console.ReadLine());
            foreach (Socio s in biblioteca.Socios)
            {
                if (s.Dni == dni)
                {
                    biblioteca.eliminarSocio(s);
                    Console.WriteLine();
                    Console.WriteLine("¡¡¡ Socio dado de baja exitosamente !!!");
                    Console.WriteLine();
                    volviendoAlMenuPrincipal(); 
                    break;                
                }
            }
                    Console.WriteLine();
                    Console.WriteLine("¡¡¡ No hay ningún socio asociado con ese DNI !!!");
                    Console.WriteLine();
                    volviendoAlMenuPrincipal(); 

        }

        //función para dar efecto de carga
        static void volviendoAlMenuPrincipal(){
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


