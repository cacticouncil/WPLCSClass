using System.Text;

namespace SimpleWindow
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_Submit(object sender, EventArgs e)
        {
            StringBuilder infoline = new StringBuilder();

            infoline.Append(tbFirstName.Text);
            infoline.Append(", ");
            infoline.Append(tbLastName.Text);
            infoline.Append(", ");
            infoline.Append(calBirth.SelectionRange.Start.ToShortDateString());

            if (String.IsNullOrEmpty(tbList.Text) == false)
                tbList.Text += System.Environment.NewLine;

            tbList.Text += infoline.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}