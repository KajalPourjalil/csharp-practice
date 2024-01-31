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



 