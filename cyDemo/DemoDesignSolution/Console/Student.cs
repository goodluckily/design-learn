using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Student
    {
        //一般的构造函数，里面是一堆参数，方便实例化的时候给参数赋值（俗称初始化）
        public Student(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        //带this的构造函数，借“主构造函数”（参数最多的）的参数来用，不需要的参数用任意相同类型的值来补，目的就是为了避免大括号里面每个参数再赋值一遍，造成代码冗余
        public Student(string name) : this(name, 1, "a")
        { }
        public Student() : this("", 2, "b")
        { }


        public void SayHello()
        {
            System.Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", this.Name, this.Age, this.Gender);
        }
        public void SayHello2()
        {
            System.Console.WriteLine("我叫{0}", this.Name);
        }
    }
}
