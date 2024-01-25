using Rydrogen.Solutions;

class Program : Utils
{
    static int Main()
    {
        //could of done with with switch cases but I don't care.
        Message("MP3 or MP4? : ");
        var s = Console.ReadLine();
        if(s == "MP4")
        {
            Message("LINK: ");
            var mp4 = Console.ReadLine();
            if (mp4 != null)
            {
                CYoutube.MP4C(mp4);
            }         
        }
        else if (s == "MP3")
        {
            Message("LINK: ");
            var mp3 = Console.ReadLine();
            if (mp3 != null)
            {
                CYoutube.MP3C(mp3);
            }
        }
        else
        {
            Error("INVAILD COMMAND.");
        }
        return 0;
    }
}