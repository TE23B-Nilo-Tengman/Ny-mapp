int score = 0;

Console.WriteLine("1. Vad heter den svenska kungen?");
Console.WriteLine("a) Hugo | b) Carl | c) Gustav XVI Adolf");

string choice1 = Console.ReadLine();
if (choice1.ToLower() == "b"){
    Console.WriteLine("Rätt!");
    score++;
}
else{
    Console.WriteLine("Fel");
}

Console.WriteLine("2. Hur stor är min tumme?");
Console.WriteLine("a) 5cm | b) 7,4cm | c) några cm ;)");

string choice2 = Console.ReadLine();
if (choice2.ToLower() == "c"){
    Console.WriteLine("Rätt!");
    score++;
}
else{
    Console.WriteLine("Fel");
}

Console.WriteLine("3. Vilket svar är rätt?");
Console.WriteLine("a) hej hej | b) hejhej | c) b är rätt ;)");

string choice3 = Console.ReadLine();
if (choice3.ToLower() == "b"){
    Console.WriteLine("Rätt!");
    score++;
    Console.WriteLine($"Du fick {score} poäng!!!!");
}
else{
    Console.WriteLine("Fel");
    Console.WriteLine($"Du fick {score} poäng!!!!");
}


Console.ReadLine();