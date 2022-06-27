// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        bool valido;
        int salir = 0;
       
        
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome Range App\n");
            Console.Write("Ingrese el rango: ");
            string range = Console.ReadLine();
            
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
                        Console.Write("\nIngrese el otro rango: ");
                        string otroRango = Console.ReadLine();
                        RangeABST.Range range3 = new RangeABST.Range(range);
                        Console.WriteLine(range3.Equals(otroRango));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("\nIngrese el otro rango: ");
                        string otroRango1 = Console.ReadLine();
                        RangeABST.Range range4 = new RangeABST.Range(range);
                        Console.WriteLine(range4.OverlapsRange(otroRango1));
                        Console.ReadKey();
                        break;
                    case 3:
                        RangeABST.Range range5 = new RangeABST.Range(range);
                        List<int> values = new List<int>();
                        Console.Write("Cuantos elementos tendra? ");
                        int max = int.Parse(Console.ReadLine());
                        for(int i = 0; i <max; i++)
                        {
                            Console.Write("Ingrese el " + (i + 1) + ": ");
                            int value = int.Parse(Console.ReadLine());
                            values.Add(value);
                        }
                        Console.WriteLine(range5.IntegerRangeContain(values) + range5.NumberContaining(values));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("\nIngrese el otro rango: ");
                        string otroRango3 = Console.ReadLine();
                        RangeABST.Range range6 = new RangeABST.Range(range);
                        Console.WriteLine(range6.ContainsRange(otroRango3));
                        Console.ReadKey();
                        break;
                    case 5:
                        RangeABST.Range range1 = new RangeABST.Range(range);
                        Console.WriteLine(range1.endPoints());
                        Console.ReadKey();
                        break;
                    case 6:
                        RangeABST.Range range2 = new RangeABST.Range(range);
                        Console.WriteLine(range2.GetAllPoints());
                        Console.ReadKey();
                        break;
                    case 7:
                        salir = 1;
                        Console.WriteLine("......Saliendo de la aplicación");
                        break;
                    default:
                        break;
                }
            }
        } while (salir == 0);
        
       

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