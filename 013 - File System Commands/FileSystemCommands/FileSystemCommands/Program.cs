namespace FileSystemCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write(">> ");
                var input = Console.ReadLine().Trim();
                var whitespace = input.IndexOf(' ');
                var command = input.Substring(0, whitespace).ToLower();
                var path = input .Substring(whitespace + 1).Trim();
                if (command== "list")
                {
                    foreach(var e in Directory.GetDirectories(path))
                    {
                        Console.WriteLine("\t [Dir]"+e);
                    }
                    foreach(var e in Directory.GetFiles(path))
                    {
                        Console.WriteLine("\t [File]"+e);
                    }

                }
                if (command == "info")
                {
                    if (Directory.Exists(path))
                    {
                    var dirinfo = new DirectoryInfo(path);
                        Console.WriteLine("Type: Directory");
                        Console.WriteLine("Created At: " + dirinfo.CreationTime);
                        Console.WriteLine(" Last Modified At: " + dirinfo.LastWriteTime);
                    }
                    else if (File.Exists(path))
                    {
                        var FileInfo = new FileInfo(path);
                        Console.WriteLine("Type File ");
                        Console.WriteLine("added" + FileInfo.CreationTime );
                        Console.WriteLine("last Modified At"+ FileInfo.LastWriteTime);
                        Console.WriteLine("Size In Bytes: "+ FileInfo.Length);

                    }
                    else { Console.WriteLine("Not Found"); }
                }
                if (command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                    string folderName = path.Substring(path.LastIndexOf('\\') + 1);
                    Console.WriteLine(folderName + " Added");
                }
                if (command == "remove")
                {
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path);
                    }
                    else if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    string folderName = path.Substring(path.LastIndexOf('\\') + 1);
                    Console.WriteLine(folderName + " Removed");
                }
                if (command == "read")
                {
                    if (File.Exists(path))
                    {
                       var Content = File.ReadAllText(path);
                        Console.WriteLine(Content);
                    }
                }
                if (command == "exit")
                {

                }


            }

        }
    }
}