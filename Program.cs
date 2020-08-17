﻿using System;

namespace ConsoleApp_EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario("Geraldo", "555555", 15, 35.5);
            string nome, cpf;
            double valorhora, numerohoras;
            Console.WriteLine("Nome: {0}\nCpf: {1}\nNumero de horas:{2}\nValor da Hora: {3}", f1.GetNome(), f1.GetCpf(), f1.GetNumeroHoras(), f1.GetValorHora());
            Console.WriteLine("Nome: {0}\nCpf: {1}\nNumero de horas:{2}\nValor da Hora: {3}", f2.GetNome(), f2.GetCpf(), f2.GetNumeroHoras(), f2.GetValorHora());
            
            Console.WriteLine("Digite o nome do funcionário 1:");
            nome = Console.ReadLine();

            f1.SetNome(nome);

            Console.WriteLine("Digite o nome do funcionario 2:");
            nome = Console.ReadLine();

            f2.SetNome(nome);

            Console.WriteLine("Digite o cpf do funcionario 1:");
            cpf = Console.ReadLine();

            f1.SetCpf(cpf);

            do
            {
                Console.WriteLine("Digite o numero de horas trabalhadas do funcionario 1:");
                numerohoras = Convert.ToDouble(Console.ReadLine());
                if (numerohoras < 0)
                {
                    Console.WriteLine("Valor não pode ser negativo! Digite novamente!");
                }
            } while (numerohoras < 0);

            f1.SetNumeroHoras(numerohoras);

            do
            {
                Console.WriteLine("Digite o valor da hora trabalhada: ");
                valorhora = Convert.ToDouble(Console.ReadLine());
                if (valorhora < 0)
                {
                    Console.WriteLine("Valor não pode ser negativo! Digite novamente!");
                }
            } while (valorhora < 0);

            f1.SetValorHora(valorhora);
            double salario = f1.CalcularSalario();

            Console.WriteLine("Nome: {0}\nCpf: {1}\nNumero de horas:{2}\nValor da Hora: {3}", f1.GetNome(), f1.GetCpf(), f1.GetNumeroHoras(), f1.GetValorHora());

            Console.WriteLine("\nSalario do funcionario 1: {0}",salario);

            Console.WriteLine("\n Salario do funcionario 2: {0}", f2.CalcularSalario());


            Console.WriteLine("Digite o nome do funcionário 3:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o cpf do funcionario 3:");
            cpf = Console.ReadLine();
          
            do
            {
                Console.WriteLine("Digite o numero de horas trabalhadas do funcionario 3:");
                numerohoras = Convert.ToDouble(Console.ReadLine());
                if (numerohoras < 0)
                {
                    Console.WriteLine("Valor não pode ser negativo! Digite novamente!");
                }
            } while (numerohoras < 0);
        
            do
            {
                Console.WriteLine("Digite o valor da hora trabalhada do funcionario 3: ");
                valorhora = Convert.ToDouble(Console.ReadLine());
                if (valorhora < 0)
                {
                    Console.WriteLine("Valor não pode ser negativo! Digite novamente!");
                }
            } while (valorhora < 0);

            Funcionario f3 = new Funcionario(nome, cpf, numerohoras, valorhora);
            

            Console.WriteLine("\nSalario do funcionario 3:{0}", f3.CalcularSalario());
            Console.WriteLine("Número de funcionários:{0}", f1.GetQtdDeFncionarios());

        }
    }
}