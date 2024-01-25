namespace HIL_Interface
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.targetAddressTextBox = new System.Windows.Forms.TextBox();
            this.targetPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.YellowGreen;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.connectButton.Location = new System.Drawing.Point(562, 398);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(79, 34);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Bağlan";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Red;
            this.disconnectButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.disconnectButton.Location = new System.Drawing.Point(658, 398);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(130, 34);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Bağlantıyı Kes";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 8F);
            this.label1.Location = new System.Drawing.Point(220, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hedef IP Adres:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // targetAddressTextBox
            // 
            this.targetAddressTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.targetAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.targetAddressTextBox.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetAddressTextBox.Location = new System.Drawing.Point(358, 408);
            this.targetAddressTextBox.Name = "targetAddressTextBox";
            this.targetAddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.targetAddressTextBox.Size = new System.Drawing.Size(105, 27);
            this.targetAddressTextBox.TabIndex = 2;
            this.targetAddressTextBox.Text = "10.10.10.15";
            this.targetAddressTextBox.TextChanged += new System.EventHandler(this.targetAddressTextBox_TextChanged);
            // 
            // targetPortTextBox
            // 
            this.targetPortTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.targetPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.targetPortTextBox.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetPortTextBox.Location = new System.Drawing.Point(502, 408);
            this.targetPortTextBox.Name = "targetPortTextBox";
            this.targetPortTextBox.Size = new System.Drawing.Size(59, 28);
            this.targetPortTextBox.TabIndex = 2;
            this.targetPortTextBox.Text = "22222";
            this.targetPortTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 64);
            this.button2.TabIndex = 7;
            this.button2.Text = "XPlane Başlat/Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.targetPortTextBox);
            this.Controls.Add(this.targetAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserInterface";
            this.Text = "User Interface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetAddressTextBox;
        private System.Windows.Forms.TextBox targetPortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

