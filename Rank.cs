using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media;

namespace Exercise1
{
    public partial class Rank : Form
    {
        public static List<int> Points = new List<int>();

        MediaPlayer PlayerTemp = new MediaPlayer();

        TimeSpan _currentPosition = new TimeSpan(0, 0 , 0);

        Int32 ID = 0;
        Int32 ansRight = 0;
        public int _score = 0;

        private String[] Fruits = { "avocado", "coconut", "dragonfruit", "grapes", "jackfruit", "lychee", "mango", "pineapple", "rambutan", "starfruit" };
        private String[] Animals = { "bear", "deer", "donkey", "fox", "hippopotamus", "kangaroo", "lion", "ostrich", "panda", "turtle" };
        private String[] Vehicles = { "airplane", "bicycle", "bus", "canoe", "helicopter", "motorbike", "taxi", "train", "truck", "van" };
        private String[] Households = { "air conditioner", "bed", "couch", "curtains", "cushion", "sofa", "stove", "television", "wardrobe", "washing machine" };

        public Rank(TimeSpan CurrentPosition)
        {
            BackgroundImage = new Bitmap(@"../background/play.jpg");
            _currentPosition = CurrentPosition;
            try
            {
                waitForSound();

                InitializeComponent();
                btn_sound_on.BackgroundImage = Image.FromFile(@"../button/sound_on.png");
                btn_sound_off.BackgroundImage = Image.FromFile(@"../button/sound_off.png");
                btn_topic.BackgroundImage = Image.FromFile(@"../button/home.png");
                btn_exit.BackgroundImage = Image.FromFile(@"../button/exit.png");

                txt_first.Text = Points[0].ToString();
                txt_second.Text = Points[1].ToString();
                txt_third.Text = Points[2].ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private async Task waitForSound()
        {
            var SoundUri = new Uri(Directory.GetParent(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!)!.ToString() + "/sound/bg.wav");
            PlayerTemp.Open(SoundUri);
            PlayerTemp.Position = _currentPosition;
            if (!Main.isPaused) PlayerTemp.Play();
            PlayerTemp.MediaEnded += loopSound!;
        }

        private void loopSound(Object sender, EventArgs e)
        {
            PlayerTemp.Position = TimeSpan.Zero;
            PlayerTemp.Play();
        }

        private void btn_sound_off_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Pause sound");
            PlayerTemp.Pause();
            Main.isPaused = true;
        }

        private void btn_sound_on_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Play sound");
            PlayerTemp.Play();
            Main.isPaused = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void btn_topic_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Topic(CurrentPosition);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }

}