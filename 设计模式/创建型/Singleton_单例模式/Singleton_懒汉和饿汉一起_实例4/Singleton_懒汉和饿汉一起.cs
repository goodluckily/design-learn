using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Singleton_懒汉和饿汉一起
{
    public class Singleton_懒汉和饿汉一起
    {
        private volatile static Singleton_懒汉和饿汉一起 singleton;
        private Singleton_懒汉和饿汉一起() { }
        public static Singleton_懒汉和饿汉一起 getSingleton()
        {
            if (singleton == null)
            {
                lock (singleton)//多线程 同时访问时 锁住区域  只允许一个线程访问
                {
                    //第二重检查判断  (第二个线程并不知道实例已经创建，将继续创建新的实例，还是会产生多个单例对象，违背单例模式的设计思想，因此需要进行双重检查)
                    if (singleton == null)
                    {
                        singleton = new Singleton_懒汉和饿汉一起();
                    }
                }
            }
            return singleton;
        }
    }
}
