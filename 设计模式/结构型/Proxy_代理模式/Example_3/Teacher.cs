using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_3
{
    public class Teacher
    {
        public virtual String Say(String msg)
        {
            Console.WriteLine("老师在说话:" + msg);
            return "好孩子";
        }


        public virtual String SayHa(String msg)
        {
            Console.WriteLine("小孩在说话:" + msg);
            return "好样的";
        }
    }
}
