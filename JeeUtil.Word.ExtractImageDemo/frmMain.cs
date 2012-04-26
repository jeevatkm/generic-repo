using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JeeUtil.Word;

namespace JeeUtil.Word.ExtractImageDemo
{
    public partial class frmMain : Form
    {
        string selectedFile = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ExtractImage obj = new ExtractImage();
            ExtractResult res = obj.Process(selectedFile, txtSaveLocation.Text.Trim(), GetSelectedImageFormat());           
            
        }        

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose a file to process...";
            dlg.Filter = "Word 2007 Document (*.docx)|*.docx|Word 2003/2000 Document (*.doc)|*.doc";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedFile = dlg.FileName;                
                lblFileName.Text = "Filename : " + selectedFile.Substring(selectedFile.LastIndexOf('\\') + 1);
                txtSaveLocation.Text = selectedFile.Substring(0, selectedFile.LastIndexOf('\\'));
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();            
            dlg.Description = "Choose a save location for extracting image(s).";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSaveLocation.Text = dlg.SelectedPath;
            }
        }

        private ImageFileFormat GetSelectedImageFormat()
        {
            switch(ImageFormatList.SelectedItem.ToString())
            {
                case "png":
                    return ImageFileFormat.PNG;
                case "bmp":
                    return ImageFileFormat.BMP;
                case "jpeg/jpg":         
                    return ImageFileFormat.JPEG;             
            }
            return ImageFileFormat.JPEG; 
        }
    }
}