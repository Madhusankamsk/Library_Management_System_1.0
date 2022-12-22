namespace Library_Management_System_1._0
{
    public partial class Home : Form
    {
        Controllers.UserControlTotalBooks totalBooks = new Controllers.UserControlTotalBooks();
        Controllers.UserControlCategories categories = new Controllers.UserControlCategories();
        Controllers.UserControlAddNewBooks addNewBooks = new Controllers.UserControlAddNewBooks();
        Controllers.UserControlMemberships menberships = new Controllers.UserControlMemberships();
        Controllers.UserControlRemoveBooks removeBooks = new Controllers.UserControlRemoveBooks();
        Controllers.UserControlAuthorizing authorizing = new Controllers.UserControlAuthorizing();
        Controllers.UserControlAboutUs aboutUs = new Controllers.UserControlAboutUs();
        Controllers.UserControlReturns returns = new Controllers.UserControlReturns();
        Controllers.UserControlBorrows borrows = new Controllers.UserControlBorrows();





        public Home()
        {
            InitializeComponent();
        }

        private void buttonTotalBooks_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(totalBooks);
            totalBooks.Dock = DockStyle.Fill;
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(categories);
            categories.Dock = DockStyle.Fill;
        }

        private void buttonAddNewBooks_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(addNewBooks);
            addNewBooks.Dock = DockStyle.Fill;
        }

        private void buttonMemberships_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(menberships);
            menberships.Dock = DockStyle.Fill;
        }

        private void buttonRemoveBooks_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(removeBooks);
            removeBooks.Dock = DockStyle.Fill;
        }

        private void buttonAuthorizing_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(authorizing);
            authorizing.Dock = DockStyle.Fill;
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(aboutUs);
            aboutUs.Dock = DockStyle.Fill;
        }

        private void buttonBorrows_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(borrows);
            borrows.Dock = DockStyle.Fill;
        }

        private void buttonReturns_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(returns);
            returns.Dock = DockStyle.Fill;
        }
    }
}