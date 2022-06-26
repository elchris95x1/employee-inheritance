namespace _3343_LaraC_Lab02
{
    partial class Main
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
            this.productionWorkerButton = new System.Windows.Forms.Button();
            this.shiftSupervisorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productionWorkerButton
            // 
            this.productionWorkerButton.Location = new System.Drawing.Point(12, 39);
            this.productionWorkerButton.Name = "productionWorkerButton";
            this.productionWorkerButton.Size = new System.Drawing.Size(120, 75);
            this.productionWorkerButton.TabIndex = 0;
            this.productionWorkerButton.Text = "&Production Worker";
            this.productionWorkerButton.UseVisualStyleBackColor = true;
            this.productionWorkerButton.Click += new System.EventHandler(this.productionWorkerButton_Click);
            // 
            // shiftSupervisorButton
            // 
            this.shiftSupervisorButton.Location = new System.Drawing.Point(219, 39);
            this.shiftSupervisorButton.Name = "shiftSupervisorButton";
            this.shiftSupervisorButton.Size = new System.Drawing.Size(120, 75);
            this.shiftSupervisorButton.TabIndex = 1;
            this.shiftSupervisorButton.Text = "&Shift Supervisor";
            this.shiftSupervisorButton.UseVisualStyleBackColor = true;
            this.shiftSupervisorButton.Click += new System.EventHandler(this.shiftSupervisorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 151);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 186);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.shiftSupervisorButton);
            this.Controls.Add(this.productionWorkerButton);
            this.Name = "Main";
            this.Text = "Employee Section";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button productionWorkerButton;
        private System.Windows.Forms.Button shiftSupervisorButton;
        private System.Windows.Forms.Button exitButton;
    }
}

