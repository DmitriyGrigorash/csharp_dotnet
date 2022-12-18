class Programm
{
    public enum Direction
    {
        Up,
        Down,
        Right,
        Left
    }
    public enum Orientation
    {
        North,
        South,
        East,
        West
    }
    public enum CoffeChoice
    {
        Plain,
        WithMilk,
        WithIceCream,
    }
    public enum EmpTypeEnum
    {
        Manger = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    readonly struct Coords
    {
        public readonly string Z = "*** Public readonly string ***";
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";
    }
    // ****** MAIN ******
    static void Main(string[] args)
    {
        // static void ArrayDataType()
        // {
        //     var stringArray = new[] { "str1", "str2", "str3" };
        //     var stringArray2 = new[] { "str1", null, "str3" }; // with "null"??
        //                                                        //var diffArray = new[] { "str1", "str2", 1}; // *** No best type found for implicitly-typed array
        //     string[] stringArray3 = new string[2] { "str1", "str2" };
        //     int[] numberArray = new int[2] { 1, 2 };
        //     // numberArray = [ 1, 2 ];
        // }

        // static void ArrayOfObjects()
        // {
        //     object[] objArray = new object[3];
        //     objArray[0] = "First";
        //     objArray[1] = new DateTime(1969, 3, 24);
        //     objArray[2] = true;

        //     foreach (object obj in objArray)
        //     {
        //         System.Console.WriteLine($"Type: {obj.GetType()}, Value: {obj}");
        //     }
        // }
        //ArrayOfObjects();





        // static Orientation ToOrientation(Direction prop) => prop switch
        // {
        //     Direction.Up => Orientation.North,
        //     Direction.Right => Orientation.East,
        //     Direction.Down => Orientation.South,
        //     Direction.Left => Orientation.West,
        //     _ => throw new ArgumentOutOfRangeException(nameof(prop), $"Not expected direction value: {prop}"),
        // };
        // static void CheckOrientation()
        // {
        //     var direction = Direction.Down;
        //     Console.WriteLine($"Map view direction is {direction}");
        //     Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}");
        // }
        // CheckOrientation();





        // DisplayMeasurement(-20);  // Output: Measured value is -4; out of an acceptable range.
        // DisplayMeasurement(50);  // Output: Measured value is 50.
        // DisplayMeasurement(132);  // Output: Measured value is 132; out of an acceptable range.

        // void DisplayMeasurement(int measurement)
        // {
        //     switch (measurement)
        //     {
        //         case < 0:
        //         case > 100:
        //             Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
        //             break;

        //         default:
        //             Console.WriteLine($"Measured value is {measurement}.");
        //             break;
        //     }
        // }

        // DisplayMeasurements_2(3, 4);  // Output: First measurement is 3, second measurement is 4.
        // DisplayMeasurements_2(5, 5);  // Output: Both measurements are valid and equal to 5.
        // DisplayMeasurements_2(-2, -2);

        // void DisplayMeasurements_2(int a, int b)
        // {
        //     switch ((a, b))
        //     {
        //         case ( > 0, > 0) when a == b:
        //             Console.WriteLine($"Both measurements are valid and equal to {a}.");
        //             break;

        //         case ( > 0, > 0):
        //             Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
        //             break;

        //         default:
        //             Console.WriteLine("One or both measurements are not valid.");
        //             break;
        //     }
        // }




        // Console.WriteLine(CalculatePrice(CoffeChoice.Plain));  // output: 10.0
        // Console.WriteLine(CalculatePrice(CoffeChoice.WithMilk));  // output: 15.0
        // Console.WriteLine(CalculatePrice(CoffeChoice.WithIceCream));  // output: 17.0

        // decimal CalculatePrice(CoffeChoice choice)
        // {
        //     decimal price = 0;
        //     switch (choice)
        //     {
        //         // аргументом в case идет подставленное значение с "choice". Достаточно указать его тип из enum case "CoffeChoice.Plain":
        //         case CoffeChoice.Plain:
        //             price += 10.0m;
        //             break;

        //         case CoffeChoice.WithMilk:
        //             price += 5.0m;
        //             // goto позволяет перепрыгнуть в другой кейс в операторе switch
        //             goto case CoffeChoice.Plain;

        //         case CoffeChoice.WithIceCream:
        //             price += 7.0m;
        //             goto case CoffeChoice.Plain;
        //     }
        //     return price;
        // }



        // static void EvaluateEnum(Enum e)
        // {
        //     Console.WriteLine($"Information about: {e.GetType().Name}");
        //     Console.WriteLine($"Underlying storage type: {e.GetType()}");
        //     // Получить все пары имя-значения для входного параметра

        //     Array enumData = Enum.GetValues(e.GetType());
        //     for (int i = 0; i < enumData.Length; i++)
        //     {
        //         Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
        //     }
        //     Console.WriteLine();
        // }

        // EmpTypeEnum e1 = EmpTypeEnum.Contractor;
        // DayOfWeek e2 = DayOfWeek.Monday;
        // ConsoleColor e3 = ConsoleColor.Black;
        // EvaluateEnum(e1);
        // EvaluateEnum(e2);
        // EvaluateEnum(e3);




        // *** Структуры
        void StructType()
        {
            Coords c1 = new Coords(11.2, 34.4);
            Console.WriteLine($"c1.ToString(): {c1.ToString()}");
            Console.WriteLine($"X getter: {c1.X}");
            Console.WriteLine($"Z getter: {c1.Z}");

            // *** A readonly field cannot be assigned to (except in a constructor or init-only setter
            // of the type in which the field is defined or a variable initializer)
            // c1.Z = "asdas"
        }
        // StructType();




        static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }

        // С использованием элементов Item1, Item2, etc...
        static void Cortage1()
        {
            var result = QueryCityData("New York City");

            var city = result.Item1;
            var pop = result.Item2;
            var size = result.Item3;
        }

        // Деструктурирование кортежей
        static void Cortage2()
        {
            var (city, population, area) = QueryCityData("New York City");
        }
        static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }
        var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

        Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
        // The example displays the following output:
        //      Population change, 1960 to 2010: 393,149
    }
}