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
        Button applyButton, cancleButton;
        Dictionary<CheckBox, bool> checkBoxStatus;
        Dictionary<CheckBox, FileAttributes> checkBoxDictionary = new Dictionary<CheckBox, FileAttributes >();
        bool controllEnabled = false;

        public Controller(CheckBox archives,CheckBox readOnly, CheckBox hidden, CheckBox system, Button Apply, Button Cancle)
        {
            checkBoxDictionary.Add(archives, FileAttributes.Archive);
            checkBoxDictionary.Add(readOnly, FileAttributes.ReadOnly);
            checkBoxDictionary.Add(hidden, FileAttributes.Hidden);
            checkBoxDictionary.Add(system, FileAttributes.System);
            this.applyButton = Apply;
            this.cancleButton = Cancle;
        }

        void EnableCheckBoxes()
        {
            if (!controllEnabled)
            {
                foreach (CheckBox e in checkBoxDictionary.Keys)
                {
                    e.Enabled = true;
                }
                controllEnabled = true;
            }
        }

        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {            
            foreach(KeyValuePair<CheckBox,bool> element in checkBoxStatus)
            {
                if(element.Key.Checked == element.Value)
                {
                    continue;
                }
                EnableButtons();
                return;
            }
            DisableButtons();
        }

        void EnableButtons()
        {
            if(!applyButton.Enabled || !cancleButton.Enabled)
            {
                applyButton.Enabled = true;
                cancleButton.Enabled = true;
            }
        }
        void DisableButtons()
        {
            if (applyButton.Enabled || cancleButton.Enabled)
            {
                applyButton.Enabled = false;
                cancleButton.Enabled = false;
            }
        }


        void GetAttrib()
        {
            checkBoxStatus = new Dictionary<CheckBox, bool>();
            foreach (KeyValuePair<CheckBox, FileAttributes> e in checkBoxDictionary)
            {
                if ((attributes & e.Value) == e.Value)
                {
                    e.Key.Checked = true;
                }
                else e.Key.Checked = false;
                checkBoxStatus.Add(e.Key, e.Key.Checked);
                e.Key.CheckedChanged += CheckBox_CheckedChanged;
            }
        }        

        public void CancleAttrib()
        {
            foreach (KeyValuePair<CheckBox,bool> e in checkBoxStatus)
            {
                e.Key.Checked = e.Value;
            }
        }

        public void ApplyFileAttrib()
        {
            List<CheckBox> tmpList = new List<CheckBox>(checkBoxStatus.Keys);
            foreach (CheckBox e in tmpList)
            {
                if (e.Checked != checkBoxStatus[e])
                {
                    if (e.Checked == true)
                    {
                        attributes = attributes | checkBoxDictionary[e];
                    }
                    else
                        attributes = attributes & ~checkBoxDictionary[e];
                    checkBoxStatus[e] = e.Checked;
                }
            }
            CheckBox_CheckedChanged(null, null);
            if (isFile)
                ApplyFileAttrib(attributes);
            else
                ApplyDirAttrib(attributes, path);
        }

        void ApplyDirAttrib(FileAttributes attributes, string path)
        {
            File.SetAttributes(path, attributes);
            DirectoryInfo DI = new System.IO.DirectoryInfo(path);
            DirectoryInfo[] SubDir = DI.GetDirectories();
            for (int i = 0; i < SubDir.Length; ++i)
            {
                SubDir[i].Attributes = attributes;
                this.ApplyDirAttrib(attributes, SubDir[i].FullName);
            }                
            System.IO.FileInfo[] FI = DI.GetFiles();
            for (int i = 0; i < FI.Length; ++i)
                FI[i].Attributes = attributes;
        }

        void ApplyFileAttrib(FileAttributes attributes)
        {
                       
            File.SetAttributes(path, attributes);                       
        }

    }
}
