using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveGuiWindows
{


    public partial class LiveGui : Form
    {
        public delegate void d1(string indata); // Create a delegate (bridge) to transfer data from serial thread to gui thread
        private static int photoVal;
            
        public LiveGui()
        {
            InitializeComponent();

            // Opens and initializes arduino serial port at COM6
            arduinoSerialPort.Open(); 
        }


        private void photoresistorvaluetextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void arduinoSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = arduinoSerialPort.ReadLine(); // Read data from serial ardiuno 

            // Create the delegate when data received and invoke the function Write2Gui passing the indata from arduino as the parameter
            d1 writeit = new d1(Write2Gui);

            // If form is created then invoke and start thread of updating gui
            if (IsHandleCreated)
            {
                BeginInvoke(writeit, indata);
            }
            
        }

        // This function handles data sent from the Arduino
        public void Write2Gui(string indata) 
        {
            char firstchar;

            firstchar = indata[0];

            switch(firstchar) 
            {   
                // If P is received is first char then it is a photoresistor value
                case 'P':
                    photoresistorvaluetextbox.Text = Convert.ToString(indata).Substring(1);
                    break;
            }
        }
        
    }
    
}
