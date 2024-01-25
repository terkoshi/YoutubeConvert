using Pastel;

//corny name corny namespace corny...
namespace Rydrogen.Solutions
{
    internal class Utils
    {
        static string client = "Client";
        static string Time => DateTime.Now.ToString("hh:mm:ss");
        public static void Message(string text) 
        { 
            Console.Write($"[{client.Pastel(ConsoleColor.Cyan)}] ");
            Console.Write(text);
        } 
        public static void Error(string text) => Console.WriteLine($"[{"X".Pastel(System.Drawing.Color.MistyRose)}] => {text.Pastel(ConsoleColor.Red)}");
        public static void Warning(string text) => Console.WriteLine($"[{"!".Pastel(System.Drawing.Color.LightYellow)}] => {text.Pastel(ConsoleColor.Yellow)}");
        public static void Success(string text) => Console.WriteLine($"<{Time.Pastel(System.Drawing.Color.LightBlue)}> <{"+".Pastel(System.Drawing.Color.LightBlue)}> => {text.Pastel(System.Drawing.Color.LightBlue)}");

    }
    internal class CYoutube
    {
        public static void MP4C(string uri)
        {
            try
            {
                var val = Environment.GetEnvironmentVariable("RYDROGEN_CLIENT_PATH", EnvironmentVariableTarget.User);
                Console.Title = $"Current Download PATH: {val}";

                Utils.Message("Currently Downloading... \n");
                var youtube = VideoLibrary.YouTube.Default;
                var v = youtube.GetVideo(uri);
                string title = v.Title;
                VideoLibrary.VideoInfo info = v.Info; // (Title,Author,LengthSeconds)
                string fullName = v.Title; // same thing as title + fileExtension
                int resolution = v.Resolution;
               
                fullName += ".mp4";
                byte[] bytes = v.GetBytes();
                var stream = v.Stream();
                try
                {
                   
                    File.WriteAllBytes($"{val}/" + fullName , bytes);
                    string Path = $"{val}/" + fullName;
                    Utils.Success("Complete!");
                    Utils.Success("Location: " + Path);

                }
                catch(Exception e)
                {
                    Utils.Error(e.Message);
                }

            }
            catch(Exception e)
            {
                Utils.Error(e.Message);
            }
        }
        public static void MP3C(string uri)
        {
            try
            {
                var val = Environment.GetEnvironmentVariable("RYDROGEN_CLIENT_PATH", EnvironmentVariableTarget.User);
                Console.Title = $"Current Download PATH: {val}";

                Utils.Message("Currently Downloading... \n");
                var youtube = VideoLibrary.YouTube.Default;
                var v = youtube.GetVideo(uri);
                string title = v.Title;
                VideoLibrary.VideoInfo info = v.Info; // (Title,Author,LengthSeconds)
                string fullName = v.Title; // same thing as title + fileExtension
                int resolution = v.Resolution;

                fullName += ".mp3";
                byte[] bytes = v.GetBytes();
                var stream = v.Stream();
                try
                {

                    File.WriteAllBytes($"{val}/" + fullName, bytes);
                    string Path = $"{val}/" + fullName;
                    Utils.Success("Complete!");
                    Utils.Success("Location: " + Path);

                }
                catch (Exception e)
                {
                    Utils.Error(e.Message);
                }

            }
            catch (Exception e)
            {
                Utils.Error(e.Message);
            }
        }
    }
}
