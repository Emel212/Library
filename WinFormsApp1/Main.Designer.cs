
namespace WinFormsApp1
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._cmbCategory = new System.Windows.Forms.ComboBox();
            this._author = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this._bookName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._phone = new System.Windows.Forms.MaskedTextBox();
            this._adress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lastName = new System.Windows.Forms.TextBox();
            this._name = new System.Windows.Forms.TextBox();
            this.currentStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this._loanStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._statusPanel = new System.Windows.Forms.Panel();
            this.findMemberBtn = new System.Windows.Forms.Button();
            this._memberName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this._statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Message);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this._cmbCategory);
            this.groupBox1.Controls.Add(this._author);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._bookName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 449);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Indigo;
            this.button6.Location = new System.Drawing.Point(482, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Find";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Indigo;
            this.button5.Location = new System.Drawing.Point(482, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Find";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(482, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.DarkViolet;
            this.Message.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Message.ForeColor = System.Drawing.Color.Black;
            this.Message.Location = new System.Drawing.Point(37, 174);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(119, 15);
            this.Message.TabIndex = 18;
            this.Message.Text = "information message";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search by Category";
            // 
            // _cmbCategory
            // 
            this._cmbCategory.AllowDrop = true;
            this._cmbCategory.BackColor = System.Drawing.Color.DarkViolet;
            this._cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._cmbCategory.FormattingEnabled = true;
            this._cmbCategory.Location = new System.Drawing.Point(131, 126);
            this._cmbCategory.Name = "_cmbCategory";
            this._cmbCategory.Size = new System.Drawing.Size(343, 21);
            this._cmbCategory.TabIndex = 16;
            this._cmbCategory.Click += new System.EventHandler(this._cmbCategory_Click);
            // 
            // _author
            // 
            this._author.BackColor = System.Drawing.Color.DarkViolet;
            this._author.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._author.ForeColor = System.Drawing.SystemColors.Menu;
            this._author.Location = new System.Drawing.Point(131, 86);
            this._author.Name = "_author";
            this._author.Size = new System.Drawing.Size(343, 23);
            this._author.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Search by author";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.Description,
            this.Author,
            this.Publisher,
            this.Category,
            this.Id});
            this.dataGridView1.GridColor = System.Drawing.Color.Indigo;
            this.dataGridView1.Location = new System.Drawing.Point(0, 214);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Indigo;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkViolet;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 235);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 95;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search by name";
            // 
            // _bookName
            // 
            this._bookName.BackColor = System.Drawing.Color.DarkViolet;
            this._bookName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._bookName.ForeColor = System.Drawing.SystemColors.Menu;
            this._bookName.Location = new System.Drawing.Point(131, 46);
            this._bookName.Name = "_bookName";
            this._bookName.Size = new System.Drawing.Size(343, 23);
            this._bookName.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._phone);
            this.groupBox2.Controls.Add(this._adress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._lastName);
            this.groupBox2.Controls.Add(this._name);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(556, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 189);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member Information";
            // 
            // _phone
            // 
            this._phone.BackColor = System.Drawing.Color.DarkViolet;
            this._phone.Culture = new System.Globalization.CultureInfo("en-US");
            this._phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._phone.Location = new System.Drawing.Point(144, 101);
            this._phone.Mask = "(999) 000-0000";
            this._phone.Name = "_phone";
            this._phone.Size = new System.Drawing.Size(249, 23);
            this._phone.TabIndex = 21;
            // 
            // _adress
            // 
            this._adress.BackColor = System.Drawing.Color.DarkViolet;
            this._adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._adress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._adress.Location = new System.Drawing.Point(144, 135);
            this._adress.Name = "_adress";
            this._adress.Size = new System.Drawing.Size(249, 46);
            this._adress.TabIndex = 20;
            this._adress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Member Name";
            // 
            // _lastName
            // 
            this._lastName.BackColor = System.Drawing.Color.DarkViolet;
            this._lastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lastName.ForeColor = System.Drawing.SystemColors.Menu;
            this._lastName.Location = new System.Drawing.Point(144, 67);
            this._lastName.Name = "_lastName";
            this._lastName.Size = new System.Drawing.Size(249, 23);
            this._lastName.TabIndex = 15;
            // 
            // _name
            // 
            this._name.BackColor = System.Drawing.Color.DarkViolet;
            this._name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._name.ForeColor = System.Drawing.SystemColors.Menu;
            this._name.Location = new System.Drawing.Point(144, 27);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(249, 23);
            this._name.TabIndex = 14;
            // 
            // currentStatus
            // 
            this.currentStatus.BackColor = System.Drawing.Color.GhostWhite;
            this.currentStatus.Enabled = false;
            this.currentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentStatus.ForeColor = System.Drawing.Color.DarkMagenta;
            this.currentStatus.Location = new System.Drawing.Point(141, 24);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(249, 23);
            this.currentStatus.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(17, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Current Status";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(141, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(249, 23);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // _loanStart
            // 
            this._loanStart.CalendarMonthBackground = System.Drawing.Color.DarkViolet;
            this._loanStart.Location = new System.Drawing.Point(141, 67);
            this._loanStart.Name = "_loanStart";
            this._loanStart.Size = new System.Drawing.Size(249, 23);
            this._loanStart.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "End of loan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Beggining Of Loan";
            // 
            // _statusPanel
            // 
            this._statusPanel.Controls.Add(this.currentStatus);
            this._statusPanel.Controls.Add(this.label11);
            this._statusPanel.Controls.Add(this.label7);
            this._statusPanel.Controls.Add(this.label6);
            this._statusPanel.Controls.Add(this._loanStart);
            this._statusPanel.Controls.Add(this.dateTimePicker2);
            this._statusPanel.Enabled = false;
            this._statusPanel.Location = new System.Drawing.Point(559, 302);
            this._statusPanel.Name = "_statusPanel";
            this._statusPanel.Size = new System.Drawing.Size(417, 162);
            this._statusPanel.TabIndex = 26;
            // 
            // findMemberBtn
            // 
            this.findMemberBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findMemberBtn.ForeColor = System.Drawing.Color.Indigo;
            this.findMemberBtn.Location = new System.Drawing.Point(787, 264);
            this.findMemberBtn.Name = "findMemberBtn";
            this.findMemberBtn.Size = new System.Drawing.Size(95, 23);
            this.findMemberBtn.TabIndex = 24;
            this.findMemberBtn.Text = "Find";
            this.findMemberBtn.UseVisualStyleBackColor = false;
            this.findMemberBtn.Click += new System.EventHandler(this.findMemberBtn_Click);
            // 
            // _memberName
            // 
            this._memberName.BackColor = System.Drawing.Color.DarkViolet;
            this._memberName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._memberName.ForeColor = System.Drawing.SystemColors.Menu;
            this._memberName.Location = new System.Drawing.Point(700, 235);
            this._memberName.Name = "_memberName";
            this._memberName.Size = new System.Drawing.Size(261, 23);
            this._memberName.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(559, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Search member by name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(985, 476);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._memberName);
            this.Controls.Add(this.findMemberBtn);
            this.Controls.Add(this._statusPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this._statusPanel.ResumeLayout(false);
            this._statusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _bookName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _lastName;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker _loanStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _cmbCategory;
        private System.Windows.Forms.TextBox _author;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TextBox currentStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox _adress;
        private System.Windows.Forms.MaskedTextBox _phone;
        private System.Windows.Forms.Panel _statusPanel;
        private System.Windows.Forms.Button findMemberBtn;
        private System.Windows.Forms.TextBox _memberName;
        private System.Windows.Forms.Label label12;
    }
}

