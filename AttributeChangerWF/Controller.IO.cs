using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttributeChangerWF
{
    public partial class Controller
    {
        bool isFile;
        public string path;
        public FileAttributes attributes;

        public void OpenDirectory()
        {            
            FolderBrowserDialog openDirectory = new FolderBrowserDialog();
            if (openDirectory.ShowDialog() == DialogResult.OK)
            {
                isFile = false;
                EnableCheckBoxes();
                path = Path.GetFullPath(openDirectory.SelectedPath);
                attributes = File.GetAttributes(path);
                GetAttrib();
            }
        }

        public void OpenFile()
        {            
            OpenFileDialog openFile = new OpenFileDialog();
            
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                isFile = true;
                EnableCheckBoxes();
                path = Path.GetFullPath(openFile.FileName);
                attributes = File.GetAttributes(path);
                GetAttrib();
            }
        }      
    }
}
