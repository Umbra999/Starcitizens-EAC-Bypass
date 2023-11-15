using System.Diagnostics;

namespace StarcitizensBypass
{
    internal class Run
    {
        public static void Main(string[] args)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "Bin64\\StarCitizen.exe",
                Arguments = string.Join(" ", args)
            });
        }
    }
}
