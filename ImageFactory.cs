namespace Bubbles_Particle_WFApp
{
    public static class ImageFactory
    {
        private static readonly string assetsPath = Path.Combine(Application.StartupPath)
           .Replace("bin\\Debug\\net6.0-windows\\", "Assets\\");

        public readonly static List<string> Backgrounds = GetFilePath("jpg");

        public readonly static Image Image = GetImage("bubble.png");


        private static List<string> GetFilePath(string fileType)
        {
            return Directory.GetFiles(assetsPath, $"*.{fileType}").ToList();
        }

        private static Image GetImage(string file)
        {
            return Image.FromFile(assetsPath + file);
        }
    }
}
