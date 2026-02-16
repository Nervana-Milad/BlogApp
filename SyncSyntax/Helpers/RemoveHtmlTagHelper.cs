using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace SyncSyntax.Helpers
{
    public static class RemoveHtmlTagHelper
    {
        public static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>| &.*?;>", string.Empty);
        }
    }
}
