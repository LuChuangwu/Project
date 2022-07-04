using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDCheckTool
{
    public partial class CheckDiffernet : UserControl
    {
        XmlController xmlController = new XmlController();
        public CheckDiffernet()
        {
            InitializeComponent();
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string name = ((Control)sender).Name.Split('_')[1];
            switch (name)
            {
                case "heng":
                    
                    heng_path.Text = path;
              
                    xmlController.LoadXmL(path);
                    break;
                case "shu":
                    if (heng_path.Text == path)
                    {
                        MessageBox.Show("横竖版不能为同一路径");
                        return;
                    }
                    shu_path.Text = path;
                    xmlController.LoadXmL(path);
                    break;


             
            }
           
        }

        private void check_different_Click(object sender, EventArgs e)
        {
            ((RadioButton)sender).Checked = !((RadioButton)sender).Checked;
        }

        
    }
}
