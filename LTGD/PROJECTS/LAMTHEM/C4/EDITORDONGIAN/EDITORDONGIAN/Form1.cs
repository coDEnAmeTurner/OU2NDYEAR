namespace EDITORDONGIAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var font in FontFamily.Families)
                lstBxFontList.Items.Add(font.Name);

            for (int i = 0; i < 73; i++)
                cmbBxSize.Items.Add(i);
            cmbBxSize.SelectedIndex = 12;
        }

        private void cmbBxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var realSender = (ComboBox)sender;
            rchTxtBxContent.SelectionFont = new Font(rchTxtBxContent.SelectionFont.FontFamily, 
                float.Parse(realSender.SelectedItem.ToString()), rchTxtBxContent.SelectionFont.Style);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            rchTxtBxContent.SelectionFont = new Font(rchTxtBxContent.SelectionFont.FontFamily,
                rchTxtBxContent.SelectionFont.Size, FontStyle.Bold);

        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            rchTxtBxContent.SelectionFont = new Font(rchTxtBxContent.SelectionFont.FontFamily,
                rchTxtBxContent.SelectionFont.Size, rchTxtBxContent.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            rchTxtBxContent.SelectionFont = new Font(rchTxtBxContent.SelectionFont.FontFamily,
                rchTxtBxContent.SelectionFont.Size, rchTxtBxContent.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void rchTxtBxContent_MouseUp(object sender, MouseEventArgs e)
        {
            var thisRichTxtBx = sender as RichTextBox;
            hScrollBarRed.Value = thisRichTxtBx.SelectionColor.R;
            hScrollBarGreen.Value = thisRichTxtBx.SelectionColor.G;
            hScrollBarBlue.Value = thisRichTxtBx.SelectionColor.B;
        }
    }
}