using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_11_08_22
{
    public  class Persona
    {
        private string Nombre; 
        private int DNI;
        private DateTime FechaNacimiento;

        

        public Persona()
        {

        }

        public Persona(string nombre, int Dni, DateTime fecha)
        {
            Nombre = nombre; 
            DNI = Dni; 
            FechaNacimiento = fecha;  

            
        }

       public string PNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        } 

        public int PDni
        {
            set { PDni = value; }
            get { return DNI;}  
        }

        
        public DateTime pFechaNacimiento
        {
            set { FechaNacimiento = value; }
            get { return FechaNacimiento; }
        }
       
        public int Edad(int AñoN ) 
        {
         
            DateTime dateTime = DateTime.Today;
            int Edad =  dateTime.Year - AñoN ;

            return Edad; 
        }

    }
}
