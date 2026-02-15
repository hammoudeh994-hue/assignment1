Console.WriteLine("enter the invoice amount");
double amount = Convert.ToDouble(Console.ReadLine());


if (amount <= 0)
{
    Console.WriteLine("Invalid amount :{amount}");



}
else if (amount >= 500)
{
    double discountAmount = amount * 0.2;
    double finalAamount = amount - discountAmount;
    Console.WriteLine($"The final amount after discount (20%) : {finalAamount}");
  }

else if (amount < 500 && amount >= 300)
{
    double discountAmount = amount * 0.1;
    double finalAamount = amount - discountAmount;
    Console.WriteLine($"The final amount after discount (10%) : {finalAamount}");
}

else
{
    Console.WriteLine($"The final amount : {amount}");
}
