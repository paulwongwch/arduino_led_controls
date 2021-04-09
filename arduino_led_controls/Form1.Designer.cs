
namespace arduino_led_controls
{
    partial class Form1
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
            this.groupBox_serialPort = new System.Windows.Forms.GroupBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_serialPort = new System.Windows.Forms.ComboBox();
            this.groupBox_ledControl = new System.Windows.Forms.GroupBox();
            this.checkBox_led3 = new System.Windows.Forms.CheckBox();
            this.checkBox_led2 = new System.Windows.Forms.CheckBox();
            this.checkBox_led1 = new System.Windows.Forms.CheckBox();
            this.groupBox_serialPort.SuspendLayout();
            this.groupBox_ledControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_serialPort
            // 
            this.groupBox_serialPort.Controls.Add(this.button_connect);
            this.groupBox_serialPort.Controls.Add(this.comboBox_serialPort);
            this.groupBox_serialPort.Location = new System.Drawing.Point(28, 135);
            this.groupBox_serialPort.Name = "groupBox_serialPort";
            this.groupBox_serialPort.Size = new System.Drawing.Size(329, 127);
            this.groupBox_serialPort.TabIndex = 0;
            this.groupBox_serialPort.TabStop = false;
            this.groupBox_serialPort.Text = "Serial Connection";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(15, 75);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(300, 35);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.clicked_button_connect);
            // 
            // comboBox_serialPort
            // 
            this.comboBox_serialPort.FormattingEnabled = true;
            this.comboBox_serialPort.Location = new System.Drawing.Point(16, 33);
            this.comboBox_serialPort.Name = "comboBox_serialPort";
            this.comboBox_serialPort.Size = new System.Drawing.Size(295, 26);
            this.comboBox_serialPort.TabIndex = 0;
            // 
            // groupBox_ledControl
            // 
            this.groupBox_ledControl.Controls.Add(this.checkBox_led3);
            this.groupBox_ledControl.Controls.Add(this.checkBox_led2);
            this.groupBox_ledControl.Controls.Add(this.checkBox_led1);
            this.groupBox_ledControl.Location = new System.Drawing.Point(28, 26);
            this.groupBox_ledControl.Name = "groupBox_ledControl";
            this.groupBox_ledControl.Size = new System.Drawing.Size(329, 85);
            this.groupBox_ledControl.TabIndex = 1;
            this.groupBox_ledControl.TabStop = false;
            this.groupBox_ledControl.Text = "LED Control";
            // 
            // checkBox_led3
            // 
            this.checkBox_led3.AutoSize = true;
            this.checkBox_led3.Location = new System.Drawing.Point(232, 38);
            this.checkBox_led3.Name = "checkBox_led3";
            this.checkBox_led3.Size = new System.Drawing.Size(79, 22);
            this.checkBox_led3.TabIndex = 2;
            this.checkBox_led3.Text = "LED 3";
            this.checkBox_led3.UseVisualStyleBackColor = true;
            this.checkBox_led3.CheckedChanged += new System.EventHandler(this.changed_led3);
            // 
            // checkBox_led2
            // 
            this.checkBox_led2.AutoSize = true;
            this.checkBox_led2.Location = new System.Drawing.Point(122, 38);
            this.checkBox_led2.Name = "checkBox_led2";
            this.checkBox_led2.Size = new System.Drawing.Size(79, 22);
            this.checkBox_led2.TabIndex = 1;
            this.checkBox_led2.Text = "LED 2";
            this.checkBox_led2.UseVisualStyleBackColor = true;
            this.checkBox_led2.CheckedChanged += new System.EventHandler(this.changed_led2);
            // 
            // checkBox_led1
            // 
            this.checkBox_led1.AutoSize = true;
            this.checkBox_led1.Location = new System.Drawing.Point(16, 38);
            this.checkBox_led1.Name = "checkBox_led1";
            this.checkBox_led1.Size = new System.Drawing.Size(79, 22);
            this.checkBox_led1.TabIndex = 0;
            this.checkBox_led1.Text = "LED 1";
            this.checkBox_led1.UseVisualStyleBackColor = true;
            this.checkBox_led1.CheckedChanged += new System.EventHandler(this.changed_led1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 292);
            this.Controls.Add(this.groupBox_ledControl);
            this.Controls.Add(this.groupBox_serialPort);
            this.Name = "Form1";
            this.Text = "LED Controls";
            this.groupBox_serialPort.ResumeLayout(false);
            this.groupBox_ledControl.ResumeLayout(false);
            this.groupBox_ledControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_serialPort;
        private System.Windows.Forms.ComboBox comboBox_serialPort;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox_ledControl;
        private System.Windows.Forms.CheckBox checkBox_led3;
        private System.Windows.Forms.CheckBox checkBox_led2;
        private System.Windows.Forms.CheckBox checkBox_led1;
    }
}

