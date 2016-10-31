using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROBOTIS;
using System.Threading;

namespace RobotControlCIT255Project
{
   
    public partial class Form1 : Form 
    {
        LinkToRobot connect = new Connection();
        CalculateDMS calculate = new CalculateDMS();
        MotionIndex motion = new MotionIndex();
        public Form1()
        {
            InitializeComponent();
            pBarDistance.Minimum = 0;
            pBarDistance.Maximum = int.MaxValue;       
        }

        Thread GetDataThread = null;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Open Device
            //Show message if not connected
            if (connect.OpenDevice() == 0)
            {
                MessageBox.Show("Failed ", "Connection Status", MessageBoxButtons.OK);
                GetDataThread.Abort();
                return;
            }
            else if (connect.OpenDevice() == 1)
            {
                MessageBox.Show("Succeed", "Connection Status", MessageBoxButtons.OK);

            }

            //Instantiate New thread 
            if (GetDataThread == null)
                GetDataThread = new Thread(new ThreadStart(GettingDataThread));
            //Start the thread
            if (!GetDataThread.IsAlive)
            {
                GetDataThread.Start();
            }

            //textBox1.Text = calculate.getValue().ToString();
            //textBox1.Text = xyz.ToString();
            // Save sending data to message
            //int message = int.Parse(txtTestBox.Text);

            //Transimit data to robot
            //if (zigbee.zgb_tx_data(message) == 0)
            //{
            //    MessageBox.Show("Failed to transimit");
            //}

            btnConnect.Enabled = false;
        }
        public void GettingDataThread()
        {
             int[] DMS_Value = new int[20];
            //Recieve data from robot within 1000 period 

            //for (int i = 0; i < 31; i++)
            while(true)
            {
                int average;
                //Verify data recieved 
                if (zigbee.zgb_rx_check() == 1)
                {
                    int result = 0;

                    //Store Recieved data into array
                    for (int x = 0; x < DMS_Value.Length; x++)
                    {                        
                        //Rxdata = message recieved from robot
                        DMS_Value[x] = zigbee.zgb_rx_data();
                        //Adding up all numbers in array 
                        result = result + DMS_Value[x];
                        if (x == DMS_Value.Length - 1)
                        {
                            //Average the sum 
                            average =  (result / DMS_Value.Length);
                            calculate.setValue(average);
                            //Invoke main thread to change textbox
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                pBarDistance.Value = average;
                                txtTestBox.Text = average.ToString();
                                textBox1.Text = calculate.getValue().ToString();
                                
                            }
                         );
                                                     
                      }
                       
                    }
                }                
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (GetDataThread.IsAlive)
            {
                GetDataThread.Abort();
            }
            
            //Close Connection
            connect.CloseConnection();
            btnConnect.Enabled = true;

            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            motion.rightTurn();
        }

      private void btnDanceMode_Click(object sender, EventArgs e)
        {
            GpBox.Visible = true;

        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            motion.BackWard();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            motion.stop();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            motion.leftTurn();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            motion.Forward();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //To prevent error when user close application and thread still running 
            if (GetDataThread.IsAlive)
            {
                GetDataThread.Abort();
            }
            
        }

        private void btnMoveNextWin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radAutomatic.Checked = true;
            textBox1.Enabled = false;
            txtTestBox.Enabled = false;
            btnBackward.Enabled = false;
            btnForward.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnStop.Enabled = false;
            btnDanceMode.Enabled = false;
            
            
        }

        private void radManual_CheckedChanged(object sender, EventArgs e)
        {
           
            textBox1.Enabled = true;
            txtTestBox.Enabled = true;
            btnBackward.Enabled = true;
            btnForward.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
            btnStop.Enabled = true;
            btnDanceMode.Enabled = true;
        }

        private void radAutomatic_CheckedChanged(object sender, EventArgs e)
        {
           
            textBox1.Enabled = false;
            txtTestBox.Enabled = false;
            btnBackward.Enabled = false;
            btnForward.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnStop.Enabled = false;
            btnDanceMode.Enabled = false;
        }

        private void radAutomatic_Click(object sender, EventArgs e)
        {
            motion.Automatic();
        }

        private void radManual_Click(object sender, EventArgs e)
        {
            motion.Manual();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            motion.Manual();
        }
    }

    public interface LinkToRobot
    {
        int OpenDevice();
        void CloseConnection();
    }
    public class Connection:LinkToRobot
    {
        public int Port_Number = 3;
        public int OpenDevice()
        {
            // Verify if it is connected
            if (zigbee.zgb_initialize(Port_Number) == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void CloseConnection()
        {

            zigbee.zgb_terminate();
            
        }
    }

    public class CalculateDMS
    {
        int num; 
      
        public void setValue(int x)
        {
            num = x;
        }
         public int getValue()
        {

            return num;
        }        
    }

    public class MotionIndex:send
    {
        public void stop()
        {
            sendMotion(0);
        }
        public void rightTurn()
        { 
            sendMotion(12);
        }

        public void leftTurn()
        {
            sendMotion(13);
        }

        public void Forward()
        {
           
            sendMotion(21);
        }

        public void BackWard()
        {
            sendMotion(5);
        }

        public void Automatic()
        {
            sendMotion(68);

        }

        public void Manual()
        {
            sendMotion(67);
        }
    }

    public class Dance : MotionIndex
    {
        public void Freestyle()
        {
            sendMotion(4);
        }

    }

    public class send
    {
        public void sendMotion(int i)
        {
            for (int x = 0; x < 10; x++)
            {
                if (zigbee.zgb_tx_data(i) == 0)
                {
                    MessageBox.Show("Failed to transimit");
                }
            }

        }


    }

  


}