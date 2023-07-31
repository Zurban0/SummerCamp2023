using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
        public class Ejemplo
        {
            public void EjemploDelegados1()
            {
                // Expresión Lambda medinate Func<>

                Func<string> holaMundoExpresion =
                    //parametros
                    ()
                    //Operador Lambda
                    =>
                    //Delegado / Método anónimo / Expresión
                    "Hola mundo";
                Console.WriteLine(holaMundoExpresion);
                Console.WriteLine(holaMundoExpresion());

            Func<string> holaMundoBloque = () =>
                {
                    var cadena = "Hola mundo";
                    return cadena;
                };
            Console.WriteLine(holaMundoBloque);
            Console.WriteLine(holaMundoBloque());

            // Crear una expresion lambda que sume dos números.
            //Console.WriteLine(sumar(10, 20));

            Func<int, int, int> sumar = (int num1, int num2) => num1 + num2;

            Console.WriteLine(sumar(10, 20));


        }
        }
}
