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
            /*ContaCorrente joao = new ContaCorrente(123, 123456);
            Console.WriteLine(ContaCorrente.TaxaOperacao);*/
            try
            {
                ContaCorrente conta = new ContaCorrente(1, 0);
            }
            catch(ArgumentException ex)
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
