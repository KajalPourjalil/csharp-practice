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

