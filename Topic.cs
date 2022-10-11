using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media;

namespace Exercise1
{
    public partial class Topic : Form
    {

        MediaPlayer PlayerTemp = new MediaPlayer();

        TimeSpan _currentPosition = new TimeSpan(0, 0 , 0);

        public Topic(TimeSpan CurrentPosition)
        {
            BackgroundImage = new Bitmap(@"../background/topic.png");
            _currentPosition = CurrentPosition;

            try
            {

                waitForSound();

                InitializeComponent();
                btn_sound_on.BackgroundImage = Image.FromFile(@"../button/sound_on.png");
                btn_sound_off.BackgroundImage = Image.FromFile(@"../button/sound_off.png");
                btn_back.BackgroundImage = Image.FromFile(@"../button/back.png");

                btn_fruit.BackgroundImage = Image.FromFile(@"../topic/fruit.jpg");
                btn_vehicle.BackgroundImage = Image.FromFile(@"../topic/vehicle.jpg");
                btn_color.BackgroundImage = Image.FromFile(@"../topic/color.jpg");
                btn_animal.BackgroundImage = Image.FromFile(@"../topic/animal.jpg");
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
            PlayerTemp.Position = _currentPosition;
            Debug.WriteLine("Play sound");
            PlayerTemp.Play();
            Main.isPaused = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Main(CurrentPosition, Main.isPaused);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btn_fruit_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Play(CurrentPosition, "Fruit");
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btn_vehicle_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Play(CurrentPosition, "Vehicle");
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btn_animal_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Play(CurrentPosition, "Animal");
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Play(CurrentPosition, "Household");
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}