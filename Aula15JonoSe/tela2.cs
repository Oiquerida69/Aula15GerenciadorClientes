using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15JonoSe
{
    public partial class tela2 : Form
    {
        public tela2()
        {
            InitializeComponent();
        }
         public void Atualizarinterface()
        {
            listView_Usuarios.Clear();
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                listView_Usuarios.Items.Add($"---{Program.clientes[i].nome} - {Program.clientes[i].idade}");
                
                 
            }
        }

        private void btn_Tela2_Salvar_Click(object sender, EventArgs e)
        {
            string user = txt_Tela2_Usuario.Text;
            string senha = txt_Tela2_Senha.Text;
            string nomeC = Txt_NomeC.Text;
            int Ano = 2023 - int.Parse(txt_Data.Text);
            Usuario usuario = new Usuario(user , senha );
            Cliente cliente = new Cliente(nomeC ,Ano , usuario);
            Program.clientes.Add(cliente);
            Atualizarinterface();
        }

        private void tela2_Load(object sender, EventArgs e)
        {
            Atualizarinterface();
        }
    }
}
