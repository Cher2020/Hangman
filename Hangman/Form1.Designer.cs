using System;

namespace Hangman
{
    partial class FrmHangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </Summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(Disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmda = new System.Windows.Forms.Button();
            this.cmdb = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // hangImage1
            // 
            this.hangImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hangImage.ErrorImage = null;
            this.hangImage.Image = global::Hangman.Properties.Resources.Hang1;
            this.hangImage.Location = new System.Drawing.Point(224, 34);
            this.hangImage.Name = "hangImage1";
            this.hangImage.Size = new System.Drawing.Size(173, 112);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            // 
            // cmda
            // 
            this.cmda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmda.Location = new System.Drawing.Point(94, 177);
            this.cmda.Name = "cmda";
            this.cmda.Size = new System.Drawing.Size(42, 39);
            this.cmda.TabIndex = 1;
            this.cmda.Text = "a";
            this.cmda.UseVisualStyleBackColor = true;
            this.cmda.Click += new System.EventHandler(this.GuessClick);
            // 
            // cmdb
            // 
            this.cmdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdb.Location = new System.Drawing.Point(142, 177);
            this.cmdb.Name = "cmdb";
            this.cmdb.Size = new System.Drawing.Size(42, 39);
            this.cmdb.TabIndex = 2;
            this.cmdb.Text = "b";
            this.cmdb.UseVisualStyleBackColor = true;
            this.cmdb.Click += new System.EventHandler(this.GuessClick);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(608, 84);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(145, 62);
            this.lblResult.TabIndex = 27;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblShowWord
            // 
            this.lblShowWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWord.Location = new System.Drawing.Point(238, 341);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(298, 66);
            this.lblShowWord.TabIndex = 28;
            this.lblShowWord.Text = "Show Word";
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowWord.Click += new System.EventHandler(this.lblShowWord_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "c";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GuessClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(334, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 39);
            this.button2.TabIndex = 32;
            this.button2.Text = "f";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GuessClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(286, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 39);
            this.button3.TabIndex = 31;
            this.button3.Text = "e";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GuessClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(238, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 39);
            this.button4.TabIndex = 30;
            this.button4.Text = "d";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GuessClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(478, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 39);
            this.button5.TabIndex = 35;
            this.button5.Text = "i";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GuessClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(430, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 39);
            this.button6.TabIndex = 34;
            this.button6.Text = "h";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GuessClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(382, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 39);
            this.button7.TabIndex = 33;
            this.button7.Text = "g";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.GuessClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(190, 222);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 39);
            this.button8.TabIndex = 38;
            this.button8.Text = "l";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.GuessClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(142, 222);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 39);
            this.button9.TabIndex = 37;
            this.button9.Text = "k";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.GuessClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(94, 222);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 39);
            this.button10.TabIndex = 36;
            this.button10.Text = "j";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.GuessClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(334, 222);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 39);
            this.button11.TabIndex = 41;
            this.button11.Text = "o";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.GuessClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(286, 222);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 39);
            this.button12.TabIndex = 40;
            this.button12.Text = "n";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.GuessClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(238, 222);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 39);
            this.button13.TabIndex = 39;
            this.button13.Text = "m";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.GuessClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(478, 222);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 39);
            this.button14.TabIndex = 44;
            this.button14.Text = "r";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.GuessClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(430, 222);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(42, 39);
            this.button15.TabIndex = 43;
            this.button15.Text = "q";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.GuessClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(382, 222);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(42, 39);
            this.button16.TabIndex = 42;
            this.button16.Text = "p";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.GuessClick);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(190, 267);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 39);
            this.button17.TabIndex = 47;
            this.button17.Text = "u";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.GuessClick);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(142, 267);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(42, 39);
            this.button18.TabIndex = 46;
            this.button18.Text = "t";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.GuessClick);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(94, 267);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(42, 39);
            this.button19.TabIndex = 45;
            this.button19.Text = "s";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.GuessClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(334, 267);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(42, 39);
            this.button20.TabIndex = 50;
            this.button20.Text = "x";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.GuessClick);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(286, 267);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(42, 39);
            this.button21.TabIndex = 49;
            this.button21.Text = "w";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.GuessClick);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(238, 267);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(42, 39);
            this.button22.TabIndex = 48;
            this.button22.Text = "v";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.GuessClick);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(430, 267);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(42, 39);
            this.button24.TabIndex = 52;
            this.button24.Text = "z";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.GuessClick);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(382, 267);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(42, 39);
            this.button25.TabIndex = 51;
            this.button25.Text = "y";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.GuessClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 64);
            this.label1.TabIndex = 53;
            this.label1.Text = "Restart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Restart_Click);
            // 
            // FrmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmdb);
            this.Controls.Add(this.cmda);
            this.Controls.Add(this.hangImage);
            this.Name = "FrmHangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);

        }

        private void lblShowWord_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Restart_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmda;
        private System.Windows.Forms.Button cmdb;
        
        private System.Windows.Forms.Label lblResult;
        private EventHandler FrmHangman_Load;

        public FrmHangman(EventHandler frmHangman_Load)
        {
            FrmHangman_Load = frmHangman_Load;
        }

        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label label1;
    }
}

