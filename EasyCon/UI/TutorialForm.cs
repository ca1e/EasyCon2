using System.Windows.Forms;

namespace EasyCon.UI
{
    public partial class TutorialForm : Form
    {
        public TutorialForm()
        {
            InitializeComponent();
        }

        private void TutorialForm_Load(object sender, System.EventArgs e)
        {

            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = 0;
        }

        private void TutorialForm_Deactivate(object sender, System.EventArgs e)
        {
            try
            {
                this.Opacity = 0.8;
            }
            catch { };
        }

        private void TutorialForm_Activated(object sender, System.EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
