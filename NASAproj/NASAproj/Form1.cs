using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NASAproj
{
    public partial class Form1 : Form
    {
        public ArrayList events = new ArrayList(); 

        public Form1()
        {
            InitializeComponent();
        }

        //MakeFileTextBox text change event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //RewindButton click event
        private void button5_Click(object sender, EventArgs e)
        {

        }

        //playPauseButton click event
        private void button6_Click(object sender, EventArgs e)
        {

        }

        //fastForwardButton click event
        private void button7_Click(object sender, EventArgs e)
        {

        }

        //Parameter2 Label click event
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //StatusLabel click event
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        //OpenSeachButton click event
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            if (this.makeFileTextBox.Text == "")
                MessageBox.Show("No name entered. Please choose a name for the new file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName);
                    sr.ReadLine();

                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        StopEvent evt = new StopEvent(line);
                        if (evt.getCode() == 82 || evt.getCode() == 81)
                              Console.WriteLine(evt.toString());
                    }
                    MessageBox.Show(this.makeFileTextBox.Text);
                    sr.Close();
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }
    }
}
