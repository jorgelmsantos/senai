using System;
namespace atividade
{
    class Program
    {
        static void Main(string[] args){

          float val_pag;
          Console.WriteLine("Informe seu Nome");
          string var_nome = Console.ReadLine();
          Console.WriteLine("Informe seu Endereço");
          string var_endereco = Console.ReadLine();
          Console.WriteLine("É pessoa fisica (F) ou pessoa juridica (J) ? ");
          string var_tipo = Console.ReadLine();
          if (var_tipo == "F" || var_tipo == "f"){
            //pessoa fisica
            Pessoa_Fisica pf = new Pessoa_Fisica();
            pf.nome = var_nome;
            pf.endereco  = var_endereco;
            Console.WriteLine("Informe seu CPF:");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Informe seu RG");
            pf.rg = Console.ReadLine();
            Console.WriteLine("Informe o valor da compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_Imposto(val_pag);
            Console.WriteLine("------------ Pessoa Fisica -----------------");
            Console.WriteLine("Nome: " + pf.nome);
            Console.WriteLine("Endereço: " + pf.endereco);
            Console.WriteLine("CPF: " + pf.cpf);
            Console.WriteLine("RG: " + pf.rg);
            Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
            Console.WriteLine("Imposto: " + pf.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar: " + pf.total.ToString("C"));
          }
          if (var_tipo == "J" || var_tipo == "j"){
            //Pessoa Juridica

            Pessoa_Juridica pj = new Pessoa_Juridica();
            pj.nome = var_nome;
            pj.endereco = var_endereco;
            Console.WriteLine("Informe o seu CNPJ");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Informe a sua Insrcição Estadual(IE)");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informe o valor da compra");
            val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(val_pag);
            Console.WriteLine("----------Pessoa Juridica------------");
            Console.WriteLine("Nome: " + pj.nome);
            Console.WriteLine("Endereço: " + pj.endereco);
            Console.WriteLine("CNPJ: " + pj.cnpj);
            Console.WriteLine("Inscrição Estadual(IE):" + pj.ie);
            Console.WriteLine("Valor da Compra: " +pj.valor.ToString("C"));
            Console.WriteLine("Imposto: " + pj.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar: " +pj.total.ToString("C"));

          }
          {
            
          }

        }
    }
}