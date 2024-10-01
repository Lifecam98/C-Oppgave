namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Int er en variabel der vi bruker hele tall.
        int a = 5;
        int b = 10;
        Console.WriteLine(a + b);

        // String er en variabel vi bruker for tekst.
        string name = "John Doe";
        Console.WriteLine($"Hello {name}, how are you?");

        // Double er en variabel vi bruker for tall både med og uten desimaler.
        double pi = 3.14159;
        Console.WriteLine($"The value of pi is approximately {pi}");

        // Char er en variabel vi bruker for å representere en enkelt tegn.
        char letter = 'A';
        Console.WriteLine($"The ASCII value of '{letter}' is {Convert.ToInt32(letter)}");

        // Arrays, store multiple values av samme datatype
        int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

        // Loop igjennom array, bruker index-baserte iteratore
        // Iterator++ er det samme som: Iterator = iterator + 1;
        for (int iterator = 0; iterator < myIntArray.Length; iterator++)
        {
            Console.WriteLine ($"Iterator on position: {iterator}, index of the numbers in the array: {myIntArray[iterator]}");
        }

        // Vi assigner en ny string array, og vi bruker string[] myStringArray = {"some", "strings"};
        string[] myStringArray = { "Hello", "From", "A", "String", "Array" };

        // Vi kan bruke en foreach loop, for å loope gjennom string arrayen med en enkelt string variabel.
        // string[] er et array, (string myStrings) er en singel variabel, og in myStringArray er en iterator.
        foreach (string myStrings in myStringArray)
        {
            Console.WriteLine(myStrings);
        }

        // Fortsett her!
    }
}
