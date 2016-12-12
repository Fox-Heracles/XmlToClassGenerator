namespace XmlToClassGenerator
{
    partial class frmGenerator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.plTree = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.plInfo = new System.Windows.Forms.Panel();
            this.lblFileFolders = new System.Windows.Forms.Label();
            this.lblNameSpace = new System.Windows.Forms.Label();
            this.txtFileFolders = new System.Windows.Forms.TextBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.plDetail = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.plTree.SuspendLayout();
            this.plInfo.SuspendLayout();
            this.plDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTree
            // 
            this.plTree.Controls.Add(this.treeView1);
            this.plTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.plTree.Location = new System.Drawing.Point(0, 0);
            this.plTree.Name = "plTree";
            this.plTree.Size = new System.Drawing.Size(180, 515);
            this.plTree.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(180, 515);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // plInfo
            // 
            this.plInfo.Controls.Add(this.lblFileFolders);
            this.plInfo.Controls.Add(this.lblNameSpace);
            this.plInfo.Controls.Add(this.txtFileFolders);
            this.plInfo.Controls.Add(this.txtNameSpace);
            this.plInfo.Controls.Add(this.btnGenerate);
            this.plInfo.Controls.Add(this.btnLoadXml);
            this.plInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plInfo.Location = new System.Drawing.Point(180, 0);
            this.plInfo.Name = "plInfo";
            this.plInfo.Size = new System.Drawing.Size(524, 128);
            this.plInfo.TabIndex = 1;
            // 
            // lblFileFolders
            // 
            this.lblFileFolders.AutoSize = true;
            this.lblFileFolders.Location = new System.Drawing.Point(25, 101);
            this.lblFileFolders.Name = "lblFileFolders";
            this.lblFileFolders.Size = new System.Drawing.Size(41, 12);
            this.lblFileFolders.TabIndex = 5;
            this.lblFileFolders.Text = "文件夹";
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.AutoSize = true;
            this.lblNameSpace.Location = new System.Drawing.Point(25, 63);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(53, 12);
            this.lblNameSpace.TabIndex = 4;
            this.lblNameSpace.Text = "命名空间";
            // 
            // txtFileFolders
            // 
            this.txtFileFolders.Location = new System.Drawing.Point(85, 98);
            this.txtFileFolders.Name = "txtFileFolders";
            this.txtFileFolders.Size = new System.Drawing.Size(299, 21);
            this.txtFileFolders.TabIndex = 3;
            this.txtFileFolders.Text = "InPut";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(85, 60);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(363, 21);
            this.txtNameSpace.TabIndex = 2;
            this.txtNameSpace.Text = "WeChat.Models";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(132, 23);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "生成实体类";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(27, 23);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(75, 23);
            this.btnLoadXml.TabIndex = 0;
            this.btnLoadXml.Text = "加载Xml";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // plDetail
            // 
            this.plDetail.Controls.Add(this.txtCode);
            this.plDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDetail.Location = new System.Drawing.Point(180, 128);
            this.plDetail.Name = "plDetail";
            this.plDetail.Size = new System.Drawing.Size(524, 387);
            this.plDetail.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(524, 387);
            this.txtCode.TabIndex = 0;
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 515);
            this.Controls.Add(this.plDetail);
            this.Controls.Add(this.plInfo);
            this.Controls.Add(this.plTree);
            this.Name = "frmGenerator";
            this.Text = "Xml生成实体类(C#版)";
            this.plTree.ResumeLayout(false);
            this.plInfo.ResumeLayout(false);
            this.plInfo.PerformLayout();
            this.plDetail.ResumeLayout(false);
            this.plDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTree;
        private System.Windows.Forms.Panel plInfo;
        private System.Windows.Forms.Panel plDetail;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblFileFolders;
        private System.Windows.Forms.Label lblNameSpace;
        private System.Windows.Forms.TextBox txtFileFolders;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.TextBox txtCode;
    }
}

