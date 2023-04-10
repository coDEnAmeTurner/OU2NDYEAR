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
            var selectionFont = rchTxtBxContent.SelectionFont;
            rchTxtBxContent.SelectionFont = new Font(selectionFont.FontFamily, float.Parse(realSender.Text), selectionFont.Style);
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

        private void lstBxFontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fontFamilyName = (String) lstBxFontList.SelectedItem;
            float oldFontSize = (float)rchTxtBxContent.SelectionFont.Size;
            FontStyle oldFontStyle = rchTxtBxContent.SelectionFont.Style;
            rchTxtBxContent.SelectionFont = new Font(new FontFamily(fontFamilyName), oldFontSize, oldFontStyle);
        }

        private void rchTxtBxContent_MouseUp(object sender, MouseEventArgs e)
        {
            var thisRichTxtBx = sender as RichTextBox;
            hScrollBarRed.Value = thisRichTxtBx.SelectionColor.R;
            hScrollBarGreen.Value = thisRichTxtBx.SelectionColor.G;
            hScrollBarBlue.Value = thisRichTxtBx.SelectionColor.B;
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            HScrollBar colorScroll = (HScrollBar)sender;
            int oldA = rchTxtBxContent.SelectionColor.A;
            int oldG = rchTxtBxContent.SelectionColor.G;
            int oldB = rchTxtBxContent.SelectionColor.B;

            rchTxtBxContent.SelectionColor = Color.FromArgb(oldA, colorScroll.Value, oldG, oldB);
            panelResultColor.BackColor = Color.FromArgb(oldA, colorScroll.Value, oldG, oldB);
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            HScrollBar colorScroll = (HScrollBar)sender;
            int oldA = rchTxtBxContent.SelectionColor.A;
            int oldR = rchTxtBxContent.SelectionColor.R;
            int oldB = rchTxtBxContent.SelectionColor.B;

            rchTxtBxContent.SelectionColor = Color.FromArgb(oldA, oldR, colorScroll.Value, oldB);
            panelResultColor.BackColor = Color.FromArgb(oldA, oldR, colorScroll.Value, oldB);
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            HScrollBar colorScroll = (HScrollBar)sender;
            int oldA = rchTxtBxContent.SelectionColor.A;
            int oldR = rchTxtBxContent.SelectionColor.R;
            int oldG = rchTxtBxContent.SelectionColor.G;

            rchTxtBxContent.SelectionColor = Color.FromArgb(oldA, oldR, oldG, colorScroll.Value);
            panelResultColor.BackColor = Color.FromArgb(oldA, oldR, oldG, colorScroll.Value);
        }
    }
}