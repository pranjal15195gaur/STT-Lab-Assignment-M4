namespace STT_Lab12_FormApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label title;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(0, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(450, 35);
            this.title.Text = "GUI Alarm";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblPrompt
            // 
            this.lblPrompt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrompt.Location = new System.Drawing.Point(30, 60);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(110, 32);
            this.lblPrompt.Text = "Pick Time:";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.Location = new System.Drawing.Point(150, 60);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(180, 32);
            this.txtTime.TabIndex = 0;
            this.txtTime.PlaceholderText = "HH:mm:ss";

            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(125, 110); // temp location, will be centered in Load event
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Set Alarm";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(25, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 25);
            this.lblStatus.Text = "";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 220);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "GUI Alarm";
            this.Load += new System.EventHandler(this.Form1_Load); // << hook the load event
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
