using System;
using System.IO;

namespace DirectoryTreeSimulator
{
    public class DeepInside
    {
        private Directory startDirectory;

        public DeepInside(string path)
        {
            this.startDirectory = new Directory(new DirectoryInfo(path), null);
        }

        public string PrintSystem()
        {
            return startDirectory.GetString(1);
        }
    }
}