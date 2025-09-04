using EFcore.ConsoleApp;

BookService bk = new BookService();

Console.WriteLine("data is reading ...");
bk.Read();

Console.WriteLine("data is creating..");
bk.Write();

Console.WriteLine("data is updating");
bk.Update();

Console.WriteLine("data is deleting");
bk.Delete();