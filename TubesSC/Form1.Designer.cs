namespace TubesSC
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.filenameTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.hiddenTxt = new System.Windows.Forms.TextBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.layersTxt = new System.Windows.Forms.TextBox();
            this.MSETxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.iterationLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.recognizeBtn = new System.Windows.Forms.Button();
            this.previewPB = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lowestValueLbl = new System.Windows.Forms.Label();
            this.highestValueLbl = new System.Windows.Forms.Label();
            this.LowestMatchedPB = new System.Windows.Forms.PictureBox();
            this.HighestMatchedPB = new System.Windows.Forms.PictureBox();
            this.openTestImageBtn = new System.Windows.Forms.Button();
            this.testImageTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowestMatchedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighestMatchedPB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filenameTxt
            // 
            this.filenameTxt.Location = new System.Drawing.Point(98, 39);
            this.filenameTxt.Name = "filenameTxt";
            this.filenameTxt.Size = new System.Drawing.Size(223, 20);
            this.filenameTxt.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Initialize Training Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(6, 31);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(69, 32);
            this.trainBtn.TabIndex = 3;
            this.trainBtn.Text = "Train";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hidden :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output  :";
            // 
            // inputTxt
            // 
            this.inputTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputTxt.Enabled = false;
            this.inputTxt.Location = new System.Drawing.Point(156, 62);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(62, 20);
            this.inputTxt.TabIndex = 7;
            // 
            // hiddenTxt
            // 
            this.hiddenTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hiddenTxt.Enabled = false;
            this.hiddenTxt.Location = new System.Drawing.Point(156, 85);
            this.hiddenTxt.Name = "hiddenTxt";
            this.hiddenTxt.Size = new System.Drawing.Size(62, 20);
            this.hiddenTxt.TabIndex = 8;
            // 
            // outputTxt
            // 
            this.outputTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.outputTxt.Enabled = false;
            this.outputTxt.Location = new System.Drawing.Point(156, 109);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(62, 20);
            this.outputTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status :";
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(156, 144);
            this.statusTxt.Multiline = true;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(152, 133);
            this.statusTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Layers :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max Error:";
            // 
            // layersTxt
            // 
            this.layersTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.layersTxt.Enabled = false;
            this.layersTxt.Location = new System.Drawing.Point(281, 62);
            this.layersTxt.Name = "layersTxt";
            this.layersTxt.Size = new System.Drawing.Size(40, 20);
            this.layersTxt.TabIndex = 14;
            this.layersTxt.Text = "3";
            // 
            // MSETxt
            // 
            this.MSETxt.Location = new System.Drawing.Point(281, 88);
            this.MSETxt.Name = "MSETxt";
            this.MSETxt.Size = new System.Drawing.Size(40, 20);
            this.MSETxt.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.timerLbl);
            this.panel1.Controls.Add(this.iterationLbl);
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Controls.Add(this.MSETxt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.layersTxt);
            this.panel1.Controls.Add(this.filenameTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.statusTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.outputTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hiddenTxt);
            this.panel1.Controls.Add(this.inputTxt);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 294);
            this.panel1.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 48);
            this.button3.TabIndex = 21;
            this.button3.Text = "PCA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Settings";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Location = new System.Drawing.Point(9, 244);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(49, 13);
            this.timerLbl.TabIndex = 18;
            this.timerLbl.Text = "00:00:00";
            // 
            // iterationLbl
            // 
            this.iterationLbl.AutoSize = true;
            this.iterationLbl.Location = new System.Drawing.Point(9, 206);
            this.iterationLbl.Name = "iterationLbl";
            this.iterationLbl.Size = new System.Drawing.Size(41, 13);
            this.iterationLbl.TabIndex = 17;
            this.iterationLbl.Text = "Epoch:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(11, 171);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(32, 13);
            this.errorLbl.TabIndex = 16;
            this.errorLbl.Text = "Error:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(172, 31);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(71, 32);
            this.stopBtn.TabIndex = 19;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // recognizeBtn
            // 
            this.recognizeBtn.Location = new System.Drawing.Point(249, 31);
            this.recognizeBtn.Name = "recognizeBtn";
            this.recognizeBtn.Size = new System.Drawing.Size(71, 32);
            this.recognizeBtn.TabIndex = 17;
            this.recognizeBtn.Text = "Recognize";
            this.recognizeBtn.UseVisualStyleBackColor = true;
            this.recognizeBtn.Click += new System.EventHandler(this.recognizeBtn_Click);
            // 
            // previewPB
            // 
            this.previewPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPB.Location = new System.Drawing.Point(336, 28);
            this.previewPB.Name = "previewPB";
            this.previewPB.Size = new System.Drawing.Size(245, 240);
            this.previewPB.TabIndex = 18;
            this.previewPB.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Preview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lowestValueLbl);
            this.groupBox1.Controls.Add(this.highestValueLbl);
            this.groupBox1.Controls.Add(this.LowestMatchedPB);
            this.groupBox1.Controls.Add(this.HighestMatchedPB);
            this.groupBox1.Location = new System.Drawing.Point(336, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 101);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lowestValueLbl
            // 
            this.lowestValueLbl.AutoSize = true;
            this.lowestValueLbl.Location = new System.Drawing.Point(145, 16);
            this.lowestValueLbl.Name = "lowestValueLbl";
            this.lowestValueLbl.Size = new System.Drawing.Size(74, 13);
            this.lowestValueLbl.TabIndex = 3;
            this.lowestValueLbl.Text = "Lowest Value:";
            // 
            // highestValueLbl
            // 
            this.highestValueLbl.AutoSize = true;
            this.highestValueLbl.Location = new System.Drawing.Point(11, 16);
            this.highestValueLbl.Name = "highestValueLbl";
            this.highestValueLbl.Size = new System.Drawing.Size(76, 13);
            this.highestValueLbl.TabIndex = 2;
            this.highestValueLbl.Text = "Highest Value:";
            // 
            // LowestMatchedPB
            // 
            this.LowestMatchedPB.Location = new System.Drawing.Point(170, 32);
            this.LowestMatchedPB.Name = "LowestMatchedPB";
            this.LowestMatchedPB.Size = new System.Drawing.Size(55, 63);
            this.LowestMatchedPB.TabIndex = 1;
            this.LowestMatchedPB.TabStop = false;
            // 
            // HighestMatchedPB
            // 
            this.HighestMatchedPB.Location = new System.Drawing.Point(32, 32);
            this.HighestMatchedPB.Name = "HighestMatchedPB";
            this.HighestMatchedPB.Size = new System.Drawing.Size(55, 63);
            this.HighestMatchedPB.TabIndex = 0;
            this.HighestMatchedPB.TabStop = false;
            // 
            // openTestImageBtn
            // 
            this.openTestImageBtn.Location = new System.Drawing.Point(336, 274);
            this.openTestImageBtn.Name = "openTestImageBtn";
            this.openTestImageBtn.Size = new System.Drawing.Size(75, 23);
            this.openTestImageBtn.TabIndex = 23;
            this.openTestImageBtn.Text = "Test Image";
            this.openTestImageBtn.UseVisualStyleBackColor = true;
            this.openTestImageBtn.Click += new System.EventHandler(this.openTestImageBtn_Click);
            // 
            // testImageTxt
            // 
            this.testImageTxt.Location = new System.Drawing.Point(418, 276);
            this.testImageTxt.Name = "testImageTxt";
            this.testImageTxt.Size = new System.Drawing.Size(163, 20);
            this.testImageTxt.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.trainBtn);
            this.groupBox2.Controls.Add(this.stopBtn);
            this.groupBox2.Controls.Add(this.recognizeBtn);
            this.groupBox2.Location = new System.Drawing.Point(4, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 32);
            this.button4.TabIndex = 20;
            this.button4.Text = "Validate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(245, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Biner";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.testImageTxt);
            this.Controls.Add(this.openTestImageBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.previewPB);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Character Recognition Using Back Propagation ANN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowestMatchedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighestMatchedPB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filenameTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.TextBox hiddenTxt;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox layersTxt;
        private System.Windows.Forms.TextBox MSETxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label iterationLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button recognizeBtn;
        private System.Windows.Forms.PictureBox previewPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lowestValueLbl;
        private System.Windows.Forms.Label highestValueLbl;
        private System.Windows.Forms.PictureBox LowestMatchedPB;
        private System.Windows.Forms.PictureBox HighestMatchedPB;
        private System.Windows.Forms.Button openTestImageBtn;
        private System.Windows.Forms.TextBox testImageTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

