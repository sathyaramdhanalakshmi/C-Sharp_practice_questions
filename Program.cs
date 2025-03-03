
namespace Inheritance_practiceques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.basic Inheritance
            //Car car = new Car("Toyota", 180);
            //car.DisplayInfo();

            //Bike bike = new Bike("Yamaha", 120);
            //bike.DisplayInfo();



            //2.Method Overring
            //Car1 car = new Car1("Toyota", 180);
            //car.DisplayInfo();

            //Bike1 bike = new Bike1("Yamaha", 120);
            //bike.DisplayInfo();



            //3.Constructor Chaining
            //Employee employee = new Employee("zani", 50000);
            //employee.DisplayInfo();
            //Employee manager = new Manager("dhana", 60000, 10000);
            //manager.DisplayInfo();



            //4.Abstract Class and Polymorphism
            //Animal dog = new Dog();
            //dog.MakeSound();

            //Animal cat = new Cat();
            //cat.MakeSound();



            //5.Interface VS Inheritance
            //Robot robot = new Robot();
            //robot.Start();
            //robot.Move();



            //6.Sealed Class and Method
            //Account acc = new SavingsAccount();
            //acc.CalculateInterest();



            //7.Multiple Inheritance
            //Duck duck = new Duck();
            //duck.Fly();
            //duck.Swim();




            ////8.Upcasting and Downcasting
            //Student student = new Student("John", 20, 1234);
            //student.ShowDetails();

            //// Upcasting Student to Person
            //Person person = student;
            //person.ShowDetails();

            //// Downcasting Person back to Student
            //if (person is Student downcastedStudent)
            //{
            //    downcastedStudent.ShowDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Downcasting failed");
            //}



            //9.Real-world scenario of E-Commerce System
            //Product electronic = new ElectronicProduct("Laptop", 1000);
            //Product clothing = new ClothingProduct("Jacket", 200);

            //Console.WriteLine($"Original Price of {electronic.Name} is: {electronic.Price}, Discounted Price is: {electronic.GetDiscountedPrice()}");
            //Console.WriteLine($"Original Price of {clothing.Name} is: {clothing.Price}, Discounted Price is: {clothing.GetDiscountedPrice()}");



            //10.Prevent Inheritance using sealed class
            SecuritySystem security = new SecuritySystem();
            security.AuthenticateUser();
        }
    }
}