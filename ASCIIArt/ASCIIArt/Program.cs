using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;

namespace ASCIIArt
{
    internal class Program
    {
    public static Bitmap ResizeImage(Bitmap originalImage, int newWidth)
        {
            int originalWidth = originalImage.Width;
            int originalHeight = originalImage.Height;

            int newHeight = (int)Math.Round(originalHeight * ((double)newWidth / originalWidth));

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        static void Main(string[] args)
        {
            const int WINDOW_X = 190;
            Console.SetWindowSize(WINDOW_X, 50);
            char[] asciiChars = { ' ', '.', ':', '-', '=', '+', '*', '#', '%', '@' };
            string fileName = "puppy.jpg";
            StringBuilder sb = new StringBuilder();
            
            VideoCapture capture = new VideoCapture(0);

            // 영상 처리를 위한 무한 반복문
            Console.WriteLine("Video On");
            
            while (!(Console.KeyAvailable))
            {
                sb.Clear();
                Console.SetCursorPosition(0, 0);

                //Cv2.NamedWindow("Video");

                // VideoCapture 객체로부터 영상 프레임을 가져옴
                using (Mat frame = new Mat())
                {
                    capture.Read(frame);

                    // 가져온 영상이 없으면 루프를 빠져나감
                    if (frame.Empty())
                        break;

                    Cv2.Flip(frame, frame, FlipMode.Y);
                    //Cv2.ImShow("Video", frame);

                    Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                    Bitmap resizeImage = ResizeImage(bitmap, 40);
                    int width = resizeImage.Width;
                    int height = resizeImage.Height;
                    int padding = WINDOW_X / 2 - 40 /2 - 2;
                    Console.SetCursorPosition(0, 8);
                    for (int y = 0; y < height; y++)
                    {
                        int i = 0;
                        while (i++ < padding) sb.Append(" ");
                        for (int x = 0; x < width; x++)
                        {
                            Color color = resizeImage.GetPixel(x, y);
                            float brightness = color.GetBrightness();
                            int index = (int)Math.Floor(brightness * (asciiChars.Length - 1));
                            sb.Append(asciiChars[index]);
                        }
                        sb.Append("\n");
                    }
                    
                    
                    
                    Console.WriteLine(sb.ToString());
                }
                // 1밀리초 대기
                Cv2.WaitKey(10);
                Thread.Sleep(10);

            }
            //Cv2.DestroyWindow("Video");

            // 창을 닫음
            capture.Release();
        }
    }
}
