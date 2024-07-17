namespace BarcodeApp
{
    partial class Main
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
            btnSendBC = new Button();
            lb = new ListBox();
            SuspendLayout();
            // 
            // btnSendBC
            // 
            btnSendBC.Location = new Point(12, 490);
            btnSendBC.Name = "btnSendBC";
            btnSendBC.Size = new Size(171, 23);
            btnSendBC.TabIndex = 0;
            btnSendBC.Text = "Send barcode";
            btnSendBC.UseVisualStyleBackColor = true;
            btnSendBC.Click += button1_Click;
            // 
            // lb
            // 
            lb.Enabled = false;
            lb.FormattingEnabled = true;
            lb.ItemHeight = 15;
            lb.Location = new Point(3, 39);
            lb.Name = "lb";
            lb.Size = new Size(192, 439);
            lb.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 525);
            Controls.Add(lb);
            Controls.Add(btnSendBC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = "Barcode";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSendBC;
        private ListBox lb;
    }
}