using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int age=23;
            string name="Ali";
            console.WriteLine("hi");
            console.WriteLine("my name is "+name+"and my age is "+age);
            console.WriteLine("my name is {0} and my age is{1} ",name ,age);
            console.WriteLine($"my name is {name} and my age is{age} ");
            console.WriteLine(@"من علی احمدی هستم
            در شهر بستک و در استان هرمزگان متولد شدم و
            به برنامه نویسی علاقه دارم");
            Console.WriteLine(@"/Users/abtin_cheg/Desktop/C#/session1");
        }
    }
}