﻿using System;

namespace ListaDeConvidados
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado:");
            var nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome não informado para seguir com o programa!");
                return;
            }

            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if (idadeInformada == false)
            {
                Console.WriteLine("Idade não informada para seguir com o programa!");

            }
            
            bool estaConvidado = false;

            switch (nome)
            {
                case "Daniel":
                    estaConvidado = true;
                    break;
                case "Evandro":
                    estaConvidado = true;
                    break;
                case "Mateus":
                    estaConvidado = true;
                    break;
                case "Ale":
                    estaConvidado = true;
                    break;
                case "Teresa":
                    estaConvidado = true;
                    break;
                case "Gabriel":
                    estaConvidado = true;
                    break;
                case "Clebson":
                    estaConvidado = true;
                    break;
                case "Guiseppe":
                    estaConvidado = true;
                    break;

            }

            if (estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Parabéns, seja bem vindo a festa!");
            } else if (estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados, favor vericar com a pessoa que te convidou!");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos para entrar na festa!");
            }
        }
    }
}
