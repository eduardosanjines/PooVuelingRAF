using System;

namespace Reflection
{
    internal class Facade
    {

        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

    }


    public void MetodoA()
    {
        Console.WriteLine("\nMethodA() ---- ");
        _one.MethodOne();
        _two.MethodTwo();
        _four.MethodFour();
    }

}