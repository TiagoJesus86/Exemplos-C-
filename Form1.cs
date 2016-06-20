using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo arquivo = new FileInfo(@"C:\CCharp\arquivo.txt");
            FileStream fs = arquivo.Create();
            MessageBox.Show("Criado data e hora: "+arquivo.CreationTime);
            MessageBox.Show("Atributos "+arquivo.Attributes.ToString());
            MessageBox.Show("nome completo " + arquivo.FullName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\CCharp\arquivo.txt",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Mostrando o uso de arquivos");
            sw.WriteLine("Nas videoaulas do Neri");
            //sw.WriteLine(rtb_texto.Text);
            sw.Close(); //grava e fecha

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\CCharp\arquivo.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string texto = sr.ReadToEnd();
            rtb_texto.Text = texto;           
            sr.Close(); //grava e fecha

        }
        // sugestao:
        //Métodos CreateText() e OpenText()
    }
}
