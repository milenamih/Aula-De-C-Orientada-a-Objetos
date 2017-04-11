using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grava_Arq_Texto
{
    public partial class gavararqform : Form
    {
        public gavararqform()
        {
            InitializeComponent();
        }
        private void LimparTela()
        {
            NametextBox.Clear();
            EndtextBox.Clear();
            FemradioButton.Checked = false;
            MascradioButton.Checked = false;
            PresencialCheckBox.Checked = false;
            pais.SelectedIndex = -1;
            EstadoCivilComboBox.SelectedIndex = -1;
            NametextBox.Focus();
        }

        private void GravarButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text.Trim() == "")
            {
                MessageBox.Show("Nome é Obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NametextBox.Focus();
                return;
            }
            if (EndtextBox.Text.Trim() == "")
            {
                MessageBox.Show("Endereço Obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EndtextBox.Focus();
                return;
            }

            if (!FemradioButton.Checked && !MascradioButton.Checked)
            {
                MessageBox.Show("Escolha o sexo!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EstadoCivilComboBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Escolha o estado civíl", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EstadoCivilComboBox.Focus();
                //sendkeys.send é um comando da propria aplicação apertar o teclado.
                SendKeys.Send("{F4}");
                return;
            }

            if (pais.SelectedIndex == -1) 
            {
                MessageBox.Show("Escolha o pais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pais.Focus();
                //sendkeys.send é um comando da propria aplicação apertar o teclado.
                SendKeys.Send("{F4}");
                return;
            }
            //um arquivo é um conjunto de registro e cada registro é uma coluna e cada coluna é um dado

           // System.IO.File.WriteAllLines(@"C:\Users\aluno\Documents\mih",);

            string caminho = @"C:\Users\aluno\Documents\mih\clientes.csv";
            string registro =
                string.Format("{0};{1};{2};{3};{4};{5};{6}", NametextBox.Text.ToUpper(),
            EndtextBox.Text.ToUpper(),
            FemradioButton.Checked ? "feminino" : "masculino",
            EstadoCivilComboBox.Text.ToUpper(),
            PresencialCheckBox.Checked ? "sim" : "não",
            pais.Text,
            DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            StreamWriter gravar = new StreamWriter(caminho, true);
            gravar.WriteLine(registro);
            gravar.Close();
            MessageBox.Show("cliente cadastrado com sucesso!!");
                   
            LimparTela();
    
        }

        private void gavararqform_KeyPress(object sender, KeyPressEventArgs e)
        {
            //padrão ascii 27 é o esc do teclado
            if(e.KeyChar==27){
                LimparTela();
            }

        }

        private void UnipLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.unip.br");
            //www.unip.com.br
        }
       
    }
}
