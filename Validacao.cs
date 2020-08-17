using System;
using System.Collections.Generic;
using System.Text;

namespace CPF
{
    class Validacao
    {
        

        private   string Numero;

      
   

       public  string getCpf()
        {
            return this.Numero;
        }
        public void setCpf(string Cpf)
        {
          if( ValidaCpf(Cpf) == true )
            {
                this.Numero = Cpf;
            }
            else
            {
                Console.WriteLine("Invalido");
                this.Numero = "";
            }
        }

        public  bool ValidaCpf(string Cpf) {

       
        int[] Ativador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] Ativador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
             int Soma;
             string Digito;
             int Resto;
             string x;

            Cpf = Cpf.Trim();
            Cpf = Cpf.Replace("," , "").Replace("-" , "");

            if (Cpf.Length != 11)
                return false;

            x = Cpf.Substring(0, 9);
                Soma = 0;


            for (int i = 0; i < 9; i++) {  Soma += int.Parse( x[i].ToString()) * Ativador1[i];
            }
            

               
                Resto = Soma % 11;
                if (Resto < 2)
                {
                    Resto = 0;
                }
                else
                    Resto = 11 - Resto;

                Digito = Resto.ToString();
                x += Digito;
                int Soma2 = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Soma2 += int.Parse(x[i].ToString()) * Ativador2[i];
            }
               
            Resto = Soma2 % 11;
                if (Resto < 2)
                {
                    Resto = 0;
                }
                else
                { 
                        Resto = 11 - Resto;
                }
            x += Resto.ToString();
            return Cpf.EndsWith(Digito);


        }
        
    }
   
    
}
