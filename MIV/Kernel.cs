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
            
        }

        protected override void Run()
        {
            MIV.StartMIV();   
        }
        
    }
}
