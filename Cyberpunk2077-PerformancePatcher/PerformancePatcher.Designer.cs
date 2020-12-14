
namespace Cyberpunk2077_PerformancePatcher
{
    partial class PerformancePatcherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformancePatcherForm));
            this.AMDpatchButton = new System.Windows.Forms.Button();
            this.browseTextbox = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.contactText = new System.Windows.Forms.Label();
            this.openSourcedText = new System.Windows.Forms.Label();
            this.AMDPatcherText = new System.Windows.Forms.Label();
            this.AMDGroupBox = new System.Windows.Forms.GroupBox();
            this.IntelAVXPatcherGroupBox = new System.Windows.Forms.GroupBox();
            this.IntelAVXPatcherText = new System.Windows.Forms.Label();
            this.IntelPatchButton = new System.Windows.Forms.Button();
            this.MemoryPoolPatcherGroupBox = new System.Windows.Forms.GroupBox();
            this.MemoryPoolPatcherText = new System.Windows.Forms.Label();
            this.MemoryPoolPatcherButton = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.AMDGroupBox.SuspendLayout();
            this.IntelAVXPatcherGroupBox.SuspendLayout();
            this.MemoryPoolPatcherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AMDpatchButton
            // 
            this.AMDpatchButton.Location = new System.Drawing.Point(6, 46);
            this.AMDpatchButton.Name = "AMDpatchButton";
            this.AMDpatchButton.Size = new System.Drawing.Size(370, 23);
            this.AMDpatchButton.TabIndex = 1;
            this.AMDpatchButton.Text = "Patch Game with AMD Patcher";
            this.AMDpatchButton.UseVisualStyleBackColor = true;
            this.AMDpatchButton.Click += new System.EventHandler(this.AMDpatchButton_Click);
            // 
            // browseTextbox
            // 
            this.browseTextbox.Location = new System.Drawing.Point(15, 25);
            this.browseTextbox.Name = "browseTextbox";
            this.browseTextbox.ReadOnly = true;
            this.browseTextbox.Size = new System.Drawing.Size(226, 20);
            this.browseTextbox.TabIndex = 1;
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(26, 9);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(360, 14);
            this.infoText.TabIndex = 2;
            this.infoText.Text = "Welcome to the Cyberpunk 2077 Performance Patcher";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // browseButton
            // 
            this.browseButton.AutoSize = true;
            this.browseButton.Location = new System.Drawing.Point(247, 23);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(150, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse Cyberpunk2077.exe";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(26, 78);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(360, 17);
            this.contactText.TabIndex = 4;
            this.contactText.Text = "This Patcher was developed by @dynamyc010 and @HiItsDevin_";
            this.contactText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openSourcedText
            // 
            this.openSourcedText.Location = new System.Drawing.Point(26, 49);
            this.openSourcedText.Name = "openSourcedText";
            this.openSourcedText.Size = new System.Drawing.Size(360, 29);
            this.openSourcedText.TabIndex = 4;
            this.openSourcedText.Text = "The code for this project is free and open sourced over at https://git.hiitsdevin" +
    ".dev/HiItsDevin_/Cyberpunk2077-AMDPatcher";
            this.openSourcedText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AMDPatcherText
            // 
            this.AMDPatcherText.Location = new System.Drawing.Point(6, 16);
            this.AMDPatcherText.Name = "AMDPatcherText";
            this.AMDPatcherText.Size = new System.Drawing.Size(370, 27);
            this.AMDPatcherText.TabIndex = 4;
            this.AMDPatcherText.Text = "Disables the Intel C++ Compiler for Cyberpunk 2077, allowing the game to run a bi" +
    "t better on AMD systems.";
            this.AMDPatcherText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AMDGroupBox
            // 
            this.AMDGroupBox.Controls.Add(this.AMDPatcherText);
            this.AMDGroupBox.Controls.Add(this.AMDpatchButton);
            this.AMDGroupBox.Location = new System.Drawing.Point(15, 117);
            this.AMDGroupBox.Name = "AMDGroupBox";
            this.AMDGroupBox.Size = new System.Drawing.Size(382, 76);
            this.AMDGroupBox.TabIndex = 5;
            this.AMDGroupBox.TabStop = false;
            this.AMDGroupBox.Text = "AMD Patcher";
            // 
            // IntelAVXPatcherGroupBox
            // 
            this.IntelAVXPatcherGroupBox.Controls.Add(this.IntelAVXPatcherText);
            this.IntelAVXPatcherGroupBox.Controls.Add(this.IntelPatchButton);
            this.IntelAVXPatcherGroupBox.Location = new System.Drawing.Point(15, 199);
            this.IntelAVXPatcherGroupBox.Name = "IntelAVXPatcherGroupBox";
            this.IntelAVXPatcherGroupBox.Size = new System.Drawing.Size(382, 90);
            this.IntelAVXPatcherGroupBox.TabIndex = 5;
            this.IntelAVXPatcherGroupBox.TabStop = false;
            this.IntelAVXPatcherGroupBox.Text = "Intel AVX Patcher";
            // 
            // IntelAVXPatcherText
            // 
            this.IntelAVXPatcherText.Location = new System.Drawing.Point(6, 16);
            this.IntelAVXPatcherText.Name = "IntelAVXPatcherText";
            this.IntelAVXPatcherText.Size = new System.Drawing.Size(370, 40);
            this.IntelAVXPatcherText.TabIndex = 4;
            this.IntelAVXPatcherText.Text = "Disables the Intel AVX Check, allowing people who don\'t have proper support for A" +
    "VX, or have an older Intel CPU without AVX support, to be able to play without t" +
    "he need of AVX.";
            this.IntelAVXPatcherText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IntelPatchButton
            // 
            this.IntelPatchButton.Location = new System.Drawing.Point(6, 59);
            this.IntelPatchButton.Name = "IntelPatchButton";
            this.IntelPatchButton.Size = new System.Drawing.Size(370, 23);
            this.IntelPatchButton.TabIndex = 2;
            this.IntelPatchButton.Text = "Patch Game with Intel AVX Patcher";
            this.IntelPatchButton.UseVisualStyleBackColor = true;
            this.IntelPatchButton.Click += new System.EventHandler(this.IntelPatchButton_Click);
            // 
            // MemoryPoolPatcherGroupBox
            // 
            this.MemoryPoolPatcherGroupBox.Controls.Add(this.MemoryPoolPatcherText);
            this.MemoryPoolPatcherGroupBox.Controls.Add(this.MemoryPoolPatcherButton);
            this.MemoryPoolPatcherGroupBox.Location = new System.Drawing.Point(15, 295);
            this.MemoryPoolPatcherGroupBox.Name = "MemoryPoolPatcherGroupBox";
            this.MemoryPoolPatcherGroupBox.Size = new System.Drawing.Size(382, 104);
            this.MemoryPoolPatcherGroupBox.TabIndex = 5;
            this.MemoryPoolPatcherGroupBox.TabStop = false;
            this.MemoryPoolPatcherGroupBox.Text = "Memory Pool Patcher";
            // 
            // MemoryPoolPatcherText
            // 
            this.MemoryPoolPatcherText.Location = new System.Drawing.Point(6, 16);
            this.MemoryPoolPatcherText.Name = "MemoryPoolPatcherText";
            this.MemoryPoolPatcherText.Size = new System.Drawing.Size(370, 56);
            this.MemoryPoolPatcherText.TabIndex = 4;
            this.MemoryPoolPatcherText.Text = resources.GetString("MemoryPoolPatcherText.Text");
            this.MemoryPoolPatcherText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MemoryPoolPatcherButton
            // 
            this.MemoryPoolPatcherButton.Enabled = false;
            this.MemoryPoolPatcherButton.Location = new System.Drawing.Point(6, 75);
            this.MemoryPoolPatcherButton.Name = "MemoryPoolPatcherButton";
            this.MemoryPoolPatcherButton.Size = new System.Drawing.Size(370, 23);
            this.MemoryPoolPatcherButton.TabIndex = 3;
            this.MemoryPoolPatcherButton.Text = "(Coming Soon) Patch Game with Memory Pool Patcher";
            this.MemoryPoolPatcherButton.UseVisualStyleBackColor = true;
            this.MemoryPoolPatcherButton.Click += new System.EventHandler(this.IntelPatchButton_Click);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Location = new System.Drawing.Point(142, 101);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusMessage.Size = new System.Drawing.Size(123, 13);
            this.statusMessage.TabIndex = 6;
            this.statusMessage.Text = "Generic Status Message";
            this.statusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformancePatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.MemoryPoolPatcherGroupBox);
            this.Controls.Add(this.IntelAVXPatcherGroupBox);
            this.Controls.Add(this.AMDGroupBox);
            this.Controls.Add(this.contactText);
            this.Controls.Add(this.openSourcedText);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.browseTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 450);
            this.MinimumSize = new System.Drawing.Size(425, 450);
            this.Name = "PerformancePatcherForm";
            this.Text = "Cyberpunk 2077 Performance Patcher";
            this.AMDGroupBox.ResumeLayout(false);
            this.IntelAVXPatcherGroupBox.ResumeLayout(false);
            this.MemoryPoolPatcherGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AMDpatchButton;
        private System.Windows.Forms.TextBox browseTextbox;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label contactText;
        private System.Windows.Forms.Label openSourcedText;
        private System.Windows.Forms.Label AMDPatcherText;
        private System.Windows.Forms.GroupBox AMDGroupBox;
        private System.Windows.Forms.GroupBox IntelAVXPatcherGroupBox;
        private System.Windows.Forms.Label IntelAVXPatcherText;
        private System.Windows.Forms.Button IntelPatchButton;
        private System.Windows.Forms.GroupBox MemoryPoolPatcherGroupBox;
        private System.Windows.Forms.Label MemoryPoolPatcherText;
        private System.Windows.Forms.Button MemoryPoolPatcherButton;
        private System.Windows.Forms.Label statusMessage;
    }
}

