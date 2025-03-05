namespace CSharpAssessment
{
    public class Program
    {
        public void BankAccount()
        {
            BankAccount account = new BankAccount(12345, 1000);
            account.Deposit(500);
            account.GetBalance();
            account.Withdraw(200);
            account.GetBalance();
        }

        public void Student()
        {
            Student student = new Student("John", 123);
            student.DisplayDetails();
        }

        public void Book()
        {
            Book book1 = new Book("Harry Potter");
            Book book2 = new Book("Harry Potter", "J.K. Rowling");
            Book book3 = new Book("Harry Potter", "J.K. Rowling", 500);
        }

        public void Shape()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.CalculateArea();
            
            Circle circle = new Circle(5);
            circle.CalculateArea();
        }

        public void Vehicle()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Start();
            Car car = new Car();
            car.Start();
            Bike bike = new Bike();
            bike.Start();
        }

        public void Person()
        {
            Person person1 = new Student2("Alice", 20, "S12345");
            Person person2 = new Teacher("Mr. Smith", 45, "Mathematics");

            Console.WriteLine("---- Student Details ----");
            person1.GetDetails();

            Console.WriteLine("\n---- Teacher Details ----");
            person2.GetDetails();
        }

        public void Calculator()
        {
            Calculator calculator = new Calculator();
            int sum1 = calculator.Add(10, 20);
            int sum2 = calculator.Add(10, 20, 30);
            double sum3 = calculator.Add(10.5, 12.1);

            Console.WriteLine("A + B = " + sum1);
            Console.WriteLine("A + B + C = " + sum2);
            Console.WriteLine("A + B = " + sum3);
        }

        public void Playable()
        {
            MusicPlayer musicPlayer = new MusicPlayer();
            VideoPlayer videoPlayer = new VideoPlayer();
            musicPlayer.Play();
            videoPlayer.Play();
        }

        public void Report()
        {
            Report report = new Report("Report Title", "Report Content");
            report.PrintDetails();
            report.SaveToFile("report.txt");    
        }

        public void User()
        {
            Admin admin = new Admin { Username = "admin_user" };
            Customer customer = new Customer { Username = "customer_user" };

            Console.WriteLine($"{admin.Username} ({admin.Role}) - {admin.AccessControl()}");
            Console.WriteLine($"{customer.Username} ({customer.Role}) - {customer.AccessControl()}");
        }

        public void ComplexNumber()
        {
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);
            ComplexNumber sum = c1 + c2;

            Console.WriteLine($"({c1}) + ({c2}) = {sum}");
        }

        public void Department()
        {
            Manager originalManager = new Manager("Alice");
            Department originalDepartment = new Department("HR", originalManager);

            Department shallowCopy = originalDepartment.ShallowCopy();
            Department deepCopy = originalDepartment.DeepCopy();

            originalDepartment.Manager.Name = "Bob";

            Console.WriteLine("Original Department Manager: " + originalDepartment.Manager.Name);
            Console.WriteLine("Shallow Copy Department Manager: " + shallowCopy.Manager.Name);
            Console.WriteLine("Deep Copy Department Manager: " + deepCopy.Manager.Name);
        }

        public void BankAcc()
        {
            Bank account1 = new Bank("Alice");
            Bank account2 = new Bank("Bob");

            account1.DisplayAccountInfo();
            account2.DisplayAccountInfo();

            Console.WriteLine("\nUpdating Interest Rate to 6.5%\n");
            Bank.SetInterestRate(6.5);

            account1.DisplayAccountInfo();
            account2.DisplayAccountInfo();
        }

        public void SecuritySystem()
        {
            SecuritySystem securitySystem = new SecuritySystem();
            securitySystem.Activate();
        }

        public void Button()
        {
            Button button = new Button();
            UIHandler uiHandler = new UIHandler();

            button.OnClick += uiHandler.ShowMessage;

            Console.WriteLine("Clicking the button...");
            button.Click();
        }

        public void VehicleFactory()
        {
            Vehicle2 vehicle1 = new VehicleFactory().GetVehicle("car");
            vehicle1.Drive();

            Vehicle2 vehicle2 = new VehicleFactory().GetVehicle("bike");
            vehicle2.Drive();
        }
        public static void Main()
        {
            Program program = new Program();

            //program.BankAccount();
            //program.Student();
            //program.Book();
            //program.Shape();
            //program.Vehicle();
            //program.Person();
            //program.Calculator();
            //program.Playable();
            //program.Report();
            //program.User();
            //program.ComplexNumber();
            //program.Department();
            //program.BankAcc();
            //program.SecuritySystem();
            //program.Button();
            //program.VehicleFactory();
        }
    }
}