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
        public void AgregarLibro(Libro libro){
            libros.Add(libro);
        }

        public void EliminarLibro(Libro libro){
            libros.Remove(libro);
        }

        public int CantidadLibros(){
            return libros.Count;
        }

        public bool ExisteLibro(Libro libro){
            return libros.Contains(libro);
        }

        public Libro VerLibro(int i){
            return (Libro)libros[i];
        }

        public ArrayList TodosLibros(){
            return libros;
        }




        //métodos para socio
         public void AgregarSocio(Socio socio){
            socios.Add(socio);
        }

        public void EliminarSocio(Socio socio){
            socios.Remove(socio);
        }

        public int CantidadSocios(){
            return socios.Count;
        }

        public bool ExisteSocio(Socio socio){
            return socios.Contains(socio);
        }

        public Socio VerSocio(int i){
            return (Socio)socios[i];
        }

        public ArrayList TodosSocios(){
            return socios;
        }
    }

}