namespace GitlabAPI.Models;

public abstract class Request
{
    public const string BASE_URL = "https://gitlab.com/api/v4/";
    
    protected abstract string GetEndpoint();
    protected abstract bool HasParameters();

    protected virtual Dictionary<string, string> GetParameters()
    {
        return new Dictionary<string, string>();
    }
    
                 
    public string GetFullUrl()
    {
        var endPoint = GetEndpoint();
        if (endPoint.StartsWith('/'))
        {
            endPoint = endPoint[1..];
        }

        var url = BASE_URL + endPoint;

        if (HasParameters())
        {
            url += "?" + GetParameters();
        }

        return url;
    }
}