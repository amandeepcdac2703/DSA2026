using DSA.Core.Algorithms.Arrays;
using DSA.Core.Algorithms.FAQs;
using DSA.Core.DesignPatterns.CreationDP.BuilderDP;
using DSA.Core.DesignPatterns.CreationDP.PrototypeDP;
using DSA.Core.DesignPatterns.CreationDP.Singleton;


//MyClass c = new MyClass();
//MyClass c2 = new MyClass();

//MyClass m1 = MyClass.GetInstance();
//MyClass m2 = MyClass.GetInstance();

//if(m1 == m2)
//{
//    Console.WriteLine("both the objects are same");
//} else
//{
//    Console.WriteLine("both the objects are not same");
//}

//MergeTwoSortedArrays.Run();
//CheckForBalanceParanthises.Run();
//Q1.Run();
//FindTheDuplicates.Run();

// prototype dp

//var e = new Employee();

//e.Id = 1;
//e.Name = "jay";
//e.Email = "jay@gmail.com";

//e.ShowDetails();

//var e2 = e.Cline();
//e2.Id = e.Id + 1 ;

//e2.ShowDetails();

Product product = new ProductBuilder()
            .SetId(101)
            .SetName("Laptop")
            .SetPrice(75000)
            .SetDescription("Dell Laptop with 16GB RAM")
            .SetCategory("Electronics")
            .SetStockQuantity(50)
            .Build();

product.Display();