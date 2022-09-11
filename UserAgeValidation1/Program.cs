//Rakendus küsib kasutajal sisestada tema vanus
//Kui kasutaja vanus on väiksem kui 13, siis konsool kuvab:
//"You are too young to use Instagram"
//Muul juhul
//Kuvatakse "Welcome to Instagram!"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); 
//"13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");

}
else //if (userAge <13)
{
    Console.WriteLine("You are too young to use Instagram.");
}
