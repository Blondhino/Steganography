using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenImageFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image Files (*.png) | *.png;";
            Dialog.InitialDirectory = @"C:\";
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImageFilePath.Text = Dialog.FileName.ToString();
                pictureBox1.ImageLocation = ImageFilePath.Text;

            }
        }

        private void OpenTextFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Txt Files (*.txt) | *.txt";
            Dialog.InitialDirectory = @"C:\";
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                TextFilePath.Text = Dialog.FileName.ToString();

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string getBinNum(int intNumber)
        {
            string output = Convert.ToString(intNumber, 2);
            if (output.Length < 8)
            {
                while (output.Length != 8) {
                    output = output.Insert(0, "0");
                }
                return output;
            }
            else {
                return output;
            }
        }


        public int getIntFromBin(string block) {


            return Convert.ToInt32(block, 2);
        }

        public void GenerateHeader(int NumOfChars, Bitmap image) {

              string binNumOfChars = getBinNum(NumOfChars);
            int n = 16 - binNumOfChars.Length;
            for(int i=0; i<n; i++)
            {
                binNumOfChars = binNumOfChars.Insert(0, "0");  // N A D O P U N J A V A N J E   N A   1 6   B I T A
            }
            textBox1.AppendText("Writing to header...");
            textBox1.AppendText(Environment.NewLine);
            for (int i = 0; i < 8; i++)
            {
                Color pixel = image.GetPixel(0, i);
                string binPixel = getBinNum(pixel.B);
                textBox1.AppendText("Org: ");
                textBox1.AppendText(binPixel.ToString());
                var BinNewValueOfPixel = new StringBuilder(binPixel);
                BinNewValueOfPixel.Remove(6, 1);
                BinNewValueOfPixel.Insert(6, binNumOfChars[2 * i]);
                BinNewValueOfPixel.Remove(7, 1);
                BinNewValueOfPixel.Insert(7, binNumOfChars[2 * i + 1]);
                int NewValueOfPixel = getIntFromBin(BinNewValueOfPixel.ToString());
                image.SetPixel(i, 0, Color.FromArgb(pixel.R, pixel.G, NewValueOfPixel));
                textBox1.AppendText("  New:   ");
                textBox1.AppendText(getBinNum(image.GetPixel(i, 0).B));
                textBox1.AppendText(Environment.NewLine);
            }


        }

        public void EncodeMessage(Bitmap image)
        {
            StreamReader sr = new StreamReader(TextFilePath.Text); //   D O H V A C A N J E
            string textFromData = sr.ReadToEnd();                  //      T E K S T A 
            //textBox1.Text=textFromData;                          //   I Z   D A T O T E K E
            sr.Close();            
            StreamWriter sw = new StreamWriter("bynaryOutput.txt");    // G E N E R I R A N J E
            for (int i = 0; i < textFromData.Length; i++)
            {                                                          //    B I A R N E 
                string block = getBinNum(textFromData[i]);             //   D A T O T E K E
                sw.Write(block);

            }
            sw.Close();

            StreamReader BinLine = new StreamReader("bynaryOutput.txt");
            string line = BinLine.ReadToEnd();
            BinLine.Close();
            int n = line.Length;

            StreamWriter sw1 = new StreamWriter("bynaryOutput.txt");    // G E N E R I R A N J E
            for (int k= 0; k < textFromData.Length; k++)
            {                                                          //    B I A R N E 
                string block = getBinNum(textFromData[k]);             //   D A T O T E K E
                sw1.WriteLine(block);

            }
            sw1.Close();

            int Counter = image.Width;
            int PxCounter = 0;
            textBox1.AppendText("Duljina bin datoteke: ");
            textBox1.AppendText(n.ToString());
            textBox1.AppendText(" znakova");
            textBox1.AppendText(Environment.NewLine);            
            StreamReader sr1 = new StreamReader("bynaryOutput.txt");
            int z = image.Width * image.Height;
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("WRITING TO BODY");
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("---------------------------");
            textBox1.AppendText(Environment.NewLine);
            for (int i=0; i<n/8; i++)
            {
                                             
                string binValueOfCharacter = sr1.ReadLine();               
                for (int j = 0; j < 4; j++)
                {
                    int x = Counter % image.Width;
                    int y = Counter / image.Width;
                    Color Pixel = image.GetPixel(x, y);
                    string binValueOfPixel = getBinNum(image.GetPixel(x, y).B);
                    //textBox1.AppendText("Org: " + binValueOfPixel.ToString());
                    var ColorBuilder = new StringBuilder(binValueOfPixel);
                    ColorBuilder.Remove(6, 1);
                    ColorBuilder.Insert(6, binValueOfCharacter[2 * j]);
                    ColorBuilder.Remove(7, 1);
                    ColorBuilder.Insert(7, binValueOfCharacter[2 * j+1]);
                    //textBox1.AppendText("    New: " + ColorBuilder.ToString());
                    //textBox1.AppendText(Environment.NewLine);
                    int NewValueOfColor = getIntFromBin(ColorBuilder.ToString());
                    image.SetPixel(x, y, Color.FromArgb(Pixel.R,Pixel.G, NewValueOfColor));
                    Counter++;
                    PxCounter++;
                }

                

            }
            textBox1.AppendText(" Obradeno "+PxCounter.ToString()+" px");
        }
        

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(TextFilePath.Text);
            string text = sr.ReadToEnd();  
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.ShowDialog(); 
            saveImage.Filter= "Png Files (*.png) | *.png";
            saveImage.DefaultExt = "png";
            saveImage.AddExtension = true;
            Bitmap image = new Bitmap(ImageFilePath.Text);
            GenerateHeader(text.Length, image);
            EncodeMessage(image);
            image.Save(saveImage.FileName);
            
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            sfd.Filter = "Txt Files (*.txt) | *.txt";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;
            Bitmap image = new Bitmap(ImageFilePath.Text);
            textBox1.AppendText("---------------------------");
            textBox1.AppendText(Environment.NewLine);
            string BinHeader = "";
            for (int i = 0; i < 8; i++) {
                string binPixel = getBinNum(image.GetPixel(i, 0).B);
                BinHeader = BinHeader.Insert(BinHeader.Length, binPixel[6].ToString());
                BinHeader = BinHeader.Insert(BinHeader.Length, binPixel[7].ToString());
            }
            string message = "";
            int n = getIntFromBin(BinHeader);
            textBox1.AppendText("INFO FROM HEADER:");
            textBox1.AppendText(Environment.NewLine);            
            textBox1.AppendText("This image contains ");
            textBox1.AppendText(getIntFromBin(BinHeader).ToString());
            textBox1.AppendText(" characters");
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("---------------------------");
            textBox1.AppendText(Environment.NewLine);
            int counter = image.Width;
            StreamWriter sw = new StreamWriter(sfd.FileName);
            string character = "";
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int x = counter % image.Width;
                    int y = counter / image.Width;
                    string binValueOfPixel = getBinNum(image.GetPixel(x, y).B);
                   character=character.Insert(character.Length, binValueOfPixel[6].ToString());
                   character=character.Insert(character.Length, binValueOfPixel[7].ToString());                    
                    counter++;

                }
                
                int AsciiCharacter = getIntFromBin(character);                
                char c = (char)AsciiCharacter;
                message=message.Insert(message.Length, c.ToString());
                sw.Write(c);
                character = "";
                //textBox1.AppendText(c.ToString());
                
            }
            sw.Close();
        }
    }
    }



   


