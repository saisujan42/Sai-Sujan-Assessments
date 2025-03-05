using CSharpAssessment2.CSharpAssessment2;

namespace CSharpAssessment2
{
    class Program
    {
        public void Vehicle()
        {
            Vehicle car = new Vehicle("Skoda", 200);
            Vehicle bike = new Vehicle("Yamaha", 100);

            car.DisplayInfo();
            bike.DisplayInfo();
        }

        public void Employee()
        {
            Employee employee = new Employee("John", 25000);
            employee.DisplayInfo();

            Manager manager = new Manager("Johnson", 50000, 1500);
            manager.DisplayInfo();
        }

        public void Animal()
        {
            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();
        }

        public void Robot()
        {
            Robot robot = new Robot();
            robot.Move();
        }

        public void Account()
        {
            Account account = new Account("Jack", 5000);
            account.CalculateInterest();

            SavingsAccount savingsAccount = new SavingsAccount("Jill", 10000, 0.05);
            savingsAccount.CalculateInterest();
        }

        public void Duck()
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();
        }

        public void Person()
        {
            Student student = new Student("John Doe", 20, 12345);

            Person person = student;
            person.DisplayPerson();

            Student NewStudent = (Student)person;
            NewStudent.DisplayStudent();
        }

        public void Product()
        {
            Product product = new Product("Hammer", 1000);
            product.GetDiscountedPrice();

            ElectronicProduct electronicProduct = new ElectronicProduct("SmartPhone", 15000);
            electronicProduct.GetDiscountedPrice();

            ClothingProduct clothingProduct = new ClothingProduct("TShirt", 2000);
            clothingProduct.GetDiscountedPrice();
        }

        public void SecuritySystem()
        {
            SecuritySystem securitySystem = new SecuritySystem();
            securitySystem.AuthenticateUser();

            HomeSecuritySystem homeSecuritySystem = new HomeSecuritySystem();
            homeSecuritySystem.AuthenticateUser();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //program.Vehicle();
            //program.Employee();
            //program.Animal();
            //program.Robot();
            //program.Account();
            //program.Duck();
            //program.Person();
            //program.Product();
            //program.SecuritySystem();
        }
    }
}