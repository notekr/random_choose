using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Choose_Program
{
    static class Program
    {
        /*
        * ----------------------------------------------------------------------------
        * Made by NoteKR
        * Copyright 2018 notekr
        * If you wanna copy this code, Please give me a mail. (rhcksgus2@gmail.com)
        * ----------------------------------------------------------------------------
        */

        static public Random ramn = new Random();
        static public int count = 0;
        static public ArrayList list = new ArrayList();
        static public bool samechecked = false;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
