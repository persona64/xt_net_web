using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace Task5Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"E:\Testing\trySome.txt");
            var create = file.Create();
            create.Close();
            var stream = new FileStream(@"E:\Testing\trySome.txt", FileMode.Open);
            var buffStream = new BufferedStream(stream);
            var writer = new StreamWriter(buffStream);

            SpaceShip fighter = new SpaceShip();

            fighter.Name = "Irbadan";
            fighter.Size = 56;
            fighter.NumberOfGuns = 4;

            writer.WriteLine(JsonConvert.SerializeObject(fighter));


            
            writer.Close();
            FilesActions();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]

        public static void FilesActions()
        {

            Console.WriteLine("Какой из режимов вы хотите включить?\n 1 - режим наблюдения \n 2 - режим отката изменений");

            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = @"E:\Testing";

                watcher.NotifyFilter = NotifyFilters.LastAccess
                                    | NotifyFilters.LastWrite
                                    | NotifyFilters.FileName
                                    | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";

                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRename;

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Нажмите 'q' для выхода из демонстрации");
                while (true)
                {
                    var k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Q)
                        break;
                }
            }

        }

        private static void OnChanged(object source, FileSystemEventArgs e) =>
            Console.WriteLine($"E:Testing: {e.FullPath} {e.ChangeType}");

        private static void OnRename(object source, RenamedEventArgs e) =>
            Console.WriteLine($"E:Testing: {e.OldFullPath} renamed to {e.FullPath}");
    }

    public class SpaceShip
    {
        public string Name { get; set; } = "Normandy";
        public int Size { get; set; }
        public int NumberOfGuns { get; set; }

    }
}
