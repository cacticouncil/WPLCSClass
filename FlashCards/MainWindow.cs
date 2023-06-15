namespace FlashCards
{
    public partial class MainWindow : Form
    {
        private List<string> mQuestions = new List<string>();
        private List<string> mAnswers = new List<string>();
        private bool mShowAnswers;
        private int mIndex;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = "";
            lblAnswer.Text = "";

            mShowAnswers = false;
            mIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter to only display .csv files
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            // reset lists
            mQuestions.Clear();
            mAnswers.Clear();

            using (StreamReader reader = new StreamReader(openFileDialog.FileName))
            {
                string? line;

                // read header
                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Split(',');
                    mQuestions.Add(tokens[0]);
                    mAnswers.Add(tokens[1]);
                }
            }

            if (mQuestions.Count == 0)
                return;

            mIndex = 0;
            displayCard();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextCard();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevCard();
        }

        private void cbAnswers_CheckedChanged(object sender, EventArgs e)
        {
            mShowAnswers = cbAnswers.Checked;

            displayCard();
        }

        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            if (mQuestions.Count == 0)
                return;

            if (e.KeyCode == Keys.A)
            {
                if (String.IsNullOrEmpty(lblAnswer.Text))
                    lblAnswer.Text = mAnswers[mIndex];
                else
                    lblAnswer.Text = "";

                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                nextCard();

                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                prevCard();

                e.Handled = true;
            }
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (!msg.HWnd.Equals(Handle) &&
        //        (keyData == Keys.Left || keyData == Keys.Right ||
        //         keyData == Keys.Up   || keyData == Keys.Down))
        //        return true;

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private void nextCard()
        {
            if (mQuestions.Count == 0)
                return;

            if (mIndex == mQuestions.Count - 1)
                return;

            mIndex++;
            displayCard();
        }

        private void prevCard()
        {
            if (mQuestions.Count == 0)
                return;

            if (mIndex == 0)
                return;

            mIndex--;
            displayCard();
        }

        private void displayCard()
        {
            lblQuestion.Text = mQuestions[mIndex];

            if (mShowAnswers)
                lblAnswer.Text = mAnswers[mIndex];
            else
                lblAnswer.Text = "";
        }
    }
}