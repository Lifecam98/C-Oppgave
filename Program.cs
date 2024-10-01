namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        //int er en variabel der vi bruker hele tall.
        int a = 5;
        int b = 10;
        Console.WriteLine(a + b);

        //String er en variabel vi bruker for tekst.
        string name = "John Doe";
        Console.WriteLine($"Hello {name}, how are you?");

        //Double er en variabel vi bruker for tall både med og uten desimaler.
        double pi = 3.14159;
        Console.WriteLine($"The value of pi is approximately {pi}");

        //Char er en variabel vi bruker for å representere en enkelt tegn.
        char letter = 'A';
        Console.WriteLine($"The ASCII value of '{letter}' is {Convert.ToInt32(letter)}");



        Console.WriteLine("Hello, World!");
    }
}
