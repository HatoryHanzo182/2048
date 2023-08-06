namespace TwoThousandFortyEight
{
    internal static class Program
    {
        private static Random _rand = new Random();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Map());
        }
    }
}