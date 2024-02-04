// See https://aka.ms/new-console-template for more information
Console.WriteLine("You can do this Kajal!");

string name = "Alexandra";

//string interpolation with using $
Console.WriteLine($"{name} is both my girlfriend and my wife");

string greeting = "            gambateee           ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string firstFriend = "shadow";

string secondFriend = "tails";

string friends = $"{firstFriend} and {secondFriend} are best friends.";

Console.WriteLine(friends);
// Console.WriteLine(friends.Replace("tails", "sonic"));
friends = friends.Replace("tails", "sonic");
Console.WriteLine(friends);

Console.WriteLine(friends.Contains("sonic"));

Console.WriteLine(friends.Length);

Console.WriteLine(friends.StartsWith("hello"));

int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int n = 2100000000;
int m = 2100000000;
long v = (long)n + (long)m;
Console.WriteLine(v);

double r = 34.2;
double e = 29.9;
double x = r + e;
Console.WriteLine(x);


//if statements and loops
int k = 9;
int l = 5;
if ((k + l) > 10) {
    Console.WriteLine("true");
}
else {
    Console.WriteLine("false");
}

if((k - l) < 10) Console.WriteLine("true");
else Console.WriteLine("false");

int o = k + l;
bool test = o > k;
Console.WriteLine(test);

// && == || 

//while loops

int counter = 0;
// counter += 1;
// Console.WriteLine(counter);
// counter += 1;
// Console.WriteLine(counter);
// counter += 1;
// Console.WriteLine(counter);
// counter += 1;
// Console.WriteLine(counter);


while(counter < 10){
    counter += 1;
}
Console.WriteLine(counter);


while(counter < 5){
    counter++;
    Console.WriteLine(counter);
    // counter++;
}

//for loops


for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"the cell is ({row}, {column})");
    }
}

//using list of t. t is type
//working with foreach

var surnames = new List<string> {"alex", "ana", "felipe"};
surnames.Add("Kajal");

foreach (var i in surnames)
{
    Console.WriteLine($"Hello {i.ToUpper()}!");
}

//arrays , lists, indexing and foreach

Console.WriteLine(surnames[0]);
Console.WriteLine(surnames[3]);
Console.WriteLine(surnames[^1]); //last one
Console.WriteLine(surnames[^2]);


var numbers = new List<int> {1,2,3,4,5,6,7,8,9};

// foreach (var j in numbers[2..7])
// {
//    Console.WriteLine(numbers);
// }

var bings = new string[] {"alex", "kajal"}; //array

for (int i = 0; i < bings.Length; i++)
{
    Console.WriteLine(bings[i]);
}


//add a new item
bings = [..bings, "ever"];//appending

foreach(var j in bings){
    Console.WriteLine($"hello {j.ToUpper()}");
}

//use defualt list instead of arrays

//sorting and searching lists
var hazbin = new List<string> {"angel", "stolas", "blitz"};
//sorting
hazbin.Sort();


foreach (var item in hazbin)
{
    Console.WriteLine($"piss off {item.ToUpper()}");
}

var helluva = new List<int> {54, 34, 8, 23, 144};

// helluva.Sort();

foreach (var item in helluva)
{
    Console.WriteLine($"{item}");
}

// Console.WriteLine($"i found 8 at the index of {helluva.IndexOf(8)}");

//language integrated query (LINQ) makes working with a collection
//of things much simpler

int[] scores = [97, 99, 80, 70, 5, 100, 32]; //an array

var fels = new List<int> {0, 9, 8};

List<int> nesd = [5,4,3,0,2];

//find all the scores over eighty

// for (int i = 0; i < scores.Length; i++) {
//     if (scores[i] > 80)
//     {
//          Console.WriteLine($"found a score over 80 {scores[i]}");
//     }
// }

// return;

//IEnumerable: describes

IEnumerable<string> query = 
from score in scores 
where score < 80 
orderby score descending 
select $"the score is {score}";

foreach (string i in query)
{
    // Console.Write(i + " ");
}

//object orientation

//different way of making people

var p1 = new Person("Alexandra", "Arrieche", new DateOnly(1981,5,4));
var p2 = new Person("Kajal", "Pourjalil", new DateOnly(1998,10,22));

p1.Pets.Add(new Cat("Mortricia"));

List<Person> people = [p1,p2];

foreach (var person in people)
{
    Console.WriteLine($"{person}");

    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"      {pet}");
    }
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First { get; } = firstName;
    public string Last { get; } = lastName;
    public DateOnly Birthday { get; } = birthday;

    public List<Pet> Pets{ get;} = new();

    public override string ToString()
    {
        return $"Human {First} {Last}";
    }

}

public abstract class Pet(string firstName){
    public string First { get; } = firstName;
    public abstract string MakeNoise();

     public override string ToString()
    {
        return $"{firstName} and I am a {GetType().Name} and I {MakeNoise()}";
    }
}


public class Cat(string firstName) : Pet(firstName)
{

    public override string MakeNoise() => "meow";


}

public class Dog(string firstName) : Pet(firstName)
{

    public override string MakeNoise() => "bark";
}