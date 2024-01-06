using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATRIBUIR_CANDIDATURA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            checkedListBox1.Visible = false;
            checkedListBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++)
            {
                checkedListBox1.Items.Add("CANDIDATURAS " + i.ToString());
            }

            for (int i = 1; i <= 15; i++)
            {
                checkedListBox2.Items.Add("GESTOR RESIDÊNCIA " + i.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            checkedListBox1.Visible = false;
            checkedListBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = false;
            checkedListBox1.Visible = true;
            checkedListBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox2.Visible = true;
            button5.Visible = true;
            checkedListBox1.Visible = false;
            button4.Visible = false;

            List<int> indicesSelecionados = new List<int>();


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    indicesSelecionados.Add(i);
                }
            }


            if (indicesSelecionados.Count > 0)
            {
                string mensagem = "CANDIDATURAS ATRIBUÍDAS: ";
                string mensagem1 = "SELECIONE O GESTOR DE RESIDÊNCIA: ";
                foreach (int indice in indicesSelecionados)
                {
                    mensagem += checkedListBox1.Items[indice].ToString() + ", ";
                }

                mensagem = mensagem.TrimEnd(' ', ',');

                MessageBox.Show(mensagem);
                MessageBox.Show(mensagem1);

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> indicesSelecionados = new List<int>();

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    indicesSelecionados.Add(i);
                }
            }

            if (indicesSelecionados.Count != 1)
            {
                MessageBox.Show("SELECIONE APENAS 1 GESTOR DE RESIDÊNCIA.");
                
            }

            if(indicesSelecionados.Count == 1)
            {
                string mensagem = "GESTOR DE RESIDÊNCIA A ATRIBUIR RESERVA/AS: ";
                foreach (int indice in indicesSelecionados)
                {
                    mensagem += checkedListBox2.Items[indice].ToString() + ", ";
                }

                mensagem = mensagem.TrimEnd(' ', ',');

                MessageBox.Show(mensagem);
                Application.Exit();
            }
           

        }
    }
}
