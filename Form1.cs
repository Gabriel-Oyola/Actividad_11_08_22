using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_11_08_22
{
    public partial class Form1 : Form
    {
        Persona persona;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btPersona_Click(object sender, EventArgs e)
        {
             
            string nombre = txt_Nombre.Text;
            long Dni = long.Parse(txtDni.Text);
            DateTime Fecha = DateTime.Parse(txtFecha.Text);

            persona = new Persona(nombre, Dni, Fecha);


        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        

        private void txtFecha_Validated(object sender, EventArgs e)
        {
            DateTime ValidarFecha = DateTime.Parse(txtFecha.Text);
            DateTime dateTime = DateTime.Now;
            if (ValidarFecha > dateTime)
            {
                MessageBox.Show("La fecha de nacimiento es invalida");
            }
        }

        private void btEdad_Click(object sender, EventArgs e)
        { 
             persona = new Persona();

            DateTime fecha = DateTime.Parse(txtFecha.Text);


            int año = fecha.Year; 

            lblEdad.Text = "Edad: "+persona.Edad(año).ToString();
             
        }
    }
}
