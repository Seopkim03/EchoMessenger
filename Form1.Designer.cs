namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstMessages = new ListBox();
            txtboxMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Regular", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 62);
            label1.TabIndex = 0;
            label1.Text = "Echo Messenger";
            // 
            // lstMessages
            // 
            lstMessages.Font = new Font("한컴 말랑말랑 Regular", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 21;
            lstMessages.Location = new Point(22, 74);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(750, 256);
            lstMessages.TabIndex = 1;
            // 
            // txtboxMessage
            // 
            txtboxMessage.Font = new Font("한컴 말랑말랑 Regular", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtboxMessage.Location = new Point(22, 360);
            txtboxMessage.Name = "txtboxMessage";
            txtboxMessage.Size = new Size(650, 32);
            txtboxMessage.TabIndex = 2;
            txtboxMessage.Text = "문자를 입력하세요";
            txtboxMessage.Click += txtboxMessage_Click;
            txtboxMessage.TextChanged += txtboxMessage_TextChanged;
            txtboxMessage.KeyPress += txtboxMessage_KeyPress;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.GradientInactiveCaption;
            btnSend.Font = new Font("한컴 말랑말랑 Regular", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(681, 360);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(91, 32);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtboxMessage);
            Controls.Add(lstMessages);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstMessages;
        private TextBox txtboxMessage;
        private Button btnSend;
    }
}
