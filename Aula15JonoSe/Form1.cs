using System.Reflection.Metadata.Ecma335;

namespace Aula15JonoSe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuário.Text;
            string senha = txt_Senha.Text;
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if (Program.clientes[i].usuario.usuario == usuario && Program.clientes[i].usuario.senha == senha )
                {
                    tela2 tela2 = new tela2();
                    tela2.Show();
                    
                   
                }
                else
                {
                    MessageBox.Show("O usuario ou senha se encontra incorreto" , "error", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                    return;
                }

            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Admin" , "123");
            Cliente cliente = new Cliente("Admin", 0 , usuario);
            Program.clientes.Add(cliente);
            
        }
    }
}