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
                string typed_msg = txtboxMessage.Text.Trim(); //불필요한 공백 삭제
                string timeStamp = DateTime.Now.ToString("[HH:mm:ss]"); //현재 시간을 가져옴
                lstMessages.Items.Add($"{timeStamp} {typed_msg}");//입력한 메시지를 리스트박스에 추가, 메시지 뒤에 현재 시간을 [HH:mm:ss] 형식으로 표시
                txtboxMessage.Clear();//문자를 보내면 텍스트박스 초기화
                txtboxMessage.Select(); //텍스트박스에 커서 위치시키기
                msgCount.Text = $"총 메시지 수: {lstMessages.Items.Count}"; //메시지 수를 표시하는 카운터의 숫자를 올림
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMessages.SelectedIndex != -1)  //항목이 선택되었는지 확인 (SelectedIndex가 -1이면 선택 안 된 상태)
                {
                    lstMessages.Items.RemoveAt(lstMessages.SelectedIndex); //선택된 항목의 인덱스를 이용해 삭제
                }
                else
                {
                    MessageBox.Show("삭제할 메시지를 목록에서 먼저 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 선택하지 않고 삭제를 눌렀을 때 사용자에게 알림 (예외 상황 처리)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류가 발생했습니다: {ex.Message}");  //혹시 모를 기타 에러 발생 시 프로그램이 꺼지지 않게 처리
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstMessages.Items.Count > 0) //리스트박스에 삭제할 항목이 있는지 확인
            {
                //사용자에게 정말 삭제할 것인지 물어봄 (확인 메시지 창)
                if (MessageBox.Show("모든 대화 기록을 삭제하시겠습니까?", "전체 초기화", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstMessages.Items.Clear(); //리스트박스의 모든 내용을 한 번에 지움
                    txtboxMessage.Focus(); //삭제 후 입력창으로 커서 이동
                }
            }
            else
            {
                MessageBox.Show("삭제할 대화 기록이 없습니다."); //삭제할 내용이 없을 때 안내
            }
        }


    }
}
