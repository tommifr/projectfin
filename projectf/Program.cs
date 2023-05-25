
// game start
while (true)
{
    Console.Clear();


//name generator
Random namegenerator = new Random();
int i = namegenerator.Next(6);
string[] names = {"Chair", "Wall", "Carpet", "Ceiling", "Hugo", "Clock"};
string name = names [i];
string foodchoice="";






Console.WriteLine($"hey your name is {name}");
Console.WriteLine($"hi {name}. Where did you eat lunch max , sub or other?");



// makes sure you only answer max sub or other
while(foodchoice!="max"&& foodchoice!="sub" && foodchoice!="other")
{
    foodchoice=Console.ReadLine();

    if (foodchoice == "max")
    {
    Maxchoice();
    
    }

    else if (foodchoice == "sub")
    {
        Subchoice();
    }

    else if (foodchoice=="other")
    {
        Otherchoice();
    }

    else
    {
        Console.WriteLine("answer max sub or other");
        foodchoice="";
    }

}










//methods   

void Maxchoice()
{

  Console.WriteLine("Eh ok... weird but sure");
  Console.WriteLine(" bad ending eat somewhere else");
  Console.WriteLine("press enter to restart");
  Console.ReadLine();

}

void Subchoice()
{
    Console.WriteLine("ah ok nice");
    Console.WriteLine("neutral ending ");
    Console.WriteLine("press enter to restart");
    Console.ReadLine();
    
}
void Otherchoice()
{
    Console.WriteLine("ah nice");
    Console.WriteLine("good ending hope you ate something good");
    Console.WriteLine("press enter to restart");
    Console.ReadLine();
    
}

}