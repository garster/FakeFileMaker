namespace FakeFileMaker
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      const int x = 1024;

      for (var kb = 1; kb < 11; kb++)
      {
        var b = kb * x;

        var procStartInfo =
          new System.Diagnostics.ProcessStartInfo("cmd",
            $"/c fsutil file createnew FakeFile({kb} KB).ext {b}")
          {
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
          };

        var proc = new System.Diagnostics.Process { StartInfo = procStartInfo };
        proc.Start();
      }
    }
  }
}
