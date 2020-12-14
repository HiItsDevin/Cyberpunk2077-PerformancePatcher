using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;


namespace Cyberpunk2077_PerformancePatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OpenFileDialog openFileDialog1;

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Cyberpunk 2077 executable|Cyberpunk2077.exe",
                Title = "Select your Cyberpunk2077.exe"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    browseTextbox.Text = filePath;
                    AMDpatchButton.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void AMDpatchButton_Click(object sender, EventArgs e)
        {
            if (browseTextbox.Text != "")
            {
                AMDpatchButton.Enabled = false;
                try
                {
                    PatchFile(openFileDialog1.FileName, openFileDialog1.FileName, AMDPatchFind, AMDPatchReplace);
                }
                catch (Exception ex)
                {
                    if (File.Exists($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\Cyberpunk2077.exe.unpatched"))
                    {
                        File.Delete($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\Cyberpunk2077.exe.unpatched");
                        if (File.Exists($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\cyber.tmp"))
                        {
                            File.Copy($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\cyber.tmp", $@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\Cyberpunk2077.exe.unpatched");
                            File.Delete($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\cyber.tmp");
                        }
                    }
                    MessageBox.Show($"We were not able to patch your game with AMD Patcher. \nAny changes have been discarded.\n\nError message: {ex.Message}");

                }
            }
            else
            {
                MessageBox.Show("Please select your Cyberpunk2077.exe first!");
            }
        }
        private void IntelPatchButton_Click(object sender, EventArgs e)
        {
            if (browseTextbox.Text != "")
            {
                IntelPatchButton.Enabled = false;
                try
                {
                    PatchFile(openFileDialog1.FileName, openFileDialog1.FileName, IntelPatchFind, IntelPatchReplace);
                }
                catch (Exception ex)
                {
                    if (File.Exists($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\Cyberpunk2077.exe.unpatched"))
                    {
                        File.Delete($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\Cyberpunk2077.exe.unpatched");
                        if (File.Exists($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\cyber.tmp"))
                        {
                            File.Copy($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\cyber.tmp", $@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\Cyberpunk2077.exe.unpatched");
                            File.Delete($@"{System.IO.Path.GetDirectoryName(openFileDialog1.FileName)}\cyber.tmp");
                        }
                    }
                    MessageBox.Show($"We were not able to patch your game with AMD Patcher. \nAny changes have been discarded.\n\nError message: {ex.Message}");

                }
            }
            else
            {
                MessageBox.Show("Please select your Cyberpunk2077.exe first!");
            }
        }


        // AMD Patcher Hex
        private static readonly byte[] AMDPatchFind = { 0x75, 0x30, 0x33, 0xC9, 0xB8, 0x01, 0x00, 0x00, 0x00, 0x0F, 0xA2, 0x8B, 0xC8, 0xC1, 0xF9, 0x08 };
        private static readonly byte[] AMDPatchReplace = { 0xEB, 0x30, 0x33, 0xC9, 0xB8, 0x01, 0x00, 0x00, 0x00, 0x0F, 0xA2, 0x8B, 0xC8, 0xC1, 0xF9, 0x08 };

        // Intel AVX Patcher Hex
        private static readonly byte[] IntelPatchFind = { 0x55, 0x48, 0x81, 0xEC, 0xA0, 0x00, 0x00, 0x00, 0x0F, 0x29, 0x70, 0xE8 };
        private static readonly byte[] IntelPatchReplace = { 0xC3, 0x48, 0x81, 0xEC, 0xA0, 0x00, 0x00, 0x00, 0x0F, 0x29, 0x70, 0xE8 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool DetectPatch(byte[] sequence, int position, byte[] PatchFind)
        {
            if (position + PatchFind.Length > sequence.Length) return false;
            for (int p = 0; p < PatchFind.Length; p++)
            {
                if (PatchFind[p] != sequence[position + p]) return false;
            }
            return true;
        }

        private static void PatchFile(string originalFile, string patchedFile, byte[] PatchFind, byte[] PatchReplace)
        {
            // Ensure target directory exists.
            var targetDirectory = Path.GetDirectoryName(patchedFile);
            if (targetDirectory == null) return;
            Directory.CreateDirectory(targetDirectory);

            // Read file bytes.
            byte[] fileContent = File.ReadAllBytes(originalFile);

            // Detect and patch file.
            bool foundPatch = false;
            for (int p = 0; p < fileContent.Length; p++)
            {
                if (!DetectPatch(fileContent, p, PatchFind)) continue;
                foundPatch = true;
                for (int w = 0; w < PatchFind.Length; w++)
                {
                    fileContent[p + w] = PatchReplace[w];
                }
            }

            // Save it to another location.
            if (!foundPatch)
            {
                MessageBox.Show("We couldn't patch your game. Perhaps you already ran the patcher?\n\nDouble check your path, and try again.");
                return;
            }
            File.WriteAllBytes(patchedFile, fileContent);
            MessageBox.Show("We patched your game! Enjoy c:");
        }
    }
}
