using System.Diagnostics;

namespace cs_form_230622
{
    public partial class Form1 : Form
    {

        OpenFileDialog �t�@�C�����J���_�C�A���O = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();
        }

        private void �L�����Z���{�^��_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ESC ��������܂���");

            �ǉ��{�^��_Click(null, null);

        }

        private void �A�N�Z�v�g�{�^��_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Enter ��������܂���");

        }

        private void �ǉ��{�^��_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("�ǉ��{�^����������܂���");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // += �͂����ł��ǉ��ł��܂�
            // ��̃{�^���ŕ����̃C�x���g���N���ł��܂�
            �A�N�Z�v�g�{�^��.Click += �ǉ��{�^��_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            �t�@�C�����J���_�C�A���O.Filter = "�S��|*.*|�e�L�X�g�t�@�C��|*.txt|�摜|*.png;*.jpg;*.jpeg";
            �t�@�C�����J���_�C�A���O.Title = "Select a Text File";

            // ���ϐ������o���ăp�X�ɗ��p����
            string username = System.Environment.GetEnvironmentVariable("USERNAME");

            �t�@�C�����J���_�C�A���O.InitialDirectory = $@"C:\Users\{username}\Pictures\a";

            if (�t�@�C�����J���_�C�A���O.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(�t�@�C�����J���_�C�A���O.FileName);
            }

        }
    }
}