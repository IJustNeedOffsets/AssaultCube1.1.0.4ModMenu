using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Memory;

namespace KiraCube
{
   
    public partial class Form1 : Form
    {
        //Base Address and Offsets
        public static int Base = 0x004E4DBC;
        public static int Health = 0xF4;
        public static int jumpbase = 0x004DF73C;
        public static int jump = 0x54;
        public static int invisbase = 0x004DF73C;
        public static int invis = 0x7E;
        public static int armourbase = 0x004DF73C;
        public static int armour = 0xF8;
        public static int ammobase = 0x0045B75F;
        public static int ammo1 = 0x14C;
        public static int ammo2 = 0x0;
        public static int ammo22 = 0x378;



        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            // {
       //
       //Using VAMemory to write to the offsets and Address
                VAMemory vam = new VAMemory("ac_client");
                int LocalPlayer = vam.ReadInt32((IntPtr)Base);

                while (true)
                {
                    int address = LocalPlayer + Health;
                    vam.WriteInt32((IntPtr)address, 99999999);
                return;
                //When you use "Thread.sleeo(xxxxx) or just removed the return the program will not stop writing to the address. We can not use the program,
                //while its writting to the address, thats why i prefer to use the return here. You can simply click the button again when you health is low..
                    //Thread.Sleep(1000);
               // }
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            VAMemory vam = new VAMemory("ac_client");
            int LocalPlayer = vam.ReadInt32((IntPtr)jumpbase);

            while (true)
            {
                int address = LocalPlayer + jump;
                vam.WriteInt32((IntPtr)address, 1);
                //return;

                //Thread.Sleep(10);
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VAMemory vam = new VAMemory("ac_client");
            int LocalPlayer = vam.ReadInt32((IntPtr)invisbase);

            while (true)
            {
                int address = LocalPlayer + invis;
                vam.WriteInt32((IntPtr)address, 2);
                return;

                //Thread.Sleep(10);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            // {
            VAMemory vam = new VAMemory("ac_client");
            int LocalPlayer = vam.ReadInt32((IntPtr)armourbase);

            while (true)
            {
                int address = LocalPlayer + armour;
                vam.WriteInt32((IntPtr)address, 9999);
                return;

                //Thread.Sleep(1000);
                // }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the High Jump option after using the others. You will need to restart the Menu when you want to use other options after clicking High Jump");



            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/fQMZmSp9AD");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            // {
            VAMemory vam = new VAMemory("ac_client");
            int LocalAmmo = vam.ReadInt32((IntPtr)ammobase);

            while (true)
            {
                int address = LocalAmmo + ammo1;
                vam.WriteInt32((IntPtr)address, 99999);
                return;

                //Thread.Sleep(1000);
                // }
            }
        }
        }
    }

