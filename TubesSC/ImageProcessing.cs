using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Math.Comparers;
using Accord.Math.Decompositions;
using Accord.Statistics;
using Accord.Statistics.Analysis;
using System.Runtime.InteropServices;

namespace TubesSC
{
    class ImageProcessing
    {
        public static double[] ToMatrix(Bitmap BM, int MatrixRowNumber, int MatrixColumnNumber)
        {
            //Bitmap bmp;
            //bmp = Scale(BM, MatrixRowNumber / 2, MatrixColumnNumber / 2);
            double HRate = ((Double)MatrixRowNumber / BM.Height);
            double WRate = ((Double)MatrixColumnNumber / BM.Width);
            //double HRate = ((Double)bmp.Height / bmp.Height);
            //double WRate = ((Double)bmp.Width / bmp.Width);
            double[] Result = new double[MatrixColumnNumber * MatrixRowNumber];

            for (int r = 0; r < MatrixRowNumber; r++)
            {
                for (int c = 0; c < MatrixColumnNumber; c++)
                {
                    Color color = BM.GetPixel((int)(c / WRate), (int)(r / HRate));
                    Result[r * MatrixColumnNumber + c] = 1 - (color.R * .3 + color.G * .59 + color.B * .11) / 255;
                }
            }

            #region PCA Process
            //double[,] Result2d = new double[MatrixRowNumber,MatrixColumnNumber];
            //int x = 0;
            //for (int i = 0; i < MatrixRowNumber; i++)
            //{
            //    for (int j = 0; j < MatrixColumnNumber; j++)
            //    {
            //        Result2d[i, j] = Result[x];
            //        x = x + 1;
            //    }
            //}
            //var pca = new PrincipalComponentAnalysis(Result2d, AnalysisMethod.Center);
            //pca.Compute();
            //double[,] components = pca.Transform(Result2d);
            //double[] Result1d = new double[MatrixColumnNumber * MatrixRowNumber];
            //int y = 0;
            //for (int k = 0; k < MatrixRowNumber; k++)
            //{
            //    for (int l = 0; l < MatrixColumnNumber; l++)
            //    {
            //        Result1d[y] = Result2d[k,l];
            //        y = y + 1;
            //    }
            //}
            
            //return Result1d;
            #endregion
            return Result;
        }

        public static Bitmap Scale(Bitmap Input, int newHeight, int newWidth)
        {
            double HRate = (double)Input.Height / newHeight;
            double WRate = (double)Input.Width / newWidth;
            Bitmap Result = new Bitmap(newWidth, newHeight);
            for (int i = 0; i < newHeight; i++)
            {
                for (int j = 0; j < newWidth; j++)
                {
                    int x = (int)((double)j * WRate);
                    int y = (int)((double)i * HRate);
                    Result.SetPixel(j, i, Input.GetPixel(x, y));
                }
            }

            return Result;
        }

        public static Bitmap ToImage(double[] Matrix, int MatrixRowNumber, int MatrixColumnNumber,
                                                     int ImageHeight, int ImageWidth)
        {
            double HRate = ((double)ImageHeight / MatrixRowNumber);
            double WRate = ((double)ImageWidth / MatrixColumnNumber);
            Bitmap Result = new Bitmap(ImageWidth, ImageHeight);

            for (int i = 0; i < ImageHeight; i++)
            {
                for (int j = 0; j < ImageWidth; j++)
                {
                    int x = (int)((double)j / WRate);
                    int y = (int)((double)i / HRate);

                    double temp = Matrix[y * MatrixColumnNumber + x];
                    Result.SetPixel(j, i, Color.FromArgb((int)((1 - temp) * 255), (int)((1 - temp) * 255), (int)((1 - temp) * 255)));

                }
            }
            return Result;
        }

        public Bitmap BinaryImage(Bitmap bmp)
        {
            Bitmap img = bmp;//(Bitmap)original.Image;
            Image image;
            //Bitmap bm;
            Bitmap bitmap;

            if (img.PixelFormat != PixelFormat.Format32bppPArgb)
            {

                Bitmap temp = new Bitmap(img.Width, img.Height, PixelFormat.Format32bppPArgb);

                Graphics g = Graphics.FromImage(temp);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel);

                img.Dispose();

                g.Dispose();

                img = temp;

            }

            image = img;



            BitmapData bmdo = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, img.PixelFormat);

            Bitmap bm = new Bitmap(image.Width, image.Height, PixelFormat.Format1bppIndexed);

            BitmapData bmdn = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);

            DateTime dt = DateTime.Now;

            int x, y;

            for (y = 0; y < img.Height; y++)
            {

                for (x = 0; x < img.Width; x++)
                {



                    int index = y * bmdo.Stride + (x * 4);



                    if (Color.FromArgb(Marshal.ReadByte(bmdo.Scan0, index + 2),

                                    Marshal.ReadByte(bmdo.Scan0, index + 1),

                                    Marshal.ReadByte(bmdo.Scan0, index)).GetBrightness() > 0.5f)

                        this.SetIndexedPixel(x, y, bmdn, true);

                }

            }

            bm.UnlockBits(bmdn);
            img.UnlockBits(bmdo);

            TimeSpan ts = dt - DateTime.Now;

            System.Diagnostics.Trace.WriteLine("Conversion time was:" + ts.ToString());




            //this.result.Image = bm;
            bitmap = bm;
            return bitmap;
        }

        protected void SetIndexedPixel(int x, int y, BitmapData bmd, bool pixel)
        {

            int index = y * bmd.Stride + (x >> 3);

            byte p = Marshal.ReadByte(bmd.Scan0, index);

            byte mask = (byte)(0x80 >> (x & 0x7));

            if (pixel)

                p |= mask;

            else

                p &= (byte)(mask ^ 0xff);

            Marshal.WriteByte(bmd.Scan0, index, p);

        }

        public double[,] PCA(double[,] data)
        {
            double[,] feature;
            double[] mean = data.Mean();
            double[,] cm = data.Subtract(mean);
            double[,] cov = cm.Covariance();
            var evd = new EigenvalueDecomposition(cov);
            double[] eigenvalues = evd.RealEigenvalues;
            double[,] eigenvectors = evd.Eigenvectors;
            eigenvectors = Matrix.Sort(eigenvalues, eigenvectors, new GeneralComparer(ComparerDirection.Descending, true));

            double[,] ev = eigenvectors;

            feature = cm.Multiply(ev);
            return feature;
        }
    }
}
