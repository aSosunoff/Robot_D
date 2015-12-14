using System;
using System.Collections;
using System.Collections.Generic;
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
                //tbCommand.Text = commander.GetFinalPositionRobot;
                if (commander.GetFinalPositionRobot != null)
                {
                    foreach (var el in commander.GetFinalPositionRobot)
                    {
                        tbCommand.Text += String.Format("{0}: {1}", el.Key, el.Value);
                    }
                }
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
                if (commander.GetFinalPositionRobot != null)
                {
                    foreach (var el in commander.GetFinalPositionRobot)
                    {
                        tbCommand.Text += String.Format("{0}: {1}", el.Key, el.Value);
                    }
                }
                //tbCommand.Text = commander.GetFinalPositionRobot;
            }
            catch (ApplicationException exception)
            {
                tbCommand.Text += "\r\n" + exception.Message;

                if (exception.Data != null)
                {
                    foreach (DictionaryEntry el in exception.Data)
                    {
                        tbCommand.Text += "\r\n" + String.Format("{0}: {1}", el.Key, el.Value);
                    }
                }
                //tbCommand.Text += "\r\n" + exceptionUser.TargetSite;
                //tbCommand.Text += "\r\n" + exceptionUser.Source;
                //tbCommand.Text += "\r\n" + exceptionUser.StackTrace;
            }
        }
    }
}
