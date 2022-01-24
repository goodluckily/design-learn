//namespace Console
//{
//    class Program
//    {
//        //static void Main(string[] args)
//        //{


//        //    //都改变 尚未浅拷贝
//        //    //Class1 class1 = new Class1(20, 20);
//        //    //Class1 c = class1;
//        //    //class1.x = 100;

//        //    ////b 尚未改变 使用的是struct 结构体(值类型)
//        //    //Location a = new Location(20, 20);
//        //    //Location b = a;
//        //    //a.x = 100;

//        //    //System.Console.WriteLine(b.x);

//        //    var aa = new B();
//        //}
//    }



//    public class A
//    {
//        public A()
//        {
//            System.Console.WriteLine("Build A");
//        }
//    }
//    public class B : A
//    {
//        public B() : base()
//        {
//            System.Console.WriteLine("Build B");
//        }
//        static void Main()
//        {
//            B b = new B();
//            System.Console.ReadLine();
//        }
//    }
//}

//1.在派生类中调用基类方法。

//using System;
//public class BaseClass
//{
//    protected string _className = "BaseClass";
//    public virtual void PrintName()
//    {
//        System.Console.WriteLine("Class Name: {0}", _className);
//    }
//}
//class DerivedClass : BaseClass
//{
//    public string _className = "DerivedClass";
//    public override void PrintName()
//    {
//        System.Console.Write("The BaseClass Name is {0}", _className); //调用基类方法 base.PrintName(); Console.WriteLine("This DerivedClass is {0}", _className); }
//    }
//    class TestApp
//    {
//        public static void Main()
//        {
//            DerivedClass dc = new DerivedClass();
//            dc.PrintName();
//        }
//    }
//}

//// keywords_base2.cs
//using System;
//public class BaseClass
//{
//    int num;
//    public BaseClass()
//    {
//        System.Console.WriteLine("in BaseClass()");
//    }
//    public BaseClass(int i)
//    {
//        num = i;
//        System.Console.WriteLine("in BaseClass(int {0})", num);
//    }
//}
//public class DerivedClass : BaseClass
//{
//    // 该构造器调用
//    //BaseClass.BaseClass() public DerivedClass() : base() { } 
//    // 该构造器调用 BaseClass.BaseClass(int i) public DerivedClass(int i) : base(i) { } static void Main() { DerivedClass dc = new DerivedClass(); DerivedClass dc1 = new DerivedClass(1)(); Console.ReadLine(); }
//}


class Program
{
    static void Main(string[] args)
    {
        Student s = new Student("李四", 28, "女");
        s.SayHello();
        Student s2 = new Student("王五", 22, "男", 88, 23);
        s2.SayHello2();
        System.Console.ReadKey();
    }
    //Person类，这里有个地方要注意，之前偷懒不爱写字段，只写个属性。其实这样不好，因为如果只有属性，并且属性设为只读，那就没法改了，构造函数也不行。
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            //set { age = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            //set { gender = value; }
        }

        //父类构造函数，有name,age,gender三个参数
        public Person(string name, int age, string gender)
        {
            //这里用this代表本类Person，用来区分参数name，不然重名了。
            //在构造函数里将参数赋值给字段，这样就可以越过只读属性，直接修改字段了。
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
    //Student类，继承Person类。如果Person类内有自己写的有参构造方法，则Student类的构造方法必须要加:base继承这个构造方法！因为默认的Student:base(空)构造方法已经被干掉了！
    public class Student : Person
    {
        public int Chinese { get; set; }
        public int Math { get; set; }


        //如果不加:base会提示Person不包含0个参数的构造函数。
        public Student(string name, int age, string gender)//蒋坤：构造方法的定义
            : base(name, age, gender)//蒋坤：构造方法的调用//base里的参数，前面Student里面写什么，这里就写什么。
        { }
        public void SayHello()
        {
            System.Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", this.Name, this.Age, this.Gender);
        }

        //子类构造函数有chinese,math两个，必须要加上父类的构造函数，参数如果没有值的话随便写
        public Student(string name, int age, string gender, int chinese, int math)
            : base(gender, age, name)//base里的参数，前面Student里面写什么，这里就写什么，前提是Person类有对应的这三个参数。因为这个Person类参数少，所以就写满三个就行，不然还要补空值。
        {
            this.Chinese = chinese;
            this.Math = math;
        }


        public void SayHello2()
        {
            System.Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，语文{3}分，数学{4}分。", this.Name, this.Age, this.Gender, this.Chinese, this.Math);
        }
    }
}