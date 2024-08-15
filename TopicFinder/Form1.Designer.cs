namespace TopicFinder
{
    partial class TopicFinderMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.topicIntro = new System.Windows.Forms.Label();
            this.topicText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(130, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Topic!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topicIntro
            // 
            this.topicIntro.AutoSize = true;
            this.topicIntro.Location = new System.Drawing.Point(13, 13);
            this.topicIntro.Name = "topicIntro";
            this.topicIntro.Size = new System.Drawing.Size(161, 13);
            this.topicIntro.TabIndex = 1;
            this.topicIntro.Text = "Please press the \"Topic\" button.";
            // 
            // topicText
            // 
            this.topicText.AutoSize = true;
            this.topicText.Location = new System.Drawing.Point(13, 35);
            this.topicText.Name = "topicText";
            this.topicText.Size = new System.Drawing.Size(0, 13);
            this.topicText.TabIndex = 2;
            // 
            // TopicFinderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 126);
            this.Controls.Add(this.topicText);
            this.Controls.Add(this.topicIntro);
            this.Controls.Add(this.button1);
            this.Name = "TopicFinderMain";
            this.Text = "Topic Finder!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label topicIntro;
        private System.Windows.Forms.Label topicText;
    }
}

