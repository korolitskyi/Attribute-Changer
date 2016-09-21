using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttributeChangerWF
{
    public partial class MainForm : Form
    {
        Controller controller;

        public MainForm()
        {
            InitializeComponent();
            controller = new Controller(checkBox_Archives,checkBox_ReadOnly,checkBox_Hidden,checkBox_System,button_Apply,button_Cancle);                
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            controller.OpenFile();
            textBox_Path.Text = controller.path;
        }

        private void button_Directory_Click(object sender, EventArgs e)
        {
            controller.OpenDirectory();
            textBox_Path.Text = controller.path;
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            controller.ApplyFileAttrib();
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            controller.CancleAttrib();
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
