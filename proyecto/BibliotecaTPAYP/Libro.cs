using System;

namespace BibliotecaTPAYP
{
    public class Libro
    {
        // atributos
        private string codigo, titulo, autor, editorial;
        private bool estado;
        private int dniSocio;
        private DateTime fechaPrestamo, fechaDevolucion;

        // constructores
        public Libro(string codigo, string titulo, string autor,string editorial,
         bool estado, int dniSocio, DateTime fechaPrestamo, DateTime fechaDevolucion){
            this.codigo=codigo;
            this.titulo=titulo;
            this.autor=autor;
            this.editorial=editorial;
            this.estado=estado;
            this.dniSocio=dniSocio;
            this.fechaPrestamo=fechaPrestamo;
            this.fechaDevolucion=fechaDevolucion;
        }


        // propiedades
        public string Codigo{
            get{return this.codigo;}
            set{this.codigo = value;}
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