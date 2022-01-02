using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando el constructor con 1 elemento
            CuentaBancaria cuenta1 = new CuentaBancaria("00001");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta1.NoCuenta,
                cuenta1.Usuario, cuenta1.Saldo);

            // Usando el constructor con 2 elementos
            CuentaBancaria cuenta2 = new CuentaBancaria("00002", "John Doe");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta2.NoCuenta,
                cuenta2.Usuario, cuenta2.Saldo);

            // Usando el constructor con 3 elementos
            CuentaBancaria cuenta3 = new CuentaBancaria("00003", "Franck E.", 100000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta3.NoCuenta,
                cuenta3.Usuario, cuenta3.Saldo);
        }
    }
}
