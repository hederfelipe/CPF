﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_EX9
{
    class CPF
    {
        private string Numero;

        public CPF(string Cpf)
        {
            if (ValidarCpf(Cpf) == true)
            {
                this.Numero = Cpf;
            }
            else
            {
                Console.WriteLine("CPF INVALIDO!");
                this.Numero = "";
            }
        }

        public CPF()
        {
            this.Numero = "";
        }

        public string GetCpf()
        {
            return this.Numero;
        }

        public void SetCpf(string Cpf)
        {
            if (ValidarCpf(Cpf) == true)
            {
                this.Numero = Cpf;
            }
            else
            {
                Console.WriteLine("CPF INVALIDO!");
                this.Numero = "";
            }
        }

        private static bool ValidarCpf(string Cpf)
        {
            int resto, cont, soma, mul, sub;
            string digito;
            Cpf = Cpf.Trim();
            Cpf = Cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (Cpf.Length != 11)
            {
                return false;
            }
            else
            {
                soma = 0;
                for (mul = 10, cont = 0; cont < 9; cont++, mul--)
                {
                    soma += int.Parse(Cpf[cont].ToString()) * mul;
                }
                resto = soma % 11;
                sub = 11 - resto;
                if (sub > 9)
                {
                    digito = "0";
                }
                else
                {
                    digito = Convert.ToString(sub);
                }

                soma = 0;
                for (mul = 11, cont = 0; cont < 10; cont++, mul--)
                {
                    soma = soma + int.Parse(Cpf[cont].ToString()) * mul;
                }
                resto = soma % 11;
                sub = 11 - resto;
                if (sub > 9)
                {
                    digito = digito + "0";
                }
                else
                {
                    digito = digito + Convert.ToString(sub);
                }

                if (Cpf.EndsWith(digito) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}