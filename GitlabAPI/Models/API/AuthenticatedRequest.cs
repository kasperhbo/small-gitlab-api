using System.Net;

namespace GitlabAPI.Models;

public abstract class AuthenticatedRequest : Request
{
    protected abstract string GetToken();

    private void test()
    {
        using (var client = new HttpWebRequest())
        {
            
        }
    }
    
    protected override Dictionary<string, string> GetParameters()
    {
        var parameters = new Dictionary<string, string>();
        parameters.Add("private_token", GetToken());
        return parameters;
    }
}