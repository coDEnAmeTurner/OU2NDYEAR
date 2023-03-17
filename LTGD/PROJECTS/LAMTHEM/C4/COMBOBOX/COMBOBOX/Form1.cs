using static System.Windows.Forms.ListBox;

namespace COMBOBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBxChuoi.Text == "")
                    throw new FormatException("Phai nhap chuoi");
                lstBxTrai.Items.Add(txtBxChuoi.Text);
                txtBxChuoi.Text = "";

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonQuaPhai_Click(object sender, EventArgs e)
        {
            foreach (var item in lstBxTrai.SelectedItems)
                lstBxPhai.Items.Add(item);

            for (int i = lstBxTrai.SelectedItems.Count - 1; i >= 0; i--)
                lstBxTrai.Items.Remove(lstBxTrai.Items[i]);
        }

        private void buttonQuaTrai_Click(object sender, EventArgs e)
        {
            lstBxTrai.Items.Add(lstBxPhai.SelectedItem);

            lstBxPhai.Items.Remove(lstBxPhai.SelectedItem);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for (int i = lstBxTrai.SelectedItems.Count - 1; i >= 0; i--)
                lstBxTrai.Items.Remove(lstBxTrai.Items[i]);

            for (int i = lstBxPhai.SelectedItems.Count - 1; i >= 0; i--)
                lstBxPhai.Items.Remove(lstBxPhai.Items[i]);
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            lstBxTrai.Items.Clear();
            lstBxPhai.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBxChonMau.Items.Add(Color.Cyan);
            cmbBxChonMau.Items.Add(Color.Red);
            cmbBxChonMau.Items.Add(Color.BlueViolet);
            cmbBxChonMau.Items.Add(Color.GreenYellow);
            cmbBxChonMau.Items.Add(Color.CadetBlue);
            cmbBxChonMau.Items.Add(Color.MediumAquamarine);
            cmbBxChonMau.SelectedIndex = 0;

            lstBxPhai.BackColor = (Color)cmbBxChonMau.SelectedItem;
        }

        private void cmbBxChonMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxPhai.BackColor = (Color)(((ComboBox)sender).SelectedItem);

        }
    }
}