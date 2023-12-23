using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        string fileName;
        bool saveFile;
        ITools tools = new Tools();

        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog1.DefaultExt = "txt";
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                fileName = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fileName, Body.Text);
            this.Text = fileName;
            saveFile = true;
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            fileName = null;
            save_Click(null, null);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == false)
            {
                DialogResult result;
                result = MessageBox.Show("do you want save file ?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    save_Click(null, null);
            }
            Body.Text = "";
            this.Text = "notepad";
            saveFile = true;
            fileName = null;
        }

        private void Body_TextChanged(object sender, EventArgs e)
        {
            saveFile = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == false)
            {
                DialogResult result;
                result = MessageBox.Show("do you want save fille ?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    save_Click(null, null);
            }

            openFileDialog1.Filter = "Text Files (*.txt)|*.txt;*.docx";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;

            fileName = openFileDialog1.FileName;
            Body.Text = System.IO.File.ReadAllText(fileName);
            this.Text = fileName;
            saveFile = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile == false)
            {
                DialogResult result;
                result = MessageBox.Show("do you want save fille ?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    save_Click(null, null);
            }

            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Body.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Body.SelectedText);
            Body.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.Text = tools.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.Text = tools.Redo();
        }

        private void Body_KeyUp(object sender, KeyEventArgs e)
        {
            tools.Insert(Body.Text);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find form = new Find(this);
            form.Show();
        }

        public void Find(string str)
        {
            int index = Body.Text.IndexOf(str, 0);
            if (index == -1)
                MessageBox.Show("not found");

            Body.SelectionStart = index;
            Body.SelectionLength = str.Length;
            Body.Focus();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Body.Font = fontDialog1.Font;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Body.ForeColor = colorDialog1.Color;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body.BackColor = Color.Red;
        }

        private void ChangeBackColor(object sender, EventArgs e)
        {
            Body.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.File.WriteAllText(@"e:\Practice\config.txt", Body.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"e:\Practice\config.txt"))
            {
                string color = System.IO.File.ReadAllText(@"e:\Practice\config.txt");
                Body.BackColor = Color.FromName(color);
            }
            saveFile = true;
        }
    }
}