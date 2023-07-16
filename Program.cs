using ATMPin_App;

internal class Program
{
    private static void Main(string[] args)
    {
        DebitCard checkPin = new DebitCard();

        Console.WriteLine("Welcome, create your PIN code. It must be 4 or 6 numbers: ");

        do
        {
            checkPin.PinCode = Console.ReadLine();
        } while (checkPin.PinCode == null);

        

        Console.WriteLine("value in _pinCode field: " + checkPin.PinCode);


    }
}