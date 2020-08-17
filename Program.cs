using System;

namespace CPF
{
    class Program
    {
        static void Main(string[] args)
        {


           Validacao val = new Validacao();
            string valido;

          Console.WriteLine("Informe o CPF: ");
          string   cpf = Console.ReadLine();



            val.ValidaCpf(valido);

            Console.WriteLine("CPF INFORMADO É: " + valido );
           
           
          
            

         
           
           
           
        }
    }
}
