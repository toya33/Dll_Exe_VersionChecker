namespace DirectorySearcher
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.exeFileList = new System.Windows.Forms.TextBox();
            this.dllFileList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(160, 290);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(145, 36);
            this.FolderSelectButton.TabIndex = 0;
            this.FolderSelectButton.Text = "フォルダ選択";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // exeFileList
            // 
            this.exeFileList.Location = new System.Drawing.Point(34, 65);
            this.exeFileList.Multiline = true;
            this.exeFileList.Name = "exeFileList";
            this.exeFileList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.exeFileList.Size = new System.Drawing.Size(405, 82);
            this.exeFileList.TabIndex = 1;
            // 
            // dllFileList
            // 
            this.dllFileList.Location = new System.Drawing.Point(34, 181);
            this.dllFileList.Multiline = true;
            this.dllFileList.Name = "dllFileList";
            this.dllFileList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dllFileList.Size = new System.Drawing.Size(405, 77);
            this.dllFileList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "EXE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "DLL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direcotry : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dllFileList);
            this.Controls.Add(this.exeFileList);
            this.Controls.Add(this.FolderSelectButton);
            this.Name = "Form1";
            this.Text = "バージョンチェッカー";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.TextBox exeFileList;
        private System.Windows.Forms.TextBox dllFileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

