using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Singleton_懒汉和饿汉一起_实例4
{
    public class cydemo
    {
        private static cydemo cydemo1 = new cydemo();

        private static readonly Object objectInitital = new object();
        private cydemo() { }

        public static cydemo getSingleton()
        {
            if (cydemo1 == null)
            {
                lock (objectInitital)
                {
                    if (cydemo1 == null)
                    {
                        cydemo1 = new cydemo();
                    }
                }
            }
            return cydemo1;
        }

        public void test1() 
        {
            //1初始话
            var demo = cydemo.getSingleton();

            //2 使用
            var result = demo.add();
        }

        public int add() => 1 + 1;
    }
}
