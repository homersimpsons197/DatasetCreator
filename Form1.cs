using System.Windows.Forms;

namespace Text_Processor
{
    public partial class Form1 : Form
    {
        Text t;
        public static bool rChecked;
        public static bool aChecked;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtxtWord.EnableContextMenu();
            t = new Text(this);
        }

        private void btnDup_Click(object sender, EventArgs e)
        {
            t.Distinct();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            t.Sort();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            t.Variation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtWord.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            t.SaveAs();
        }

        private void rtxtWord_TextChanged(object sender, EventArgs e)
        {
            t.LineCount();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if(chReplace.Checked || chAdd.Checked)
            {
                t.RegexWord(rChecked, aChecked);
            }
            else
            {
                MessageBox.Show("\"Replace\" or \"Add\" must be checked!");
            }
        }

        private void btnTxtClear_Click(object sender, EventArgs e)
        {
            t.TextBoxClear();
        }

        private void btnRemovedClear_Click(object sender, EventArgs e)
        {
            t.RemovedDuplicates();
        }

        private void chReplace_CheckedChanged(object sender, EventArgs e)
        {
            rChecked = !rChecked;

            if (rChecked)
            {
                chAdd.Checked = false;
            }
        }

        private void chAdd_CheckedChanged(object sender, EventArgs e)
        {
            aChecked = !aChecked;

            if (aChecked)
            {
                chReplace.Checked = false;
            }
        }
    }
}