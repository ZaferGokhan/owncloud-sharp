using System;
using System.IO;
using System.Reflection;

namespace owncloudsharp.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var c = new Client("https://cloud.zafergokhan.com/", "uploaduser", "uploadpassword");
            var de = c.Download("/5K_Wallpaper_9.png");
            using (var fileStream = new FileStream(path + "\\5K_Wallpaper_9.png", FileMode.Create, FileAccess.Write))
            {
                de.CopyTo(fileStream);
            }

            Stream fs = File.OpenRead(path + "\\5K_Wallpaper_9.png");
            c.Upload("/Zafer.png", fs);
            var ps = c.ShareWithLink("/Zafer.png");


        }
    }
}
