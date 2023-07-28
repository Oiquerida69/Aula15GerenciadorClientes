using System.Net.NetworkInformation;

namespace Aula15JonoSe
{
    internal class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        







        // tudo que for "static" não é necessario usar o "new program". acesssando usando "Program.", pode ser feito com variaveis,funçoes e classes.
        //Acesso geral a todas as classes,formularios ,listas e variaveis globais.
        // = /// é um comentario do tipo sumario para adicionar links.
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}