using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Center_Layer;
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
                tbCommand.Text = commander.SendCommand("5 5\r\n1 2 N\r\nLMLMLMLMM\r\n");
            }
            catch (ApplicationException exception)
            {
                tbCommand.Text = exception.Message;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Commander commander = new Commander();
                tbCommand.Text = commander.SendCommand(tbCommand.Text);
            }
            catch (ApplicationException exception)
            {
                tbCommand.Text = exception.Message;
                //tbCommand.Text += "\r\n" + exceptionUser.TargetSite;
                //tbCommand.Text += "\r\n" + exceptionUser.Source;
                //tbCommand.Text += "\r\n" + exceptionUser.StackTrace;
            }
        }
    }
}
