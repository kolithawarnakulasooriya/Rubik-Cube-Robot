using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using System.Threading;
using DirectShowLib;
using Emgu.CV.UI;


namespace TestApplication
{
    public partial class ReadCube : Form
    {

        Capture videoCapture;
        Mat frame;
        const int CAMERA_INDEX = 1;
        const int fps = (int)(1000.0 / 30);
        Rectangle leftup,up,rightup,left,center,right,leftdown,down,rightdown;

        static Image<Bgr, Byte>[] blocks = new Image<Bgr, Byte>[9];
        Image<Bgr, Byte> img;
        private static string read;
        int yp = 0;
        private static bool initCommand=false;
        Panel p;
        public ReadCube()
        {
            InitializeComponent();

            foreach (var pb in this.Controls.OfType<Panel>())
            {
                pb.MouseClick += ULU_MouseClick;
            }


            DsDevice[] captureDevices;

            // Get the set of directshow devices that are video inputs.
            captureDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            for (int idx = 0; idx < captureDevices.Length; idx++)
            {
                comboBox1.Items.Add(captureDevices[idx].Name);
            }

            comboBox1.SelectedIndex = 0;

            if (SP.IsOpen)
                SP.Close();

        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {

                frame = videoCapture.QueryFrame();
                if (frame != null)
                {

                    pbImage.Image = drawLine(frame.Bitmap);
                    extractROI(frame.Bitmap);


                    Thread.Sleep(fps);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void extractROI(Bitmap bitmap)
        {
            for (int i = 0; i < 9; i++)
            {
                img= new Image<Bgr,Byte>((Bitmap)bitmap.Clone());

                img._EqualizeHist();
                //img._GammaCorrect(2.0d);
                pbImage.Image = img.Bitmap;


                switch (i)
                {
                    case 0: blocks[0] = extractColor(img, leftup); break;
                    case 1: blocks[1] = extractColor(img, up); break;
                    case 2: blocks[2] = extractColor(img, rightup); break;
                    case 3: blocks[3] = extractColor(img, left); break;
                    case 4: blocks[4] = extractColor(img, center); break;
                    case 5: blocks[5] = extractColor(img, right); break;
                    case 6: blocks[6] = extractColor(img, leftdown); break;
                    case 7: blocks[7] = extractColor(img, down); break;
                    case 8: blocks[8] = extractColor(img, rightdown); break;
                }
            }
        }

        private Image<Bgr,Byte> extractColor(Image<Bgr,Byte>img,Rectangle rectangle)
        {
            img.ROI = rectangle;
            return img;
        }


        private Bitmap drawLine(Bitmap bitmap)
        {

            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.DrawRectangle(new Pen(Brushes.Black), leftup);
                gr.DrawRectangle(new Pen(Brushes.Black), up);
                gr.DrawRectangle(new Pen(Brushes.Black), rightup);
                gr.DrawRectangle(new Pen(Brushes.Black), left);
                gr.DrawRectangle(new Pen(Brushes.Black), center);
                gr.DrawRectangle(new Pen(Brushes.Black), right);
                gr.DrawRectangle(new Pen(Brushes.Black), leftdown);
                gr.DrawRectangle(new Pen(Brushes.Black), down);
                gr.DrawRectangle(new Pen(Brushes.Black), rightdown);
                return bitmap;
            }

        }

        private void cmdSelectCamera_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture(comboBox1.SelectedIndex);
            videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, 30);
            videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, pbImage.Height);
            videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, pbImage.Width);

            Application.Idle += ProcessFrame;

            leftup = new Rectangle(new Point(85, 55), new Size(10,10));
            up = new Rectangle(new Point(134, 55), new Size(10, 10));
            rightup = new Rectangle(new Point(179, 55), new Size(10, 10));
            left = new Rectangle(new Point(85, 103), new Size(10, 10));
            center = new Rectangle(new Point(134, 103), new Size(10, 10));
            right = new Rectangle(new Point(179, 103), new Size(10, 10));
            leftdown = new Rectangle(new Point(85, 150), new Size(10, 10));
            down = new Rectangle(new Point(134, 150), new Size(10, 10));
            rightdown = new Rectangle(new Point(179, 150), new Size(10, 10));

        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            Button[] b = { cmdAutoinit, cmdInit, cmdOK, cmdRead };
            if (SP.IsOpen)
            {
                SP.Close();
                cmdConnect.Text = "Connect";
                
            }
            else {
                SP.Open();
                cmdConnect.Text = "Disconnect";

            }
            foreach (Button bs in b)
            {
                bs.Enabled = SP.IsOpen;
            }
            
        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            SP.Write("I");
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (yp == 0)
                yp = 1;
            else
                yp = 0;
            SP.Write("D");
        }

        private void fillUpper()
        {
            ULU.BackColor = getColor(blocks[0],0);
            URU.BackColor = getColor(blocks[2],2);
            UC.BackColor = getColor(blocks[4],4);
            ULD.BackColor = getColor(blocks[6],6);
            URD.BackColor = getColor(blocks[8],8);

            if (yp == 1)
            {
                UL.BackColor = getColor(blocks[3],3);
                UR.BackColor = getColor(blocks[5],5);

            }
            else
            {
                UU.BackColor = getColor(blocks[1],1);
                UD.BackColor = getColor(blocks[7],7);

            }
        }

        private void fillBack()
        {
            BLU.BackColor = getColor(blocks[8], 8);
            BRU.BackColor = getColor(blocks[6], 6);
            BC.BackColor = getColor(blocks[4], 4);
            BLD.BackColor = getColor(blocks[2], 2);
            BRD.BackColor = getColor(blocks[0], 0);
            BL.BackColor = getColor(blocks[5], 5);
            BR.BackColor = getColor(blocks[3], 3);
            BU.BackColor = getColor(blocks[7], 7);
            BD.BackColor = getColor(blocks[1], 1);
            
        }

        private void fillFront()
        {
            FLU.BackColor = getColor(blocks[0], 0);
            FRU.BackColor = getColor(blocks[2], 2);
            FC.BackColor = getColor(blocks[4], 4);
            FLD.BackColor = getColor(blocks[6], 6);
            FRD.BackColor = getColor(blocks[8], 8);
            FL.BackColor = getColor(blocks[3], 3);
            FR.BackColor = getColor(blocks[5], 5);
            FU.BackColor = getColor(blocks[1], 1);
            FD.BackColor = getColor(blocks[7], 7);

        }

        private void fillDown()
        {
            DLU.BackColor = getColor(blocks[0], 0);
            DRU.BackColor = getColor(blocks[2], 2);
            DC.BackColor = getColor(blocks[4], 4);
            DLD.BackColor = getColor(blocks[6], 6);
            DRD.BackColor = getColor(blocks[8], 8);

            if (yp == 1)
            {
                DL.BackColor = getColor(blocks[3], 3);
                DR.BackColor = getColor(blocks[5], 5);

            }
            else
            {
                DU.BackColor = getColor(blocks[1], 1);
                DD.BackColor = getColor(blocks[7], 7);

            }
        }

        private void fillRight()
        {
            RLU.BackColor = getColor(blocks[6], 6);
            RRU.BackColor = getColor(blocks[0], 0);
            RC.BackColor = getColor(blocks[4], 4);
            RLD.BackColor = getColor(blocks[8], 8);
            RRD.BackColor = getColor(blocks[2], 2);
            RL.BackColor = getColor(blocks[7], 7);
            RR.BackColor = getColor(blocks[1], 1);
            RU.BackColor = getColor(blocks[3], 3);
            RD.BackColor = getColor(blocks[5], 5);

        }

        private void fillLeft()
        {
            LLU.BackColor = getColor(blocks[2], 2);
            LRU.BackColor = getColor(blocks[8], 8);
            LC.BackColor = getColor(blocks[4], 4);
            LLD.BackColor = getColor(blocks[0], 0);
            LRD.BackColor = getColor(blocks[6], 6);
            LL.BackColor = getColor(blocks[1], 1);
            LR.BackColor = getColor(blocks[7], 7);
            LU.BackColor = getColor(blocks[5], 5);
            LD.BackColor = getColor(blocks[3], 3);

        }

        private Color getColor(Image<Bgr,Byte> image,int y)
        {
            

            Image<Hsv, byte> imghsv = image.Convert<Hsv, byte>();
            Image<Gray, Byte>[] channels = imghsv.Split();
            Image<Gray, Byte> ImgHue = channels[0];
            Image<Gray, Byte> ImgSat = channels[1];

            double avgs = getColorAvg(ImgHue);
            Console.Write(y+" - ");
            Console.Write(" - " + getColorAvg(ImgHue));
            Console.WriteLine(" - " + getColorAvg(ImgHue));

            if (avgs > 0 && avgs < 15)
                return Color.Orange;
            else if (avgs > 15 && avgs < 30)
                return Color.Yellow;
            else if (avgs > 80 && avgs < 105)
                return Color.Blue;
            else if (avgs > 105 && avgs < 160)
                return Color.Red;
            else if ((avgs > 30 && avgs < 80))
            {
               avgs = getColorAvg(ImgSat);
               if (avgs > 0 && avgs < 20)
                   return Color.White;
               else
                   return Color.Green;
            }

            return Color.Black;
        }

        void drawhisto(Image<Gray, Byte> img)
        {
            Form frm = new Form();

            HistogramBox histo = new HistogramBox();

            histo.ClearHistogram();
            histo.GenerateHistograms(img, 256);
            histo.Dock = DockStyle.Fill;
            histo.Refresh();

            frm.Controls.Add(histo);

            frm.ShowDialog(); 
        }

        private int ColorPercentage(Image<Gray, byte> img)
        {
            int black = 0, white = 0;
            for (int i = 3; i < img.Width - 3; i++)
            {
                for (int j = 3; j < img.Height - 3; j++)
                {
                    byte b = img.Data[i, j, 0];
                    if (b == 0)
                        black++;
                    else
                        white++;
                }
            }
            return (white * 100) / (white + black);
        }

        private double getColorAvg(Image<Gray, byte> img)
        {
            double d = 0;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    byte b= img.Data[i, j, 0];
                    d+=System.Convert.ToDouble(b);
                }
            }

            // devide
            return d / (img.Height * img.Width);
        }

        private Color getColorRGB(int[] data)
        {
            int max = Math.Max(data[0], data[1]);
            max = Math.Max(max, data[2]);
            if (data[0] > 100 && data[1] > 100 && data[2] > 100)
                return Color.White;
            else if (max == data[0])
            {
                if (data[0] > 80 && data[1] > 80)
                    return Color.Yellow;
                else if (data[0] > 80 && (data[1] > 40 && data[1] < 80))
                    return Color.Orange;
                else
                    return Color.Red;
            }
            else if (max == data[1])
            {
                return Color.Green;
            }
            else if (max == data[2])
                return Color.Blue;

            else
                return Color.Black;
        }

        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            read = SP.ReadExisting().ToString().Trim();
            SetText(read);

            if (initCommand)
            {
                if (read.Contains("U"))
                {
                    fillUpper();
                    if (yp == 0)
                        yp = 1;
                    else
                        yp = 0;
                }
                else if (read.Contains("B"))
                {
                    fillBack();
                }
                else if (read.Contains("F"))
                {
                    fillFront();
                }
                else if (read.Contains("D"))
                {
                    fillDown();
                    if (yp == 0)
                        yp = 1;
                    else
                        yp = 0;
                }
                else if (read.Contains("R"))
                {
                    fillRight();
                }
                else if (read.Contains("L"))
                {
                    fillLeft();
                }else if(read.Contains("E"))
                {
                    initCommand = false;
                }

                Thread.Sleep(1000);
                SP.Write("D");
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.rtc.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtc.Text += text;
            }
        }

        private void pbImage_MouseClick(object sender, MouseEventArgs e)
        {

            Console.WriteLine(e.Location);
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            Console.WriteLine("----------");
            if (SP.IsOpen)
            {

                try
                {
                    if (read.Contains("U"))
                {
                    fillUpper();
                }
                else if (read.Contains("B"))
                {
                    fillBack();
                }
                else if (read.Contains("F"))
                {
                    fillFront();
                }
                else if (read.Contains("D"))
                {
                    fillDown();
                }
                else if (read.Contains("R"))
                {
                    fillRight();
                }
                else if (read.Contains("L"))
                {
                    fillLeft();
                }
                }
                catch (Exception)
                {
                    
                }
            }
            else
            {
                fillFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            initCommand = true;
            SP.Write("I");
        }

        private void cmdSolve_Click(object sender, EventArgs e)
        {
            solve();
        }

        private void solve()
        {
            string p =getStringOfCube();
            txtreadPattern.Text =p;
            string solved=KociembaTwoPhase.Search.solution(p, 100,false);
            txtSolvedPattern.Text = solved;
            // convert to ar text
            string sps= createArduinoString(solved);
            txtarstring.Text = sps;
        }

        private string createArduinoString(string s)
        {
            string[] spl = s.Split(' ');

            string res = "";
            foreach (string y in spl)
            {
                Console.WriteLine(y);
                if (y.Contains("."))
                    continue;
                if (y.Length == 2)
                {
                    char f = y[0];
                    if (y[1] == '\'')
                    {
                        f = Char.ToLower(f);
                        res += f;
                    }
                    else if (Char.IsDigit(y[1]))
                    {
                        int p = Int16.Parse(y[1].ToString());
                        for (int i = 0; i < p; i++)
                        {
                            res += f;
                        }
                    }
                }
                else
                {
                    res+=y;
                }
            }
            res += "A";
            return res;
        }

         private string getStringOfCube()
        {
            // read color string
            string[] s = new string[54];

            for (int i = 0; i < 54; i++)
                s[i] = "B";

            string result = "";

            s[0] = getChar(ULU);
            s[1] = getChar(UU);
            s[2] = getChar(URU);
            s[3] = getChar(UL);
            s[4] = getChar(UC);
            s[5] = getChar(UR);
            s[6] = getChar(ULD);
            s[7] = getChar(UD);
            s[8] = getChar(URD);

            s[9] = getChar(RLU);
            s[10] = getChar(RU);
            s[11] = getChar(RRU);
            s[12] = getChar(RL);
            s[13] = getChar(RC);
            s[14] = getChar(RR);
            s[15] = getChar(RLD);
            s[16] = getChar(RD);
            s[17] = getChar(RRD);

            s[18] = getChar(FLU);
            s[19] = getChar(FU);
            s[20] = getChar(FRU);
            s[21] = getChar(FL);
            s[22] = getChar(FC);
            s[23] = getChar(FR);
            s[24] = getChar(FLD);
            s[25] = getChar(FD);
            s[26] = getChar(FRD);

            s[27] = getChar(DLU);
            s[28] = getChar(DU);
            s[29] = getChar(DRU);
            s[30] = getChar(DL);
            s[31] = getChar(DC);
            s[32] = getChar(DR);
            s[33] = getChar(DLD);
            s[34] = getChar(DD);
            s[35] = getChar(DRD);

            s[36] = getChar(LLU);
            s[37] = getChar(LU);
            s[38] = getChar(LRU);
            s[39] = getChar(LL);
            s[40] = getChar(LC);
            s[41] = getChar(LR);
            s[42] = getChar(LLD);
            s[43] = getChar(LD);
            s[44] = getChar(LRD);

            s[45] = getChar(BLU);
            s[46] = getChar(BU);
            s[47] = getChar(BRU);
            s[48] = getChar(BL);
            s[49] = getChar(BC);
            s[50] = getChar(BR);
            s[51] = getChar(BLD);
            s[52] = getChar(BD);
            s[53] = getChar(BRD);

            foreach(string f in s){
                result += f;
            }
            return result.ToString();    
        }

        private string getChar(Panel p)
        {
            if (p.BackColor == UC.BackColor)
                return "U";
            if (p.BackColor == RC.BackColor)
                return "R";
            if (p.BackColor == LC.BackColor)
                return "L";
            if (p.BackColor == BC.BackColor)
                return "B";
            if (p.BackColor == FC.BackColor)
                return "F";
            if (p.BackColor == DC.BackColor)
                return "D";
            return "B";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ULU.BackColor = Color.Yellow;
            UU.BackColor = Color.Green;
            URU.BackColor = Color.Red;
            UL.BackColor = Color.Yellow;
            UC.BackColor = Color.White;
            UR.BackColor = Color.Blue;
            ULD.BackColor = Color.Blue;
            UD.BackColor = Color.Yellow;
            URD.BackColor = Color.Orange;

            RLU.BackColor = Color.Blue;
            RU.BackColor = Color.Red;
            RRU.BackColor = Color.Yellow;
            RL.BackColor = Color.White;
            RC.BackColor = Color.Blue;
            RR.BackColor = Color.Red;
            RLD.BackColor = Color.Orange;
            RD.BackColor = Color.Orange;
            RRD.BackColor = Color.Green;

            FLU.BackColor = Color.Red;
            FU.BackColor = Color.Orange;
            FRU.BackColor = Color.White;
            FL.BackColor = Color.Orange;
            FC.BackColor = Color.Red;
            FR.BackColor = Color.Blue;
            FLD.BackColor = Color.Yellow;
            FD.BackColor = Color.Yellow;
            FRD.BackColor = Color.Green;

            DLU.BackColor = Color.Green;
            DU.BackColor = Color.Green;
            DRU.BackColor = Color.White;
            DL.BackColor = Color.Red;
            DC.BackColor = Color.Yellow;
            DR.BackColor = Color.Green;
            DLD.BackColor = Color.Orange;
            DD.BackColor = Color.Blue;
            DRD.BackColor = Color.Red;

            LLU.BackColor = Color.Blue;
            LU.BackColor = Color.Red;
            LRU.BackColor = Color.White;
            LL.BackColor = Color.Orange;
            LC.BackColor = Color.Green;
            LR.BackColor = Color.Blue;
            LLD.BackColor = Color.Yellow;
            LD.BackColor = Color.White;
            LRD.BackColor = Color.Red;

            BLU.BackColor = Color.Blue;
            BU.BackColor = Color.White;
            BRU.BackColor = Color.Orange;
            BL.BackColor = Color.Green;
            BC.BackColor = Color.Orange;
            BR.BackColor = Color.White;
            BLD.BackColor = Color.White;
            BD.BackColor = Color.Yellow;
            BRD.BackColor = Color.Green;

        }

        private void cmdsend_Click(object sender, EventArgs e)
        {
            string s = txtarstring.Text;
            if (SP.IsOpen)
            {
                SP.Write(s);
                Console.WriteLine(s);
            }
        }

        int y = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write(txtarstring.Text.Trim().ToCharArray()[y++].ToString());
            }
            if(y==txtarstring.Text.Length)
                y=0;
        }

        private void ULU_MouseClick(object sender, MouseEventArgs e)
        {
            Panel pl = (Panel)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmdl.Show(this, new Point(e.X + ((Control)sender).Left, e.Y + ((Control)sender).Top ));
                p = pl;
                cmdl.ItemClicked+=cmdl_ItemClicked;
            }

        }

        private void cmdl_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            switch (item.Text)
            {
                case "Red": p.BackColor = Color.Red; break;
                case "Green": p.BackColor = Color.Green; break;
                case "Blue": p.BackColor = Color.Blue; break;
                case "White": p.BackColor = Color.White; break;
                case "Yellow": p.BackColor = Color.Yellow; break;
                case "Orange": p.BackColor = Color.Orange; break; 
            }
        }

     
    }
}
