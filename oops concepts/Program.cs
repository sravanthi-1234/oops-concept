//abstraction
//abstract class animal
//{
//    public abstract void eat();
//    public void sound()
//    {
//        Console.WriteLine("dog can sound");
//    }
//}
//class dog : animal
//{
//    public override void eat()
//    {
//        Console.WriteLine("dog can eat");
//    }

//    static void Main(string[] args)
//    {
//        dog d1 = new dog();
//        animal thepet = d1;
//        thepet.eat();
//        d1.sound();
//    }
//}

////compiletime polymorphism
//class mobile
//{
//    public void nokia(string color, double price)
//    {
//        Console.WriteLine("mobile specifications");
//    }
//    public void nokia(int height, string ram)
//    {
//        Console.WriteLine("mobile specifications");
//    }
//    public static void Main(string[] args)
//    {
//        mobile m1 = new mobile();
//        m1.nokia("blue", 4356.56);
//        m1.nokia(3, "3gb");
//        Console.ReadLine();
//    }
//}


////hierarchical inheritance
//class Test
//{
//    static void Main(string[] args)
//    {
//        Father f = new Father();
//        f.display();
//        Son s = new Son();
//        s.display();
//        s.displayOne();
//        Daughter d = new Daughter();
//        d.displayTwo();
//        Console.ReadKey();
//    }
//    class Father
//    {
//        public void display()
//        {
//            Console.WriteLine("Display...");
//        }
//    }
//    class Son : Father
//    {
//        public void displayOne()
//        {
//            Console.WriteLine("Display One");
//        }
//    }
//    class Daughter : Father
//    {
//        public void displayTwo()
//        {
//            Console.WriteLine("Display Two");
//        }
//    }
//}


//interface
//interface vehicle
//{
//    void run();
//    void park();
//}
//class car : vehicle
//{
//    public void run()
//    {
//        Console.WriteLine("run car");
//    }
//    public void park()
//    {
//        Console.WriteLine("park car");
//    }
//}
//class bus : vehicle
//{
//    public void run()
//    {
//        Console.WriteLine("run bus");
//    }
//    public void park()
//    {
//        Console.WriteLine("park bus");
//    }
//}
//class Interface
//{
//    public static void Main(string[] args)
//    {
//        car c = new car();
//        c.run();
//        c.park();
//        bus b = new bus();
//        b.park();
//        b.run();
//        Console.ReadLine();
//    }
//}


////runtime polymorphism
//class human
//{
//    public void eat(string name)
//    {
//        Console.WriteLine("human behaviour");
//    }
//    public void walk(int kilometers)
//    {
//        Console.WriteLine("human behaviour");
//    }
//    public static void Main(string[] args)
//    {
//        human h1 = new human();
//        h1.eat("food");
//        h1.walk(3);
//        Console.ReadLine();
//    }
//}


////single level inheritance
//public class Student
//{
//    public float marks = 90;
//}
//public class Topper : Student
//{
//    public float extra = 5;
//}
//class Std
//{
//    public static void Main(string[] args)
//    {
//        Topper t1 = new Topper();
//        Console.WriteLine("Marks:" + t1.marks);
//        Console.WriteLine("Extra Marks:" + t1.extra);
//    }
//}
