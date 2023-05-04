using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula0405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Faça um programa que peça uma nota, entre zero e dez.Mostre uma mensagem caso o valor seja
            //inválido e continue pedindo até que o usuário informe um valor válido.
            // ex1();

            // 2.Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do
            //usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
            // ex2();


            // 4.Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de
            //crescimento de 3 % e que a população de B seja 200000 habitantes com uma taxa de crescimento de
            //1.5 %.Faça um programa que calcule e escreva o número de anos necessários para que a população
            //do país A ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento.
            ex4();


            // 10.Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo
            //compreendido por eles.
           // ex10();

            Console.ReadKey();

        }



        static void ex1()
        {
            Boolean exibirTela = true;
            while (exibirTela)
            {
                Console.WriteLine("Digite a nota de 0 a 10:");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    exibirTela = true;
                }
                else
                {
                    Console.WriteLine("Nota Cadastrada");
                    exibirTela = false;
                    break;
                }
            }


        }


        static void ex2()
        {
            Boolean exibirTela = true;
            while (exibirTela)
            {
                Console.WriteLine("Nome do usuário:");
                string nome = Console.ReadLine().ToLower();

                Console.WriteLine("Senha do usuário:");
                string senha = Console.ReadLine().ToLower();

                if (nome == senha)
                {
                    Console.WriteLine("Error!");
                    exibirTela = true;
                }
                else
                {
                    Console.WriteLine("Acesso Concedido");
                    exibirTela = false;
                    break;
                }
            }
        }


        static void ex4()
        {

            double populacaoPaisA = 80000;
            double populacaoPaisB = 200000;
            double taxaPaisA = 0.03;
            double taxaPaisB = 0.015;
            int anos = 0;

            while (populacaoPaisA < populacaoPaisB)
            {
                populacaoPaisA = populacaoPaisA + (populacaoPaisA * taxaPaisA);
                populacaoPaisB = populacaoPaisB + (populacaoPaisB * taxaPaisB);
                anos = anos + 1;
            }

            Console.WriteLine(" Para que a população do país A ultrapasse ou iguale a população do país B, serão necessários " + anos + " anos.");



        }


        static void ex10()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int n2 = int.Parse(Console.ReadLine());

            int nMaior = Math.Max(n1, n2);
            int nMenor = Math.Min(n1, n2);
            Console.WriteLine($"intervalo entre os numeros {nMenor} e {nMaior} é: \n");
            for (int i = nMenor; i <= nMaior; i++)
            {
                Console.WriteLine(i);
            }

        }
    }



}


