namespace OOP_Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnect CsharptoMySQL = new DBConnect();

            CsharptoMySQL.Insert();
            CsharptoMySQL.Update();
            CsharptoMySQL.Delete();
        }
    }
}
