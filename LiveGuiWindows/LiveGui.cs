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
        public LiveGui()
        {
            InitializeComponent();

            // Opens and initializes arduino serial port at COM6
            arduinoSerialPort.Open(); 
        }
    }
}
