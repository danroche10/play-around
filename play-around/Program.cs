using System.Collections;

class Example
{
    // Use the PrintIntAsString method with the two methods defined above
    public static void Main()
    {
        // Create a non-generic collection of ints
        ArrayList collection = new ArrayList();

        // Add a value to the collection
        int value = 42;
        collection.Add(value);

        // Retrieve the value from the collection
        int unboxedValue = collection[0];
    }




}