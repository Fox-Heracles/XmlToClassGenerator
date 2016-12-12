using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace XmlToClassGenerator
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StringBuilder strBuilder = GenerateCode(this.treeView1.SelectedNode.Tag.ToString());
            this.txtCode.Text = strBuilder.ToString();
        }
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="filePath">文件物理路径</param>
        /// <returns></returns>
        private StringBuilder GenerateCode(string filePath)
        {
            XElement xe = XElement.Load(filePath);
            StringBuilder strBuilder = new StringBuilder(409600);
            StringBuilder strBuildertmp = new StringBuilder(409600);
            ElementClass ec = new ElementClass();
            Util.XmlToClass(xe, ref ec);
            Util.ClassToCs(ec, ref strBuildertmp);
            strBuilder.Append(string.Format(Util.classFormat, this.txtNameSpace.Text + "." + this.txtFileFolders.Text, xe.Name.LocalName, strBuildertmp.ToString()));
            return strBuilder;
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            System.Windows.Forms.OpenFileDialog dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            dlgOpenFile.Multiselect = true;
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlgOpenFile.FileNames.Length; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = dlgOpenFile.SafeFileNames[i];
                    node.Tag = dlgOpenFile.FileNames[i];
                    treeView1.Nodes.Add(node);
                }
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string destnatinPath = Application.StartupPath;
                if (!string.IsNullOrEmpty(this.txtFileFolders.Text))
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\" + this.txtFileFolders.Text);
                    destnatinPath = Application.StartupPath + "\\" + this.txtFileFolders.Text;
                }
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    string filePath = treeView1.Nodes[i].Tag.ToString();
                    StringBuilder strBuilder = this.GenerateCode(filePath);
                    string destnationFileName = destnatinPath + "\\" + treeView1.Nodes[i].Text.Replace(".xml", "").Replace(".XML","") + ".cs";
                    StringToFile(strBuilder, destnationFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
            MessageBox.Show("代码生成成功!");
        }
        /// <summary>
        /// 字符串输出成文件
        /// </summary>
        /// <param name="strBuilder"></param>
        /// <param name="destnationFileName"></param>
        private static void StringToFile(StringBuilder strBuilder, string destnationFileName)
        {
            FileStream fileStream = new FileStream(destnationFileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(strBuilder.ToString());
            streamWriter.Flush();
        }
    }
}
