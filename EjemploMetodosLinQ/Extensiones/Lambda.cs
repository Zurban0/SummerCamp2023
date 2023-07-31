namespace Extensiones
{
        public class Ejemplo
        {
        public Action<int> AccionMetodo { get; set; }
        public void EjemploAction()
        {
            TestAction(Accion, 1);
            
            TestAction((num1) => Console.Write($"En el método Acción {num1}"), 1);

            //1- Crear una variable que almaciene la acción
            //2- Llamar a TestAction pasandole la variable y el valor 1.
            Action<int> accion = (y) =>
            {
                Console.Write($"En el método Acción {y}");
            };

            TestAction(accion, 1);

            List<Action<int>> listaAcciones = new List<Action<int>>();
            listaAcciones.Add(accion);
            listaAcciones.Add(AccionMetodo);

            listaAcciones.ForEach(accion => accion(1));
        }
        //Metodo que recibe un Action<int> y un int.
        public void TestAction(Action<int> accion, int num)
        {
            accion(num);
        }

        public void Accion(int num)
        {
            Console.WriteLine($"En el método Acción {num}");
        }
        public void EjemploFunc()
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

            Func<int, int, int> sumar = (num1, num2) => num1 + num2;

            Console.WriteLine(sumar(10, 20));


        }
        }
}
