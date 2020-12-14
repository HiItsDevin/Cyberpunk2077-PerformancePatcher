
namespace Cyberpunk2077_PerformancePatcher
{
    partial class MemoryPoolSelector
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
            this.PoolCPUTackBar = new System.Windows.Forms.TrackBar();
            this.PoolGPUTrackBar = new System.Windows.Forms.TrackBar();
            this.PoolCPUText = new System.Windows.Forms.Label();
            this.PoolGPUText = new System.Windows.Forms.Label();
            this.MemoryPoolPatchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PoolCPUTackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoolGPUTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PoolCPUTackBar
            // 
            this.PoolCPUTackBar.Location = new System.Drawing.Point(12, 55);
            this.PoolCPUTackBar.Name = "PoolCPUTackBar";
            this.PoolCPUTackBar.Size = new System.Drawing.Size(180, 45);
            this.PoolCPUTackBar.TabIndex = 0;
            this.PoolCPUTackBar.Value = 5;
            // 
            // PoolGPUTrackBar
            // 
            this.PoolGPUTrackBar.Location = new System.Drawing.Point(192, 55);
            this.PoolGPUTrackBar.Name = "PoolGPUTrackBar";
            this.PoolGPUTrackBar.Size = new System.Drawing.Size(180, 45);
            this.PoolGPUTrackBar.TabIndex = 0;
            this.PoolGPUTrackBar.Value = 10;
            // 
            // PoolCPUText
            // 
            this.PoolCPUText.Location = new System.Drawing.Point(9, 9);
            this.PoolCPUText.Name = "PoolCPUText";
            this.PoolCPUText.Size = new System.Drawing.Size(183, 43);
            this.PoolCPUText.TabIndex = 1;
            this.PoolCPUText.Text = "Set your PoolCPU Here (Recommended at least half of your System RAM, 50%)";
            this.PoolCPUText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PoolGPUText
            // 
            this.PoolGPUText.Location = new System.Drawing.Point(189, 9);
            this.PoolGPUText.Name = "PoolGPUText";
            this.PoolGPUText.Size = new System.Drawing.Size(183, 43);
            this.PoolGPUText.TabIndex = 1;
            this.PoolGPUText.Text = "Set your PoolGPU Here (Recommended ALL of your VRAM, 100%)";
            this.PoolGPUText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MemoryPoolPatchButton
            // 
            this.MemoryPoolPatchButton.Location = new System.Drawing.Point(12, 106);
            this.MemoryPoolPatchButton.Name = "MemoryPoolPatchButton";
            this.MemoryPoolPatchButton.Size = new System.Drawing.Size(360, 23);
            this.MemoryPoolPatchButton.TabIndex = 2;
            this.MemoryPoolPatchButton.Text = "Patch";
            this.MemoryPoolPatchButton.UseVisualStyleBackColor = true;
            this.MemoryPoolPatchButton.Click += new System.EventHandler(this.MemoryPoolPatchButton_Click);
            // 
            // MemoryPoolSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.MemoryPoolPatchButton);
            this.Controls.Add(this.PoolGPUText);
            this.Controls.Add(this.PoolCPUText);
            this.Controls.Add(this.PoolGPUTrackBar);
            this.Controls.Add(this.PoolCPUTackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MemoryPoolSelector";
            this.Text = "Set to your preference";
            ((System.ComponentModel.ISupportInitialize)(this.PoolCPUTackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoolGPUTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar PoolCPUTackBar;
        private System.Windows.Forms.TrackBar PoolGPUTrackBar;
        private System.Windows.Forms.Label PoolCPUText;
        private System.Windows.Forms.Label PoolGPUText;
        private System.Windows.Forms.Button MemoryPoolPatchButton;
    }
}