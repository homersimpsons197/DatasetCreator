namespace Text_Processor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxtWord = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDup = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLineCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWord = new System.Windows.Forms.Button();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnTxtClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtRemoved = new System.Windows.Forms.RichTextBox();
            this.btnRemovedClear = new System.Windows.Forms.Button();
            this.lblRemoved = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chReplace = new System.Windows.Forms.CheckBox();
            this.chAdd = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNltk = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtWord
            // 
            this.rtxtWord.BackColor = System.Drawing.Color.White;
            this.rtxtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtWord.Location = new System.Drawing.Point(2, 2);
            this.rtxtWord.Name = "rtxtWord";
            this.rtxtWord.Size = new System.Drawing.Size(335, 600);
            this.rtxtWord.TabIndex = 0;
            this.rtxtWord.Text = "";
            this.rtxtWord.TextChanged += new System.EventHandler(this.rtxtWord_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(300, 620);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 25);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDup
            // 
            this.btnDup.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDup.FlatAppearance.BorderSize = 2;
            this.btnDup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDup.Location = new System.Drawing.Point(10, 10);
            this.btnDup.Name = "btnDup";
            this.btnDup.Size = new System.Drawing.Size(150, 40);
            this.btnDup.TabIndex = 2;
            this.btnDup.Text = "Remove duplicates";
            this.btnDup.UseVisualStyleBackColor = true;
            this.btnDup.Click += new System.EventHandler(this.btnDup_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCreate.FlatAppearance.BorderSize = 2;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(10, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create variations";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrder.FlatAppearance.BorderSize = 2;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(10, 55);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(150, 40);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Place by order(A-Z)";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(170, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save as";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLine.Location = new System.Drawing.Point(15, 585);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(49, 21);
            this.lblLine.TabIndex = 6;
            this.lblLine.Text = "Lines:";
            // 
            // lblLineCount
            // 
            this.lblLineCount.AutoSize = true;
            this.lblLineCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLineCount.ForeColor = System.Drawing.Color.Red;
            this.lblLineCount.Location = new System.Drawing.Point(65, 585);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(19, 21);
            this.lblLineCount.TabIndex = 7;
            this.lblLineCount.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.rtxtWord);
            this.panel1.Location = new System.Drawing.Point(170, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 604);
            this.panel1.TabIndex = 8;
            // 
            // btnWord
            // 
            this.btnWord.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnWord.FlatAppearance.BorderSize = 2;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Location = new System.Drawing.Point(10, 180);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(150, 40);
            this.btnWord.TabIndex = 9;
            this.btnWord.Text = "Single word regex";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(10, 220);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.PlaceholderText = "Regex";
            this.txtRegex.Size = new System.Drawing.Size(150, 23);
            this.txtRegex.TabIndex = 10;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(10, 243);
            this.txtWord.Name = "txtWord";
            this.txtWord.PlaceholderText = "Word";
            this.txtWord.Size = new System.Drawing.Size(150, 23);
            this.txtWord.TabIndex = 11;
            // 
            // btnTxtClear
            // 
            this.btnTxtClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTxtClear.FlatAppearance.BorderSize = 2;
            this.btnTxtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxtClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnTxtClear.Location = new System.Drawing.Point(105, 270);
            this.btnTxtClear.Name = "btnTxtClear";
            this.btnTxtClear.Size = new System.Drawing.Size(55, 25);
            this.btnTxtClear.TabIndex = 12;
            this.btnTxtClear.Text = "Clear";
            this.btnTxtClear.UseVisualStyleBackColor = true;
            this.btnTxtClear.Click += new System.EventHandler(this.btnTxtClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.rtxtRemoved);
            this.panel2.Location = new System.Drawing.Point(555, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 564);
            this.panel2.TabIndex = 11;
            // 
            // rtxtRemoved
            // 
            this.rtxtRemoved.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtxtRemoved.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtRemoved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtRemoved.Location = new System.Drawing.Point(2, 2);
            this.rtxtRemoved.Name = "rtxtRemoved";
            this.rtxtRemoved.ReadOnly = true;
            this.rtxtRemoved.Size = new System.Drawing.Size(250, 560);
            this.rtxtRemoved.TabIndex = 0;
            this.rtxtRemoved.Text = "";
            // 
            // btnRemovedClear
            // 
            this.btnRemovedClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemovedClear.FlatAppearance.BorderSize = 2;
            this.btnRemovedClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovedClear.Location = new System.Drawing.Point(685, 620);
            this.btnRemovedClear.Name = "btnRemovedClear";
            this.btnRemovedClear.Size = new System.Drawing.Size(125, 25);
            this.btnRemovedClear.TabIndex = 9;
            this.btnRemovedClear.Text = "Clear";
            this.btnRemovedClear.UseVisualStyleBackColor = true;
            this.btnRemovedClear.Click += new System.EventHandler(this.btnRemovedClear_Click);
            // 
            // lblRemoved
            // 
            this.lblRemoved.AutoSize = true;
            this.lblRemoved.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoved.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRemoved.ForeColor = System.Drawing.Color.Red;
            this.lblRemoved.Location = new System.Drawing.Point(555, 10);
            this.lblRemoved.Name = "lblRemoved";
            this.lblRemoved.Size = new System.Drawing.Size(238, 32);
            this.lblRemoved.TabIndex = 13;
            this.lblRemoved.Text = "Removed duplicates";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(530, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 585);
            this.panel3.TabIndex = 14;
            // 
            // chReplace
            // 
            this.chReplace.AutoSize = true;
            this.chReplace.BackColor = System.Drawing.Color.Transparent;
            this.chReplace.ForeColor = System.Drawing.Color.Red;
            this.chReplace.Location = new System.Drawing.Point(10, 160);
            this.chReplace.Name = "chReplace";
            this.chReplace.Size = new System.Drawing.Size(67, 19);
            this.chReplace.TabIndex = 15;
            this.chReplace.Text = "Replace";
            this.chReplace.UseVisualStyleBackColor = false;
            this.chReplace.CheckedChanged += new System.EventHandler(this.chReplace_CheckedChanged);
            // 
            // chAdd
            // 
            this.chAdd.AutoSize = true;
            this.chAdd.BackColor = System.Drawing.Color.Transparent;
            this.chAdd.ForeColor = System.Drawing.Color.Red;
            this.chAdd.Location = new System.Drawing.Point(80, 160);
            this.chAdd.Name = "chAdd";
            this.chAdd.Size = new System.Drawing.Size(48, 19);
            this.chAdd.TabIndex = 16;
            this.chAdd.Text = "Add";
            this.chAdd.UseVisualStyleBackColor = false;
            this.chAdd.CheckedChanged += new System.EventHandler(this.chAdd_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(15, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 5);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(10, 665);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 60);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnNltk);
            this.panel6.Location = new System.Drawing.Point(15, 670);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(790, 50);
            this.panel6.TabIndex = 18;
            // 
            // btnNltk
            // 
            this.btnNltk.BackColor = System.Drawing.SystemColors.Control;
            this.btnNltk.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnNltk.FlatAppearance.BorderSize = 2;
            this.btnNltk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNltk.Location = new System.Drawing.Point(5, 5);
            this.btnNltk.Name = "btnNltk";
            this.btnNltk.Size = new System.Drawing.Size(150, 40);
            this.btnNltk.TabIndex = 19;
            this.btnNltk.Text = "Stop words processor";
            this.btnNltk.UseVisualStyleBackColor = false;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Transparent;
            this.pnlControl.Location = new System.Drawing.Point(10, 10);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(800, 645);
            this.pnlControl.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 731);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chAdd);
            this.Controls.Add(this.chReplace);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblRemoved);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTxtClear);
            this.Controls.Add(this.btnRemovedClear);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLineCount);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDup);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text_Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClear;
        private Button btnDup;
        private Button btnCreate;
        private Button btnOrder;
        public RichTextBox rtxtWord;
        private Button btnSave;
        private Label lblLine;
        public Label lblLineCount;
        private Panel panel1;
        private Button btnWord;
        public TextBox txtRegex;
        public TextBox txtWord;
        private Button btnTxtClear;
        private Panel panel2;
        public RichTextBox rtxtRemoved;
        private Button btnRemovedClear;
        private Label lblRemoved;
        private Panel panel3;
        public CheckBox chReplace;
        public CheckBox chAdd;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        public Button btnNltk;
        public Panel pnlControl;
    }
}