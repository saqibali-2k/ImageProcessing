using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArayFromBitmap();

        }
        private void SetBitmapFromAray()
        {
            for (int col = 0; col < 320; col++)
                for (int row = 0; row < 240; row++)
                {
                    bitmapImage.SetPixel(col, row, ImageArray[col, row]);
                }
        }

        private void SetArayFromBitmap()
        {
            if (bitmapImage != null)
            {
                for (int row = 0; row < 320; row++)
                    for (int col = 0; col < 240; col++)
                    {
                        ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                    }
            }

        }


        private void btnTransform_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Green = col.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte Red = 0, Green = 0, Blue = 0;
            Byte Increment = 5;
            Byte MaxValue = Convert.ToByte(255 - Increment);

            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    if (col.G <= MaxValue && col.R <= MaxValue && col.B <= MaxValue)
                    {
                        Green = Convert.ToByte(col.G + Increment);
                        Blue = Convert.ToByte(col.B + Increment);
                        Red = Convert.ToByte(col.R + Increment);

                        Color newColor = Color.FromArgb(255, Red, Green, Blue);
                        ImageArray[i, j] = newColor;
                    }
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte Red = 0, Green = 0, Blue = 0;
            Byte Increment = 5;
            Byte MinValue = Increment;

            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    if (col.G >= MinValue && col.R >= MinValue && col.B >= MinValue)
                    {
                        Green = Convert.ToByte(col.G - Increment);
                        Blue = Convert.ToByte(col.B - Increment);
                        Red = Convert.ToByte(col.R - Increment);

                        Color newColor = Color.FromArgb(255, Red, Green, Blue);
                        ImageArray[i, j] = newColor;
                    }
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte Red = 0, Green = 0, Blue = 0;


            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Green = Convert.ToByte(255 - col.G);
                    Blue = Convert.ToByte(255 - col.B);
                    Red = Convert.ToByte(255 - col.R);

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte Red = 0, Blue = 0;
            Byte Increment = 5;
            Byte MinValue = Increment;

            double dRatioRed = 1.25, dRatioBlue = 0.75;

            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    if (col.R * dRatioRed <= 255)
                    {
                        Blue = Convert.ToByte(col.B * dRatioBlue);
                        Red = Convert.ToByte(col.R * dRatioRed);

                        Color newColor = Color.FromArgb(255, Red, col.G, Blue);
                        ImageArray[i, j] = newColor;
                    }
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipH_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            Color TempHolder;

            for (int i = 0; i < iHeight; i++)
            {
                for (int j = 0; j < iWidth / 2; j++)
                {
                    Color col = ImageArray[j, i];
                    TempHolder = ImageArray[(iWidth - 1) - j, i];
                    ImageArray[(iWidth - 1) - j, i] = col;
                    ImageArray[j, i] = TempHolder;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipV_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            Color TempHolder;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    Color col = ImageArray[i, j];
                    TempHolder = ImageArray[i, iHeight - 1 - j];
                    ImageArray[i, iHeight - 1 - j] = col;
                    ImageArray[i, j] = TempHolder;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            Color TempHolder;

            for (int i = 0; i < iHeight; i++)
            {
                for (int j = 0; j < iWidth / 2; j++)
                {
                    Color col = ImageArray[j, i];
                    TempHolder = ImageArray[(iWidth - 1) - j, i];
                    ImageArray[(iWidth - 1) - j, i] = col;
                    ImageArray[j, i] = TempHolder;
                }
            }

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    Color col = ImageArray[i, j];
                    TempHolder = ImageArray[i, iHeight - 1 - j];
                    ImageArray[i, iHeight - 1 - j] = col;
                    ImageArray[i, j] = TempHolder;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnGrayScale_Click(object sender, EventArgs e)
        {

            if (bitmapImage == null)
                return;


            Byte Average;
            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Average = Convert.ToByte((col.B + col.R + col.G) / 3);

                    Color newColor = Color.FromArgb(255, Average, Average, Average);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int RedSum=0, GreenSum=0, BlueSum=0;
            Byte Red = 0, Green = 0, Blue = 0;


            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    GreenSum += col.G;
                    RedSum += col.R;
                    BlueSum += col.B;
                }

            }

            GreenSum /= iWidth * iHeight;
            BlueSum /= iWidth * iHeight;
            RedSum /= iWidth * iHeight;


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    if(col.R > RedSum)
                    {
                        Red = 255;
                    }
                    else if(col.R == RedSum) 
                    {
                        if(col.R < 127)
                        {
                            Red = 0;
                        }
                        else
                        {
                            Red = 255;
                        }
                    }
                    else
                    {
                        Red = 0;
                    }

                    if(col.G > GreenSum)
                    {
                        Green = 255;
                    }
                    else if (col.G == RedSum)
                    {
                        if (col.G < 127)
                        {
                            Green = 0;
                        }
                        else
                        {
                            Green = 255;
                        }
                    }
                    else
                    {
                        Green = 0;
                    }
                    if(col.B > BlueSum)
                    {
                        Blue = 255;
                    }
                    else if (col.B == RedSum)
                    {
                        if (col.B < 127)
                        {
                            Blue = 0;
                        }
                        else
                        {
                            Blue = 255;
                        }
                    }
                    else
                    {
                        Blue = 0;
                    }

                    ImageArray[i, j] = Color.FromArgb(255, Red, Green, Blue);

                }

            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPixelate_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte BlockSize = 8;
            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth; i += BlockSize)
            {
                for (int j = 0; j < iHeight; j += BlockSize)
                {
                    Color col = ImageArray[i, j];

                    for (int k = i; k < (i+BlockSize); k++)
                    {
                        for(int l = j; l < (j+BlockSize); l++)
                        {
                            ImageArray[k, l] = col;                                                
                        }
                    }

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte Red = 0, Green = 0, Blue = 0;
            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[iWidth, iHeight];

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    int AverageR = 0, AverageG = 0, AverageB = 0;
                    int iDivider = 0;
                    if (!(i+1 >= iWidth))//Right
                    {
                        AverageR += ImageArray[i+1, j].R;
                        AverageB += ImageArray[i+1, j].B;
                        AverageG += ImageArray[i+1, j].G;
                        iDivider++;

                    }
                    if(!(i-1 < 0))//Left
                    {
                        AverageR += ImageArray[i-1, j].R;
                        AverageB += ImageArray[i-1, j].B;
                        AverageG += ImageArray[i-1, j].G;
                        iDivider++;
                    }
                    if(!(j+1 >= iHeight))//Top
                    {
                        AverageR += ImageArray[i, j+1].R;
                        AverageB += ImageArray[i, j+1].B;
                        AverageG += ImageArray[i, j+1].G;
                        iDivider++;
                    }
                    if(!(j-1 < 0))//Bottom
                    {
                        AverageR += ImageArray[i, j-1].R;
                        AverageB += ImageArray[i, j-1].B;
                        AverageG += ImageArray[i, j-1].G;
                        iDivider++;
                    }
                    if(!(j-1 < 0 || i-1 < 0))//Top left
                    {
                        AverageR += ImageArray[i-1, j-1].R;
                        AverageB += ImageArray[i-1, j-1].B;
                        AverageG += ImageArray[i-1, j-1].G;
                        iDivider++;
                    }
                    if(!(j-1 < 0 || i+1 >= iWidth))//Top right
                    {
                        AverageR += ImageArray[i+1, j-1].R;
                        AverageB += ImageArray[i+1, j-1].B;
                        AverageG += ImageArray[i+1, j-1].G;
                        iDivider++;
                    }
                    if(!(j+1 >= iHeight || i+1 >= iWidth))//Bot right
                    {
                        AverageR += ImageArray[i+1, j+1].R;
                        AverageB += ImageArray[i+1, j+1].B;
                        AverageG += ImageArray[i+1, j+1].G;
                        iDivider++;
                    }
                    if(!(j+1 >= iHeight || i-1 < 0))//Bot Left
                    {
                        AverageR += ImageArray[i-1, j+1].R;
                        AverageB += ImageArray[i-1, j+1].B;
                        AverageG += ImageArray[i-1, j+1].G;
                        iDivider++;
                    }
                    Red = Convert.ToByte(AverageR /iDivider);
                    Green = Convert.ToByte(AverageG /iDivider);
                    Blue = Convert.ToByte(AverageB/iDivider);

                    TempArray[i, j] = Color.FromArgb(255, Red, Green, Blue);

                }
            }
            ImageArray = TempArray;
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSwitchCorner_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;


            for (int i = 0; i < iWidth/2; i++)
            {
                for (int j = 0; j < iHeight/2; j++)
                {
                    Color Tempcol = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[i + iWidth / 2, j + iHeight / 2];
                    ImageArray[i + iWidth / 2, j + iHeight / 2] = Tempcol;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 240; i++)
            {
                QuickSort(ImageArray, 0, 319, i);
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int ScrollLength = 30;

            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[iWidth, ScrollLength];


            for (int i = 0; i < ScrollLength; i++)
            {

                for(int j = 0; j < iWidth; j++)
                {
                    TempArray[j, i] = ImageArray[j, i];                                                                                                              
                }

            }

            for(int i=0; i < iHeight - ScrollLength; i++) //Goes up the 2-d Array, stop at the index where tempArray will be placed
            {
                for(int j=0; j < iWidth; j++)
                {
                    ImageArray[j, i] = ImageArray[j, i + ScrollLength];                                                                                                                       
                }
            }


            for (int i = 0; i < ScrollLength; i++)
            {

                for (int j = 0; j < iWidth; j++)
                {
                    ImageArray[j, iHeight - ScrollLength + i] = TempArray[j, i];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int ScrollLength = 30;

            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[iWidth, ScrollLength];

            int iCounter = 0;

            for (int i = iHeight - ScrollLength; i < iHeight; i++)
            {

                for (int j = 0; j < iWidth; j++)
                {
                    TempArray[j, iCounter] = ImageArray[j, i];
                }

                iCounter++;
            }

            for (int i = iHeight - 1; i > ScrollLength - 1; i--) //Goes up the 2-d Array, stop at the index where tempArray will be placed
            {
                for (int j = 0; j < iWidth; j++)
                {
                    ImageArray[j, i] = ImageArray[j, i - ScrollLength];
                }
            }


            for (int i = 0; i < ScrollLength; i++)
            {

                for (int j = 0; j < iWidth; j++)
                {
                    ImageArray[j, i] = TempArray[j, i];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int ScrollLength = 40;

            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[ScrollLength, iHeight];
            
            for(int i = iWidth - ScrollLength; i < iWidth; i++)
            {
                for(int j=0; j < iHeight; j++)
                {
                    TempArray[i-(iWidth - ScrollLength), j] = ImageArray[i, j];
                }
            }

            for(int i = iWidth -1; i > ScrollLength - 1 ; i-- )
            {
                for(int j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = ImageArray[i - ScrollLength, j];
                }
            }

            for(int i = 0; i < ScrollLength; i++)
            {
                for(int j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = TempArray[i, j];
                }
            }

          
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int ScrollLength = 40;

            int iWidth = 320;
            int iHeight = 240;

            Color[,] TempArray = new Color[ScrollLength, iHeight];

            for (int i = 0; i < ScrollLength; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            for (int i = 0; i < iWidth - ScrollLength; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = ImageArray[i + ScrollLength, j];
                }
            }

            for (int i = 0; i < ScrollLength; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    ImageArray[i + (iWidth - ScrollLength), j] = TempArray[i, j];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void QuickSort(Color[,] Array, int iStart, int iEnd, int y)
        {
            //Left side will have values < Pivot
            //Right side will have values > Pivot
            if (iStart == iEnd) //Can not be partitioned if there is only 1 element in array
                return;

            int iPartitionIndex = Partition(Array, iStart, iEnd, y);

            if(iPartitionIndex > iStart) //If the left subarray does not contain any elements, it will not be partitioned
            {
                QuickSort(Array, iStart, iPartitionIndex - 1, y);
            }

            if(iPartitionIndex < iEnd) //If Right subarray does not contain any elements, it will not be partitioned
            {
                QuickSort(Array, iPartitionIndex + 1, iEnd, y);
            }
            return;
        }

        private int Partition(Color[,] Array, int iStart, int iEnd, int y)
        {
            int iPivot = (Array[iStart, y].R + Array[iStart, y].G + Array[iStart, y].B) / 3; //In this implementation the value to be compared is always first 

            while (true)
            {

                int iAvgRight = (Array[iEnd, y].R + Array[iEnd, y].G + Array[iEnd, y].B) / 3;
                while (iAvgRight >= iPivot)
                {
                    iEnd--; //Since the value at iEnd follows order, array to be examined is reduced

                    if (iStart == iEnd)
                        return iStart;

                    iAvgRight = (Array[iEnd, y].R + Array[iEnd, y].G + Array[iEnd, y].B) / 3;

                }
                //The right and left most values are switched once right one is less than the left
                Color cTemp = Array[iEnd, y];
                Array[iEnd, y] = Array[iStart, y];
                Array[iStart, y] = cTemp;

                int iAvgLeft = (Array[iStart, y].R + Array[iStart, y].G + Array[iStart, y].B) / 3;
                //Since value to be compared is switched, we now start at other end
                while (iAvgLeft < iPivot)
                {
                    iStart++; //Since the value at iStart follows order, array to be examined is reduced

                    if (iStart == iEnd)
                        return iStart;

                    iAvgLeft = (Array[iStart, y].R + Array[iStart, y].G + Array[iStart, y].B) / 3;
                }
                //Values are switched
                cTemp = Array[iEnd, y];
                Array[iEnd, y] = Array[iStart, y];
                Array[iStart, y] = cTemp;
            }

        }

        private void GetContrast(Color[,] OutputArray, int iHeight, int iWidth)
        {
            /* -1 0 1 VALUES ARE WEIGHTED (X dir) 
               -2 0 2
               -1 0 1
            

               -1 -2 -1 VALUES ARE WEIGHTED (y dir) 
                0  0  0
                1  2  1
            */

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    int ChangeX = 0;
                    int ChangeY = 0;
                    
                    if (!(i + 1 >= iWidth)) //Right
                    {
                        ChangeX += 2 * ImageArray[i + 1, j].R;

                    }
                    if (!(i - 1 < 0)) //Left
                    {
                        ChangeX += -2 * ImageArray[i - 1, j].R;
                    }
                    if (!(j - 1 < 0)) //Bottom
                    {
                        ChangeY += 2 * ImageArray[i, j - 1].R;
                    }
                    if (!(j + 1 >= iHeight))//Top
                    {
                        ChangeY += -2 * ImageArray[i, j + 1].R;
                    }

                    if (!(j - 1 < 0 || i - 1 < 0))//Top left
                    {
                        ChangeX += -1 * ImageArray[i -1 , j - 1].R;
                        ChangeY += -1 * ImageArray[i - 1, j - 1].R;
                    }
                    if (!(j - 1 < 0 || i + 1 >= iWidth))//Top right
                    {
                        ChangeX += ImageArray[i + 1, j - 1].R;
                        ChangeY += -1 * ImageArray[i + 1, j - 1].R;
                    }
                    if (!(j + 1 >= iHeight || i + 1 >= iWidth))//Bot right
                    {
                        ChangeX += ImageArray[i+1, j+1].R;
                        ChangeY += ImageArray[i + 1, j + 1].R;
                    }
                    if (!(j + 1 >= iHeight || i - 1 < 0))//Bot Left
                    {
                        ChangeX += -1 * ImageArray[i-1, j+1].R;
                        ChangeY += ImageArray[i - 1, j + 1].R;
                    }
                    
                    double dXY =(Math.Sqrt(ChangeX * ChangeX + ChangeY * ChangeY));

                    Byte value;

                    if(dXY > 255)
                    {
                         value = 255;
                    }
                    else
                    {
                        value = (Byte)(dXY);
                    }

                    OutputArray[i, j] = Color.FromArgb(255, value, value, value);

                }
            }
        }

        private void btnEdgeDetection_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int iWidth = 320;
            int iHeight = 240;
            Color[,] TempArray = new Color[iWidth, iHeight];

            //First the Image is Grayscaled
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    byte Average = Convert.ToByte((col.B + col.R + col.G) / 3);

                    Color newColor = Color.FromArgb(255, Average, Average, Average);
                    ImageArray[i, j] = newColor;

                }
            }
            //Weighted blur to remove noise

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    int AverageR = 0, AverageG = 0, AverageB = 0;
                    int iDivider = 0;
                    Byte Red, Blue, Green;

                    AverageR += 4*ImageArray[i, j].R;
                    AverageG += 4 * ImageArray[i, j].G;
                    AverageB += 4 * ImageArray[i, j].B;
                    iDivider += 4;

                    if (!(i + 1 >= iWidth))//Right
                    {
                        AverageR += 2* ImageArray[i + 1, j].R;
                        AverageB += 2* ImageArray[i + 1, j].B;
                        AverageG += 2* ImageArray[i + 1, j].G;
                        iDivider+= 2;

                    }
                    if (!(i - 1 < 0))//Left
                    {
                        AverageR += 2* ImageArray[i - 1, j].R;
                        AverageB += 2* ImageArray[i - 1, j].B;
                        AverageG += 2* ImageArray[i - 1, j].G;
                        iDivider+= 2;
                    }
                    if (!(j + 1 >= iHeight))//Top
                    {
                        AverageR += 2* ImageArray[i, j + 1].R;
                        AverageB += 2* ImageArray[i, j + 1].B;
                        AverageG += 2* ImageArray[i, j + 1].G;
                        iDivider+= 2;
                    }
                    if (!(j - 1 < 0))//Bottom
                    {
                        AverageR += 2* ImageArray[i, j - 1].R;
                        AverageB += 2* ImageArray[i, j - 1].B;
                        AverageG += 2* ImageArray[i, j - 1].G;
                        iDivider+= 2;
                    }
                    if (!(j - 1 < 0 || i - 1 < 0))//Top left
                    {
                        AverageR += ImageArray[i - 1, j - 1].R;
                        AverageB += ImageArray[i - 1, j - 1].B;
                        AverageG += ImageArray[i - 1, j - 1].G;
                        iDivider++;
                    }
                    if (!(j - 1 < 0 || i + 1 >= iWidth))//Top right
                    {
                        AverageR += ImageArray[i + 1, j - 1].R;
                        AverageB += ImageArray[i + 1, j - 1].B;
                        AverageG += ImageArray[i + 1, j - 1].G;
                        iDivider++;
                    }
                    if (!(j + 1 >= iHeight || i + 1 >= iWidth))//Bot right
                    {
                        AverageR += ImageArray[i + 1, j + 1].R;
                        AverageB += ImageArray[i + 1, j + 1].B;
                        AverageG += ImageArray[i + 1, j + 1].G;
                        iDivider++;
                    }
                    if (!(j + 1 >= iHeight || i - 1 < 0))//Bot Left
                    {
                        AverageR += ImageArray[i - 1, j + 1].R;
                        AverageB += ImageArray[i - 1, j + 1].B;
                        AverageG += ImageArray[i - 1, j + 1].G;
                        iDivider++;
                    }

                    Red = Convert.ToByte(AverageR / iDivider);
                    Green = Convert.ToByte(AverageG / iDivider);
                    Blue = Convert.ToByte(AverageB / iDivider);

                    TempArray[i, j] = Color.FromArgb(255, Red, Green, Blue);

                }
            }
            //Blurred image is transferred
            ImageArray = (Color[,])(TempArray.Clone());

            GetContrast(TempArray, iHeight, iWidth);

            //Edges are transferred
            ImageArray = (Color[,])(TempArray.Clone());

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }
    }
}
