
namespace ChatLogAnalyzer
{
    partial class ChatReader
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
            this.btnLoadJSON = new System.Windows.Forms.Button();
            this.txtBxURL = new System.Windows.Forms.TextBox();
            this.lblUrlBar = new System.Windows.Forms.Label();
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.numTimesOver = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfTimes = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnAnalyzeVoD = new System.Windows.Forms.Button();
            this.lblAnalyzed = new System.Windows.Forms.Label();
            this.lblTotalMessages = new System.Windows.Forms.Label();
            this.lblLengthOfVoD = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadJSON
            // 
            this.btnLoadJSON.Location = new System.Drawing.Point(12, 100);
            this.btnLoadJSON.Name = "btnLoadJSON";
            this.btnLoadJSON.Size = new System.Drawing.Size(75, 23);
            this.btnLoadJSON.TabIndex = 0;
            this.btnLoadJSON.Text = "Load VoD";
            this.btnLoadJSON.UseVisualStyleBackColor = true;
            this.btnLoadJSON.Click += new System.EventHandler(this.btnLoadJSON_Click);
            // 
            // txtBxURL
            // 
            this.txtBxURL.Location = new System.Drawing.Point(12, 27);
            this.txtBxURL.Name = "txtBxURL";
            this.txtBxURL.Size = new System.Drawing.Size(546, 23);
            this.txtBxURL.TabIndex = 1;
            // 
            // lblUrlBar
            // 
            this.lblUrlBar.AutoSize = true;
            this.lblUrlBar.Location = new System.Drawing.Point(12, 9);
            this.lblUrlBar.Name = "lblUrlBar";
            this.lblUrlBar.Size = new System.Drawing.Size(240, 15);
            this.lblUrlBar.TabIndex = 2;
            this.lblUrlBar.Text = "Enter the id of the VoD to be checked below:";
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(12, 129);
            this.txtBxOutput.Multiline = true;
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxOutput.Size = new System.Drawing.Size(546, 353);
            this.txtBxOutput.TabIndex = 3;
            this.txtBxOutput.Visible = false;
            // 
            // numTimesOver
            // 
            this.numTimesOver.Location = new System.Drawing.Point(12, 71);
            this.numTimesOver.Name = "numTimesOver";
            this.numTimesOver.Size = new System.Drawing.Size(120, 23);
            this.numTimesOver.TabIndex = 5;
            this.numTimesOver.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblNumberOfTimes
            // 
            this.lblNumberOfTimes.AutoSize = true;
            this.lblNumberOfTimes.Location = new System.Drawing.Point(12, 53);
            this.lblNumberOfTimes.Name = "lblNumberOfTimes";
            this.lblNumberOfTimes.Size = new System.Drawing.Size(478, 15);
            this.lblNumberOfTimes.TabIndex = 7;
            this.lblNumberOfTimes.Text = "How many times over the average number of chats, by the no of secs below (of the " +
    "VoD)?";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 129);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(87, 15);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Invalid video id";
            this.lblError.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(12, 129);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(50, 15);
            this.lblLoading.TabIndex = 9;
            this.lblLoading.Text = "Loading";
            this.lblLoading.Visible = false;
            // 
            // btnAnalyzeVoD
            // 
            this.btnAnalyzeVoD.Enabled = false;
            this.btnAnalyzeVoD.Location = new System.Drawing.Point(93, 100);
            this.btnAnalyzeVoD.Name = "btnAnalyzeVoD";
            this.btnAnalyzeVoD.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyzeVoD.TabIndex = 10;
            this.btnAnalyzeVoD.Text = "Analyze VoD";
            this.btnAnalyzeVoD.UseVisualStyleBackColor = true;
            this.btnAnalyzeVoD.Click += new System.EventHandler(this.btnAnalyzeVoD_Click);
            // 
            // lblAnalyzed
            // 
            this.lblAnalyzed.AutoSize = true;
            this.lblAnalyzed.Location = new System.Drawing.Point(175, 104);
            this.lblAnalyzed.Name = "lblAnalyzed";
            this.lblAnalyzed.Size = new System.Drawing.Size(77, 15);
            this.lblAnalyzed.TabIndex = 11;
            this.lblAnalyzed.Text = "VoD analyzed";
            this.lblAnalyzed.Visible = false;
            // 
            // lblTotalMessages
            // 
            this.lblTotalMessages.AutoSize = true;
            this.lblTotalMessages.Location = new System.Drawing.Point(260, 104);
            this.lblTotalMessages.Name = "lblTotalMessages";
            this.lblTotalMessages.Size = new System.Drawing.Size(94, 15);
            this.lblTotalMessages.TabIndex = 12;
            this.lblTotalMessages.Text = "x total messages";
            this.lblTotalMessages.Visible = false;
            // 
            // lblLengthOfVoD
            // 
            this.lblLengthOfVoD.AutoSize = true;
            this.lblLengthOfVoD.Location = new System.Drawing.Point(416, 104);
            this.lblLengthOfVoD.Name = "lblLengthOfVoD";
            this.lblLengthOfVoD.Size = new System.Drawing.Size(86, 15);
            this.lblLengthOfVoD.TabIndex = 13;
            this.lblLengthOfVoD.Text = "x seconds long";
            this.lblLengthOfVoD.Visible = false;
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(153, 71);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(38, 23);
            this.numSeconds.TabIndex = 14;
            this.numSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSeconds.Visible = false;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(197, 73);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(190, 15);
            this.lblSeconds.TabIndex = 15;
            this.lblSeconds.Text = "Number of seconds between chats";
            this.lblSeconds.Visible = false;
            // 
            // ChatReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 494);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.numSeconds);
            this.Controls.Add(this.lblLengthOfVoD);
            this.Controls.Add(this.lblTotalMessages);
            this.Controls.Add(this.lblAnalyzed);
            this.Controls.Add(this.btnAnalyzeVoD);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblNumberOfTimes);
            this.Controls.Add(this.numTimesOver);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.lblUrlBar);
            this.Controls.Add(this.txtBxURL);
            this.Controls.Add(this.btnLoadJSON);
            this.Name = "ChatReader";
            this.Text = "Chat Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.numTimesOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadJSON;
        private System.Windows.Forms.TextBox txtBxURL;
        private System.Windows.Forms.Label lblUrlBar;
        private System.Windows.Forms.TextBox txtBxOutput;
        private System.Windows.Forms.NumericUpDown numTimesOver;
        private System.Windows.Forms.Label lblNumberOfTimes;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnAnalyzeVoD;
        private System.Windows.Forms.Label lblAnalyzed;
        private System.Windows.Forms.Label lblTotalMessages;
        private System.Windows.Forms.Label lblLengthOfVoD;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Label lblSeconds;
    }
}

