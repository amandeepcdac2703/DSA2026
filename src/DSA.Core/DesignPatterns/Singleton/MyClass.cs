using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Core.DesignPatterns.Singleton
{

    public sealed class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static MyClass instance = null;
        private static readonly object _lock = new object();

        private MyClass()
        {

        }

        public static MyClass GetInstance()
        {
            if(instance == null)
            {
                lock(_lock)
                {
                    if(instance == null)
                    {
                        instance = new MyClass();
                    }
                }
            }


            return instance;
        }

    }
}
