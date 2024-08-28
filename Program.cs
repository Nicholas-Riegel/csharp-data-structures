// ARRAYS
// Arrays are a collection of elements of the same type
// in C# arrays are static in size, meaning you can't add or remove elements
// but you can change the values of the elements

// 5 is the size of the array
// int[] numbers = new int[5]; 

// Console.WriteLine("Enter a number: ");
// numbers[0] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The number you entered was: {numbers[0]}");

// ARRAY SORTING
// int[] numbers = new int[5]
// {
//     5, 2, 3, 4, 1
// };

// Array.Sort(numbers); // returns void; affects the array directly
// Array.Reverse(numbers); // reverses the array

// arrays are static in size, so we can't add or remove elements
// but you can change the values of the elements

// numbers[0] = 1;


// CLEARING AN ARRAY
// Array.Clear(numbers, 0, numbers.Length); // clears the array from index 0 to the end

// foreach (int number in numbers) Console.WriteLine(number);

// LISTS

List<int> numbers1 = new List<int>()
{
    1, 2, 3, 4, 5
};
// or
List<int> numbers2 = [1, 2, 3, 4, 5];

numbers1.Add(6); // adds 6 to the end of the list
numbers1.Insert(0, 6); // inserts 6 at index 0
numbers1.RemoveAt(0); // removes the element at index 0
numbers1.RemoveAt(numbers1.Count - 1); // removes the last element

numbers1.Add(7);
numbers1.Remove(7); // removes the first 6 from the list
numbers1.RemoveAll(n => n == 6); // removes all 6s from the list
numbers1.Clear(); // clears the list
numbers1.AddRange(numbers2); // adds all elements from numbers2 to numbers1
numbers1.Contains(1); // returns true if the list contains 1
numbers1.IndexOf(1); // returns the index of the first 1 in the list

// foreach (int number in numbers1) Console.WriteLine(number);


// DICTIONARIES
// Dictionaries are collections of key-value pairs
// the key is unique and the value can be anything
// Dictionaries are not sorted or indexed

Dictionary<string, string> config1 = new Dictionary<string, string>()
{
    {"resolution", "1920x1080"},
    {"title", "My game"}
};
// or
Dictionary<string, string> config2 = new()
{
    {"resolution", "1920x1080"},
    {"title", "My game"}
};
// or
Dictionary<string, string> config3 = new()
{
    ["resolution"] = "1920x1080",
    ["title"] = "My game"
};
// or
Dictionary<int, string> names = [];

names.Add(1, "John");
names.Add(2, "Jane");
names[2] = "Doe"; // changes the value of the key 2
// Console.WriteLine(names[1]); // John
// Console.WriteLine(names[2]); // Doe

for (int i = 0; i < names.Count; i++)
{
    // Console.WriteLine(names.ElementAt(i));
    // KeyValuePair<int, string> pair = names.ElementAt(i);
    // Console.WriteLine(pair.Key + " " + pair.Value);
    // Console.WriteLine($"{pair.Key} - {pair.Value}");
    // Console.WriteLine(pair);
}

// foreach (var pair in names)
foreach (KeyValuePair<int, string> pair in names)
{
    // Console.WriteLine(pair.Key + " " + pair.Value);
    // Console.WriteLine($"{pair.Key} - {pair.Value}");
    // Console.WriteLine(pair);
}

Dictionary<string, string> teachers = new()
{
    ["Math"] = "Jack",
    ["English"] = "Brody"
};

// if (teachers.TryGetValue("Mth", out string? teacher))
// {
//     Console.WriteLine(teacher);
// }
// else
// {
//     Console.WriteLine("Teacher not found");
// }

// EXCERCISE
// Create two lists of integer data type, one for even one for odd numbers
// Loop through the numbers from 1 to 20 and add them to the appropriate list
// Print the even and odd lists
// List<int> evenNumbers = [];
// List<int> oddNumbers = [];

// for (int i = 0; i <= 20; i++)
// {
//     if (i % 2 == 0)
//     {
//         evenNumbers.Add(i);
//     }
//     else
//     {
//         oddNumbers.Add(i);
//     }
// }
// foreach (int number in evenNumbers) Console.Write(number + " ");
// Console.WriteLine();
// foreach (int number in oddNumbers) Console.Write(number + " ");

/*
Define and initialize two integers num and length
(7, 5) -> [7, 14, 21, 28, 35]
Create int array with the size length
loop through an insert the (loop counter x num) inot the array
print the final array
*/

int num = 5;
int length = 5;

int[] arr0 = new int[length];

for (int i = 0; i < arr0.Length; i++)
{
    arr0[i] = num * (i + 1);
}

foreach(int item in arr0)
{
    Console.Write(item + " ");
}