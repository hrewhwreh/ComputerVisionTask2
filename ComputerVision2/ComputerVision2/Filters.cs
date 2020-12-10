using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerVision2
{
    abstract class Filters
    {
        public abstract Bitmap processImage(Bitmap sourceImage);
        public int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }

   
    class Convolution1 : Filters
    {
        float[,,] kernel;
        public Convolution1()
        {
            kernel = new float[3, 3, 3];
            kernel[0, 0, 0] = (float)1 / 9; kernel[0, 0, 1] = (float)1 / 9; kernel[0, 0, 2] = (float)1 / 9;
            kernel[0, 1, 0] = (float)1 / 9; kernel[0, 1, 1] = (float)1 / 9; kernel[0, 1, 2] = (float)1 / 9;
            kernel[0, 2, 0] = (float)1 / 9; kernel[0, 2, 1] = (float)1 / 9; kernel[0, 2, 2] = (float)1 / 9;

            kernel[1, 0, 0] = (float)1 / 9; kernel[1, 0, 1] = (float)1 / 9; kernel[1, 0, 2] = (float)1 / 9;
            kernel[1, 1, 0] = (float)1 / 9; kernel[1, 1, 1] = (float)1 / 9; kernel[1, 1, 2] = (float)1 / 9;
            kernel[1, 2, 0] = (float)1 / 9; kernel[1, 2, 1] = (float)1 / 9; kernel[1, 2, 2] = (float)1 / 9;

            kernel[2, 0, 0] = (float)1 / 9; kernel[2, 0, 1] = (float)1 / 9; kernel[2, 0, 2] = (float)1 / 9;
            kernel[2, 1, 0] = (float)1 / 9; kernel[2, 1, 1] = (float)1 / 9; kernel[2, 1, 2] = (float)1 / 9;
            kernel[2, 2, 0] = (float)1 / 9; kernel[2, 2, 1] = (float)1 / 9; kernel[2, 2, 2] = (float)1 / 9;
        }
        public override Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height); 
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int color = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            for (int r = -1; r <= 1; r++)
                            {
                                if (k == 0) 
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).R) * 
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 1)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).G) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 2)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).B) *
                                        kernel[k, l + 1, r + 1]);
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(i, j, Color.FromArgb(Clamp(color, 0, 255), Clamp(color, 0, 255), Clamp(color, 0, 255)));
                }
            }
            return resultImage;
        }
    }

    class Convolution2 : Filters
    {
        float[,,] kernel;
        public Convolution2()
        {
            kernel = new float[3, 3, 3];
            kernel[0, 0, 0] = (float)0; kernel[0, 0, 1] = (float)-1; kernel[0, 0, 2] = (float)0;
            kernel[0, 1, 0] = (float)-1; kernel[0, 1, 1] = (float)5; kernel[0, 1, 2] = (float)-1;
            kernel[0, 2, 0] = (float)1 / 9; kernel[0, 2, 1] = (float)-1; kernel[0, 2, 2] = (float)0;

            kernel[1, 0, 0] = (float)0; kernel[1, 0, 1] = (float)-1; kernel[1, 0, 2] = (float)0;
            kernel[1, 1, 0] = (float)-1; kernel[1, 1, 1] = (float)5; kernel[1, 1, 2] = (float)-1;
            kernel[1, 2, 0] = (float)0; kernel[1, 2, 1] = (float)-1; kernel[1, 2, 2] = (float)0;

            kernel[2, 0, 0] = (float)0; kernel[2, 0, 1] = (float)-1; kernel[2, 0, 2] = (float)0;
            kernel[2, 1, 0] = (float)-1; kernel[2, 1, 1] = (float)5; kernel[2, 1, 2] = (float)-1;
            kernel[2, 2, 0] = (float)0; kernel[2, 2, 1] = (float)-1; kernel[2, 2, 2] = (float)0;
        }
        public override Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int color = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            for (int r = -1; r <= 1; r++)
                            {
                                if (k == 0)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).R) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 1)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).G) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 2)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).B) *
                                        kernel[k, l + 1, r + 1]);
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(i, j, Color.FromArgb(Clamp(color, 0, 255), Clamp(color, 0, 255), Clamp(color, 0, 255)));
                }
            }
            return resultImage;
        }
    }

    class Convolution3 : Filters
    {
        float[,,] kernel;
        public Convolution3()
        {
            kernel = new float[3, 3, 3];
            kernel[0, 0, 0] = (float)1; kernel[0, 0, 1] = (float)0; kernel[0, 0, 2] = (float)1;
            kernel[0, 1, 0] = (float)0; kernel[0, 1, 1] = (float)1; kernel[0, 1, 2] = (float)0;
            kernel[0, 2, 0] = (float)1; kernel[0, 2, 1] = (float)0; kernel[0, 2, 2] = (float)1;

            kernel[1, 0, 0] = (float)-2; kernel[1, 0, 1] = (float)0; kernel[1, 0, 2] = (float)-2;
            kernel[1, 1, 0] = (float)1 / 9; kernel[1, 1, 1] = (float)2; kernel[1, 1, 2] = (float)0;
            kernel[1, 2, 0] = (float)-2; kernel[1, 2, 1] = (float)0; kernel[1, 2, 2] = (float)-2;

            kernel[2, 0, 0] = (float)-1; kernel[2, 0, 1] = (float)1; kernel[2, 0, 2] = (float)0;
            kernel[2, 1, 0] = (float)0; kernel[2, 1, 1] = (float)-1; kernel[2, 1, 2] = (float)1;
            kernel[2, 2, 0] = (float)-1; kernel[2, 2, 1] = (float)1; kernel[2, 2, 2] = (float)0;
        }
        public override Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int color = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            for (int r = -1; r <= 1; r++)
                            {
                                if (k == 0)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).R) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 1)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).G) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 2)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).B) *
                                        kernel[k, l + 1, r + 1]);
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(i, j, Color.FromArgb(Clamp(color, 0, 255), Clamp(color, 0, 255), Clamp(color, 0, 255)));
                }
            }
            return resultImage;
        }
    }

    class Convolution4 : Filters
    {
        float[,,] kernel;
        public Convolution4()
        {
            kernel = new float[3, 3, 3];
            kernel[0, 0, 0] = (float)1; kernel[0, 0, 1] = (float)0; kernel[0, 0, 2] = (float)1;
            kernel[0, 1, 0] = (float)0; kernel[0, 1, 1] = (float)1; kernel[0, 1, 2] = (float)0;
            kernel[0, 2, 0] = (float)1; kernel[0, 2, 1] = (float)0; kernel[0, 2, 2] = (float)1;

            kernel[1, 0, 0] = (float)0; kernel[1, 0, 1] = (float)1; kernel[1, 0, 2] = (float)0;
            kernel[1, 1, 0] = (float)1; kernel[1, 1, 1] = (float)0; kernel[1, 1, 2] = (float)1;
            kernel[1, 2, 0] = (float)0; kernel[1, 2, 1] = (float)1; kernel[1, 2, 2] = (float)0;

            kernel[2, 0, 0] = (float)-1; kernel[2, 0, 1] = (float)0; kernel[2, 0, 2] = (float)-1;
            kernel[2, 1, 0] = (float)0; kernel[2, 1, 1] = (float)-1; kernel[2, 1, 2] = (float)0;
            kernel[2, 2, 0] = (float)-1; kernel[2, 2, 1] = (float)0; kernel[2, 2, 2] = (float)-1;
        }
        public override Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int color = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            for (int r = -1; r <= 1; r++)
                            {
                                if (k == 0)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).R) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 1)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).G) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 2)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).B) *
                                        kernel[k, l + 1, r + 1]);
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(i, j, Color.FromArgb(Clamp(color, 0, 255), Clamp(color, 0, 255), Clamp(color, 0, 255)));
                }
            }
            return resultImage;
        }
    }

    class Convolution5 : Filters
    {
        float[,,] kernel;
        public Convolution5()
        {
            kernel = new float[3, 3, 3];
            kernel[0, 0, 0] = (float)1; kernel[0, 0, 1] = (float)0; kernel[0, 0, 2] = (float)1;
            kernel[0, 1, 0] = (float)0; kernel[0, 1, 1] = (float)0; kernel[0, 1, 2] = (float)0;
            kernel[0, 2, 0] = (float)1; kernel[0, 2, 1] = (float)0; kernel[0, 2, 2] = (float)1;

            kernel[1, 0, 0] = (float)0; kernel[1, 0, 1] = (float)1; kernel[1, 0, 2] = (float)0;
            kernel[1, 1, 0] = (float)0; kernel[1, 1, 1] = (float)1; kernel[1, 1, 2] = (float)0;
            kernel[1, 2, 0] = (float)0; kernel[1, 2, 1] = (float)1; kernel[1, 2, 2] = (float)0;

            kernel[2, 0, 0] = (float)0; kernel[2, 0, 1] = (float)0; kernel[2, 0, 2] = (float)0;
            kernel[2, 1, 0] = (float)1; kernel[2, 1, 1] = (float)1; kernel[2, 1, 2] = (float)1;
            kernel[2, 2, 0] = (float)0; kernel[2, 2, 1] = (float)0; kernel[2, 2, 2] = (float)0;
        }
        public override Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int color = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            for (int r = -1; r <= 1; r++)
                            {
                                if (k == 0)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).R) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 1)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).G) *
                                        kernel[k, l + 1, r + 1]);
                                }
                                if (k == 2)
                                {
                                    color += (int)((float)(sourceImage.GetPixel(Clamp(i + l, 0, sourceImage.Width - 1), Clamp(j + r, 0, sourceImage.Height - 1)).B) *
                                        kernel[k, l + 1, r + 1]);
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(i, j, Color.FromArgb(Clamp(color, 0, 255), Clamp(color, 0, 255), Clamp(color, 0, 255)));
                }
            }
            return resultImage;
        }
    }

    class MaxPooling : Filters
    {
        public override Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width / 2 + 1, sourceImage.Height / 2 + 1);
            for (int i = 0; i < sourceImage.Width / 2; i++)
            {
                for (int j = 0; j < sourceImage.Height / 2; j++)
                {
                    int a = sourceImage.GetPixel(2 * i, 2 * j).R;
                    int b = sourceImage.GetPixel(2 * i + 1, 2 * j).R;
                    int c = sourceImage.GetPixel(2 * i, 2 * j + 1).R;
                    int d = sourceImage.GetPixel(2 * i + 1, 2 * j + 1).R;
                    if (a > b)
                    {
                        b = a;
                    }
                    else if (b > c)
                    {
                        c = b;
                    }
                    else if (c > d)
                    {
                        d = c;
                    }
                    resultImage.SetPixel(i, j, Color.FromArgb(d, d, d));
                }
            }
            return resultImage;
        }
    }

}
