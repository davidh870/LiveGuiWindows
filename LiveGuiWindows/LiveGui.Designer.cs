namespace LiveGuiWindows
{
    partial class LiveGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.arduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.photoresistorvaluetextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arduinoSerialPort
            // 
            this.arduinoSerialPort.PortName = "COM3";
            this.arduinoSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoSerialPort_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(75, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Photoresistor value: ";
            // 
            // photoresistorvaluetextbox
            // 
            this.photoresistorvaluetextbox.Location = new System.Drawing.Point(181, 79);
            this.photoresistorvaluetextbox.Name = "photoresistorvaluetextbox";
            this.photoresistorvaluetextbox.Size = new System.Drawing.Size(100, 20);
            this.photoresistorvaluetextbox.TabIndex = 1;
            this.photoresistorvaluetextbox.TextChanged += new System.EventHandler(this.photoresistorvaluetextbox_TextChanged);
            // 
            // LiveGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.photoresistorvaluetextbox);
            this.Controls.Add(this.textBox1);
            this.Name = "LiveGui";
            this.Text = "Live Gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduinoSerialPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox photoresistorvaluetextbox;
    }
}

