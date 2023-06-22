using System.Diagnostics;

namespace cs_form_230622
{
    public partial class Form1 : Form
    {

        OpenFileDialog ファイルを開くダイアログ = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();
        }

        private void キャンセルボタン_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ESC が押されました");

            追加ボタン_Click(null, null);

        }

        private void アクセプトボタン_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Enter が押されました");

        }

        private void 追加ボタン_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("追加ボタンが押されました");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // += はいくつでも追加できます
            // 一つのボタンで複数のイベントを起動できます
            アクセプトボタン.Click += 追加ボタン_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ファイルを開くダイアログ.Filter = "全て|*.*|テキストファイル|*.txt|画像|*.png;*.jpg;*.jpeg";
            ファイルを開くダイアログ.Title = "Select a Text File";

            // 環境変数を取り出してパスに利用する
            string username = System.Environment.GetEnvironmentVariable("USERNAME");

            ファイルを開くダイアログ.InitialDirectory = $@"C:\Users\{username}\Pictures\a";

            if (ファイルを開くダイアログ.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(ファイルを開くダイアログ.FileName);
            }

        }
    }
}