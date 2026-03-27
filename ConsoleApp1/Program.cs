namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string customerName = "Trinity";

            int itemsInCart = 3;

            decimal itemPrice = 99.99m;

            bool isLoggedIn = true;

            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Items in Cart: " + itemsInCart);
            Console.WriteLine("Item Price: R" + itemPrice);
            Console.WriteLine("User Logged In: " + isLoggedIn);

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();


            //2
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---- User Information ----");

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height (m): " + height);

            Console.WriteLine();


            //3
            Console.Write("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            double sum = number1 + number2;

            double difference = number1 - number2;

            double product = number1 * number2;

            double quotient = number1 / number2;

            Console.WriteLine();
            Console.WriteLine("---- Calculation Results ----");

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            Console.WriteLine();

            //4

            Console.Write("Enter your weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height (m): ");
            double height1 = double.Parse(Console.ReadLine());

            double bmi = weight / (height1 * height1);

            Console.WriteLine();

            Console.WriteLine("Your BMI is: " + bmi.ToString("F2"));


            //5
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Test 1 mark: ");
            double test1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Test 2 mark: ");
            double test2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Exam mark: ");
            double exam = double.Parse(Console.ReadLine());

            double finalMark = (test1 * 0.25) + (test2 * 0.25) + (exam * 0.50);

            Console.WriteLine();
            Console.WriteLine("---- Student Final Results ----");

            Console.WriteLine("Student Name: " + studentName);

            Console.WriteLine("Test 1: " + test1.ToString("F2"));
            Console.WriteLine("Test 2: " + test2.ToString("F2"));
            Console.WriteLine("Exam: " + exam.ToString("F2"));
            Console.WriteLine("Final Mark: " + finalMark.ToString("F2"));

            Console.WriteLine();

        }
    }
}
