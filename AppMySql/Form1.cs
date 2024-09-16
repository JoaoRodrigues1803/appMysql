using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cmdSql = "insert into aluno (nome,email) values ";
            cmdSql += "('Giullya Minha Esposa','giugiu@gmail.com')";

            int result = Program.cx.INSERT(cmdSql);
            if(result > 0)
            {
                int idAluno = Program.cx.getLastId();
                MessageBox.Show($"ID aluno: {idAluno}");
            }
            else 
            {
                MessageBox.Show($"Erro: {Program.cx.getMsgErro()}");
            }
        }
    }
}
