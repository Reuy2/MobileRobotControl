namespace _5sem_Lab1UDP
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
            ResBox = new ListBox();
            TransBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            startServerBut = new Button();
            serverPort = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ipBox = new TextBox();
            consoleBox = new TextBox();
            label5 = new Label();
            clientPort = new NumericUpDown();
            panel1 = new Panel();
            closeServerBut = new Button();
            sendBut = new Button();
            bump = new TextBox();
            label6 = new Label();
            label7 = new Label();
            lEnc = new TextBox();
            label8 = new Label();
            rEnc = new TextBox();
            label9 = new Label();
            d0 = new TextBox();
            label10 = new Label();
            d1 = new TextBox();
            label11 = new Label();
            d2 = new TextBox();
            label12 = new Label();
            d3 = new TextBox();
            label13 = new Label();
            d7 = new TextBox();
            label14 = new Label();
            d6 = new TextBox();
            label15 = new Label();
            d5 = new TextBox();
            label16 = new Label();
            d4 = new TextBox();
            panel2 = new Panel();
            fNum = new NumericUpDown();
            bNum = new NumericUpDown();
            label17 = new Label();
            label18 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            autoWallCheck = new CheckBox();
            autoModeCheck = new CheckBox();
            panel4 = new Panel();
            label19 = new Label();
            panel6 = new Panel();
            label21 = new Label();
            checkBox1 = new CheckBox();
            panel7 = new Panel();
            label22 = new Label();
            autoModeLine = new CheckBox();
            pictureBox1 = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            ((System.ComponentModel.ISupportInitialize)serverPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientPort).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNum).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ResBox
            // 
            ResBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ResBox.FormattingEnabled = true;
            ResBox.ItemHeight = 20;
            ResBox.Location = new Point(13, 40);
            ResBox.Name = "ResBox";
            ResBox.ScrollAlwaysVisible = true;
            ResBox.Size = new Size(424, 124);
            ResBox.TabIndex = 0;
            // 
            // TransBox
            // 
            TransBox.FormattingEnabled = true;
            TransBox.ItemHeight = 20;
            TransBox.Location = new Point(442, 40);
            TransBox.Name = "TransBox";
            TransBox.ScrollAlwaysVisible = true;
            TransBox.Size = new Size(445, 124);
            TransBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Прием";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 17);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Передача";
            // 
            // startServerBut
            // 
            startServerBut.Location = new Point(128, 28);
            startServerBut.Name = "startServerBut";
            startServerBut.Size = new Size(44, 29);
            startServerBut.TabIndex = 4;
            startServerBut.Text = "вкл";
            startServerBut.UseVisualStyleBackColor = true;
            startServerBut.Click += startServerBut_Click;
            // 
            // serverPort
            // 
            serverPort.Location = new Point(3, 83);
            serverPort.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            serverPort.Name = "serverPort";
            serverPort.Size = new Size(119, 27);
            serverPort.TabIndex = 5;
            serverPort.Value = new decimal(new int[] { 7777, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Порт сервера";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 8;
            label4.Text = "IP";
            // 
            // ipBox
            // 
            ipBox.Location = new Point(3, 30);
            ipBox.Name = "ipBox";
            ipBox.PlaceholderText = "127.0.0.1";
            ipBox.Size = new Size(119, 27);
            ipBox.TabIndex = 9;
            ipBox.Text = "127.0.0.1";
            // 
            // consoleBox
            // 
            consoleBox.Location = new Point(12, 170);
            consoleBox.Multiline = true;
            consoleBox.Name = "consoleBox";
            consoleBox.Size = new Size(246, 138);
            consoleBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 60);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 12;
            label5.Text = "Порт клиента";
            // 
            // clientPort
            // 
            clientPort.Location = new Point(128, 83);
            clientPort.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            clientPort.Name = "clientPort";
            clientPort.Size = new Size(119, 27);
            clientPort.TabIndex = 11;
            clientPort.Value = new decimal(new int[] { 8888, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closeServerBut);
            panel1.Controls.Add(ipBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(startServerBut);
            panel1.Controls.Add(clientPort);
            panel1.Controls.Add(serverPort);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(264, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 138);
            panel1.TabIndex = 13;
            // 
            // closeServerBut
            // 
            closeServerBut.Location = new Point(178, 29);
            closeServerBut.Name = "closeServerBut";
            closeServerBut.Size = new Size(53, 29);
            closeServerBut.TabIndex = 13;
            closeServerBut.Text = "выкл";
            closeServerBut.UseVisualStyleBackColor = true;
            closeServerBut.Click += closeServerBut_Click;
            // 
            // sendBut
            // 
            sendBut.Location = new Point(3, 4);
            sendBut.Name = "sendBut";
            sendBut.Size = new Size(162, 29);
            sendBut.TabIndex = 14;
            sendBut.Text = "Отправить данные";
            sendBut.UseVisualStyleBackColor = true;
            sendBut.Click += sendBut_Click;
            // 
            // bump
            // 
            bump.Location = new Point(91, 85);
            bump.Name = "bump";
            bump.ReadOnly = true;
            bump.Size = new Size(125, 27);
            bump.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 88);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 16;
            label6.Text = "Бампер";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 18);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 18;
            label7.Text = "Л.Енкодер";
            // 
            // lEnc
            // 
            lEnc.Location = new Point(91, 15);
            lEnc.Name = "lEnc";
            lEnc.ReadOnly = true;
            lEnc.Size = new Size(125, 27);
            lEnc.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 51);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 20;
            label8.Text = "П.Енкодер";
            // 
            // rEnc
            // 
            rEnc.Location = new Point(91, 48);
            rEnc.Name = "rEnc";
            rEnc.ReadOnly = true;
            rEnc.Size = new Size(125, 27);
            rEnc.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(228, 18);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 22;
            label9.Text = "Датчик0";
            // 
            // d0
            // 
            d0.Location = new Point(299, 19);
            d0.Name = "d0";
            d0.ReadOnly = true;
            d0.Size = new Size(125, 27);
            d0.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(228, 52);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 24;
            label10.Text = "Датчик1";
            // 
            // d1
            // 
            d1.Location = new Point(299, 52);
            d1.Name = "d1";
            d1.ReadOnly = true;
            d1.Size = new Size(125, 27);
            d1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(228, 85);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 26;
            label11.Text = "Датчик2";
            // 
            // d2
            // 
            d2.Location = new Point(299, 85);
            d2.Name = "d2";
            d2.ReadOnly = true;
            d2.Size = new Size(125, 27);
            d2.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(444, 22);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 28;
            label12.Text = "Датчик3";
            // 
            // d3
            // 
            d3.Location = new Point(515, 19);
            d3.Name = "d3";
            d3.ReadOnly = true;
            d3.Size = new Size(125, 27);
            d3.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(646, 55);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 36;
            label13.Text = "Датчик7";
            // 
            // d7
            // 
            d7.Location = new Point(712, 52);
            d7.Name = "d7";
            d7.ReadOnly = true;
            d7.Size = new Size(125, 27);
            d7.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(646, 22);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 34;
            label14.Text = "Датчик6";
            // 
            // d6
            // 
            d6.Location = new Point(712, 19);
            d6.Name = "d6";
            d6.ReadOnly = true;
            d6.Size = new Size(125, 27);
            d6.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(444, 88);
            label15.Name = "label15";
            label15.Size = new Size(65, 20);
            label15.TabIndex = 32;
            label15.Text = "Датчик5";
            // 
            // d5
            // 
            d5.Location = new Point(515, 85);
            d5.Name = "d5";
            d5.ReadOnly = true;
            d5.Size = new Size(125, 27);
            d5.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(444, 55);
            label16.Name = "label16";
            label16.Size = new Size(65, 20);
            label16.TabIndex = 30;
            label16.Text = "Датчик4";
            // 
            // d4
            // 
            d4.Location = new Point(515, 52);
            d4.Name = "d4";
            d4.ReadOnly = true;
            d4.Size = new Size(125, 27);
            d4.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(d0);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(lEnc);
            panel2.Controls.Add(d7);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(d6);
            panel2.Controls.Add(rEnc);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(bump);
            panel2.Controls.Add(d3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(d5);
            panel2.Controls.Add(d2);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(d1);
            panel2.Controls.Add(d4);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(12, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 117);
            panel2.TabIndex = 37;
            // 
            // fNum
            // 
            fNum.Location = new Point(3, 59);
            fNum.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            fNum.Name = "fNum";
            fNum.Size = new Size(84, 27);
            fNum.TabIndex = 38;
            // 
            // bNum
            // 
            bNum.Location = new Point(93, 59);
            bNum.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            bNum.Name = "bNum";
            bNum.Size = new Size(84, 27);
            bNum.TabIndex = 39;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 36);
            label17.Name = "label17";
            label17.Size = new Size(16, 20);
            label17.TabIndex = 40;
            label17.Text = "F";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(93, 38);
            label18.Name = "label18";
            label18.Size = new Size(18, 20);
            label18.TabIndex = 41;
            label18.Text = "B";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(sendBut);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(fNum);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(bNum);
            panel3.Location = new Point(528, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 94);
            panel3.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(171, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 52;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // autoWallCheck
            // 
            autoWallCheck.AutoSize = true;
            autoWallCheck.Location = new Point(133, 26);
            autoWallCheck.Name = "autoWallCheck";
            autoWallCheck.Size = new Size(144, 24);
            autoWallCheck.TabIndex = 43;
            autoWallCheck.Text = "Режим до стены";
            autoWallCheck.UseVisualStyleBackColor = true;
            autoWallCheck.CheckedChanged += autoModeCheck_CheckedChanged;
            // 
            // autoModeCheck
            // 
            autoModeCheck.AutoSize = true;
            autoModeCheck.Location = new Point(11, 26);
            autoModeCheck.Name = "autoModeCheck";
            autoModeCheck.Size = new Size(116, 24);
            autoModeCheck.TabIndex = 42;
            autoModeCheck.Text = "Авто режим";
            autoModeCheck.UseVisualStyleBackColor = true;
            autoModeCheck.CheckedChanged += autoModeCheck_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label19);
            panel4.Controls.Add(autoWallCheck);
            panel4.Controls.Add(autoModeCheck);
            panel4.Location = new Point(12, 314);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 53);
            panel4.TabIndex = 44;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 3);
            label19.Name = "label19";
            label19.Size = new Size(54, 20);
            label19.TabIndex = 45;
            label19.Text = "1 лаба";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label21);
            panel6.Controls.Add(checkBox1);
            panel6.Location = new Point(312, 314);
            panel6.Name = "panel6";
            panel6.Size = new Size(294, 53);
            panel6.TabIndex = 47;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(11, 3);
            label21.Name = "label21";
            label21.Size = new Size(54, 20);
            label21.TabIndex = 45;
            label21.Text = "2 лаба";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(209, 24);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Авто режим левая стенка";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label22);
            panel7.Controls.Add(autoModeLine);
            panel7.Location = new Point(612, 314);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 53);
            panel7.TabIndex = 47;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(11, 3);
            label22.Name = "label22";
            label22.Size = new Size(54, 20);
            label22.TabIndex = 45;
            label22.Text = "3 лаба";
            // 
            // autoModeLine
            // 
            autoModeLine.AutoSize = true;
            autoModeLine.Location = new Point(11, 26);
            autoModeLine.Name = "autoModeLine";
            autoModeLine.Size = new Size(170, 24);
            autoModeLine.TabIndex = 42;
            autoModeLine.Text = "Авто режим полоса";
            autoModeLine.UseVisualStyleBackColor = true;
            autoModeLine.CheckedChanged += autoModeCheck_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(893, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(528, 267);
            label23.Name = "label23";
            label23.Size = new Size(58, 20);
            label23.TabIndex = 49;
            label23.Text = "label23";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(592, 267);
            label24.Name = "label24";
            label24.Size = new Size(58, 20);
            label24.TabIndex = 50;
            label24.Text = "label24";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(656, 267);
            label25.Name = "label25";
            label25.Size = new Size(58, 20);
            label25.TabIndex = 51;
            label25.Text = "label25";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 519);
            Controls.Add(panel6);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(pictureBox1);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(consoleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TransBox);
            Controls.Add(ResBox);
            Name = "Form1";
            Text = "Волошин Максим";
            ((System.ComponentModel.ISupportInitialize)serverPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientPort).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNum).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ResBox;
        private ListBox TransBox;
        private Label label1;
        private Label label2;
        private Button startServerBut;
        private NumericUpDown serverPort;
        private Label label3;
        private Label label4;
        private TextBox ipBox;
        private TextBox consoleBox;
        private Label label5;
        private NumericUpDown clientPort;
        private Panel panel1;
        private Button sendBut;
        private TextBox bump;
        private Label label6;
        private Label label7;
        private TextBox lEnc;
        private Label label8;
        private TextBox rEnc;
        private Label label9;
        private TextBox d0;
        private Label label10;
        private TextBox d1;
        private Label label11;
        private TextBox d2;
        private Label label12;
        private TextBox d3;
        private Label label13;
        private TextBox d7;
        private Label label14;
        private TextBox d6;
        private Label label15;
        private TextBox d5;
        private Label label16;
        private TextBox d4;
        private Panel panel2;
        private Button closeServerBut;
        private NumericUpDown fNum;
        private NumericUpDown bNum;
        private Label label17;
        private Label label18;
        private Panel panel3;
        private CheckBox autoModeCheck;
        private CheckBox autoWallCheck;
        private Panel panel4;
        private Label label19;
        private Panel panel6;
        private Label label21;
        private CheckBox checkBox1;
        private Panel panel7;
        private Label label22;
        private CheckBox autoModeLine;
        private PictureBox pictureBox1;
        private Label label23;
        private Label label24;
        private Label label25;
        private Button button1;
    }
}