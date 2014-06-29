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

        //RewindButton click event
        private void rewind_Click(object sender, EventArgs e)
        {

        }

        //playPauseButton click event
        private void playPause_Click(object sender, EventArgs e)
        {

        }

        //fastForwardButton click event
        private void forward_Click(object sender, EventArgs e)
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
            OpenFileDialog pict = new OpenFileDialog();
            if(pict.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = pict.FileName;
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