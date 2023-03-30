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
        public const int WINDOW_X = 190;
        public static char[] asciiChars = { ' ', '.', ':', '-', '=', '+', '*', '#', '%', '@'};
        //public static char[] asciiChars = { '@', '.', ':', '-', '=', '+', '*', '#', '%', ' ' };
        

        public const int CAPTURE_SIZE = 40;
        public const int PADDING_SIZE = WINDOW_X / 2 - CAPTURE_SIZE / 2 - 2;

        public const int CURSOR_START_Y = CAPTURE_SIZE / 5;

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

        public static void VideoCapture(Bitmap resizeImage, StringBuilder sb)
        { 
            int width = resizeImage.Width;
            int height = resizeImage.Height;
            int padding = PADDING_SIZE;
            Console.SetCursorPosition(0, CURSOR_START_Y);
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
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(WINDOW_X, 50);

            StringBuilder sb = new StringBuilder();
            VideoCapture capture = new VideoCapture(0);

            // 영상 처리를 위한 무한 반복문
            Console.WriteLine("Video On");
            
            while (!(Console.KeyAvailable))
            {
                sb.Clear();
                Console.SetCursorPosition(0, 0);

                // VideoCapture 객체로부터 영상 프레임을 가져옴
                using (Mat frame = new Mat())
                {
                    capture.Read(frame);

                    // 가져온 영상이 없으면 루프를 빠져나감
                    if (frame.Empty())
                        break;

                    Cv2.Flip(frame, frame, FlipMode.Y);
                    //
                    Mat grayFrame = new Mat();
                    Cv2.CvtColor(frame, grayFrame, ColorConversionCodes.BGR2GRAY); // 그레이스케일로 변환

                    Scalar meanValue = Cv2.Mean(grayFrame); // 평균값 계산
                    double brightness = meanValue.Val0; // 밝기 값 계산

                    // 계산된 밝기 값 출력
                    Console.WriteLine($"Brightness: {brightness}");
                    //
                    if(brightness < 100) Cv2.ConvertScaleAbs(frame, frame, 1.5, 0);


                    Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                    Bitmap resizeImage = ResizeImage(bitmap, CAPTURE_SIZE);
                    VideoCapture(resizeImage, sb);
                    
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
