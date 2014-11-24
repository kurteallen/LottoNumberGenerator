namespace LotteryNumbers
{
    public partial class LotteryForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotteryForm));
            this.LotteryResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.encoreBTN = new System.Windows.Forms.Button();
            this.lotteryPicBox = new System.Windows.Forms.PictureBox();
            this.encoreLabel = new System.Windows.Forms.Label();
            this.numberResult = new System.Windows.Forms.Label();
            this.pick4BTN = new System.Windows.Forms.Button();
            this.lotto649BTN = new System.Windows.Forms.Button();
            this.lottarioBTN = new System.Windows.Forms.Button();
            this.lottoMaxBTN = new System.Windows.Forms.Button();
            this.LotteryResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LotteryResultsGroupBox
            // 
            this.LotteryResultsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LotteryResultsGroupBox.Controls.Add(this.encoreBTN);
            this.LotteryResultsGroupBox.Controls.Add(this.lotteryPicBox);
            this.LotteryResultsGroupBox.Controls.Add(this.encoreLabel);
            this.LotteryResultsGroupBox.Controls.Add(this.numberResult);
            this.LotteryResultsGroupBox.Location = new System.Drawing.Point(12, 172);
            this.LotteryResultsGroupBox.Name = "LotteryResultsGroupBox";
            this.LotteryResultsGroupBox.Size = new System.Drawing.Size(260, 138);
            this.LotteryResultsGroupBox.TabIndex = 2;
            this.LotteryResultsGroupBox.TabStop = false;
            this.LotteryResultsGroupBox.Text = "LotteryResults";
            this.LotteryResultsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // encoreBTN
            // 
            this.encoreBTN.Image = global::LotteryNumbers.Properties.Resources.encore51x34;
            this.encoreBTN.Location = new System.Drawing.Point(6, 87);
            this.encoreBTN.Name = "encoreBTN";
            this.encoreBTN.Size = new System.Drawing.Size(51, 34);
            this.encoreBTN.TabIndex = 5;
            this.encoreBTN.UseVisualStyleBackColor = true;
            this.encoreBTN.Visible = false;
            this.encoreBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // lotteryPicBox
            // 
            this.lotteryPicBox.Location = new System.Drawing.Point(6, 38);
            this.lotteryPicBox.Name = "lotteryPicBox";
            this.lotteryPicBox.Size = new System.Drawing.Size(50, 31);
            this.lotteryPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lotteryPicBox.TabIndex = 4;
            this.lotteryPicBox.TabStop = false;
            // 
            // encoreLabel
            // 
            this.encoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encoreLabel.AutoSize = true;
            this.encoreLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoreLabel.Location = new System.Drawing.Point(64, 101);
            this.encoreLabel.Name = "encoreLabel";
            this.encoreLabel.Size = new System.Drawing.Size(0, 17);
            this.encoreLabel.TabIndex = 2;
            this.encoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberResult
            // 
            this.numberResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberResult.AutoSize = true;
            this.numberResult.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberResult.Location = new System.Drawing.Point(64, 44);
            this.numberResult.Name = "numberResult";
            this.numberResult.Size = new System.Drawing.Size(8, 17);
            this.numberResult.TabIndex = 0;
            this.numberResult.Text = "\r\n";
            this.numberResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // pick4BTN
            // 
            this.pick4BTN.BackColor = System.Drawing.SystemColors.Control;
            this.pick4BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick4BTN.Image = ((System.Drawing.Image)(resources.GetObject("pick4BTN.Image")));
            this.pick4BTN.Location = new System.Drawing.Point(147, 92);
            this.pick4BTN.Name = "pick4BTN";
            this.pick4BTN.Size = new System.Drawing.Size(125, 74);
            this.pick4BTN.TabIndex = 5;
            this.pick4BTN.UseVisualStyleBackColor = false;
            this.pick4BTN.Click += new System.EventHandler(this.pick4BTN_Click);
            // 
            // lotto649BTN
            // 
            this.lotto649BTN.BackColor = System.Drawing.SystemColors.Control;
            this.lotto649BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotto649BTN.Image = ((System.Drawing.Image)(resources.GetObject("lotto649BTN.Image")));
            this.lotto649BTN.Location = new System.Drawing.Point(147, 12);
            this.lotto649BTN.Name = "lotto649BTN";
            this.lotto649BTN.Size = new System.Drawing.Size(125, 74);
            this.lotto649BTN.TabIndex = 4;
            this.lotto649BTN.UseVisualStyleBackColor = false;
            this.lotto649BTN.Click += new System.EventHandler(this.lotto649BTN_Click);
            // 
            // lottarioBTN
            // 
            this.lottarioBTN.BackColor = System.Drawing.SystemColors.Control;
            this.lottarioBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottarioBTN.Image = ((System.Drawing.Image)(resources.GetObject("lottarioBTN.Image")));
            this.lottarioBTN.Location = new System.Drawing.Point(12, 92);
            this.lottarioBTN.Name = "lottarioBTN";
            this.lottarioBTN.Size = new System.Drawing.Size(125, 74);
            this.lottarioBTN.TabIndex = 3;
            this.lottarioBTN.UseVisualStyleBackColor = false;
            this.lottarioBTN.Click += new System.EventHandler(this.lottarioBTN_Click);
            // 
            // lottoMaxBTN
            // 
            this.lottoMaxBTN.BackColor = System.Drawing.SystemColors.Control;
            this.lottoMaxBTN.BackgroundImage = global::LotteryNumbers.Properties.Resources.lottoMax_117x68;
            this.lottoMaxBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoMaxBTN.Location = new System.Drawing.Point(12, 12);
            this.lottoMaxBTN.Name = "lottoMaxBTN";
            this.lottoMaxBTN.Size = new System.Drawing.Size(125, 74);
            this.lottoMaxBTN.TabIndex = 1;
            this.lottoMaxBTN.UseVisualStyleBackColor = false;
            this.lottoMaxBTN.Click += new System.EventHandler(this.lottoMaxBTN_Click);
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.pick4BTN);
            this.Controls.Add(this.lotto649BTN);
            this.Controls.Add(this.lottarioBTN);
            this.Controls.Add(this.LotteryResultsGroupBox);
            this.Controls.Add(this.lottoMaxBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LotteryForm";
            this.Text = "Random Lottery Generator";
            this.LotteryResultsGroupBox.ResumeLayout(false);
            this.LotteryResultsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lottoMaxBTN;
        private System.Windows.Forms.GroupBox LotteryResultsGroupBox;
        private System.Windows.Forms.Label numberResult;
        private System.Windows.Forms.Button lottarioBTN;
        private System.Windows.Forms.Label encoreLabel;
        private System.Windows.Forms.Button lotto649BTN;
        private System.Windows.Forms.Button pick4BTN;
        private System.Windows.Forms.PictureBox lotteryPicBox;
        private System.Windows.Forms.Button encoreBTN;

    }
}

