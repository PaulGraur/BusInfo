namespace BusInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addControl1.Visible = false;
            viewControl1.Visible = false;
            editControl1.Visible = false;
            boughtTicketsControl1.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SetActivePanel(addControl1);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            viewControl1.InsertDataIntoDataGridView();
            SetActivePanel(viewControl1);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            editControl1.InsertDataIntoDataGridView();
            SetActivePanel(editControl1);
        }

        private void BoughtTicketsButton_Click(object sender, EventArgs e)
        {
            boughtTicketsControl1.InsertDataIntoDataGridView();
            SetActivePanel(boughtTicketsControl1);
        }
        public void SetActivePanel(UserControl control)
        {
            addControl1.Visible = false;
            editControl1.Visible = false;
            viewControl1.Visible = false;
            boughtTicketsControl1.Visible = false;

            control.Visible = true;
        }
    }
}