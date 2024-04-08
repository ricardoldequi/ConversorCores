namespace ConversorCores
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
            this.label1 = new System.Windows.Forms.Label();
            this.btRGBtoHSV = new System.Windows.Forms.Button();
            this.lbR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btRGBtoCMYK = new System.Windows.Forms.Button();
            this.btRGBtoGrayScale = new System.Windows.Forms.Button();
            this.btRGBtoNORMALIZE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txResultadoRGB = new System.Windows.Forms.TextBox();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownShine = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMatriz = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txResultadoHSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HSVtoRGB = new System.Windows.Forms.Button();
            this.CMYKtoRGB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txResultadoCMYK = new System.Windows.Forms.TextBox();
            this.numericUpDownYellow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMagenta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCyan = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownBlack = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira os valores a serem convertidos";
            // 
            // btRGBtoHSV
            // 
            this.btRGBtoHSV.Location = new System.Drawing.Point(247, 61);
            this.btRGBtoHSV.Name = "btRGBtoHSV";
            this.btRGBtoHSV.Size = new System.Drawing.Size(151, 23);
            this.btRGBtoHSV.TabIndex = 3;
            this.btRGBtoHSV.Text = "RGB >> HSV";
            this.btRGBtoHSV.UseVisualStyleBackColor = true;
            this.btRGBtoHSV.Click += new System.EventHandler(this.btRGBtoHSV_Click);
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Location = new System.Drawing.Point(31, 73);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(57, 13);
            this.lbR.TabIndex = 6;
            this.lbR.Text = "Valor de R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor de G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor de B";
            // 
            // btRGBtoCMYK
            // 
            this.btRGBtoCMYK.Location = new System.Drawing.Point(247, 89);
            this.btRGBtoCMYK.Name = "btRGBtoCMYK";
            this.btRGBtoCMYK.Size = new System.Drawing.Size(151, 23);
            this.btRGBtoCMYK.TabIndex = 9;
            this.btRGBtoCMYK.Text = "RGB >> CMYK";
            this.btRGBtoCMYK.UseVisualStyleBackColor = true;
            this.btRGBtoCMYK.Click += new System.EventHandler(this.btRGBtoCMYK_Click);
            // 
            // btRGBtoGrayScale
            // 
            this.btRGBtoGrayScale.Location = new System.Drawing.Point(247, 118);
            this.btRGBtoGrayScale.Name = "btRGBtoGrayScale";
            this.btRGBtoGrayScale.Size = new System.Drawing.Size(151, 23);
            this.btRGBtoGrayScale.TabIndex = 10;
            this.btRGBtoGrayScale.Text = "RGB >> Escala de Cinza";
            this.btRGBtoGrayScale.UseVisualStyleBackColor = true;
            this.btRGBtoGrayScale.Click += new System.EventHandler(this.btRGBtoGrayScale_Click);
            // 
            // btRGBtoNORMALIZE
            // 
            this.btRGBtoNORMALIZE.Location = new System.Drawing.Point(247, 147);
            this.btRGBtoNORMALIZE.Name = "btRGBtoNORMALIZE";
            this.btRGBtoNORMALIZE.Size = new System.Drawing.Size(151, 23);
            this.btRGBtoNORMALIZE.TabIndex = 11;
            this.btRGBtoNORMALIZE.Text = "RGB Normalizado";
            this.btRGBtoNORMALIZE.UseVisualStyleBackColor = true;
            this.btRGBtoNORMALIZE.Click += new System.EventHandler(this.btRGBtoNORMALIZE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // txResultadoRGB
            // 
            this.txResultadoRGB.Enabled = false;
            this.txResultadoRGB.Location = new System.Drawing.Point(504, 63);
            this.txResultadoRGB.Multiline = true;
            this.txResultadoRGB.Name = "txResultadoRGB";
            this.txResultadoRGB.Size = new System.Drawing.Size(117, 100);
            this.txResultadoRGB.TabIndex = 13;
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(111, 71);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownRed.TabIndex = 14;
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(111, 100);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownGreen.TabIndex = 15;
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(111, 130);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownBlue.TabIndex = 16;
            // 
            // numericUpDownShine
            // 
            this.numericUpDownShine.Location = new System.Drawing.Point(111, 330);
            this.numericUpDownShine.Name = "numericUpDownShine";
            this.numericUpDownShine.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownShine.TabIndex = 22;
            // 
            // numericUpDownSaturation
            // 
            this.numericUpDownSaturation.Location = new System.Drawing.Point(111, 300);
            this.numericUpDownSaturation.Name = "numericUpDownSaturation";
            this.numericUpDownSaturation.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownSaturation.TabIndex = 21;
            // 
            // numericUpDownMatriz
            // 
            this.numericUpDownMatriz.Location = new System.Drawing.Point(111, 271);
            this.numericUpDownMatriz.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownMatriz.Name = "numericUpDownMatriz";
            this.numericUpDownMatriz.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMatriz.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valor de V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor de S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor de H";
            // 
            // txResultadoHSV
            // 
            this.txResultadoHSV.Enabled = false;
            this.txResultadoHSV.Location = new System.Drawing.Point(504, 250);
            this.txResultadoHSV.Multiline = true;
            this.txResultadoHSV.Name = "txResultadoHSV";
            this.txResultadoHSV.Size = new System.Drawing.Size(117, 100);
            this.txResultadoHSV.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "=";
            // 
            // HSVtoRGB
            // 
            this.HSVtoRGB.Location = new System.Drawing.Point(247, 302);
            this.HSVtoRGB.Name = "HSVtoRGB";
            this.HSVtoRGB.Size = new System.Drawing.Size(151, 23);
            this.HSVtoRGB.TabIndex = 25;
            this.HSVtoRGB.Text = "HSV >> RGB";
            this.HSVtoRGB.UseVisualStyleBackColor = true;
            this.HSVtoRGB.Click += new System.EventHandler(this.HSVtoRGB_Click);
            // 
            // CMYKtoRGB
            // 
            this.CMYKtoRGB.Location = new System.Drawing.Point(247, 490);
            this.CMYKtoRGB.Name = "CMYKtoRGB";
            this.CMYKtoRGB.Size = new System.Drawing.Size(151, 23);
            this.CMYKtoRGB.TabIndex = 34;
            this.CMYKtoRGB.Text = "CMYK >> RGB";
            this.CMYKtoRGB.UseVisualStyleBackColor = true;
            this.CMYKtoRGB.Click += new System.EventHandler(this.CMYKtoRGB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "=";
            // 
            // txResultadoCMYK
            // 
            this.txResultadoCMYK.Enabled = false;
            this.txResultadoCMYK.Location = new System.Drawing.Point(504, 449);
            this.txResultadoCMYK.Multiline = true;
            this.txResultadoCMYK.Name = "txResultadoCMYK";
            this.txResultadoCMYK.Size = new System.Drawing.Size(117, 100);
            this.txResultadoCMYK.TabIndex = 32;
            // 
            // numericUpDownYellow
            // 
            this.numericUpDownYellow.Location = new System.Drawing.Point(111, 509);
            this.numericUpDownYellow.Name = "numericUpDownYellow";
            this.numericUpDownYellow.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownYellow.TabIndex = 31;
            // 
            // numericUpDownMagenta
            // 
            this.numericUpDownMagenta.Location = new System.Drawing.Point(111, 479);
            this.numericUpDownMagenta.Name = "numericUpDownMagenta";
            this.numericUpDownMagenta.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMagenta.TabIndex = 30;
            // 
            // numericUpDownCyan
            // 
            this.numericUpDownCyan.Location = new System.Drawing.Point(111, 450);
            this.numericUpDownCyan.Name = "numericUpDownCyan";
            this.numericUpDownCyan.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownCyan.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Valor de Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Valor de M";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Valor de C";
            // 
            // numericUpDownBlack
            // 
            this.numericUpDownBlack.Location = new System.Drawing.Point(111, 535);
            this.numericUpDownBlack.Name = "numericUpDownBlack";
            this.numericUpDownBlack.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownBlack.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Valor de K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.numericUpDownBlack);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CMYKtoRGB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txResultadoCMYK);
            this.Controls.Add(this.numericUpDownYellow);
            this.Controls.Add(this.numericUpDownMagenta);
            this.Controls.Add(this.numericUpDownCyan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HSVtoRGB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txResultadoHSV);
            this.Controls.Add(this.numericUpDownShine);
            this.Controls.Add(this.numericUpDownSaturation);
            this.Controls.Add(this.numericUpDownMatriz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.txResultadoRGB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRGBtoNORMALIZE);
            this.Controls.Add(this.btRGBtoGrayScale);
            this.Controls.Add(this.btRGBtoCMYK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbR);
            this.Controls.Add(this.btRGBtoHSV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMagenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRGBtoHSV;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRGBtoCMYK;
        private System.Windows.Forms.Button btRGBtoGrayScale;
        private System.Windows.Forms.Button btRGBtoNORMALIZE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txResultadoRGB;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownShine;
        private System.Windows.Forms.NumericUpDown numericUpDownSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownMatriz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txResultadoHSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button HSVtoRGB;
        private System.Windows.Forms.Button CMYKtoRGB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txResultadoCMYK;
        private System.Windows.Forms.NumericUpDown numericUpDownYellow;
        private System.Windows.Forms.NumericUpDown numericUpDownMagenta;
        private System.Windows.Forms.NumericUpDown numericUpDownCyan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownBlack;
        private System.Windows.Forms.Label label13;
    }
}

