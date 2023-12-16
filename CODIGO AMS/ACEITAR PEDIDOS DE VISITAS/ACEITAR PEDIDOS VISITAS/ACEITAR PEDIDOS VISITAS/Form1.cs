using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACEITAR_PEDIDOS_VISITAS
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
            checkedListBox1.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 15; i++)
            {
                checkedListBox1.Items.Add("VISITA " + i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            checkedListBox1.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {

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
                string mensagem = "VISITAS ACEITES: ";
                foreach (int indice in indicesSelecionados)
                {
                    mensagem += checkedListBox1.Items[indice].ToString() + ", ";
                }

                mensagem = mensagem.TrimEnd(' ', ',');

                MessageBox.Show(mensagem);
                
            }
            MessageBox.Show("Todos os candidatos aceites serão informados brevemente!!!");
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            
        }

       
    }
}
