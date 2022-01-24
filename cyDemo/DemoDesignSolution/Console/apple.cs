using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class apple : fruit
    {
        public apple(string name) : base(name)
        {
            //在apple类实例化时，
            //在apple的构造器中，存在参数a和b.并以a和b作为基类构造器的参数，
            //基类对象先实例化.Rectangle继承基类的成员变量length和width(在实例化中已完成赋值).
            //因此在下面的函数GetArea()中，可以直接使用length和width
        }
        public override string GetArea()
        {
            return base.GetArea();
        }
    }
}
