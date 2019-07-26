using Microsoft.JSInterop;
using System.Threading.Tasks;

public class JavaScriptInvokable
{
    [JSInvokable]
    public static Task<string> myfunc()
    {
        return Task.FromResult("from C#");
    }
}
