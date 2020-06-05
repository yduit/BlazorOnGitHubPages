using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorOnGitHubPages
{
    public static class FileUtil
    {
        public static ValueTask SaveAs(this IJSRuntime js, string filename, byte[] data)
            => js.InvokeVoidAsync(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}