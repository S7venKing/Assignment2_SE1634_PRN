using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_SE1634.GUI
{
    public partial class TestUpLoadImage : Form
    {
        public TestUpLoadImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                if (ofd.FileName == "")
                    return;
                string filename = ofd.FileName;
                string[] str = filename.Split("\\");
                pictureBox1.ImageLocation = filename;
                MessageBox.Show(filename.ToString());
                MessageBox.Show(Application.StartupPath);
                File.Copy(pictureBox1.ImageLocation, Application.StartupPath + "Resources\\Images\\" + str.Last(), true);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "Resources\\Images\\songoku.jpg";

        }
    }
    }



