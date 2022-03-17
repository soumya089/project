namespace OnlineExamApp.DataAccessLayer
{
    public interface ILoginDao
    {
        string Authenticate(string uname, string pwd);
    }
}
