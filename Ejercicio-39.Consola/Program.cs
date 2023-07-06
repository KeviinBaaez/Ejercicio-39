namespace Ejercicio_39.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero del mes que deseas saber su nombre (1 al 12)");
            var nseleccionado = int.Parse(Console.ReadLine());
            if (nseleccionado == 1)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Enero");
            }
            else if (nseleccionado == 2)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Febrero");
            }
            else if (nseleccionado == 3)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Marzo");
            }
            else if (nseleccionado == 4)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Abril");
            }
            else if (nseleccionado == 5)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Mayo");
            }
            else if (nseleccionado == 6)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Junio");
            }
            else if (nseleccionado == 7)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Julio");
            }
            else if (nseleccionado == 8)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Agosto");
            }
            else if (nseleccionado == 9)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Septiembre");
            }
            else if (nseleccionado == 10)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Octubre");
            }
            else if (nseleccionado == 11)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Noviembre");
            }
            else if (nseleccionado == 12)
            {
                Console.WriteLine($"{nseleccionado} corresponde al mes de Diciembre"
                    );
            }
        }
    }
}