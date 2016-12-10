using System;
using System.IO;
using Sys = Cosmos.System;

namespace MIV
{
    public class Kernel : Sys.Kernel
    {
        private static Sys.FileSystem.CosmosVFS FS;
        public static string file;
        

        protected override void BeforeRun()
        {

            FS = new Sys.FileSystem.CosmosVFS(); Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS); FS.Initialize();
            Console.WriteLine("Enter file's filename to open:");
            Console.WriteLine("If the specified file does not exist, it will be created.");
            file = Console.ReadLine();
            try
            {
                if (File.Exists(@"0:\" + file))
                {
                    Console.WriteLine("Found file!");
                }
                else if (!File.Exists(@"0:\" + file))
                {
                    Console.WriteLine("Creating file!");
                    File.Create(@"0:\" + file);
                }
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override void Run()
        {
            MIV.StartMIV(file);   
        }
        
    }
}
