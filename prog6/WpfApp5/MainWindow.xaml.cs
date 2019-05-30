using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using System.Threading;


namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();
        System.Windows.Threading.DispatcherTimer timer;
        bool lk = false;
        bool random_clicked = false;

        
        public MainWindow()
        {
            InitializeComponent();
            string[] dirs = Directory.GetFiles(@"c:\music", "*.mp3");
           
            foreach (string dir in dirs)
            {
                string name  = dir.Remove(0, 9);
                listBox.Items.Add(name);
            }
            listBox.SelectedIndex = 0;
            timerStart();
        }

            private void but_play_Click(object sender, RoutedEventArgs e)
            {
            random_clicked = false;
            play();
            
            }

        private void play()
        {
            if (player.Position == new TimeSpan(0, 0, 0, 0, 0))
            {
                player.Open(new Uri(@"c:\music\" + listBox.SelectedValue.ToString(), UriKind.Relative));
                player.MediaOpened += player_MediaOpened;
                
                player.Play();
            }
            else
            {
                player.Play();
            }
        }

        private void player_MediaEnded(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == listBox.Items.Count-1)
            {
                listBox.SelectedIndex = 0;
            }else
                listBox.SelectedIndex++;
            player.Position = new TimeSpan(0,0,0,0);
            
            play();
        }

        private void player_MediaOpened(object sender, EventArgs e)
        {
            sl_time.Maximum = player.NaturalDuration.TimeSpan.TotalMilliseconds;
            l_time.Content = player.NaturalDuration.TimeSpan.ToString();
            
        }

        private void listBox_SelectionChanged(object sender, EventArgs e)
        {
            player.Stop();
            play();
        }

        private void sl_volume_ValueChanged(object sender, DragCompletedEventArgs e)
        {
            player.Volume = sl_volume.Value;
        }

        private void sl_time_ValueChanged(object sender, DragCompletedEventArgs e)
        {
            lk = false;
            int SliderValue = (int)sl_time.Value;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            player.Position = ts;
        }

        private void but_pause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void but_stop_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void timerStart()
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            if (lk == false)
                sl_time.Value = player.Position.TotalMilliseconds;
            player.MediaEnded += player_MediaEnded;
            l_cur_time.Content = player.Position.Minutes + ":" + player.Position.Seconds;
        }

        private void sl_time_ValueChanged_1(object sender, DragStartedEventArgs e)
        {
            lk = true;
        }

        private void But_shuffle_Click(object sender, RoutedEventArgs e)
        {
            random_clicked = true;
            
            Random rand = new Random();
            int a = rand.Next(listBox.Items.Count);
            while(a == listBox.SelectedIndex)
                a = rand.Next(listBox.Items.Count);
            listBox.SelectedIndex = a;
            player.Stop();
            sl_time.Value = 0;

            play();

            //string cur = listBox.SelectedItem.ToString();
            //int curnum = listBox.SelectedIndex;
            //listBox.SelectedItem = listBox.Items[0];
            ////listBox.Items.RemoveAt(0);
            //listBox.Items.Insert(0, cur);
            //listBox.Items.RemoveAt(curnum + 1);
            //listBox.SelectedIndex = 0;
            //Random rand = new Random();
            //for(int i = 1; i<listBox.Items.Count; i++)
            //{
            //    //listBox.Items.Insert(rand.Next(i, listBox.Items.Count-1), listBox.Items[i].ToString());
            //    //listBox.Items.RemoveAt(i);
            //    listBox.SelectedItem = i;
            //    listBox.Items.(rand.Next(1, listBox.Items.Count - 1));
            //}

            //listBox.SelectedItem = 0;


            //////string[] H =new string[listBox.Items.Count-1];

            //////for (int i = 1; i < listBox.Items.Count-1; i++)
            //////{
            //////    H[i] = listBox.Items[i].ToString();
            //////}

            //////for (int i = H.Length - 1; i > 0; i--)
            //////{
            //////    int j = rand.Next(i);
            //////    string tmp = H[i];
            //////    H[i] = H[j];
            //////    H[j] = tmp;
            //////}
            //////for (int i = 1; i < listBox.Items.Count; i++)
            //////    listBox.Items.RemoveAt(i);

            //////for (int i=0; i<H.Length; i++)
            //////listBox.Items.Add(H[i]);

            //for (int i = 1; i < listBox.Items.Count; i++)
            //    if (listBox.Items[i].ToString() == "System.String[]")
            //        listBox.Items.RemoveAt(i);
        }        
    }
}
