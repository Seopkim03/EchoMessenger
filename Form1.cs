namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg = txtboxMessage.Text;
            lstMessages.Items.Add(typed_msg);
            txtboxMessage.Clear();
        }

        private void txtboxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMessage_Click(object sender, EventArgs e)
        {
            txtboxMessage.Clear();
        }
    }
}
