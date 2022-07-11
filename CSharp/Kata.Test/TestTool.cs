using System.Security.Cryptography;
using System.Text;

namespace Kata.Test;

public class TestTool 
{
    public static string GetFileHash(string filename)
    {
        var hash = new SHA1Managed();
        var clearBytes = File.ReadAllBytes(filename);
        var hashedBytes = hash.ComputeHash(clearBytes);
        return ConvertBytesToHex(hashedBytes);
    }

    public static string ConvertBytesToHex(byte[] bytes)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < bytes.Length; i++)
        {
            sb.Append(bytes[i].ToString("x"));
        }
        return sb.ToString();
    }
}