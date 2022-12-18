namespace OOP
{

    // class A
    // {
    //     protected int x = 123;
    // }

    // class B : A
    // {

    //     static void Main()
    //     {
    //         var a = new A();
    //         var b = new B();

    //         // Error CS1540, because x can only be accessed by
    //         // classes derived from A.
    //         // a.x = 10;
    //         // Оператор a.x = 10 вызывает ошибку, поскольку выполняется в статическом методе Main, а не в экземпляре класса Б.

    //         // OK, because this class derives from A.
    //         b.x = 10;
    //     }
    // }

    class Point
    {
        protected int x;
        protected int y;
    }

    class DerivedPoint : Point
    {
        static void Main()
        {
            var dpoint = new DerivedPoint();
            var baseclass = new Point();

            // Cannot access protected member 'Point.x' via a qualifier of type 'Point'
            // baseclass.x = 1;

            // Direct access to protected members.
            dpoint.x = 10;
            dpoint.y = 15;
            Console.WriteLine($"x = {dpoint.x}, y = {dpoint.y}");
        }
    }
}