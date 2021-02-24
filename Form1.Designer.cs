
namespace DMLDemoWindowsFormsApp
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
            this.DbConnCheck = new System.Windows.Forms.Label();
            this.UserDetailsGridView = new System.Windows.Forms.DataGridView();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.userCountLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.placeLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.idTextBoxForDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DbConnCheck
            // 
            this.DbConnCheck.AutoSize = true;
            this.DbConnCheck.Location = new System.Drawing.Point(61, 9);
            this.DbConnCheck.Name = "DbConnCheck";
            this.DbConnCheck.Size = new System.Drawing.Size(35, 13);
            this.DbConnCheck.TabIndex = 0;
            this.DbConnCheck.Text = "label1";
            // 
            // UserDetailsGridView
            // 
            this.UserDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDetailsGridView.Location = new System.Drawing.Point(424, 23);
            this.UserDetailsGridView.Name = "UserDetailsGridView";
            this.UserDetailsGridView.Size = new System.Drawing.Size(364, 400);
            this.UserDetailsGridView.TabIndex = 1;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(12, 99);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 2;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(13, 36);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 3;
            this.countButton.Text = "Count Users";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // userCountLabel
            // 
            this.userCountLabel.AutoSize = true;
            this.userCountLabel.Location = new System.Drawing.Point(132, 41);
            this.userCountLabel.Name = "userCountLabel";
            this.userCountLabel.Size = new System.Drawing.Size(70, 13);
            this.userCountLabel.TabIndex = 4;
            this.userCountLabel.Text = "User Count is";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(22, 83);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(66, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name : ";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(159, 83);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(67, 13);
            this.secondNameLabel.TabIndex = 6;
            this.secondNameLabel.Text = "Last Name : ";
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(273, 99);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(100, 20);
            this.placeTextBox.TabIndex = 7;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(135, 99);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(288, 83);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(40, 13);
            this.placeLabel.TabIndex = 9;
            this.placeLabel.Text = "Place :";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(151, 142);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(22, 186);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(12, 215);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Items.AddRange(new object[] {
            "FirstName",
            "LastName",
            "Place"});
            this.updateComboBox.Location = new System.Drawing.Point(151, 214);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(121, 21);
            this.updateComboBox.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(151, 261);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(343, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(291, 214);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 16;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(175, 186);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(69, 13);
            this.ColumnLabel.TabIndex = 17;
            this.ColumnLabel.Text = "columnName";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(304, 186);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 18;
            this.valueLabel.Text = "Value";
            // 
            // idTextBoxForDelete
            // 
            this.idTextBoxForDelete.Location = new System.Drawing.Point(55, 351);
            this.idTextBoxForDelete.Name = "idTextBoxForDelete";
            this.idTextBoxForDelete.Size = new System.Drawing.Size(100, 20);
            this.idTextBoxForDelete.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(208, 354);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBoxForDelete);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateComboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.userCountLabel);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.UserDetailsGridView);
            this.Controls.Add(this.DbConnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DbConnCheck;
        private System.Windows.Forms.DataGridView UserDetailsGridView;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label userCountLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox idTextBoxForDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}

