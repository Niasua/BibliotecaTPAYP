using System;
using System.Collections;
using System.Net.Http.Headers;

namespace BibliotecaTPAYP
{
    public class Biblioteca
    {
        // atributos
        private string nombre;
        private ArrayList libros;
        private ArrayList socios;


        // constructores
        public Biblioteca(string nombre){
            this.nombre=nombre;
            libros = new ArrayList();
            socios = new ArrayList();
        }


        // propiedades
        public string Nombre{
            get{return this.nombre;}
            set{this.nombre=value;}
        }
        public ArrayList Libros{
            get{return this.libros;}
            set{this.libros=value;}
        }
        public ArrayList Socios{
            get{return this.socios;}
            set{this.socios=value;}
        }

        //métodos para libro
        public void agregarLibro(Libro libro){
            libros.Add(libro);
        }

        public void eliminarLibro(Libro libro){
            libros.Remove(libro);
        }

        public int cantidadLibros(){
            return libros.Count;
        }

        public bool existeLibro(Libro libro){
            return libros.Contains(libro);
        }

        public Libro verLibro(int i){
            return (Libro)libros[i];
        }

        public ArrayList todosLibros(){
            return libros;
        }




        //métodos para socio
         public void agregarSocio(Socio socio){
            socios.Add(socio);
        }

        public void eliminarSocio(Socio socio){
            socios.Remove(socio);
        }

        public int cantidadSocios(){
            return socios.Count;
        }

        public bool existeSocio(Socio socio){
            return socios.Contains(socio);
        }

        public Socio verSocio(int i){
            return (Socio)socios[i];
        }

        public ArrayList todosSocios(){
            return socios;
        }
    }

}