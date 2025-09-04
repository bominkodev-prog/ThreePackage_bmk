using Dapper.ConsoleApp;

DapperService dap   = new DapperService();

Console.WriteLine("data is reading ...");
dap.Read();

Console.WriteLine("data is creating...");
dap.Write();

Console.WriteLine("data is updating...");
dap.Update();

Console.WriteLine("data is deleting...");
dap.Delete();

Console.ReadLine();