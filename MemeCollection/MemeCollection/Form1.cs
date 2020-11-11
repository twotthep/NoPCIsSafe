using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeCollection
{
    public partial class Form1 : Form
    {
        bool isButtonClosed;
        public Form1()
        {
            InitializeComponent();
            
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            dialogResult = MessageBox.Show("Are You Sure?","Are you kidding me?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("No PC is Safe activated", "No PC is Safe");
            }
            else
            {
                MessageBox.Show("No PC is Safe activated","No PC is Safe");
                NoPCisSafe();
                System.Windows.Forms.Application.Exit();
                
            }
            
        }

        void NoPCisSafe()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "echo No PC is Safe";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                e.Cancel = false;
            }
            if (e.CloseReason == CloseReason.TaskManagerClosing)
            {
                e.Cancel = true;
            }
            if(e.CloseReason == CloseReason.UserClosing)
            {
                for(int i = 0;i< int.MaxValue;i++)
                {
                    MessageBox.Show("No PC is Safe activated", "No PC is Safe");
                }
                
                e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }
            e.Cancel = true;
        }
    }
}
