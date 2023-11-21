using Model;

namespace SimpleSystem
{
    public partial class Form1 : Form
    {
        private readonly IDB<God> _gods;
        public Form1()
        {
            InitializeComponent();
            _gods = new FileDB("gods.in");
            gods.DataSource = _gods.ReadAll();
        }

        private void add_Click(object sender, EventArgs e)
        {
            _gods.Create(new God(name.Text, mythology.Text, (int)children.Value, isImmortal.Checked));
            gods.DataSource = _gods.ReadAll();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int row = gods.SelectedCells[0].RowIndex;
            _gods.Delete(_gods.ReadAll()[row].Id);
            gods.DataSource = _gods.ReadAll();
        }

        private void update_Click(object sender, EventArgs e)
        {
            God god = _gods.ReadAll()[gods.SelectedCells[0].RowIndex];
            god.Name = name.Text;
            god.ChildrenCount = (int)children.Value;
            god.IsImmortal = isImmortal.Checked;
            god.Mythology = mythology.Text;
            gods.DataSource = _gods.ReadAll();
        }
    }
}