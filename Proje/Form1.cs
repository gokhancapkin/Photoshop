using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Blob;
using System.Drawing;
using OpenCvSharp.UserInterface;

namespace YazLabForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] countGri = new int[256];
        int[] countRed = new int[256];
        int[] countBlue = new int[256];
        int[] countGreen = new int[256];
        bool histRC = false, histBC = false, histGC = false, histGriC = false;
        int sayac = 0;
        IplImage[] resim = new IplImage[500];
        OpenFileDialog file = new OpenFileDialog();
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;

            if (file.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            pictureBox2.ImageLocation = file.FileName;
            resim[sayac] = Cv.LoadImage(pictureBox2.ImageLocation);
        }

        private void btnGriYap_Click(object sender, EventArgs e)
        {

            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage src = resim[sayac];
            sayac++;
            IplImage test = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            resim[sayac] = GriYap(src);
            Bitmap gri = BitmapConverter.ToBitmap(resim[sayac]);
            pictureBox2.Image = gri;
        }

        private void btnAynala_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage ayna = resim[sayac];
            sayac++;
            resim[sayac] = Aynala(ayna);
            Bitmap bmpAyna = BitmapConverter.ToBitmap(resim[sayac]);
            pictureBox2.Image = bmpAyna;
        }
        private void Aynala2_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage aynaD = resim[sayac];
            sayac++;
            resim[sayac] = AynalaD(aynaD);
            aynaD = AynalaD(aynaD);
            Bitmap bmpAynaD = BitmapConverter.ToBitmap(aynaD);
            pictureBox2.Image = bmpAynaD;
        }
        private void sagDondurBtn_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage sag = resim[sayac];
            sayac++;
            resim[sayac] = sagDondur(sag);
            sag = sagDondur(sag);
            Bitmap bmpSag = BitmapConverter.ToBitmap(sag);
            pictureBox2.Image = bmpSag;
        }
        private void solDondurBtn_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage sol = resim[sayac];
            sayac++;
            resim[sayac] = solDondur(sol);
            sol = solDondur(sol);
            Bitmap bmpSol = BitmapConverter.ToBitmap(sol);
            pictureBox2.Image = bmpSol;
        }
        private void negatifBtn_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage ngtf = resim[sayac];
            sayac++;
            resim[sayac] = negatif(ngtf);
            ngtf = negatif(ngtf);
            Bitmap bmpNegatif = BitmapConverter.ToBitmap(ngtf);
            pictureBox2.Image = bmpNegatif;
        }
        private void kirmiziYap_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage filtreK = resim[sayac];
            sayac++;
            resim[sayac] = filtreR(filtreK);
            filtreK = filtreR(filtreK);
            Bitmap bmpKirmizi = BitmapConverter.ToBitmap(filtreK);
            pictureBox2.Image = bmpKirmizi;
        }

        private void yesilYap_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage filtreY = resim[sayac];
            sayac++;
            resim[sayac] = filtreG(filtreY);
            filtreY = filtreG(filtreY);
            Bitmap bmpYesil = BitmapConverter.ToBitmap(filtreY);
            pictureBox2.Image = bmpYesil;
        }

        private void maviYap_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage filtreM = resim[sayac];
            sayac++;
            resim[sayac] = filtreB(filtreM);
            filtreM = filtreB(filtreM);
            Bitmap bmpMavi = BitmapConverter.ToBitmap(filtreM);
            pictureBox2.Image = bmpMavi;
        }
        private void olcekUygula_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage olcek = resim[sayac];
            sayac++;
            resim[sayac] = olcekle(olcek);
            olcek = olcekle(olcek);
            Bitmap bmpOlcek = BitmapConverter.ToBitmap(olcek);
            pictureBox2.Image = bmpOlcek;
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                sayac--;
                Bitmap geri = BitmapConverter.ToBitmap(resim[sayac]);
                pictureBox2.Image = geri;
            }
            if (sayac == 0)
            {
                Bitmap geri = BitmapConverter.ToBitmap(resim[sayac]);
                pictureBox2.Image = geri;
                geriBtn.Enabled = false;
            }
            ileriBtn.Enabled = true;
        }

        private void ileriBtn_Click(object sender, EventArgs e)
        {
            sayac++;
            geriBtn.Enabled = true;
            Bitmap ileri = BitmapConverter.ToBitmap(resim[sayac]);
            pictureBox2.Image = ileri;
            if (resim[sayac + 1] == null)
            {
                ileriBtn.Enabled = false;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            kaydet.FileName = "resim";
            if (kaydet.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(kaydet.FileName);
            }
        }
        private void redch_CheckedChanged(object sender, EventArgs e)
        {
            if (histRC == false) histRC = true;
            else histRC = false;
            histRenkli(resim[sayac]);
        }

        private void bluech_CheckedChanged(object sender, EventArgs e)
        {
            if (histBC == false) histBC = true;
            else histBC = false;
            histRenkli(resim[sayac]);
        }

        private void greench_CheckedChanged(object sender, EventArgs e)
        {
            if (histGC == false) histGC = true;
            else histGC = false;
            histRenkli(resim[sayac]);
        }

        private void grich_CheckedChanged(object sender, EventArgs e)
        {
            if (histGriC == false) histGriC = true;
            else histGriC = false;
            histGri(resim[sayac]);

        }
        private void btnRkanal_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage kanalR = resim[sayac];
            sayac++;
            resim[sayac] = Rkanal(kanalR);
            kanalR = Rkanal(kanalR);
            Bitmap bmpRkanal = BitmapConverter.ToBitmap(kanalR);
            pictureBox2.Image = bmpRkanal;
        }

        private void btnBkanal_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage kanalB = resim[sayac];
            sayac++;
            resim[sayac] = Bkanal(kanalB);
            kanalB = Bkanal(kanalB);
            Bitmap bmpBkanal = BitmapConverter.ToBitmap(kanalB);
            pictureBox2.Image = bmpBkanal;
        }

        private void btnGkanal_Click(object sender, EventArgs e)
        {
            geriBtn.Enabled = true;
            ileriBtn.Enabled = false;
            IplImage kanalG = resim[sayac];
            sayac++;
            resim[sayac] = Gkanal(kanalG);
            kanalG = Gkanal(kanalG);
            Bitmap bmpGkanal = BitmapConverter.ToBitmap(kanalG);
            pictureBox2.Image = bmpGkanal;
        }

        /// 
        /// Fonk
        ///
        private IplImage GriYap(IplImage src)
        {
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {

                    CvColor c = src[y, x];
                    src[y, x] = new CvColor()
                    {
                        B = (Byte)((c.R + c.B + c.G) / 3),
                        G = (Byte)((c.R + c.B + c.G) / 3),
                        R = (Byte)((c.R + c.B + c.G) / 3),
                    };

                }
            }
            return src;
        }
        
        private IplImage Aynala(IplImage src)
        {
            IplImage aynala = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    aynala[y, src.Width - 1 - x] = new CvColor()
                    {
                        B = (byte)(c.B),
                        G = (byte)(c.G),
                        R = (byte)(c.R),
                    };

                }
            }
            return aynala;
        }
        private IplImage AynalaD(IplImage src)
        {
            IplImage aynalaD = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    aynalaD[src.Height - 1 - y, x] = new CvColor()
                    {
                        B = (byte)(c.B),
                        G = (byte)(c.G),
                        R = (byte)(c.R),
                    };

                }
            }
            return aynalaD;
        }

        private IplImage sagDondur(IplImage src)
        {
            IplImage sag = Cv.CreateImage(new CvSize(src.Height, src.Width), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {

                    sag[x, y] = src[src.Height - 1 - y, x];
                }
            }
            return sag;
        }

        private IplImage solDondur(IplImage src)
        {
            IplImage sol = Cv.CreateImage(new CvSize(src.Height, src.Width), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {

                    sol[x, y] = src[y, src.Width - 1 - x];
                }
            }
            return sol;
        }

        private IplImage negatif(IplImage src)
        {
            IplImage negative = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    negative[y, x] = new CvColor()
                    {
                        B = (byte)(255 - c.B),
                        G = (byte)(255 - c.G),
                        R = (byte)(255 - c.R),
                    };
                }
            }
            return negative;
        }
        private IplImage filtreR(IplImage src)
        {
            IplImage filtreR = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    filtreR[y, x] = new CvColor()
                    {
                        B = (byte)(0),
                        G = (byte)(0),
                        R = (byte)(c.R),
                    };
                }
            }
            return filtreR;
        }
        private IplImage filtreG(IplImage src)
        {
            IplImage filtreK = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    filtreK[y, x] = new CvColor()
                    {
                        B = (byte)(0),
                        G = (byte)(c.G),
                        R = (byte)(0),
                    };
                }
            }
            return filtreK;
        }
        private IplImage filtreB(IplImage src)
        {
            IplImage filtreB = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    filtreB[y, x] = new CvColor()
                    {
                        B = (byte)(c.B),
                        G = (byte)(0),
                        R = (byte)(0),
                    };
                }
            }
            return filtreB;
        }
        private IplImage Rkanal(IplImage src)
        {
            IplImage Rkanal = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    Rkanal[y, x] = new CvColor()
                    {
                        B = (byte)(c.R),
                        G = (byte)(c.R),
                        R = (byte)(c.R),
                    };
                }
            }
            return Rkanal;
        }
        private IplImage Bkanal(IplImage src)
        {
            IplImage Bkanal = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    Bkanal[y, x] = new CvColor()
                    {
                        B = (byte)(c.B),
                        G = (byte)(c.B),
                        R = (byte)(c.B),
                    };
                }
            }
            return Bkanal;
        }
        private IplImage Gkanal(IplImage src)
        {
            IplImage Gkanal = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    CvColor c = src[y, x];
                    Gkanal[y, x] = new CvColor()
                    {
                        B = (byte)(c.G),
                        G = (byte)(c.G),
                        R = (byte)(c.G),
                    };
                }
            }
            return Gkanal;
        }
        private void histGri(IplImage src)
        {
            IplImage histG = Cv.CreateImage(new CvSize(src.Width, src.Height), BitDepth.U8, 3);
            int w = histG.Width;
            int h = histG.Height;
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {

                    CvColor c = src[y, x];
                    histG[y, x] = new CvColor()
                    {
                        B = (Byte)((c.R + c.B + c.G) / 3),
                        G = (Byte)((c.R + c.B + c.G) / 3),
                        R = (Byte)((c.R + c.B + c.G) / 3),
                    };

                }
            }

            for (int i = 0; i < 256; i++)
                countGri[i] = 0;
            for (int y = 0; y < histG.Height; y++)
            {
                for (int x = 0; x < histG.Width; x++)
                {
                    for (int i = 0; i < 256; i++)
                    {
                        CvColor gri = histG[y, x];
                        if (gri.R == i)
                        {
                            countGri[i]++;
                        }
                    }

                }
            }
            histCiz();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            sayac = 0;
            Bitmap clear = BitmapConverter.ToBitmap(resim[sayac]);
            pictureBox2.Image = clear;
            geriBtn.Enabled = false;
        }

        private void histRenkli(IplImage src)
        {
            int w = src.Width;
            int h = src.Height;

            for (int i = 0; i < 256; i++)
            {
                countRed[i] = 0;
                countBlue[i] = 0;
                countGreen[i] = 0;
            }
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    for (int i = 0; i < 256; i++)
                    {
                        CvColor renk = src[y, x];
                        if (renk.R == i)
                        {
                            countRed[i]++;
                        }
                        if (renk.B == i)
                        {
                            countBlue[i]++;
                        }
                        if (renk.G == i)
                        {
                            countGreen[i]++;
                        }

                    }

                }
            }
            histCiz();
        }


        private void histCiz()
        {

            Graphics grafik;
            grafik = panel1.CreateGraphics();
            int min = 20;
            int maxH = panel1.Height - 20;
            int maxW = panel1.Width - 20;
            int sıgdırma = 2000 / (maxH - min);
            System.Drawing.Graphics grafiknesne;
            grafiknesne = panel1.CreateGraphics();
            Brush beyaz = new SolidBrush(System.Drawing.Color.White);
            grafiknesne.FillRectangle(beyaz, 0, 0, panel1.Width, panel1.Height);
            Pen black = new Pen(Color.Black, 2);
            grafik.DrawLine(black, 18, 18, 18, maxH + 2);
            grafik.DrawLine(black, 18, maxH + 2, maxW + 2, maxH + 2);
            Pen gray = new Pen(Color.Gray, 1);
            Pen red = new Pen(Color.Red, 1);
            Pen blue = new Pen(Color.Blue, 1);
            Pen green = new Pen(Color.Green, 1);
            if (histGriC == true)
            {
                for (int i = 0; i < 255; i++)
                {
                    if (countGri[i] / sıgdırma > maxH) countGri[i] = maxH * sıgdırma;
                    grafik.DrawLine(gray, i + 20, (panel1.Height - countGri[i] / sıgdırma) - 20, i + 20, (panel1.Height - countGri[i + 1] / sıgdırma) - 20);
                }
            }
            if (histRC == true)
            {
                for (int i = 0; i < 255; i++)
                {
                    if (countRed[i] / sıgdırma > maxH) countRed[i] = maxH * sıgdırma;
                    grafik.DrawLine(red, i + 20, (panel1.Height - countRed[i] / sıgdırma) - 20, i + 20, (panel1.Height - countRed[i + 1] / sıgdırma) - 20);
                }

            }
            if (histBC == true)
            {
                for (int i = 0; i < 255; i++)
                {
                    if (countBlue[i] / sıgdırma > maxH) countBlue[i] = maxH * sıgdırma;
                    grafik.DrawLine(blue, i + 20, (panel1.Height - countBlue[i] / sıgdırma) - 20, i + 20, (panel1.Height - countBlue[i + 1] / sıgdırma) - 20);
                }
            }
            if (histGC == true)
            {
                for (int i = 0; i < 255; i++)
                {
                    if (countGreen[i] / sıgdırma > maxH) countGreen[i] = maxH * sıgdırma;
                    grafik.DrawLine(green, i + 20, (panel1.Height - countGreen[i] / sıgdırma) - 20, i + 20, (panel1.Height - countGreen[i + 1] / sıgdırma) - 20);
                }
            }

        }
        private IplImage olcekle(IplImage src)
        {
            double newW, newH;
            newW = Convert.ToDouble(txtWidth.Text);
            newH = Convert.ToDouble(txtHeight.Text);
            int[,,] dizi = new int[src.Height, Convert.ToInt32(newW), 3];
            IplImage temp = Cv.CreateImage(new CvSize(Convert.ToInt32(newW), src.Height), BitDepth.U8, 3);
            IplImage temp2 = Cv.CreateImage(new CvSize(Convert.ToInt32(newW), Convert.ToInt32(newH)), BitDepth.U8, 3);
            double fy = newH / src.Height;
            double fx = newW / src.Width;
            bool[,] dizix = new bool[Math.Max(Convert.ToInt32(newH), src.Height), Math.Max(Convert.ToInt32(newW), src.Width)];

            for (int y = 0; y < newH; y++)
            {
                for (int x = 0; x < newW; x++)
                {
                    dizix[y, x] = false;
                }
            }
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {

                    int bW = Convert.ToInt32(x * fx);
                    if (bW == newW) break;

                    temp[y, bW] = src[y, x];
                    dizix[y, bW] = true;

                }
            }

            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 1; x < newW; x++)
                {

                    if (dizix[y, x] == false)
                    {
                        int basx = x - 1;
                        int basy = y;
                        int sonx = x;
                        int sony = y;
                        for (int t = x; t < newW; t++)
                        {
                            if (dizix[sony, t] == true)
                            {
                                sonx = t;
                                break;
                            }
                        }
                        for (int d = 1; d < sonx - basx; d++)
                        {
                            int aralik = sonx - basx;
                            CvColor ilk = temp[basy, basx];
                            CvColor son = temp[sony, sonx];
                            int farkR = (ilk.R - son.R) / (aralik * 1000);
                            int farkB = (ilk.B - son.B) / (aralik * 1000);
                            int farkG = (ilk.G - son.G) / (aralik * 1000);
                            temp[basy, basx + d] = new CvColor()
                            {
                                R = (Byte)(ilk.R + (farkR * d)),
                                B = (Byte)(ilk.B + (farkB * d)),
                                G = (Byte)(ilk.G + (farkG * d)),
                            };

                        }



                    }
                }
            }


            for (int y = 0; y < newH; y++)
            {
                for (int x = 0; x < newW; x++)
                {
                    dizix[y, x] = false;
                }
            }
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < newW; x++)
                {
                    int bY = Convert.ToInt32(y * fy);
                    if (bY == newH) break;
                    temp2[bY, x] = temp[y, x];
                    dizix[bY, x] = true;
                }
            }


            for (int y = 0; y < newH; y++)
            {
                for (int x = 0; x < newW; x++)
                {

                    if (dizix[y, x] == false)
                    {

                        int basx = x;
                        int basy = y - 1;
                        int sonx = x;
                        int sony = y;
                        for (int t = y; t < newH; t++)
                        {
                            if (dizix[t, sonx] == true)
                            {
                                sony = t;
                                break;
                            }
                        }
                        for (int d = 1; d < sony - basy; d++)
                        {
                            int aralik = sony - basy;
                            CvColor ilk = temp2[basy, basx];
                            CvColor son = temp2[sony, sonx];
                            int farkR = (ilk.R - son.R) / (aralik * 1000);
                            int farkB = (ilk.B - son.B) / (aralik * 1000);
                            int farkG = (ilk.G - son.G) / (aralik * 1000);
                            temp2[basy + d, basx] = new CvColor()
                            {
                                R = (Byte)(ilk.R + (farkR * d)),
                                B = (Byte)(ilk.B + (farkB * d)),
                                G = (Byte)(ilk.G + (farkG * d)),
                            };
                        }


                    }
                }
            }

            return temp2;
        }


    }


}

