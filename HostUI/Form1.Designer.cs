namespace HostUI
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
            this.hostControlBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hostControlBtn
            // 
            this.hostControlBtn.Location = new System.Drawing.Point(45, 93);
            this.hostControlBtn.Name = "hostControlBtn";
            this.hostControlBtn.Size = new System.Drawing.Size(110, 58);
            this.hostControlBtn.TabIndex = 0;
            this.hostControlBtn.Text = "Start";
            this.hostControlBtn.UseVisualStyleBackColor = true;
            this.hostControlBtn.Click += new System.EventHandler(this.hostControlBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(41, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(142, 20);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Host is not running";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 237);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.hostControlBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hostControlBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}

