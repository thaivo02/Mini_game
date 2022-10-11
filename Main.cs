using English_game;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media;

namespace Exercise1
{

    public partial class Main : Form
    {

        private bool dictIsOpened = false;

        public static bool isPaused = false;

        public Dictionaries DictForm = new Dictionaries();

        MediaPlayer PlayerTemp = new MediaPlayer();

        TimeSpan _currentPosition = new TimeSpan(0, 0, 0);

        public Main(TimeSpan CurrentPosition, bool isPaused)
        {
            BackgroundImage = new Bitmap(@"../background/bg.jpg");
            _currentPosition = CurrentPosition;

            try
            {
                waitForSound();

                InitializeComponent();
                btn_sound_on.BackgroundImage = Image.FromFile(@"../button/sound_on.png");
                btn_sound_off.BackgroundImage = Image.FromFile(@"../button/sound_off.png");
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
            if (!isPaused) PlayerTemp.Play();
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
            isPaused = true;
        }

        private void btn_sound_on_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Play sound");
            PlayerTemp.Play();
            isPaused = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            DictForm.Hide();
            PlayerTemp.Stop();
            var form = new Topic(CurrentPosition);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dict_Click(object sender, EventArgs e)
        {
            DictForm = new Dictionaries();
            dictIsOpened = true;
            DictForm.Show();
        }
    }
}