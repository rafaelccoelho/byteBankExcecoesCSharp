using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente(123, 456789);
            c1.Depositar(50);
            Console.WriteLine("Saldo da conta 1 = " + c1.Saldo);


            ContaCorrente c2 = new ContaCorrente(321, 987654);
            Console.WriteLine("Saldo da conta 2 = " + c2.Saldo);

            Console.WriteLine("Transferindo R$200 da conta 1 pra a conta 2");
            try
            {
                c1.Transferir(200, c2);

            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações de INNER EXCEPTION (Excecao Interna):");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }


            /*ContaCorrente joao = new ContaCorrente(123, 123456);
            Console.WriteLine(ContaCorrente.TaxaOperacao);*/
            
            
            
            /*try
            {
                ContaCorrente conta = new ContaCorrente(1, 100);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(151);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                //Console.WriteLine("Problemas com o parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma excessão do tipo ArgumentExcepetion!");
                Console.WriteLine(ex.Message);

            }


            try
            {
                //Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possivel realizar divisão por 0!");
            }catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            */

            Console.ReadLine();
        }

        static double Dividir (int numero, int divisor)
        {
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try
            {
            return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Excecao com numero = " + numero + " divisor = " + divisor);
                throw;
            }
        }
        static void Metodo()
        {
            TestaDivisao(0);
        }
        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
