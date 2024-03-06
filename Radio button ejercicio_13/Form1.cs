using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_button_ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            
            string asignatura = txt_Asignatura.Text;
            string profesor = txt_Profesor.Text;
            string modalidad = ObtenerModalidad();

            
            string mensaje = $"Asignatura: {asignatura}\nProfesor: {profesor}\nModalidad: {modalidad}";
            MessageBox.Show(mensaje, "Información de la Asignatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private string ObtenerModalidad()
        {
            if (rb_Virtual.Checked)
            {
                return "Virtual";
            }
            else if (rb_Presencial.Checked)
            {
                return "Presencial";
            }
            else
            {
                return "No especificada";
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Asignatura.Clear();
            txt_Profesor.Clear();
            
        }
    }
}
