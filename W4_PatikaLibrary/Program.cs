using W4_PatikaLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitapevi");
        book.PrintBookDetails();

        /* classes are blueprints for creating objects, allowing us to define properties and methods,
        also behaviours that objects of that class will have. */

        /* properties are special class members that provide read, write or compute the values of 
         private fields, allowing for encapsulation and data validation. */

        /* new keyword is used to create instances of a class and invoking its constructor. */

        /* a constuctor is a special method that is called automatically when an instance of a class
         is created, allowing for initialization of the object's properties. */
    }
}