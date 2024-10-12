using System;

namespace BibliotecaTPAYP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creación de libros para aplicación
            Libro libro1 = new Libro("101", "El Principito", "Antoine de Saint-Exupéry", "Salamandra", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro2 = new Libro("102", "1984", "George Orwell", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro3 = new Libro("103", "Matar a un ruiseñor", "Harper Lee", "J.B. Lippincott & Co.", false, 20123456, new DateTime(2024, 9, 6), new DateTime(2024, 9, 15));
            Libro libro4 = new Libro("104", "El Gran Gatsby", "F. Scott Fitzgerald", "Scribner", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro5 = new Libro("105", "Orgullo y Prejuicio", "Jane Austen", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro6 = new Libro("106", "Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana", false, 30123457, new DateTime(2024, 9, 20), new DateTime(2024, 10, 5));
            Libro libro7 = new Libro("107", "Crimen y Castigo", "Fiódor Dostoyevski", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro8 = new Libro("108", "Rayuela", "Julio Cortázar", "Sudamericana", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro9 = new Libro("109", "Don Quijote de la Mancha", "Miguel de Cervantes", "Castalia", false, 40123458, new DateTime(2024, 9, 25), new DateTime(2024, 10, 10));
            Libro libro10 = new Libro("110", "La Odisea", "Homero", "Alianza", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro11 = new Libro("111", "La Casa de los Espíritus", "Isabel Allende", "Plaza & Janés", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro12 = new Libro("112", "El Amor en los Tiempos del Cólera", "Gabriel García Márquez", "Sudamericana", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro13 = new Libro("113", "Los Miserables", "Victor Hugo", "Penguin", false, 50123459, new DateTime(2024, 10, 3), new DateTime(2024, 10, 20));
            Libro libro14 = new Libro("114", "Drácula", "Bram Stoker", "Penguin", true, 0, DateTime.MinValue, DateTime.MinValue);
            Libro libro15 = new Libro("115", "La Metamorfosis", "Franz Kafka", "Debolsillo", false, 60123450, new DateTime(2024, 10, 1), new DateTime(2024, 10, 2));

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
        }

        static void agregarLibro(Biblioteca biblioteca){
            //tres variables definidas suponiendo que el libro está disponible
            int dniSocio = 0;
            DateTime fechaPrestamo = DateTime.MinValue;
            DateTime fechaDevolucion= DateTime.MinValue;

            //preguntas al usuario
            Console.WriteLine();
            Console.WriteLine("### AGREGAR LIBRO ###");
            Console.Write("Ingrese el código del libro: ");
            string codigoLibro = Console.ReadLine();
            Console.Write("Ingrese el título del libro: ");
            string tituloLibro = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            string autorLibro = Console.ReadLine();
            Console.Write("Ingrese la editorial del libro: ");
            string editorialLibro = Console.ReadLine();
            Console.Write("Está disponible? (True: sí/ False: no): ");
            bool libroDisponible = bool.Parse(Console.ReadLine());

            //si el libro no está disponible, entonces se llena con los datos del socio que lo posee
            if (!libroDisponible)
            {
                Console.Write("Ingrese dni del socio: ");
                dniSocio = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la fecha de préstamo (AAAA/M/D): ");
                fechaPrestamo = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingrese la fecha de devolución (AAAA/M/D): ");
                fechaDevolucion = DateTime.Parse(Console.ReadLine());
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
            
        }

        

    }
}


