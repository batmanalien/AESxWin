using AESxWin.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AESxWin
{
    public partial class MainWindow : Form
    {
        private string outputpath;

        public MainWindow()
        {
            InitializeComponent();
            this.SetLogViewer(txtLog);
        }

        public MainWindow(string[] args)
        {
            InitializeComponent();
            this.SetLogViewer(txtLog);

            foreach (var path in args)
            {
                if (File.Exists(path) || Directory.Exists(path))
                    lstPaths.Items.Add(path);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lstExts.SelectedIndex = 6;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Select your File(s)";
                fileDialog.CheckFileExists = true;
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = true;
                fileDialog.SupportMultiDottedExtensions = true;
                fileDialog.InitialDirectory = Application.StartupPath;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var files = fileDialog.FileNames;

                    if (files != null && files.Length > 0)
                    {
                        foreach (var filePath in files)
                        {
                            var items = lstPaths.Items;
                            if (!items.Contains(filePath))
                                lstPaths.Items.Add(filePath);
                            else
                                this.Log(filePath + " is already exist in the list.");
                        }
                    }
                }
            }
        }

        private void btnRemovePath_Click(object sender, EventArgs e)
        {
            var selectedIndex = lstPaths.SelectedIndex;
            if (selectedIndex != -1)
            {
                lstPaths.Items.RemoveAt(selectedIndex);

                lstPaths.SelectedIndex = selectedIndex < lstPaths.Items.Count ? selectedIndex : selectedIndex - 1;
                lstPaths.Focus();
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select A Folder";
                folderDialog.ShowNewFolderButton = true;
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    var folderPath = folderDialog.SelectedPath;
                    if (!String.IsNullOrEmpty(folderPath))
                    {
                        var items = lstPaths.Items;
                        if (!items.Contains(folderPath))
                            lstPaths.Items.Add(folderPath);
                        else
                            this.Log(folderPath + " is already exist in the list.");
                    }
                }
            }
        }

        private async void btnEncrypt_Click(object sender, EventArgs e)
        {
            var count = 0;
            var paths = lstPaths.Items;

            this.Log("Encryption Started.");

            if (paths != null && paths.Count > 0)
            {
                foreach (string path in paths)
                {
                    if (File.Exists(path)) // Is File
                    {
                        if (path.CheckExtension(lstExts.Text.ParseExtensions()))
                        {
                            try
                            {
                                if (chkSelectDest.Checked)
                                    await path.EncryptFileToOutPutPathAsync(txtPassword.Text, outputpath);
                                else
                                    await path.EncryptFileAsync(txtPassword.Text);
                                this.Log(path + " Encrypted.");
                                count++;

                                if (chkDeleteOrg.Checked)
                                    File.Delete(path);
                            }
                            catch (Exception ex)
                            {
                                this.Log(path + " " + ex.Message);
                            }
                        }
                    }
                    if (Directory.Exists(path)) // Is Folder
                    {
                        var followSubDirs = chkSubFolders.Checked ? true : false;

                        var allfiles = path.GetFolderFilesPaths(followSubDirs);

                        foreach (var file in allfiles)
                        {
                            if (file.CheckExtension(lstExts.Text.ParseExtensions()))
                            {
                                if (!file.EndsWith(".aes"))
                                {
                                    try
                                    {
                                        if (chkSelectDest.Checked)
                                            await file.EncryptFileToOutPutPathAsync(txtPassword.Text, outputpath);
                                        else
                                            await file.EncryptFileAsync(txtPassword.Text);
                                        this.Log(file + " Encrypted.");
                                        count++;

                                        if (chkDeleteOrg.Checked)
                                            File.Delete(file);
                                    }
                                    catch (Exception ex)
                                    {
                                        this.Log(file + " " + ex.Message);
                                    }
                                }
                                else
                                {
                                    //  this.Log(file + " Ignored.");
                                }
                            }
                        }
                    }
                }
            }

            this.Log($"Finished : {count} File(s) Encrypted.");
        }

        private async void btnDecrypt_Click(object sender, EventArgs e)
        {
            var count = 0;
            var paths = lstPaths.Items;

            this.Log("Decryption Started.");

            if (paths.Count > 0)
            {
                foreach (string path in paths)
                {
                    if (File.Exists(path) && path.EndsWith(".aes")) // Is Encrypted File
                    {
                        try
                        {
                            if (chkSelectDest.Checked)
                                await path.DecryptFileToOutPutPathAsync(txtPassword.Text, outputpath);
                            else
                                await path.DecryptFileAsync(txtPassword.Text);
                            this.Log(path + " Decrypted.");
                            count++;

                            if (chkDeleteOrg.Checked)
                                File.Delete(path);
                        }
                        catch (Exception ex)
                        {
                            this.Log(path + " " + ex.Message);
                            if (File.Exists(path.RemoveExtension()))
                                File.Delete(path.RemoveExtension());
                        }
                    }
                    if (Directory.Exists(path)) // Is Folder
                    {
                        var followSubDirs = chkSubFolders.Checked ? true : false;

                        var allfiles = path.GetFolderFilesPaths(followSubDirs);

                        foreach (var file in allfiles)
                        {
                            if (file.RemoveExtension().CheckExtension(lstExts.Text.ParseExtensions()))
                            {
                                if (file.EndsWith(".aes"))
                                {
                                    try
                                    {
                                        if (chkSelectDest.Checked)
                                            await file.DecryptFileToOutPutPathAsync(txtPassword.Text, outputpath);
                                        else
                                            await file.DecryptFileAsync(txtPassword.Text);
                                        this.Log(file + " Decrypted.");
                                        count++;

                                        if (chkDeleteOrg.Checked)
                                            File.Delete(file);
                                    }
                                    catch (Exception ex)
                                    {
                                        this.Log(file + " " + ex.Message);
                                        if (File.Exists(file.RemoveExtension()))
                                            File.Delete(file.RemoveExtension());
                                    }
                                }
                            }
                            else
                            {
                                // this.Log(file + " Ignored.");
                            }
                        }
                    }
                }
            }

            this.Log($"Finished : {count} File(s) Decrypted.");
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/batmanalien");
        }

        private void lstPaths_DragDrop(object sender, DragEventArgs e)
        {
            var fileList = e.Data.GetData(DataFormats.FileDrop, false);

            var paths = fileList as IEnumerable<string>;
            if (paths != null)
                foreach (var path in paths)
                {
                    lstPaths.Items.Add(path);
                }
        }

        private void lstPaths_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void chkSelectDest_CheckedChanged(object sender, EventArgs e)
        {
            gbDest.Visible = !gbDest.Visible;
            if (chkSelectDest.Checked)
            {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Select A Folder";
                    folderDialog.ShowNewFolderButton = true;
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        outputpath = folderDialog.SelectedPath;
                        txtDest.Text = outputpath;
                    }
                }
            }
            else
            {
                txtDest.Text = "";
            }
        }

        private async void btnDecryptAndOpen_Click(object sender, EventArgs e)
        {
            string tempFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AESxWin", Guid.NewGuid().ToString());
            var paths = lstPaths.Items;

            this.Log("Decryption Started.");

            if (paths.Count == 1)
            {
                var path = paths[0].ToString();

                if (File.Exists(path) && path.EndsWith(".aes")) // Is Encrypted File
                {
                    try
                    {
                        if (chkSelectDest.Checked)
                            await path.DecryptFileToOutPutPathAsync(txtPassword.Text, outputpath);
                        else
                        {
                            await path.DecryptFileToOutPutPathAsync(txtPassword.Text, tempFolderPath);

                            this.Log(path + " Decrypted. Opening File...");

                            if (chkDeleteOrg.Checked)
                                File.Delete(path);

                            string tempFilePath = Path.Combine(tempFolderPath, path.GetFileNameWithoutExtension());

                            var process = Process.Start(tempFilePath);
                            process.EnableRaisingEvents = true;
                            process.Exited += (sdr, evt) => DeleteTempFolderAndFileWhenFileClosed(sdr, evt, tempFolderPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Log(path + " " + ex.Message);
                        if (File.Exists(path.RemoveExtension()))
                            File.Delete(path.RemoveExtension());
                    }
                }
            }
            else
            {
                this.Log("Decrypt and Open operation is only allowed for single file");
            }
        }

        private void DeleteTempFolderAndFileWhenFileClosed(object sender, EventArgs e, string folderPath)
        {
            Directory.Delete(folderPath, true);
            this.Log("File deleted securely...");
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}