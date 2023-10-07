//simple interest app


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=====================================");
Console.WriteLine("Simple Calculator For Simple Interest");
Console.WriteLine("=====================================");
Console.WriteLine("Choose what you wanna solve for: ");
Console.WriteLine(" 1.SimpleInterest\n 2.Principal\n 3.Rate\n 4.Time");
 Console.WriteLine("Choose your Operation: ");
 Console.ResetColor();
 Console.ForegroundColor = ConsoleColor.Red;
 int userInput = Convert.ToInt32(Console.ReadLine());
 Console.ResetColor();
 switch (userInput)
 {
     case 1:
         SimpleInterest(); 
         break;
     case 2:
         principal(); 
         break;
     case 3:
         rate(); 
         break;
     case 4:
         time();
        break;
     default: throw new InvalidOperationException("Operator not recognized!");
         break;
}
static void SimpleInterest()
{
Console.Write(" Welcome to Simple Interest!!!.\n Enter the below command....\n");
double Principal;
double Rate;
double Time;
double simpleInterest;

bool flag = true;
do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the principal");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Principal = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the rate");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Rate = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the time");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Time = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    simpleInterest = (Principal * Rate * Time) / 100;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Your answer is: " + simpleInterest);
    Console.ResetColor();

    string continueOption = string.Empty;

    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n Do you want to continue: (Y/N)" );
        Console.ResetColor();
        continueOption = Console.ReadLine()!;

    } while ( continueOption != "y" && continueOption != "n");

    flag = continueOption == "y";
    
} while (flag);        

}
static void principal()
{
Console.Write(" Welcome to Principal!!!.\n Enter the below command...\n");
double Principal;
double Rate;
double Time;
double simpleInterest;

bool flag = true;
do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the Simple Interest: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    simpleInterest = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the rate");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Rate = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the time");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Time = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Principal = (simpleInterest * 100) / (Rate * Time);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Your answer is: " + Principal);
    Console.ResetColor();

    string continueOption = string.Empty;

    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n Do you want to continue: (Y/N)" );
        Console.ResetColor();
        continueOption = Console.ReadLine()!;

    } while ( continueOption != "y" && continueOption != "n");

    flag = continueOption == "y";
    
} while (flag);        

}
static void rate()
{
Console.Write(" Welcome to Rate!!!.\n Enter the below command...\n");
double Principal;
double Rate;
double Time;
double simpleInterest;

bool flag = true;
do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the Simple Interest: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    simpleInterest = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the Principal: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Principal = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the time");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Time = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Rate = (simpleInterest * 100) / (Principal * Time);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Your answer is: " + Rate);
    Console.ResetColor();

    string continueOption = string.Empty;

    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n Do you want to continue: (Y/N)" );
        Console.ResetColor();
        continueOption = Console.ReadLine()!;

    } while ( continueOption != "y" && continueOption != "n");

    flag = continueOption == "y";
    
} while (flag);        

}
static void time()
{
Console.Write(" Welcome to Time!!!.\n Enter the below command...\n");
double Principal;
double Rate;
double Time;
double simpleInterest;

bool flag = true;
do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the Simple Interest: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    simpleInterest = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the Principal: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Principal = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter the value of the Rate: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Rate = Convert.ToInt64(Console.ReadLine());
    Console.ResetColor();

    Time = (simpleInterest * 100) / (Principal * Rate);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Your answer is: " + Time);
    Console.ResetColor();

    string continueOption = string.Empty;

    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n Do you want to continue: (Y/N)" );
        Console.ResetColor();
        continueOption = Console.ReadLine()!;

    } while ( continueOption != "y" && continueOption != "n");

    flag = continueOption == "y";
    
} while (flag);        
}