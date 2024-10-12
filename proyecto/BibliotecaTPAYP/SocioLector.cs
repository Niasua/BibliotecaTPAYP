using System;
using System.Collections;

namespace BibliotecaTPAYP
{
    public class SocioLector : Socio
    {
        // atributos
        private ArrayList librosPedidos;

        // constructores
        public SocioLector(string nombreApellido, int dni, int telefono, string direccion,
                        int cantLibrosPrestado) : base(nombreApellido, 
                        dni, telefono, direccion, cantLibrosPrestado)
                {
                    librosPedidos = new ArrayList();
                }


        // propiedades
        public ArrayList LibrosPedidos{
            get{return this.librosPedidos;}
            set{this.librosPedidos=value;}
        }

        //métodos
         public void agregarLibro(Libro libro){
            librosPedidos.Add(libro);
        }

        public void eliminarLibro(Libro libro){
            librosPedidos.Remove(libro);
        }

        public int cantidadLibros(){
            return librosPedidos.Count;
        }

        public bool existeLibro(Libro libro){
            return librosPedidos.Contains(libro);
        }

        public Libro verLibro(int i){
            return (Libro)librosPedidos[i];
        }

        public ArrayList todosLibros(){
            return librosPedidos;
        }
       
    }
}