using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media;

namespace Exercise1
{
    public partial class Play : Form
    {
        MediaPlayer PlayerTemp = new MediaPlayer();

        TimeSpan _currentPosition = new TimeSpan(0, 0 , 0);

        Int32 ID = 0;
        Int32 ansRight = 0;

        private String _topic;
        private String[] Fruits = { "avocado", "coconut", "dragonfruit", "grapes", "jackfruit", "lychee", "mango", "pineapple", "rambutan", "starfruit" };
        private String[] Animals = { "bear", "deer", "donkey", "fox", "hippopotamus", "kangaroo", "lion", "ostrich", "panda", "turtle" };
        private String[] Vehicles = { "airplane", "bicycle", "bus", "canoe", "helicopter", "motorbike", "taxi", "train", "truck", "van" };
        private String[] Households = { "air conditioner", "bed", "couch", "curtains", "cushion", "sofa", "stove", "television", "wardrobe", "washing machine" };
        private String[] Quests = new String[10];

        public Play(TimeSpan CurrentPosition, string Topic)
        {
            BackgroundImage = new Bitmap(@"../background/play.jpg");
            _currentPosition = CurrentPosition;
            try
            {
                waitForSound();

                this._topic = Topic;

                InitializeComponent();
                btn_sound_on.BackgroundImage = Image.FromFile(@"../button/sound_on.png");
                btn_sound_off.BackgroundImage = Image.FromFile(@"../button/sound_off.png");
                btn_back.BackgroundImage = Image.FromFile(@"../button/back.png");
                btn_exit.BackgroundImage = Image.FromFile(@"../button/exit.png");

                if (this._topic == "Animal") Array.Copy(Animals, Quests, Animals.Length);
                else if (this._topic == "Fruit") Array.Copy(Fruits, Quests, Fruits.Length);
                else if (this._topic == "Vehicle") Array.Copy(Vehicles, Quests, Vehicles.Length);
                else if (this._topic == "Household") Array.Copy(Households, Quests, Households.Length);
               
                shuffleQuests(Quests);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void shuffleQuests(String[] quests)
        {
            Random _random = new Random();
            for (int i = 0; i < quests.Length; i++)
                swap(ref quests[i], ref quests[i + _random.Next(quests.Length - i)]);    
        }

        private void swap(ref String a, ref String b)
        {
            String temp = a;
            a = b;
            b = temp;
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
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var CurrentPosition = PlayerTemp.Position;
            PlayerTemp.MediaEnded -= loopSound!;
            this.Hide();
            PlayerTemp.Stop();
            var form = new Topic(CurrentPosition);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            pic_quest.BackgroundImage = Image.FromFile(@"../topic/" + this._topic.ToLower() + "/" + Quests[ID] + ".jpg");
        }

        private void txt_answer_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ID < Quests.Length - 1)
                {
                    if (txt_answer.Text.Trim().ToLower() == Quests[ID]) ansRight += 1;
                    ID++;
                    txt_answer.Clear();
                    if (pic_quest.BackgroundImage != null) pic_quest.BackgroundImage.Dispose();
                    pic_quest.BackgroundImage = null;

                    var path = "../topic/" + this._topic.ToLower() + "/" + Quests[ID] + ".jpg";
                    
                    FileInfo file = new FileInfo(path);

                    if (file.Exists)
                        pic_quest.BackgroundImage = Image.FromFile("../topic/" + this._topic.ToLower() + "/" + Quests[ID] + ".jpg");
                }
                else
                {
                    if (txt_answer.Text.Trim().ToLower() == Quests[ID]) ansRight += 1;
                    string Congrats = "Congratulations!\nYou have done the game with the result: " + ansRight.ToString() + "/ 10";
                    MessageBox.Show(Congrats, "Result", MessageBoxButtons.OK);
                    Rank.Points.Add(ansRight);
                    Rank.Points.Sort();
                    Rank.Points.Reverse();
                    var CurrentPosition = PlayerTemp.Position;
                    PlayerTemp.MediaEnded -= loopSound!;
                    this.Hide();
                    PlayerTemp.Stop();
                    var form = new Rank(CurrentPosition);
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
                
                e.Handled = true;
            }
        }
    }
}