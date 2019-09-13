using System.Resources;
using System.IO;
using System.Media;

struct WindowRect
{
    public int left;
    public int top;
    public int width;
    public int height;

    public WindowRect(int newLeft, int newTop, int newWidth, int newHeight)
    {
        this.left   = newLeft;
        this.top    = newTop;
        this.width  = newWidth;
        this.height = newHeight;
    }
}

struct Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Sound
{
    private SoundPlayer sndPlayer = new SoundPlayer();

    public void Play(UnmanagedMemoryStream soundResId)
    {
        // retrieve .wav from resource file.
        sndPlayer = new SoundPlayer(soundResId);   
        sndPlayer.Play();
    }

    public void Halt()
    {
        sndPlayer.Stop();
    }

    ~Sound()
    {
        sndPlayer.Stop();
        sndPlayer.Dispose();
    }
}