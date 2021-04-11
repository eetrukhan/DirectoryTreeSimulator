using System.IO;

namespace DirectoryTreeSimulator
{
    public class File : SystemStaff
    {
        public long length;
        public Directory parent;
        public File(FileInfo fileInfo, Directory parent) : base(fileInfo.Name)
        {
            this.parent = parent;
            this.length = fileInfo.Length;
        }
        
        public string GetString(int i)
        {
            var tabs = "\t";
            for (var p = 0; p < i; p++)
                tabs += tabs;
            var res = tabs + this;
            return res;
        }
    }
}