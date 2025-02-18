namespace LuckyStreakAlcoholInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoBeerBot_CheckedChanged(object sender, EventArgs e)
        {
            cmbBrands.Visible = rdoBeerBot.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBrands.Visible = false;
            rdoBeerBot.Checked = false;

            // Populate ComboBox with beer brands
            cmbBrands.Items.Add("Bud Light");
            cmbBrands.Items.Add("Budweiser");
             cmbBrands.Items.Add("Busch Light");
            cmbBrands.Items.Add("Coors Light");
            cmbBrands.Items.Add("Miller Lite");
            cmbBrands.Items.Add("Corona");
            cmbBrands.Items.Add("Heineken");
        }
    }
}
