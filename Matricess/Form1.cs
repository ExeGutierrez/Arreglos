using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] DiasSemana = new string[7];
        int i = 0;
        private void btListar_Click(object sender, EventArgs e)
        {
            //string [] DiasSemana = new string[7];
            // string[] DiaSemana = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};
            //string[] DiasSemana = new string[7];
            //DiasSemana[0] = "Lunes";
            //DiasSemana[1] = "Martes";
            //DiasSemana[2] = "Miercoles";
            //DiasSemana[3] = "Jueves";
            //DiasSemana[4] = "Viernes";
            //DiasSemana[5] = "Sabado";
            //DiasSemana[6] = "Domingo";

            lblSalida.Text = "";
            foreach (string dia in DiasSemana)
            {
                lblSalida.Text = lblSalida.Text + dia  + "\r\n";


            }
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            DiasSemana[i] = txtDia.Text;

            i = i + 1;
        }
    }
}
