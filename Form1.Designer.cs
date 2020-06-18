namespace AppTranslateXls
{
    partial class Form1
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
            this.btn_open = new System.Windows.Forms.Button();
            this.tb_language = new System.Windows.Forms.ComboBox();
            this.btn_translate = new System.Windows.Forms.Button();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(34, 28);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "打开";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // tb_language
            // 
            this.tb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_language.FormattingEnabled = true;
            this.tb_language.Location = new System.Drawing.Point(34, 68);
            this.tb_language.Name = "tb_language";
            this.tb_language.Size = new System.Drawing.Size(121, 20);
            this.tb_language.TabIndex = 1;
            // 
            // btn_translate
            // 
            this.btn_translate.Location = new System.Drawing.Point(188, 66);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(75, 23);
            this.btn_translate.TabIndex = 2;
            this.btn_translate.Text = "导出";
            this.btn_translate.UseVisualStyleBackColor = true;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // tb_content
            // 
            this.tb_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_content.Location = new System.Drawing.Point(34, 112);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_content.Size = new System.Drawing.Size(563, 275);
            this.tb_content.TabIndex = 3;
            this.tb_content.WordWrap = false;
            this.tb_content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_content_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 399);
            this.Controls.Add(this.tb_content);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.tb_language);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ComboBox tb_language;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.TextBox tb_content;
    }
}

