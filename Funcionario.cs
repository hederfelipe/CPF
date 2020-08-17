using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_EX9
{
    class Funcionario
    {
        private string Nome;
        private CPF Cpf;
        private double NumeroHoras;
        private double ValorHora;
        private static int QtdDeFuncionarios = 0;
       

        public Funcionario()
        {
            this.Nome = "";
            this.Cpf  = new CPF();
            this.NumeroHoras = 0;
            this.ValorHora = 0;
            QtdDeFuncionarios++;
        }

        public Funcionario(string Nome, string Cpf, double NumeroHoras, double ValorHora)
        {
            this.Nome = Nome;
            this.Cpf = new CPF(Cpf);
            QtdDeFuncionarios++;
            if (NumeroHoras >= 0)
            {
                this.NumeroHoras = NumeroHoras;
            }
            else
            {
                this.NumeroHoras = 0;
                Console.WriteLine("Número de Horas não pode ser negativo!");
            }
            if(ValorHora >= 0)
            {
                this.ValorHora = ValorHora;
            }
            else
            {
                this.ValorHora = 0;
                Console.WriteLine("Valor da hora não pode ser negativo!");
            }
        }
        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public void SetCpf(string Cpf)
        {
            this.Cpf.SetCpf(Cpf);
        }

        public void SetNumeroHoras(double NumeroHoras)
        {
            if(NumeroHoras > 0)
            {
                this.NumeroHoras = NumeroHoras;
            }
            else
            {
                Console.WriteLine("Numero de horas não pode ser negativo!");
            }
            
        }

        public void SetValorHora(double ValorHora)
        {
            if(ValorHora > 0)
            {
                this.ValorHora = ValorHora;
            }
            else
            {
                Console.WriteLine("Valor da hora não pode ser negativo!");
            }
            
        }

        public string GetNome()
        {
            return this.Nome; 
        }

        public string GetCpf()
        {
            return this.Cpf.GetCpf();
        }

        public double GetNumeroHoras()
        {
            return this.NumeroHoras;
        }

        public double GetValorHora()
        {
            return this.ValorHora;
        }

        public double CalcularSalario()
        {
            double salario;
            salario = this.NumeroHoras * this.ValorHora;
            return salario;
        }

        public int GetQtdDeFncionarios()
        {
            return QtdDeFuncionarios;
        }
    }
}