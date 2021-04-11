using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTreeSimulator
{
    public class Directory : SystemStaff
    {
        public List<File> files;
        public List<Directory> directories;
        public Directory parent;

        public Directory(DirectoryInfo directoryInfo, Directory parent) : base(directoryInfo.Name)
        {

            this.parent = parent;
            directories = FindChildDirectories(directoryInfo.GetDirectories());
            files = FindChildFiles(directoryInfo.GetFiles());
        }

        private List<Directory> FindChildDirectories(DirectoryInfo[] directoryInfos)
        {
            return directoryInfos.Select(directoryInfo => new Directory(directoryInfo, this)).ToList();
        }
        private List<File> FindChildFiles(FileInfo[] FileInfos)
        {
            return FileInfos.Select(fileInfo => new File(fileInfo, this)).ToList();
        }

        public string GetString(int i)
        {
            var tabs = "\t";
            for (var p = 0; p < i; p++)
                tabs += tabs;
            var res = tabs + this;
            foreach (var file in files)
            {
                res += "\n" + file.GetString(i+1);
            }
            foreach (var directory in directories)
            {
                res += "\n" + directory.GetString(i+1);
            }

            return res;
        }
    }
}