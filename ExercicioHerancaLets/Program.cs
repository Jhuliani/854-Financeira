using System;
using System.Collections.Generic;

namespace ExercicioHerancaLets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ContratoPessoaFisica> contratosPf = new List<ContratoPessoaFisica>();
            List<ContratoPessoaJuridica> contratosPj = new List<ContratoPessoaJuridica>();
            int opcao;
            string voltaMenu;

            do
            {
                Console.Clear();
                Console.WriteLine(Menu.MenuInicial);                              
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 1 || opcao > 2))
                {
                    Console.WriteLine("\nOpção inválida. Digiteo número da opção desejada: ");
                }

                if (opcao == 1)
                {
                    Console.WriteLine(Menu.Opcoes);
                    int resposta;
                    while (!int.TryParse(Console.ReadLine(), out resposta) || (resposta < 1 || resposta > 2))
                    {
                        Console.WriteLine("\nOpção inválida. Digiteo número da opção desejada: ");
                    }

                    if (resposta == 1)
                    {
                        foreach (var contratos in contratosPf)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Contratante: " + contratos.Contratante);
                            Console.WriteLine("Valor: " + contratos.Valor);
                            Console.WriteLine("Prazo: " + contratos.Prazo);
                            Console.WriteLine("CPF: " + contratos.Cpf);
                            Console.WriteLine("Idade: " + contratos.Idade());
                        }

                    }
                    else
                    {
                        foreach (var contratos in contratosPj)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Contratante: " + contratos.Contratante);
                            Console.WriteLine("Valor: " + contratos.Valor);
                            Console.WriteLine("Prazo: " + contratos.Prazo);
                            Console.WriteLine("CNPJ: " + contratos.Cnpj);
                            Console.WriteLine("Inscrição Estadual: " + contratos.InscricaoEstadual);
                        }
                    }

                }
                else
                {
                    Console.WriteLine(Menu.Opcoes);
                    int resposta;
                    while (!int.TryParse(Console.ReadLine(), out resposta) || (resposta < 1 || resposta > 2))
                    {
                        Console.WriteLine("\nOpção inválida. Digiteo número da opção desejada: ");
                    }

                    if (resposta == 1)
                    {
                        Console.WriteLine("Qual o nome do contratante?");
                        string contratante = Console.ReadLine();
                        Console.WriteLine("Qual o valor do contrato?");
                        double valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o prazo em meses?");
                        int prazo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o CPF? (apenas números xxxxxxxxxxx)");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Qual o ano do nascimento?");
                        int anoNas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o mes do nascimento?");
                        int mesNas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o dia do nascimento?");
                        int diaNas = int.Parse(Console.ReadLine());
                        ContratoPessoaFisica pf = new ContratoPessoaFisica(contratante, valor, prazo, cpf, anoNas, mesNas, diaNas);
                        pf.CalcularPrestacao();
                        pf.ExibirInfo();
                        contratosPf.Add(pf);
                    }
                    else
                    {
                        Console.WriteLine("Qual o nome do contratante?");
                        string contratante = Console.ReadLine();
                        Console.WriteLine("Qual o valor do contrato?");
                        double valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o prazo em meses?");
                        int prazo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o CNPJ? (apenas números xxxxxxxxxxx)");
                        string cnpj = Console.ReadLine();
                        Console.WriteLine("Qual a inscricao estadual?");
                        string insc = Console.ReadLine();
                        ContratoPessoaJuridica pj = new ContratoPessoaJuridica(contratante, valor, prazo, cnpj, insc);
                        pj.CalcularPrestacao();
                        pj.ExibirInfo();
                        contratosPj.Add(pj);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Voltar ao Menu inicial? s/n");
                voltaMenu = Console.ReadLine();
            }
            while (voltaMenu=="s");

            

        }
    }
}
