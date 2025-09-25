namespace espMotorsBT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLed = new Button();
            btnStepForward = new Button();
            btnStepBackward = new Button();
            btnServo0 = new Button();
            btnServo90 = new Button();
            SuspendLayout();
            // 
            // btnLed
            // 
            btnLed.Location = new Point(164, 51);
            btnLed.Name = "btnLed";
            btnLed.Size = new Size(203, 43);
            btnLed.TabIndex = 0;
            btnLed.Text = "Led Butonu";
            btnLed.UseVisualStyleBackColor = true;
            btnLed.Click += btnLed_Click;
            // 
            // btnStepForward
            // 
            btnStepForward.Location = new Point(164, 115);
            btnStepForward.Name = "btnStepForward";
            btnStepForward.Size = new Size(203, 43);
            btnStepForward.TabIndex = 1;
            btnStepForward.Text = "Step Forward";
            btnStepForward.UseVisualStyleBackColor = true;
            btnStepForward.Click += btnStepForward_Click;
            // 
            // btnStepBackward
            // 
            btnStepBackward.Location = new Point(164, 189);
            btnStepBackward.Name = "btnStepBackward";
            btnStepBackward.Size = new Size(203, 43);
            btnStepBackward.TabIndex = 2;
            btnStepBackward.Text = "Step Backward";
            btnStepBackward.UseVisualStyleBackColor = true;
            btnStepBackward.Click += btnStepBackward_Click;
            // 
            // btnServo0
            // 
            btnServo0.Location = new Point(164, 259);
            btnServo0.Name = "btnServo0";
            btnServo0.Size = new Size(203, 43);
            btnServo0.TabIndex = 3;
            btnServo0.Text = "Servo 0";
            btnServo0.UseVisualStyleBackColor = true;
            btnServo0.Click += btnServo0_Click;
            // 
            // btnServo90
            // 
            btnServo90.Location = new Point(164, 341);
            btnServo90.Name = "btnServo90";
            btnServo90.Size = new Size(203, 43);
            btnServo90.TabIndex = 4;
            btnServo90.Text = "Servo 90";
            btnServo90.UseVisualStyleBackColor = true;
            btnServo90.Click += btnServo90_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnServo90);
            Controls.Add(btnServo0);
            Controls.Add(btnStepBackward);
            Controls.Add(btnStepForward);
            Controls.Add(btnLed);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLed;
        private Button btnStepForward;
        private Button btnStepBackward;
        private Button btnServo0;
        private Button btnServo90;
    }
}
