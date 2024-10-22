using System;

namespace BibliotecaTPAYP
{
    public class Socio
    {
        // atributos
        protected string nombreApellido, direccion;
        protected int dni, telefono, cantLibrosPrestado;
        private Libro libroPrestado;


        // constructores
        public Socio(string nombreApellido, int dni, int telefono, string direccion, int cantLibrosPrestado)
        {
            this.nombreApellido = nombreApellido;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.cantLibrosPrestado = cantLibrosPrestado;
            this.libroPrestado = libroPrestado;
        }

        // propiedades
        public string NombreApellido
        {
            get { return this.nombreApellido; }
            set { this.nombreApellido = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public int Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public int CantLibrosPrestado
        {
            get { return this.cantLibrosPrestado; }
            set { this.cantLibrosPrestado = value; }
        }
        public Libro LibroPrestado
        {
            get { return this.libroPrestado; }
            set { this.libroPrestado = value; }
        }
        // Método para prestar un libro
        public void PrestarLibro(Libro libro)
        {
            this.libroPrestado = libro;
            this.cantLibrosPrestado++;

        }
        public void DevolverLibro()
        {
            this.libroPrestado = null;
            this.cantLibrosPrestado--;
        }
    }
}