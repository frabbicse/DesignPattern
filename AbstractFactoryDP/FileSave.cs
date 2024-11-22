namespace AbstractFactoryDP
{
    public class FileSave : IFileSave
    {
        public int Save()
        {
            Console.WriteLine("file saved");
            return 0;
        }
    }
}
