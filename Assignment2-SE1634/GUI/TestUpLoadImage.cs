﻿using Assignment2_SE1634.Properties;
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
            //up load image cho albums 
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Image file";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*gif)| *.jpg;*.jpeg;*.png;*.gif";

                ofd.ShowDialog();
                if (ofd.FileName == "")
                    return;
                string filename = ofd.FileName;
                string[] str = filename.Split("\\");
                pictureBox1.ImageLocation = filename;
                MessageBox.Show(filename.ToString());
                //luu vao resources cua chuong trinh(Application.StartupPath(bin\.net 6) + "Resources\\Images\\" + str.Last()), luu duong dan cua resouces toi database(\\Images\\str.Last())
                File.Copy(pictureBox1.ImageLocation, Application.StartupPath + "Resources\\Images\\" + str.Last(), true);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox2.ImageLocation = pictureBox1.ImageLocation;

        }
    }
    }



