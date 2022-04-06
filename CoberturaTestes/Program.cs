using System;

namespace CoberturaTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Usuario usuario = new Usuario();

            string nomeUsuario = usuario.CriarUsuario();

            Console.WriteLine("Nome do usuário: " + nomeUsuario);
        }
    }
}
