namespace cs_form_230622
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            アクセプトボタン = new Button();
            キャンセルボタン = new Button();
            textBox1 = new TextBox();
            追加ボタン = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // アクセプトボタン
            // 
            アクセプトボタン.Location = new Point(539, 166);
            アクセプトボタン.Name = "アクセプトボタン";
            アクセプトボタン.Size = new Size(192, 45);
            アクセプトボタン.TabIndex = 2;
            アクセプトボタン.Text = "アクセプトボタン";
            アクセプトボタン.UseVisualStyleBackColor = true;
            アクセプトボタン.Click += アクセプトボタン_Click;
            // 
            // キャンセルボタン
            // 
            キャンセルボタン.Location = new Point(539, 73);
            キャンセルボタン.Name = "キャンセルボタン";
            キャンセルボタン.Size = new Size(192, 48);
            キャンセルボタン.TabIndex = 1;
            キャンセルボタン.Text = "キャンセルボタン";
            キャンセルボタン.UseVisualStyleBackColor = true;
            キャンセルボタン.Click += キャンセルボタン_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            // 
            // 追加ボタン
            // 
            追加ボタン.Location = new Point(537, 257);
            追加ボタン.Name = "追加ボタン";
            追加ボタン.Size = new Size(195, 44);
            追加ボタン.TabIndex = 3;
            追加ボタン.Text = "追加ボタン";
            追加ボタン.UseVisualStyleBackColor = true;
            追加ボタン.Click += 追加ボタン_Click;
            // 
            // button1
            // 
            button1.Location = new Point(535, 339);
            button1.Name = "button1";
            button1.Size = new Size(195, 41);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = アクセプトボタン;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = キャンセルボタン;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(追加ボタン);
            Controls.Add(textBox1);
            Controls.Add(キャンセルボタン);
            Controls.Add(アクセプトボタン);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button アクセプトボタン;
        private Button キャンセルボタン;
        private TextBox textBox1;
        private Button 追加ボタン;
        private Button button1;
    }
}