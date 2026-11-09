using DSA.Core.DesignPatterns.Singleton;

//MyClass c = new MyClass();
//MyClass c2 = new MyClass();

MyClass m1 = MyClass.GetInstance();
MyClass m2 = MyClass.GetInstance();

if(m1 == m2)
{
    Console.WriteLine("both the objects are same");
} else
{
    Console.WriteLine("both the objects are not same");
}