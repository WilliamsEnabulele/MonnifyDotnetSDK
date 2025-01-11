namespace MonnifyDotnet.SDK.Shared
{
    public static class Utilities
    {
        public static string ToQueryString(object obj)
        {
            return string.Join("&",
                obj.GetType()
                   .GetProperties()
                   .Where(p => p.GetValue(obj, null) != null)
                   .Select(p => $"{Uri.EscapeDataString(p.Name)}={Uri.EscapeDataString(p.GetValue(obj, null)?.ToString() ?? string.Empty)}"));
        }
    }
}