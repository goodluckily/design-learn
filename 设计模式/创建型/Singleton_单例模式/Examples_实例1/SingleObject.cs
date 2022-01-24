using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Examples_实例1
{
    public class SingleObject
    {
        //创建 SingleObject 的一个对象
        private static SingleObject instance = new SingleObject();
        private static List<int> intList = new List<int>();

        //让构造函数为 private，这样该类就不会被实例化
        private SingleObject() { }

        //获取唯一可用的对象
        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }

        public void InitialListData()
        {
            intList.AddRange(new List<int>() { 1,2,3,4,5});
        }

        public List<int> GetInitialListData()
        {
            return intList;
        }

    }
}
