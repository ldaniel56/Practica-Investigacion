using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"¿Esta seguro de salir?","Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int CantidadAlumnos, nota, i;
            Double Promedio = 0;
            CantidadAlumnos = Convert.ToInt32(txtAlumnos.Text);

            //Implementar el bucle for
            for (i = 1; i <= CantidadAlumnos; i++)
            {
                //Leer la nota del alumno 
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nota del alumno: "+i,"Registro Nota"));
                }
                while (nota < 0 || nota > 10);
                // Calcular el promedio
                Promedio = Promedio + nota;
            }
            txtPromedio.Text = Convert.ToString(Promedio / CantidadAlumnos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtAlumnos.Clear();
            txtPromedio.Clear();
            txtAlumnos.Focus();
            return;
        }

        private void txtAlumnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
