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
            if (!String.IsNullOrEmpty(txtboxMessage.Text) && !String.IsNullOrWhiteSpace(txtboxMessage.Text)) //텍스트박스가 비어있거나 "문자를 입력하세요"일 때는 메시지를 보내지 않도록 함
            {
                string typed_msg = txtboxMessage.Text;
                string timeStamp = DateTime.Now.ToString("[HH:mm:ss]"); //현재 시간을 가져옴
                lstMessages.Items.Add($"{timeStamp} {typed_msg}");//입력한 메시지를 리스트박스에 추가, 메시지 뒤에 현재 시간을 [HH:mm:ss] 형식으로 표시
                txtboxMessage.Clear();//문자를 보내면 텍스트박스 초기화
                txtboxMessage.Select(); //텍스트박스에 커서 위치시키기
                msgCount.Text = $"총 메시지 수: {lstMessages.Items.Count}"; //메시지 수를 표시하는 카운터의 숫자를 올림
            }
        }

        private void txtboxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMessage_Click(object sender, EventArgs e)
        {
            txtboxMessage.Clear(); //텍스트박스를 클릭하면 "문자를 입력하세요" 사라짐
        }

        private void txtboxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSend_Click(sender, e); //엔터키를 누르면 btnSend_Click 이벤트가 발생하도록 함
            }
        }
    }
}
