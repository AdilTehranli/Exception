namespace Project2.Helpers;

public static class Helper
{
    public static Dictionary<string, string> ExceptionMessage=new();
    static Helper()
    {
        
        ExceptionMessage.Add("AgecheckException", "yasiniz 16 dan kicikdir");
    }
}
