namespace SimpleWindow
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btnSubmit = new Button();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbList = new TextBox();
            calBirth = new MonthCalendar();
            lblFirst = new Label();
            lblLast = new Label();
            lblBirth = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(149, 236);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += click_Submit;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(129, 30);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(200, 39);
            tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(129, 105);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(200, 39);
            tbLastName.TabIndex = 3;
            // 
            // tbList
            // 
            tbList.BackColor = SystemColors.Window;
            tbList.Location = new Point(34, 359);
            tbList.Multiline = true;
            tbList.Name = "tbList";
            tbList.ReadOnly = true;
            tbList.ScrollBars = ScrollBars.Vertical;
            tbList.Size = new Size(915, 242);
            tbList.TabIndex = 4;
            // 
            // calBirth
            // 
            calBirth.Location = new Point(545, 30);
            calBirth.MaxSelectionCount = 1;
            calBirth.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            calBirth.Name = "calBirth";
            calBirth.TabIndex = 5;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(34, 30);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(58, 32);
            lblFirst.TabIndex = 6;
            lblFirst.Text = "First";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(34, 105);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(55, 32);
            lblLast.TabIndex = 7;
            lblLast.Text = "Last";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(422, 30);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(111, 32);
            lblBirth.TabIndex = 8;
            lblBirth.Text = "Birthdate";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 634);
            Controls.Add(lblBirth);
            Controls.Add(lblLast);
            Controls.Add(lblFirst);
            Controls.Add(calBirth);
            Controls.Add(tbList);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbList;
        private MonthCalendar calBirth;
        private Label lblFirst;
        private Label lblLast;
        private Label lblBirth;
    }
}