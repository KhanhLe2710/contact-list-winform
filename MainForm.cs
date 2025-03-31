namespace ContactList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addForm = new AddContactForm();
            addForm.ShowDialog();
        }
    }
}
