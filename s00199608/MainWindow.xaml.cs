using System;
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
using System.Diagnostics;

namespace s00199608
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Anime> AnimeList = new List<Anime>();
        List<Anime> FilteredList = new List<Anime>();
        List<Review> ReviewList = new List<Review>();
        public MainWindow()
        {
            InitializeComponent();
            Anime Dorohedoro = new Anime("Dorohedoro", "Hole—a dark, decrepit, and disorderly district where the strong prey on the weak and death is an ordinary occurrence—is all but befitting of the name given to it. A realm separated from law and ethics, it is a testing ground to the magic users who dominate it. As a race occupying the highest rungs of their society, the magic users think of the denizens of Hole as no more than insects. Murdered, mutilated, and made experiments without a second thought, the powerless Hole dwellers litter the halls of Hole's hospital on a daily basis.",new DateTime(2020,5,28), @"https://cdn.discordapp.com/attachments/762710909406937128/837095977373925406/dorhedoro.png", "Horror",1);
            Anime Parasyte = new Anime("Parasyte The Maxim", "17-year-old Shinichi Izumi is partially infected by a Parasyte; monsters that butcher and consume humans. He must learn to co-exist with the creature if he is to survive both the life of a Parasyte and human, as part monster, part person.", new DateTime(2014,10,9), @"https://cdn.discordapp.com/attachments/762710909406937128/837096315414380554/91grOivhDdL.png", "Horror",2);
            Anime Naruto = new Anime("Naruto", "On the day of Naruto Uzamaki's birth the village of Konoha was attacked by the 9-tailed fox demon. In order to protect the village Naruto's father the 4th hokage sacrificed his life and sealed the demon in his new born son. 13 years later Naruto graduates the ninja academy and becomes a shinobi with goal to be the hokage of the village. Joining him are rival Sasuke Uchiha who attempts to gain power to avenge his clan after they were murdered by his older brother Itachi. And Sakura Haruno who is Naruto's love interest who of course loves his rival Sasuke. But when itachi returns to the village after the chunnin exams and Sasuke proves to be powerless against him. Sasuke will fall to the villainous Orochimaru to gain power. Naruto must do everything in his power to stop his friend from loosing himself to darkness even if it means losing himself.", new DateTime(2007, 2, 15), @"https://cdn.discordapp.com/attachments/819395670187311164/836038292843528232/qFWDdOmK.png", "Action",3);
            Anime Akame = new Anime("Akame Ga Kill", "A countryside boy named Tatsumi sets out on a journey to The Capital to make a name for himself and met a seemingly dangerous group of Assassins known as Night Raid. Their journey begins.", new DateTime(2014, 7, 7), @"https://cdn.discordapp.com/attachments/762710909406937128/837097040990830602/37si6-806MR43TMKG-Full-Image_GalleryBackground-en-US-1573162383187.png", "Action",4);
            Anime Slime= new Anime("that time i got resurrected as a slime", "Lonely thirty-seven-year-old Satoru Mikami is stuck in a dead-end job, unhappy with his mundane life, but after dying at the hands of a robber, he awakens to a fresh start in a fantasy realm...as a slime monster!", new DateTime(2018, 10, 2), @"https://cdn.discordapp.com/attachments/762710909406937128/837097363544997968/1605734.png", "Isekai",5);
            Anime ReZero = new Anime("Re:Zero − Starting Life in Another World", "The series tells a story of Natsuki Subaru, a normal young man that lives his normal life in the modern Japan. However, one day, he is summoned to another world. Without knowing the person that summoned him, or the reason for being summoned in the new world, he soon befriends a silver-haired-half-elf girl, Emilia.", new DateTime(2016, 4, 4), @"https://cdn.discordapp.com/attachments/762710909406937128/837097609331867719/H2x1_NSwitch_ReZeroStartingLifeInAnotherWorldTheProphecyOfTheThrone1_image1600w.png", "Isekai",6);
            Anime DragonBall = new Anime("Dragon Ball", "Guko and his friends must stop King Gurumes from destroying the city in his quest for blood rubies.", new DateTime(1986, 2, 26), "https://cdn.discordapp.com/attachments/762710909406937128/837249988995055656/toei-TOEI-DBB_S1-Full-Image_GalleryCover-en-US-1479951130744.png", "Action",7);

            Review DorohedoroReview = new Review("Dorohedoro", "Nikaido is the best character", 9);
            Review AkameReview = new Review("Akame Ga Kill", "My favourite Character died.", 4);
            Review NarutoReview = new Review("Naruto", "Naruto deserves to be treated better", 8);

            AnimeList.Add(Dorohedoro);
            AnimeList.Add(Parasyte);
            AnimeList.Add(Naruto);
            AnimeList.Add(Akame);
            AnimeList.Add(Slime);
            AnimeList.Add(ReZero);
            AnimeList.Add(DragonBall);

            ReviewList.Add(DorohedoroReview);
            ReviewList.Add(AkameReview);
            ReviewList.Add(NarutoReview);

            ListAnime.ItemsSource = AnimeList;
            Reviews.ItemsSource = ReviewList;

            string github = @"https://cdn.discordapp.com/attachments/762710909406937128/837386326583410728/GitHub-Mark.png";

            Image myimage = new Image();
            myimage.Width = 300;

            BitmapImage mybitmapImage = new BitmapImage();

            mybitmapImage.BeginInit();
            mybitmapImage.UriSource = new Uri(github);
            mybitmapImage.DecodePixelWidth = 300;
            mybitmapImage.EndInit();

            myimage.Source = mybitmapImage;

            image.Source = myimage.Source;
        }
        private void Update_AnimeList()
        {
            if (Action.IsChecked ==false && Isekai.IsChecked == false && Horror.IsChecked == false || Action.IsChecked == true && Isekai.IsChecked == true && Horror.IsChecked == true)
            {
                ListAnime.ItemsSource = null;
                ListAnime.ItemsSource = AnimeList;
            }
            else
            {
                ListAnime.ItemsSource = null;
                ListAnime.ItemsSource = FilteredList;
            }    
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Anime selected = ListAnime.SelectedItem as Anime;

            //Check for null
            if (selected != null)
            {
                RefreshAccountDetails(selected);
            }
        }
        private void RefreshAccountDetails(Anime selected)
        {
            desc.Text = selected.Description;
            Details.Text = "Release Date: " + selected.ReleaseDate;
            Image myimage = new Image();
            myimage.Width = 300;

            BitmapImage mybitmapImage = new BitmapImage();

            mybitmapImage.BeginInit();
            mybitmapImage.UriSource = new Uri(selected.Image);
            mybitmapImage.DecodePixelWidth = 300;
            mybitmapImage.EndInit();

            myimage.Source = mybitmapImage;

            Picture.Source = myimage.Source;

        }

        private void Isekai_Checked(object sender, RoutedEventArgs e)
        {
            foreach (Anime anime in AnimeList)
            {
                if (anime.Genre == "Isekai")
                {
                    FilteredList.Add(anime);
                }
            }
            Update_AnimeList();
        }

        private void Isekai_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (Anime anime in AnimeList)
            {
                if (anime.Genre == "Isekai")
                {
                    FilteredList.Remove(anime);
                }
            }
            Update_AnimeList();
        }

        private void Action_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (Anime anime in AnimeList)
            {
                if (anime.Genre == "Action")
                {
                    FilteredList.Remove(anime);
                }
            }
            Update_AnimeList();
        }

        private void Action_Checked(object sender, RoutedEventArgs e)
        {
            foreach (Anime anime in AnimeList)
            {
                if (anime.Genre == "Action")
                {
                    FilteredList.Add(anime);
                }
            }
            Update_AnimeList();
        }

        private void Horror_Checked(object sender, RoutedEventArgs e)
        {
            foreach (Anime anime in AnimeList)
            {
                if (anime.Genre == "Horror")
                {
                    FilteredList.Add(anime);
                }
            }
            Update_AnimeList();
        }

        private void Horror_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (Anime anime in AnimeList)
            {
                if (anime.Genre == "Horror")
                {
                    FilteredList.Remove(anime);
                }
            }
            Update_AnimeList();
        }

        private void Reviews_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Review selected = Reviews.SelectedItem as Review;

            //Check for null
            if (selected != null)
            {
                RefreshReviewDetails(selected);
            }
        }

        private void RefreshReviewDetails(Review selected)
        {
            AnimeName.Text = "Anime: " + selected.Anime;
            Review.Text = "Review: " + selected.UserReview;
            Score.Text = selected.Score.ToString() + "/10";
        }

        private void CreateReview_Click(object sender, RoutedEventArgs e)
        {
            bool animeCheck; bool scoreCheck;
            animeCheck = AnimeCheck();
            scoreCheck = ScoreCheck();

            if(animeCheck == true && scoreCheck == true)
            {
                int score = int.Parse(EnterScore.Text);
                Review counter = new Review(EnterAnime.Text, EnterReview.Text, score);
                ReviewList.Add(counter);

                Reviews.ItemsSource = null;
                Reviews.ItemsSource = ReviewList;
            }
        }
        private bool AnimeCheck()
        {
            foreach (Anime anime in AnimeList)
            {
                if(EnterAnime.Text.ToUpper() == anime.Name.ToUpper())
                {
                    return true;
                }
            }
            MessageBox.Show("Please Enter a valid Anime");
            
            return false;
        }
        private bool ScoreCheck()
        {
            try
            {
                int reviewScore = int.Parse(EnterScore.Text);
                if (reviewScore >= 0 && reviewScore <= 10)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please Enter a valid Score. any number 0-10");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a valid Score. any number 0-10");
                return false;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Anime selected = ListAnime.SelectedItem as Anime;

            //Check for null
            if (selected != null)
            {
                Error errorWin = new Error(selected);
                errorWin.Show();
            }
            
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // for .NET Core you need to add UseShellExecute = true
            // see https://docs.microsoft.com/dotnet/api/system.diagnostics.processstartinfo.useshellexecute#property-value
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 8);

            foreach (Anime anime in AnimeList)
            {
                if (number == anime.Count)
                {
                    RefreshAccountDetails(anime);
                }
            }
        }
    }
}
