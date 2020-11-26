using System;

namespace Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];


            Console.WriteLine("-------------------------------");
            Console.WriteLine("--Sistema de passagens aéreas--");
            Console.WriteLine("-------------------------------");

            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);

            } while (!senhaValida);
            Console.Clear();

            int escolha;
            do
            {
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] Cadastrar Passagem");
                Console.WriteLine("[2] Listar passagens");
                Console.WriteLine("[3] Sair");
                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {

                    case 1:
                        string resposta;
                        int contador = 0;
                        do
                        {
                            if(contador < 5){
                            Console.WriteLine($"Digite o nome do {contador + 1}º passageiro");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite a origem do {contador + 1}º passageiro");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino do {contador + 1}º passageiro");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite a data de vôo do {contador + 1}º passageiro");
                            data[contador] = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Limite de passagens excedido");
                                break;
                            }
                            Console.WriteLine("Gostaria de cadastrar um novo passageiro? s/n");
                            resposta = Console.ReadLine();
                        } while (resposta == "s");

                        break;
                    case 2:
                        for (var i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Passageiro {nomes[i]}");
                        }
                        break;
                    case 0:

                        break;
                    default:
                        break;
                }

            }while(escolha !=0);


            bool EfetuarLogin(string senha){

                    if (senha == "123456")
                    {
                        Console.WriteLine("Achei!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta");
                        return false;
                    }
            }
        }
    }
}
