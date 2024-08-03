namespace SimpleP2PMessager
{
    partial class HelloForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServerPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.ServerPage.SuspendLayout();
            this.ClientPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 18);
            this.maskedTextBox1.Mask = "###";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(54, 18);
            this.maskedTextBox2.Mask = "###";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox2.TabIndex = 3;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(85, 18);
            this.maskedTextBox3.Mask = "###";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox3.TabIndex = 4;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(116, 18);
            this.maskedTextBox4.Mask = "###";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox4.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServerPage);
            this.tabControl1.Controls.Add(this.ClientPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(216, 120);
            this.tabControl1.TabIndex = 6;
            // 
            // ServerPage
            // 
            this.ServerPage.Controls.Add(this.button1);
            this.ServerPage.Location = new System.Drawing.Point(4, 22);
            this.ServerPage.Name = "ServerPage";
            this.ServerPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServerPage.Size = new System.Drawing.Size(208, 94);
            this.ServerPage.TabIndex = 0;
            this.ServerPage.Text = "Сервер";
            this.ServerPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "start server";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientPage
            // 
            this.ClientPage.Controls.Add(this.button2);
            this.ClientPage.Controls.Add(this.label1);
            this.ClientPage.Controls.Add(this.maskedTextBox5);
            this.ClientPage.Controls.Add(this.maskedTextBox2);
            this.ClientPage.Controls.Add(this.maskedTextBox4);
            this.ClientPage.Controls.Add(this.maskedTextBox1);
            this.ClientPage.Controls.Add(this.maskedTextBox3);
            this.ClientPage.Location = new System.Drawing.Point(4, 22);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientPage.Size = new System.Drawing.Size(208, 94);
            this.ClientPage.TabIndex = 1;
            this.ClientPage.Text = "Client";
            this.ClientPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "try connect";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(147, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(168, 18);
            this.maskedTextBox5.Mask = "###";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox5.TabIndex = 6;
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 143);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelloForm";
            this.Text = "Начало работы";
            this.tabControl1.ResumeLayout(false);
            this.ServerPage.ResumeLayout(false);
            this.ClientPage.ResumeLayout(false);
            this.ClientPage.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServerPage;
        private System.Windows.Forms.TabPage ClientPage;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        #endregion
    }
}