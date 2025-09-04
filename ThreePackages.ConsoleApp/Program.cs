using ThreePackages.ConsoleApp;

AdoDotnet ado = new AdoDotnet();

Console.WriteLine("data is reading....... ");
Console.WriteLine();
ado.Read();

Console.WriteLine("data is creating");
Console.WriteLine();
ado.Write();

Console.WriteLine("data is updating");
Console.WriteLine();
ado.Update();

Console.WriteLine("data is deleting");
Console.WriteLine();
ado.Delete();


Console.ReadLine();