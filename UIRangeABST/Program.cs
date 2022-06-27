// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        bool valido;
        int salir;
        Console.WriteLine("Welcome Range App\n");

        Console.Write("Ingrese el rango: ");
        string range = Console.ReadLine();
        do
        {
            Console.WriteLine("/*-----Compare-----");
            Console.WriteLine("1 - Equals");
            Console.WriteLine("2 - Overlaps");
            Console.WriteLine("3 - IntegerContainRange");
            Console.WriteLine("4 - ContainRange");
            Console.WriteLine("\n");
            Console.WriteLine("/*----- Not Compare-----");
            Console.WriteLine("5 - EndPoints");
            Console.WriteLine("6 - GetAllPoints");
            Console.WriteLine("--------- Salir ----------");
            Console.WriteLine("7 - Salir de la app");
            Console.Write("Eliga la opcion que prefiera: ");
            string strOp = Console.ReadLine();
            valido = Int32.TryParse(strOp, out int val);
            if (valido)
            {
                switch (val)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("......Saliendo de la aplicación");
                        
                        break;
                    default:
                        break;
                }
            }
            salir = val;
        } while (valido && salir == 7);
        
       

        /*---Compare-----
         * Equlas
         * Overlaps
         * IntegerContainRange
         * ContainRange
         * 
         * */

        /*----No compare-----
         * EndPoints
         * Getallpoints
         * 
         */


        Console.ReadKey();

    }




}