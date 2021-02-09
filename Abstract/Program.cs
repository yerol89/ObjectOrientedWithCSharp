using System;

namespace Abstract
{
    public abstract class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Method which is defined in  abstract class");
        }
        // Normal sınıflarda method tanımı yapılamaz
        // Abstract sınıflarda method tanımı yapılabilir
        public abstract void Method2();
    }

    // Türetilmiş sınıflara sadece bir adet abstract sınıf inherit edilebilir
    public class MyClass : BaseClass
    {
        // Bildirimi yapılan abstract sınıf türetilmiş sınıf içerisinde tanımlanmak zorundadır.
        public override void Method2()
        {
            Console.WriteLine("Method which is defined in the extended class");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Abstract sınıflar tamamen kalıtım için oluşturulur 
            //Bu yüzden abstract sınıflardan nesne oluşturulmaz 
            MyClass extendedclass = new MyClass();
            extendedclass.Method1();
            extendedclass.Method2();
        }
    }
}
