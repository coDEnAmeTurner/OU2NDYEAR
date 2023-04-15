using System.Diagnostics;

namespace LISTVIEWDEMO
{
    public partial class ListView : Form
    {
        private string[] dsDir;
        private string[] dsFile;

        public ListView()
        {
            InitializeComponent();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            var dsDrive = Directory.GetLogicalDrives();
            comboBox1.Items.AddRange(dsDrive);
            comboBox1.SelectedIndex = 0;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var idx = listView1.SelectedIndices[0];
            listView1.Items.Clear();
            if (idx < dsDir.Length)
                addDirFileToListView(dsDir[idx]);
            else
                openFile(dsFile[idx - dsDir.Length]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var path = comboBox1.SelectedItem.ToString();
            listView1.Items.Clear();
            addDirFileToListView(path);
        }

        private void addDirFileToListView(string dirPath)
        {
            if (dirPath != null)
            {
                dsDir = null;
                dsFile = null;
                dsDir = Directory.GetDirectories(dirPath);
                dsFile = Directory.GetFiles(dirPath);

                if (dsDir.Length != 0)
                    foreach (String item in dsDir)
                    {
                        var dirInfo = new DirectoryInfo(item);
                        var lvi = new ListViewItem(dirInfo.Name);
                        lvi.ImageIndex = 0;
                        lvi.SubItems.Add("");
                        var time = dirInfo.CreationTime;
                        lvi.SubItems.Add(time.ToString("dd-MM-yyyy"));
                        listView1.Items.Add(lvi);
                    }

                if (dsFile.Length != 0)
                    foreach (String item in dsFile)
                    {
                        var fileInfo = new FileInfo(item);
                        var lvi = new ListViewItem(fileInfo.Name);
                        lvi.ImageIndex = 1;
                        lvi.SubItems.Add(String.Format("{0:0.#}", fileInfo.Length / 1024.0f));
                        var time = fileInfo.CreationTime;
                        lvi.SubItems.Add(time.ToString("dd-MM-yyyy"));
                        listView1.Items.Add(lvi);
                    }
            }

        }

        private void openFile(string filePath)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }
    }
}