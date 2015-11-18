using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dron_Exception;
using Upper_Layer;

namespace Robot_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            try
            {
                Commander commander = new Commander();
                tbCommand.Text = commander.SendCommand("5 5\r\n0 0 N\r\nmmM");
            }
            catch (ExceptionUser exceptionUser)
            {
                tbCommand.Text = exceptionUser.Message;
                //tbCommand.Text += "\r\n" + exceptionUser.TargetSite;
                //tbCommand.Text += "\r\n" + exceptionUser.Source;
                //tbCommand.Text += "\r\n" + exceptionUser.StackTrace;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Commander commander = new Commander();
                tbCommand.Text = commander.SendCommand(tbCommand.Text);
            }
            catch (ExceptionUser exceptionUser)
            {
                tbCommand.Text = exceptionUser.Message;
                //tbCommand.Text += "\r\n" + exceptionUser.TargetSite;
                //tbCommand.Text += "\r\n" + exceptionUser.Source;
                //tbCommand.Text += "\r\n" + exceptionUser.StackTrace;
            }
        }
    }
}
