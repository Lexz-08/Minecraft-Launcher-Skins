namespace Minecraft_Launcher_Skins
{
    public partial class Form1 : Form
    {
        private static readonly string SKINS = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}" +
            $"\\AppData\\Roaming\\.minecraft\\assets\\skins";

        public Form1()
        {
            InitializeComponent();

			listBox1.Items.Clear();
            listBox1.Items.AddRange([.. Directory.GetDirectories(SKINS).Select(f => new DirectoryInfo(f).Name)]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange([..
                Directory.GetFiles($"{SKINS}\\{listBox1.SelectedItem}")
                .Select(f => Path.GetFileName(f))
                ]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($"{SKINS}\\{listBox1.SelectedItem}\\{listBox2.SelectedItem}");
        }
    }
}
