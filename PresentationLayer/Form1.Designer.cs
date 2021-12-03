
namespace PresentationLayer
{
    partial class Form1
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
            this.listBox_Students = new System.Windows.Forms.ListBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_IndexNum = new System.Windows.Forms.Label();
            this.label_AvgMark = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_IndexNum = new System.Windows.Forms.TextBox();
            this.textBox_AvgMark = new System.Windows.Forms.TextBox();
            this.button_Kreiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Students
            // 
            this.listBox_Students.FormattingEnabled = true;
            this.listBox_Students.Location = new System.Drawing.Point(49, 43);
            this.listBox_Students.Name = "listBox_Students";
            this.listBox_Students.Size = new System.Drawing.Size(981, 238);
            this.listBox_Students.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(56, 321);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // label_IndexNum
            // 
            this.label_IndexNum.AutoSize = true;
            this.label_IndexNum.Location = new System.Drawing.Point(56, 348);
            this.label_IndexNum.Name = "label_IndexNum";
            this.label_IndexNum.Size = new System.Drawing.Size(74, 13);
            this.label_IndexNum.TabIndex = 2;
            this.label_IndexNum.Text = "Index number:";
            // 
            // label_AvgMark
            // 
            this.label_AvgMark.AutoSize = true;
            this.label_AvgMark.Location = new System.Drawing.Point(56, 380);
            this.label_AvgMark.Name = "label_AvgMark";
            this.label_AvgMark.Size = new System.Drawing.Size(88, 13);
            this.label_AvgMark.TabIndex = 3;
            this.label_AvgMark.Text = "Prosecna ocena:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(174, 318);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(187, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_IndexNum
            // 
            this.textBox_IndexNum.Location = new System.Drawing.Point(174, 345);
            this.textBox_IndexNum.Name = "textBox_IndexNum";
            this.textBox_IndexNum.Size = new System.Drawing.Size(187, 20);
            this.textBox_IndexNum.TabIndex = 5;
            // 
            // textBox_AvgMark
            // 
            this.textBox_AvgMark.Location = new System.Drawing.Point(174, 377);
            this.textBox_AvgMark.Name = "textBox_AvgMark";
            this.textBox_AvgMark.Size = new System.Drawing.Size(187, 20);
            this.textBox_AvgMark.TabIndex = 6;
            // 
            // button_Kreiraj
            // 
            this.button_Kreiraj.Location = new System.Drawing.Point(683, 304);
            this.button_Kreiraj.Name = "button_Kreiraj";
            this.button_Kreiraj.Size = new System.Drawing.Size(258, 100);
            this.button_Kreiraj.TabIndex = 7;
            this.button_Kreiraj.Text = "KREIRAJ";
            this.button_Kreiraj.UseVisualStyleBackColor = true;
            this.button_Kreiraj.Click += new System.EventHandler(this.button_Kreiraj_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1108, 440);
            this.Controls.Add(this.button_Kreiraj);
            this.Controls.Add(this.textBox_AvgMark);
            this.Controls.Add(this.textBox_IndexNum);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_AvgMark);
            this.Controls.Add(this.label_IndexNum);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.listBox_Students);
            this.Name = "Form1";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Studenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox_Students;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_IndexNum;
        private System.Windows.Forms.Label label_AvgMark;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_IndexNum;
        private System.Windows.Forms.TextBox textBox_AvgMark;
        private System.Windows.Forms.Button button_Kreiraj;
    }
}

