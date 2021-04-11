namespace DirectoryTreeSimulator
{
    public class SystemStaff
    {
        protected string name;
        public SystemStaff(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}