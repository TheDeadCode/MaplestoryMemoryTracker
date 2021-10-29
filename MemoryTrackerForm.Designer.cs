
namespace MaplestoryMemoryTracker
{
    partial class MemoryTrackerForm
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
            this.MemoryStatusLabel = new System.Windows.Forms.Label();
            this.ForceForegroundCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MemoryStatusLabel
            // 
            this.MemoryStatusLabel.AutoSize = true;
            this.MemoryStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryStatusLabel.Location = new System.Drawing.Point(5, 8);
            this.MemoryStatusLabel.Name = "MemoryStatusLabel";
            this.MemoryStatusLabel.Size = new System.Drawing.Size(201, 25);
            this.MemoryStatusLabel.TabIndex = 1;
            this.MemoryStatusLabel.Text = "Game not running...";
            // 
            // ForceForegroundCheckbox
            // 
            this.ForceForegroundCheckbox.AutoSize = true;
            this.ForceForegroundCheckbox.Location = new System.Drawing.Point(218, 32);
            this.ForceForegroundCheckbox.Name = "ForceForegroundCheckbox";
            this.ForceForegroundCheckbox.Size = new System.Drawing.Size(84, 17);
            this.ForceForegroundCheckbox.TabIndex = 2;
            this.ForceForegroundCheckbox.Text = "Stay on Top";
            this.ForceForegroundCheckbox.UseVisualStyleBackColor = true;
            this.ForceForegroundCheckbox.CheckStateChanged += new System.EventHandler(this.OnForegroundCheckboxChanged);
            // 
            // MemoryTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 53);
            this.Controls.Add(this.ForceForegroundCheckbox);
            this.Controls.Add(this.MemoryStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MemoryTrackerForm";
            this.Text = "Maplestory Memory Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MemoryStatusLabel;
        private System.Windows.Forms.CheckBox ForceForegroundCheckbox;
    }
}

