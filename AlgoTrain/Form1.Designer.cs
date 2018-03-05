namespace AlgoTrain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.Animals = new System.Windows.Forms.GroupBox();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbWagonList = new System.Windows.Forms.ListBox();
            this.Algoritem = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Animals.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Algoritem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbSize);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(108, 20);
            this.tbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Big",
            "Medium",
            "Small"});
            this.cbSize.Location = new System.Drawing.Point(6, 154);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(108, 21);
            this.cbSize.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Carnivore",
            "Herbivore"});
            this.cbType.Location = new System.Drawing.Point(6, 103);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(108, 21);
            this.cbType.TabIndex = 0;
            // 
            // Animals
            // 
            this.Animals.Controls.Add(this.lbAnimals);
            this.Animals.Location = new System.Drawing.Point(286, 12);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(200, 239);
            this.Animals.TabIndex = 1;
            this.Animals.TabStop = false;
            this.Animals.Text = "Animals List";
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(6, 19);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(188, 212);
            this.lbAnimals.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbWagonList);
            this.groupBox2.Location = new System.Drawing.Point(492, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Train Wagon list";
            // 
            // lbWagonList
            // 
            this.lbWagonList.FormattingEnabled = true;
            this.lbWagonList.Location = new System.Drawing.Point(6, 19);
            this.lbWagonList.Name = "lbWagonList";
            this.lbWagonList.Size = new System.Drawing.Size(363, 212);
            this.lbWagonList.TabIndex = 0;
            // 
            // Algoritem
            // 
            this.Algoritem.Controls.Add(this.lblResult);
            this.Algoritem.Controls.Add(this.label6);
            this.Algoritem.Controls.Add(this.btnClear);
            this.Algoritem.Controls.Add(this.label5);
            this.Algoritem.Controls.Add(this.btnStart);
            this.Algoritem.Controls.Add(this.label4);
            this.Algoritem.Location = new System.Drawing.Point(150, 12);
            this.Algoritem.Name = "Algoritem";
            this.Algoritem.Size = new System.Drawing.Size(130, 239);
            this.Algoritem.TabIndex = 1;
            this.Algoritem.TabStop = false;
            this.Algoritem.Text = "Algo Menu";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 154);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total wagons:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reset";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calculate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 263);
            this.Controls.Add(this.Algoritem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AlgoTrain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Animals.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Algoritem.ResumeLayout(false);
            this.Algoritem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox Animals;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Algoritem;
        private System.Windows.Forms.ListBox lbWagonList;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
    }
}

