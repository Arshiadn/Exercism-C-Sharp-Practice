using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        ArgumentNullException.ThrowIfNull(identifier);
        
        string result = Regex.Replace(identifier, @"\s", "_");

        result = Regex.Replace(result, @"-(.)", match =>
            match.Groups[1].Value.ToUpperInvariant());

        result = Regex.Replace(result, @"\p{Cc}", "CTRL");

        result = Regex.Replace(result, @"[α-ω]", "");
        
        return Regex.Replace(result, @"[^\p{L}_]", "");
    }
}
