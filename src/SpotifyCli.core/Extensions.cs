namespace SpotifyClientCli
{
    public static class Extensions
    {
        public static async Task ColoredWriteLineAsync(this IConsole console, object content, ConsoleColor color)
        {
            console.ForegroundColor = color;
            console.WriteLine(content);
            console.ResetColor();
            await Task.CompletedTask;
        }

        public static string ListToString(this List<string> list)
        {
            string[] arr = list.ToArray();
            string str = string.Join("\n ", arr);
            return str;
        } 
    }
}