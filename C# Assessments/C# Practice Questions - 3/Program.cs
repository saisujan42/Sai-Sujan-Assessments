namespace CSharpAssessment3
{
    class Program
    {
        public void Animal()
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }

        public void CompileTime()
        {
            CompileTime compileTime = new CompileTime();
            compileTime.Add(10, 20);
            compileTime.Add(10, 20, 30);
            compileTime.Add(10.5, 20.5);
        }

        public void RunTime()
        {
            RunTime runTime = new RunTime();
            runTime.MakePayment(1000);

            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.MakePayment(2000);

            UPIPayment upiPayment = new UPIPayment();
            upiPayment.MakePayment(3000);
        }

        public void InterfaceVehicle()
        {
            Car car = new Car();
            Bike bike = new Bike();

            car.Start();
            car.TopSpeed();

            bike.Start();
            bike.TopSpeed();
        }

        public void AbstractVehicle()
        {
            Vehicle2 car = new Car2();
            car.Start();
            car.TopSpeed();
            car.Stop();

            Vehicle2 bike = new Bike2();
            bike.Start();
            bike.TopSpeed();
            bike.Stop();
        }

        public void BaseClass()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Display();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();
        }

        public void Output()
        {
            Animal2 a = new Dog2();
            a.Speak();
        }

        public void Struct()
        {
            Struct1 struct1 = new Struct1();
            Struct2 struct2 = new Struct2();

            struct1.Display();
            struct2.Display();
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //program.Animal();
            //program.CompileTime();
            //program.RunTime();
            //program.InterfaceVehicle();
            //program.AbstractVehicle();
            //program.BaseClass();
            //program.Output();
            program.Struct();
        }
    }
}