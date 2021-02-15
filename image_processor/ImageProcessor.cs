using System;
using System.Drawing;
using System.Threading;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            Bitmap bmpSource = new Bitmap(file, true);
            Bitmap bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

            for (int x = 0; x < bmpSource.Width; x++)
            {
                for (int y = 0; y < bmpSource.Height; y++)
                {

                Color clrPixel = bmpSource.GetPixel(x, y);

                clrPixel = Color.FromArgb(255 - clrPixel.R, 255 - clrPixel.G, 255 - clrPixel.B);

                bmpDest.SetPixel(x, y, clrPixel);
                }
            }
            int slash = file.LastIndexOf('/') + 1;
            int dot = file.LastIndexOf('.');
            bmpDest.Save(file.Substring(slash, dot - slash) + "_inverse" + file.Substring(dot));
        }
    }

    public static void Grayscale(string[] filenames)
    {
        foreach (string file in filenames)
        {
            Bitmap bmpSource = new Bitmap(file, true);
            Bitmap bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

            for (int x = 0; x < bmpSource.Width; x++)
            {
                for (int y = 0; y < bmpSource.Height; y++)
                {

                Color clrPixel = bmpSource.GetPixel(x, y);
                int average = (clrPixel.R + clrPixel.G + clrPixel.B) / 3;
                clrPixel = Color.FromArgb(average, average, average);
                bmpDest.SetPixel(x, y, clrPixel);
                }
            }
            int slash = file.LastIndexOf('/') + 1;
            int dot = file.LastIndexOf('.');
            bmpDest.Save(file.Substring(slash, dot - slash) + "_grayscale" + file.Substring(dot));
        }
    }

    public static void BlackWhite(string[] filenames, double threshold)
    {
        foreach (string file in filenames)
        {
            Bitmap bmpSource = new Bitmap(file, true);
            Bitmap bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

            for (int x = 0; x < bmpSource.Width; x++)
            {
                for (int y = 0; y < bmpSource.Height; y++)
                {

                Color clrPixel = bmpSource.GetPixel(x, y);
                
                }
            }
            int slash = file.LastIndexOf('/') + 1;
            int dot = file.LastIndexOf('.');
            bmpDest.Save(file.Substring(slash, dot - slash) + "_bw" + file.Substring(dot));
        }
    }

    public static void Thumbnail(string[] filenames, int height)
    {
        foreach (string file in filenames)
        {
            Bitmap bmpSource = new Bitmap(file, true);
            Bitmap bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

            for (int x = 0; x < bmpSource.Width; x++)
            {
                for (int y = 0; y < bmpSource.Height; y++)
                {

                Color clrPixel = bmpSource.GetPixel(x, y);

                clrPixel = Color.FromArgb(255 - clrPixel.R, 255 - clrPixel.G, 255 - clrPixel.B);

                bmpDest.SetPixel(x, y, clrPixel);
                }
            }
            int slash = file.LastIndexOf('/') + 1;
            int dot = file.LastIndexOf('.');
            bmpDest.Save(file.Substring(slash, dot - slash) + "_th" + file.Substring(dot));
        }
    }
}
