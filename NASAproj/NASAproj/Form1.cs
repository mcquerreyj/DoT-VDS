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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataButton_Click(object sender, EventArgs e)
        {
                // Dump the event array
            events.Clear();
                
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                sr.ReadLine();

                string line;
                while((line = sr.ReadLine()) != null)
                {
                    StopEvent evt = new StopEvent(line);
                    if (evt.getCode() == 82 || evt.getCode() == 81)
                    {
                        events.Add(evt);

                        // Fills Param boxes
                        p1ComboBox.Items.Add(evt.getParam());

                        //------------------------------
                        // THIS WILL NEED TO BE TAKEN OUT 
                        //------------------------------
                        Console.WriteLine(evt.toString());
                    }
                }
                sr.Close();

                //Removes duplicates from comboboxes
                List<object> combo = new List<object>();
                foreach (int param in p1ComboBox.Items)
                {
                    if (!combo.Contains(param))
                    {
                        combo.Add(param);
                    }
                }
                p1ComboBox.Items.Clear();
                foreach (int p in combo)
                {
                    p1ComboBox.Items.Add(p);
                    p2ComboBox.Items.Add(p);
                }               
            }
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Click the \"Data\" button to load a .csv into the system \n" + 
                            "2. Click the \"Picture\" button to load the pictures into the frame \n" + 
                            "(Note: Select the first picture from the folder)\n" + 
                            "3. Select the parameters 1 and 2 from the dropdown list \n" +
                            "4. Use the Control Buttons (RW, Play\\Pause, FF) to view the images like a video"
                            , "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}