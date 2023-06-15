namespace FlashCards
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
            btnPrev = new Button();
            btnNext = new Button();
            pnlCard = new Panel();
            lblAnswer = new Label();
            lblQuestion = new Label();
            cbAnswers = new CheckBox();
            btnLoad = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.Location = new Point(664, 558);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(150, 46);
            btnPrev.TabIndex = 3;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Location = new Point(820, 558);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 46);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = SystemColors.Window;
            pnlCard.Controls.Add(lblAnswer);
            pnlCard.Controls.Add(lblQuestion);
            pnlCard.Location = new Point(12, 12);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(958, 532);
            pnlCard.TabIndex = 1;
            pnlCard.TabStop = true;
            // 
            // lblAnswer
            // 
            lblAnswer.Dock = DockStyle.Bottom;
            lblAnswer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnswer.ForeColor = SystemColors.ControlDark;
            lblAnswer.Location = new Point(0, 347);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(958, 185);
            lblAnswer.TabIndex = 1;
            lblAnswer.Text = "answer";
            lblAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.Location = new Point(0, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(958, 532);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbAnswers
            // 
            cbAnswers.Anchor = AnchorStyles.Bottom;
            cbAnswers.AutoSize = true;
            cbAnswers.Location = new Point(426, 564);
            cbAnswers.Name = "cbAnswers";
            cbAnswers.Size = new Size(133, 36);
            cbAnswers.TabIndex = 2;
            cbAnswers.Text = "Answers";
            cbAnswers.UseVisualStyleBackColor = true;
            cbAnswers.CheckedChanged += cbAnswers_CheckedChanged;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoad.Location = new Point(12, 558);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 46);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 616);
            Controls.Add(btnLoad);
            Controls.Add(cbAnswers);
            Controls.Add(pnlCard);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            KeyPreview = true;
            Name = "MainWindow";
            Text = "Flash Cards";
            Load += MainWindow_Load;
            KeyDown += window_KeyDown;
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrev;
        private Button btnNext;
        private Panel pnlCard;
        private CheckBox cbAnswers;
        private Label lblAnswer;
        private Label lblQuestion;
        private Button btnLoad;
    }
}