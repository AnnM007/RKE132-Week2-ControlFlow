

//Rakendus küsib kasutajal valida tema sugu (m/f)
//Rakendus küsib sistestada tema perekonna nime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gener (m/f):");

char userGender = Char.Parse(Console.ReadLine());
//Console.ReadLine() loeb ainult konsoolist maha andmeid string (sõne) formaadist

Console.WriteLine("Plase, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}


//Kahe if-iga kontrollib veelkord "topelt"
//Else if-iga kui esimene vastust klapib siis ei vaata edasi ega ei koorma