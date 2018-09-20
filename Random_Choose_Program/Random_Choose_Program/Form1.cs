using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Choose_Program
{
    public partial class Form1 : Form
    {
        /*
        * ----------------------------------------------------------------------------
        * Made by NoteKR
        * Copyright 2018 notekr
        * If you wanna copy this code, Please give me a mail. (rhcksgus2@gmail.com)
        * ----------------------------------------------------------------------------
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                }
            }

            if (fileName != null)
            {
                string text = File.ReadAllText(fileName);
                Program.list.Clear();
                listView1.Clear();
                listView2.Clear();
            }

            string line;
            
            StreamReader file = new StreamReader(@fileName, Encoding.Default);

            while ((line = file.ReadLine()) != null)
            {
                Program.list.Add(line);
                listView1.Items.Add(line);
                Program.count++;
            }

            file.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView2.View = View.SmallIcon;
            listView3.View = View.SmallIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randomd = Program.ramn.Next(0, Program.count);
            try
            {
                listView2.Items.Add(Convert.ToString(Program.list[randomd]));
            } catch {
                listView3.Items.Add("남은 객체가 없습니다.");
                goto errorchacked;
            }
            Program.list.RemoveAt(randomd);
            listView1.Items.RemoveAt(randomd);
            Program.count--;
            errorchacked:;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView3.Clear();
        }
    }
}
