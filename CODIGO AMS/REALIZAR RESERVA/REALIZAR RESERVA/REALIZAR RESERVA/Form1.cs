using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace REALIZAR_RESERVA
{
    public partial class Form1 : Form
    {
        private DateTime startDate;
        private DateTime endDate;
        public Form1()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            startDate = dateTimePicker1.Value;
            endDate = dateTimePicker2.Value;

            MessageBox.Show($"Reserva agendada entre {startDate.ToShortDateString()} e {endDate.ToShortDateString()}");
            MessageBox.Show("A reserva está a ser analisada.", "Análise em andamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            button8.Visible = false;
            button7.Visible=true;

            
        }
    }
}
