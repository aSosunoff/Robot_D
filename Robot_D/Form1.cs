using System;
using System.Windows.Forms;
using Robot_D.Dispatcher;

namespace Robot_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            try
            {
                ControlCommand commander = new ControlCommand(new DevideCommand("5 5\r\n1 2 N\r\nLMLMLMLMM\r\n"));
                tbCommand.Text = commander.DronFinish;
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
                ControlCommand commander = new ControlCommand(new DevideCommand(tbCommand.Text));
                tbCommand.Text = commander.DronFinish;
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
