using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explication
{
    public abstract class AutoPadre
    {
        private string marca;
        private int anho;
        private string color;
        private string placa;
        private string concesionario;
        
        public AutoPadre(string marca, int anho, string color, string placa, string concesionario)
        {
            this.marca = marca;
            this.anho = anho;
            this.color = color;
            this.placa = placa;
            this.concesionario = concesionario;
        }
        
        
        public  string Marca{
           get{ return marca; }
           set { marca = value;}
        } 
        
        public int Anho { 
            get {  return anho; } 
            set {  anho = value;} 
        }
        public string Color { 
            get { return color; } 
            set {  color = value; } 
        }
        public string Placa { 
            get {  return placa; } 
            set {  placa = value; } 
        }
        public string Concesionario { 
            get {  return concesionario; } 
            set {  concesionario = value; } 
        }

        // definiendo el metodo abstracto no implementado
        public abstract void Arrancar();

        public abstract void Detener();

       
        public abstract void Gasolina();







    }
}
