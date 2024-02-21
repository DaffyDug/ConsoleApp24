using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Сложить два числа\n2. Вычесть два числа\n3. Умножение двух чисел\n4. Деление двух чисел\n5. Очистить экран");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    Action action = new Sum_Action();
                    action.Run();
                }
                else if (result == "2")
                {
                    Action action = new Minus();
                    action.Run();
                }
                else if (result == "3")
                {
                    Action action = new Mult();
                    action.Run();
                }
                else if (result == "4")
                {
                    Action action = new division();
                    action.Run();
                }
                else if (result == "5")
                {
                    Console.Clear();
                }
            }
        }
    }

    public abstract class Action
    {
        public abstract string _text { get; }
        public abstract void Run();
    }
    public class Sum_Action : Action
    {
        public override string _text => "сложное сложение чисел: ";// сложение

        public override void Run()
        {
            Console.WriteLine("введите первое число");
            string a = Console.ReadLine();
            int aa = int.Parse(a);

            Console.WriteLine("введите второе число");
            string b = Console.ReadLine();
            int bb = int.Parse(b);
            int result = aa + bb;

            Console.WriteLine("ответ: " + result);
        }
    }
    public class Minus : Action
    {
        public override string _text => "супер вычитание";// вычитание 
        public override void Run()
        {
            Console.WriteLine("введите первое число");
            string a = Console.ReadLine();
            int aa = int.Parse(a);
            Console.WriteLine("введите второе число");
            string b = Console.ReadLine();
            int bb = int.Parse(b);
            int result = aa - bb;
            Console.WriteLine("ответ: " + result);
        }
    }
    public class Mult : Action
    {
        public override string _text => "супер умножение";// умножение 
        public override void Run()
        {
            Console.WriteLine("введите первое число");
            string a = Console.ReadLine();
            int aa = int.Parse(a);
            Console.WriteLine("введите второе число");
            string b = Console.ReadLine();
            int bb = int.Parse(b);
            int result = aa * bb;
            Console.WriteLine("ответ: " + result);
        }
    }
    public class division : Action //деление
    {
        public override string _text => "супер деление";
        public override void Run()
        {
            Console.WriteLine("введите первое число");
            string a = Console.ReadLine();
            int aa = int.Parse(a);
            Console.WriteLine("введите второе число");
            string b = Console.ReadLine();
            int bb = int.Parse(b);
            int result = aa / bb;
            Console.WriteLine("ответ: " + result);
        }
    }
    //public abstract class work_tools
    //{
    //    public abstract void Do_work();
    //}

    //public class Hummer : work_tools
    //{
    //    public override void Do_work()
    //    {
    //        Console.WriteLine("тук тук тук тук");
    //    }
    //}

    //public class Saw : work_tools
    //{
    //    public override void Do_work()
    //    {
    //        Console.WriteLine("ввввввввввввввввввввввввв");
    //    }
    //}

    //public class Wrench : work_tools
    //{
    //    public override void Do_work()
    //    {
    //        Console.WriteLine("кручу верчу закрутить хочу");
    //    }
    //}
}
