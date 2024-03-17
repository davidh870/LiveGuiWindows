using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO.Ports;

namespace LiveGuiWindows
{


    public partial class LiveGui : Form
    {
        public delegate void d1(string indata); // Create a delegate (bridge) to transfer data from serial thread to gui thread
        public static string photoValA0 = "0";
        public static string photoValA1 = "0";

        public static int timerCounter = 0; // A timer to slow down data

        public LiveGui()
        {
            InitializeComponent();

            // Opens and initializes arduino serial port at COM6
            //arduinoSerialPort.Open();

            // Scan Ports
            string[] ports = SerialPort.GetPortNames();

            portsListView.View = View.List;

            //  Display each port name in list view
            foreach (string port in ports)
            {
                portsListView.Items.Add(port);
            }

            photoResChartA0.Series["PhotoResistor"].Points.Clear();
            photoResChartA1.Series["PhotoResistor"].Points.Clear();


           

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        // Event Action when data is being received from Arduino
        private void arduinoSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (arduinoSerialPort.IsOpen)
            {
                string indata = arduinoSerialPort.ReadLine(); // Read data from serial ardiuno 

                if (timerCounter != 10)
                {
                    timerCounter++;
                }
                else
                {
                    timerCounter = 0;

                    // Create the delegate when data received and invoke the function Write2Gui passing the indata from arduino as the parameter
                    d1 writeit = new d1(Write2Gui);

                    // If form is created then invoke and start thread of updating gui
                    if (IsHandleCreated)
                    {
                        BeginInvoke(writeit, indata);
                    }
                }
            }
            
           
        }

        // This function handles data sent from the Arduino
        public void Write2Gui(string indata) 
        {
       
            //Console.WriteLine(indata.Substring(0, 2));
            string dataType= indata.Substring(0,2);

            switch(dataType) 
            {   
                // If P0 is received then it is a photoresistor value from A0
                case "P0":
                    
                    if (photoResChartA0.Series["PhotoResistor"].Points.Count == 1000)
                    {
                        photoResChartA0.Series["PhotoResistor"].Points.Clear();
                    }
                    else
                    {
                        //photoVal = Convert.ToString(indata).Substring(1); // Convert Data to Int
                        photoValA0 = indata.Substring(3);
                        photoResChartA0.Series["PhotoResistor"].Points.AddY(photoValA0);
                        photoResValA0Textbox.Text = photoValA0;

                    }

                    break;
                // If P0 is received then it is a photoresistor value from A0
                case "P1":

                    if (photoResChartA1.Series["PhotoResistor"].Points.Count == 1000)
                    {
                        photoResChartA1.Series["PhotoResistor"].Points.Clear();
                    }
                    else
                    {
                        //photoVal = Convert.ToString(indata).Substring(1); // Convert Data to Int
                        photoValA1 = indata.Substring(3);
                        photoResChartA1.Series["PhotoResistor"].Points.AddY(photoValA1);
                        photoResValA1Textbox.Text = photoValA1;

                    }

                    break;
            }
        }

        private void LiveGui_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void portsListView_DoubleClick(object sender, EventArgs e)
        {
            arduinoSerialPort.PortName = portsListView.SelectedItems[0].ToString().Substring(15, 4);
            arduinoSerialPort.Open();
        }
    }
    
}
