using System;

namespace BibliotecaTPAYP
{
    public class Libro
    {
        // atributos
        private string titulo, autor, editorial;
        private bool estado=true;
        private int dniSocio, codigoLibro;
        private static int contadorCodigo = 1;
        private DateTime fechaPrestamo, fechaDevolucion;

        // constructores
        public Libro( string titulo, string autor,string editorial){
            this.codigoLibro=contadorCodigo++;
            this.titulo=titulo;
            this.autor=autor;
            this.editorial=editorial;
            this.estado=true;
            /*this.dniSocio=dniSocio;
            this.fechaPrestamo=fechaPrestamo;
            this.fechaDevolucion=fechaDevolucion;*/
        }


        // propiedades
        public int Codigo{
            get{return this.codigoLibro;}
            set{this.codigoLibro = value;}
        }
        public string Titulo{
            get{return this.titulo;}
            set{this.titulo = value;}
        }
        public string Autor{
            get{return this.autor;}
            set{this.autor = value;}
        }
        public string Editorial{
            get{return this.editorial;}
            set{this.editorial = value;}
        }
        public bool Estado{
            get{return this.estado;}
            set{this.estado = value;}
        }
        public int DniSocio{
            get{return this.dniSocio;}
            set{this.dniSocio = value;}
        }
        public DateTime FechaPrestamo{
            get{return this.fechaPrestamo;}
            set{this.fechaPrestamo = value;}
        }
        public DateTime FechaDevolucion{
            get{return this.fechaDevolucion;}
            set{this.fechaDevolucion= value;}
        }
    }
}