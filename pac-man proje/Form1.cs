using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pac_man_proje
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
            //oyunun başlamasını sağlıyor.
            StartGame();
        }
        /// <summary>
        /// oyunun başlangıç ayarlarını belirliyor.
        /// </summary>
        private void StartGame()
        {
            new Settings();
            pacman.Image = Properties.Resources.pacman_right;
            GameTimer.Interval = 1000 / Settings.PacmanSpeed;
            GameTimer.Tick += UpdateScreen;
            Ghost_loop.Interval = 1000 / Settings.PacmanSpeed;
            GameTimer.Stop();
            GameTimer.Start();
            lblGameOver.Visible = false;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }
            //pacman'in ve hayaletlerin başlangıç pozisyonunu belirliyor.
            pacman.Left = 313;
            pacman.Top = 395;

            red_ghost.Left= 277;
            red_ghost.Top = 332;

            blue_ghost.Left = 277;
            blue_ghost.Top = 281;

            orange_ghost.Left = 348;
            orange_ghost.Top = 281;

            pink_ghost.Left = 348;
            pink_ghost.Top = 332;

            //score'u yazıyor.
            lblscore.Text = Settings.Score.ToString();
            
        }
       
        /// <summary>
        /// Hayaletlerin haraket etme komutları.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ghost_loop_Tick(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        //mavi hayalet eğer bir duvara ile temas ederse yapması gerekenleri belirliyor. 
                        if (blue_ghost.Bounds.IntersectsWith(x.Bounds))
                        {
                            //hayaletin rotasını rastgele olarak seçmesi için 0-2 arasında bir sayı seçiyor.
                            Random rnd = new Random();
                            int a = rnd.Next(2);
                            //eğer hayaletin karşılaştığı duvar hayaletin üstündeyse yapması gerekenleri belirliyor.
                            if (Settings.ghost_direction == Direction.Up)
                            {
                                //hayaletin duvarın içinde sıkışmaması için hayaleti 5 pixel duvardan geldiği yönün tersine doğru gönderiyor.
                                Settings.ghost_direction = Direction.Down;
                                blue_ghost.Top += 5;
                                //random olarak gelen sayıya göre hayaletin gideceği yön tanımlanıyor.
                                if (a == 0)
                                {
                                    Settings.ghost_direction = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction = Direction.Down;
                                }
                            }
                            //eğer hayaletin karşılaştığı duvar hayaletin altındaysa yapması gerekenleri belirliyor.
                            else if (Settings.ghost_direction == Direction.Down)
                            {
                                Settings.ghost_direction = Direction.Up;
                                blue_ghost.Top -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction = Direction.Up;
                                }
                            }
                            //eğer hayaletin karşılaştığı duvar hayaletin solundaysa yapması gerekenleri belirliyor.
                            else if (Settings.ghost_direction == Direction.Left)
                            {
                                Settings.ghost_direction = Direction.Right;
                                blue_ghost.Left += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction = Direction.Right;
                                }
                            }
                            //eğer hayaletin karşılaştığı duvar hayaletin sağındaysa yapması gerekenleri belirliyor.
                            else if (Settings.ghost_direction == Direction.Right)
                            {
                                Settings.ghost_direction = Direction.Left;
                                blue_ghost.Left -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction = Direction.Left;
                                }
                            }
                        }
                    }

                }
            }
            //yukarıda açıkladığım mavi hayalet için geçerli olan komutların hepsi diğer hayaletlerde de aynı şekilde uygulanmıştır.
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        if (orange_ghost.Bounds.IntersectsWith(x.Bounds))
                        {
                            Random rnd = new Random();
                            int a = rnd.Next(2);
                            if (Settings.ghost_direction2 == Direction.Up)
                            {
                                Settings.ghost_direction2 = Direction.Down;
                                orange_ghost.Top += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction2 = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction2 = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction2 = Direction.Down;
                                }
                            }
                            else if (Settings.ghost_direction2 == Direction.Down)
                            {
                                Settings.ghost_direction2 = Direction.Up;
                                orange_ghost.Top -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction2 = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction2 = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction2 = Direction.Up;
                                }
                            }
                            else if (Settings.ghost_direction2 == Direction.Left)
                            {
                                Settings.ghost_direction2 = Direction.Right;
                                orange_ghost.Left += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction2 = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction2 = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction2 = Direction.Right;
                                }
                            }
                            else if (Settings.ghost_direction2 == Direction.Right)
                            {
                                Settings.ghost_direction2 = Direction.Left;
                                orange_ghost.Left -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction2 = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction2 = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction2 = Direction.Left;
                                }
                            }
                        }
                    }

                }
            }
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        if (red_ghost.Bounds.IntersectsWith(x.Bounds))
                        {
                            Random rnd = new Random();
                            int a = rnd.Next(2);
                            if (Settings.ghost_direction3 == Direction.Up)
                            {
                                Settings.ghost_direction3 = Direction.Down;
                                red_ghost.Top += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction3 = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction3 = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction3 = Direction.Down;
                                }
                            }
                            else if (Settings.ghost_direction3 == Direction.Down)
                            {
                                Settings.ghost_direction3 = Direction.Up;
                                red_ghost.Top -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction3 = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction3 = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction3 = Direction.Up;
                                }
                            }
                            else if (Settings.ghost_direction3 == Direction.Left)
                            {
                                Settings.ghost_direction3 = Direction.Right;
                                red_ghost.Left += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction3 = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction3 = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction3 = Direction.Right;
                                }
                            }
                            else if (Settings.ghost_direction3 == Direction.Right)
                            {
                                Settings.ghost_direction3 = Direction.Left;
                                red_ghost.Left -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction3 = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction3 = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction3 = Direction.Left;
                                }
                            }
                        }
                    }

                }
            }
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    if ((string)x.Tag == "wall")
                    {
                        if (pink_ghost.Bounds.IntersectsWith(x.Bounds))
                        {
                            Random rnd = new Random();
                            int a = rnd.Next(2);
                            if (Settings.ghost_direction4 == Direction.Up)
                            {
                                Settings.ghost_direction4 = Direction.Down;
                                pink_ghost.Top += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction4 = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction4 = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction4 = Direction.Down;
                                }
                            }
                            else if (Settings.ghost_direction4 == Direction.Down)
                            {
                                Settings.ghost_direction4 = Direction.Up;
                                pink_ghost.Top -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction4 = Direction.Right;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction4 = Direction.Left;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction4 = Direction.Up;
                                }
                            }
                            else if (Settings.ghost_direction4 == Direction.Left)
                            {
                                Settings.ghost_direction4 = Direction.Right;
                                pink_ghost.Left += 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction4 = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction4 = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction4 = Direction.Right;
                                }
                            }
                            else if (Settings.ghost_direction4 == Direction.Right)
                            {
                                Settings.ghost_direction4 = Direction.Left;
                                pink_ghost.Left -= 5;
                                if (a == 0)
                                {
                                    Settings.ghost_direction4 = Direction.Up;
                                }
                                else if (a == 1)
                                {
                                    Settings.ghost_direction4 = Direction.Down;
                                }
                                else if (a == 2)
                                {
                                    Settings.ghost_direction4 = Direction.Left;
                                }
                            }
                        }
                    }

                }
            }
        }
        /// <summary>
        /// pacman'in etkileşime girdiği nesnelerle karşı tepkilerini belirliyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateScreen(object sender, EventArgs e)
        {
            
            foreach (Control x in this.Controls)
            {   
                
                if (x is PictureBox)
                {
                    //pacman'in beyaz toplara deydiğinde toplar yok oluyor ve skorun 1 artmasını sağlıyor.
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            Settings.Points += 1;
                            Settings.Score += 1;
                            x.Visible = false;
                        }
                    }
                    //pacman'in mavi duvarlara deydiğinde durmasını sağlıyor.
                    if((string)x.Tag=="wall")
                    {
                        if(pacman.Bounds.IntersectsWith(x.Bounds))
                        {

                            if (Settings.direction==Direction.Left)
                            {
                                pacman.Left += 5;
                                Settings.direction = Direction.None;
                            }
                            else if (Settings.direction == Direction.Right)
                            {
                                pacman.Left -= 5;
                                Settings.direction = Direction.None;
                            }
                            else if (Settings.direction == Direction.Up)
                            {
                                pacman.Top += 5;
                                Settings.direction = Direction.None;
                            }
                            else if (Settings.direction == Direction.Down)
                            {
                                pacman.Top -= 5;
                                Settings.direction = Direction.None;
                            }

                        }
                    }
                    //pacman'in hayaletlere deydiğinde oyunun sonlanmasını sağlayacak olan GameOver değişkenini false'dan true'ya çeviriyor.
                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            //Pacman'in Special özelliği açıkken Hayaletlerle etkileşime girdiğinde olacakları tanımlıyor.
                            if(Settings.Special == true)
                            {
                                //Score'u 10 arttırıyor.
                                Settings.Score += 10;
                                //Pacman tarafında yenilen hayaleti başlangıç noktasına gönderiyor.
                                x.Left = 316;
                                x.Top = 309;
                                //Hayaletler başlangıç noktasına gittikten sonra direkt oyuna dönmek yerine 4 saniye beklemelerini sağlayacak olan timer'ların döngü sürelerini 4 saniye olarak belirliyor.
                                ghost_wait.Interval = 4000;
                                ghost_wait2.Interval = 4000;
                                ghost_wait3.Interval = 4000;
                                ghost_wait4.Interval = 4000;
                                //Pacman tarafında yenilen hayaletin hareketsiz olarak 4 saniye beklemesini sağlıyor.
                                if ((string)x.Name=="blue_ghost")
                                {
                                    Settings.ghost_direction = Direction.None;
                                    ghost_wait.Start();
                                }
                                if ((string)x.Name == "orange_ghost")
                                {
                                    Settings.ghost_direction2 = Direction.None;
                                    ghost_wait2.Start();
                                }
                                if ((string)x.Name == "red_ghost")
                                {
                                    Settings.ghost_direction3 = Direction.None;
                                    ghost_wait3.Start();
                                }
                                if ((string)x.Name == "pink_ghost")
                                {
                                    Settings.ghost_direction4 = Direction.None;
                                    ghost_wait4.Start();
                                }
                                
                            }
                            else
                            Settings.GameOver = true;
                        }
                    }
                    if ((string)x.Tag == "special" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            blue_ghost.Image = Properties.Resources.ghost_scared;
                            pink_ghost.Image = Properties.Resources.ghost_scared;
                            red_ghost.Image = Properties.Resources.ghost_scared;
                            orange_ghost.Image = Properties.Resources.ghost_scared;
                            special_timer.Interval=8000;
                            special_timer.Stop();
                            special_timer.Start();
                            Settings.Special = true;
                        }
                    }
                    //pacman'in map'in kenarlarındaki boşluklardan ışınlanabilmesini sağlıyor.
                    if ((string)x.Tag == "teleport")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {   
                            if(Settings.direction == Direction.Right)
                            pacman.Left -= 695;
                            else if(Settings.direction == Direction.Left)
                            pacman.Left += 695;
                        }
                    }
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pacman_Click(object sender, EventArgs e)
        {

        }

        private void txt_score_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Oyunu kazanma ve kaybetme koşullarını tanımlıyor. Ayrıca Hayalet ve Pacman'in hareketini tanımlayan switch-case yapılarını tanımlıyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //oyun alanındaki bütün toplanabilecek coinler tamamlandığında GameWin değişkenini True yapıyor.
            if(Settings.Points==159)
            {
                Settings.GameWin = true;
            }
            //skor'un güncel olarak ekrana yazılmasını sağlıyor.
            lblscore.Text = Settings.Score.ToString();
            //pacman'in hareketini ve hızını Settings sınıfından gelen parametreye göre anlık olarak belirliyor.
            switch (Settings.direction)
            {
                case Direction.Right:
                    pacman.Left+=2;
                    break;
                case Direction.Left:
                    pacman.Left-=2;
                    break;
                case Direction.Up:
                    pacman.Top-=2;
                    break;
                case Direction.Down:
                    pacman.Top+=2;
                    break;
                case Direction.None:
                    pacman.Top += 0;
                    break;

            }
            //hayaletlerin hareketini ve hızını Settings sınıfından gelen parametreye göre anlık olarak belirliyor.
            switch (Settings.ghost_direction)
            {
                case Direction.Right:
                    blue_ghost.Left += 3;
                    break;
                case Direction.Left:
                    blue_ghost.Left -= 3;
                    break;
                case Direction.Up:
                    blue_ghost.Top -= 3;
                    break;
                case Direction.Down:
                    blue_ghost.Top += 3;
                    break;
                case Direction.None:
                    blue_ghost.Top += 0;
                    break;
            }
            switch (Settings.ghost_direction2)
            {
                case Direction.Right:
                    orange_ghost.Left += 3;
                    break;
                case Direction.Left:
                    orange_ghost.Left -= 3;
                    break;
                case Direction.Up:
                    orange_ghost.Top -= 3;
                    break;
                case Direction.Down:
                    orange_ghost.Top += 3;
                    break;
                case Direction.None:
                    orange_ghost.Top += 0;
                    break;
            }
            switch (Settings.ghost_direction3)
            {
                case Direction.Right:
                    red_ghost.Left += 3;
                    break;
                case Direction.Left:
                    red_ghost.Left -= 3;
                    break;
                case Direction.Up:
                    red_ghost.Top -= 3;
                    break;
                case Direction.Down:
                    red_ghost.Top += 3;
                    break;
                case Direction.None:
                    red_ghost.Top += 0;
                    break;
            }
            switch (Settings.ghost_direction4)
            {
                case Direction.Right:
                    pink_ghost.Left += 3;
                    break;
                case Direction.Left:
                    pink_ghost.Left -= 3;
                    break;
                case Direction.Up:
                    pink_ghost.Top -= 3;
                    break;
                case Direction.Down:
                    pink_ghost.Top += 3;
                    break;
                case Direction.None:
                    pink_ghost.Top += 0;
                    break;
            }
            

            //GameOver değişkeni true'ya döndüğü anda oyunu sonlandırıyor.
            if (Settings.GameOver == true)
            {
                string gameOver = "GameOver! \nSkorunuz: " + Settings.Score + "\nYeniden başlamak için Enter'a basın";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
                GameTimer.Stop();
                //oyun sonlandığında objelerin görünürlüğünü kapatıyor.
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        x.Visible = false;
                    }
                }

            }
            //GameWin değişkeni true'ya döndüğünde oyunu kazandığımızı bizlere gösteriyor.
            if (Settings.GameWin == true)
            {
                string gameOver = "Tebrikler Kazandınız \nSkorunuz: " + Settings.Score + "\nYeniden başlamak için Enter'a basın";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
                GameTimer.Stop();
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        x.Visible = false;
                    }
                }
                //GameOver değişkenini true'ya çevirerek 599. satırdaki kodu çalıştırırak oyuna yeniden başlayabilmemizi sağlıyor.
                Settings.GameOver = true;
            }
            

        }
        private void coin_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Karakterimizin yönünü belirlemeye ve oyunda yandığımızda yeniden başlamamızı sağlayan metot.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyisdown(object sender, KeyEventArgs e)
        {
            //Oyun sonlandığında Enter'a basarak yeniden oyuna başlamamızı sağlıyor.
            if (e.KeyCode==Keys.Enter&&Settings.GameOver==true)
            {
                StartGame();
                //UpdateScreen metodunu çalıştırarak enter'a bastığımızda yön tuşlarına bastığımız anda oluşacak duvarların içinden geçme bug'ını engelliyor.
                GameTimer.Tick += UpdateScreen;
            }
            //karakterimizin yönünü belirlememizi sağlıyor.
            else
            {
                Input.ChangeState(e.KeyCode, true);
                if (e.KeyCode==Keys.Right)
                {
                    //direction nesnesinin yönünü 'Right' olarak belirliyor.
                    Settings.direction = Direction.Right;
                    //Pacman'in görüntüsünü içe aktardığımız görseller içerisinde ismi 'right' olan görsel ile değiştiriyor
                    //böylece karakterimiz yön değiştirdiğinde pacman'in görüntüsü de değişiyor.   
                    pacman.Image = Properties.Resources.pacman_right;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    Settings.direction = Direction.Left;
                    pacman.Image = Properties.Resources.pacman_left;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    Settings.direction = Direction.Up;
                    pacman.Image = Properties.Resources.pacman_up;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    Settings.direction = Direction.Down;
                    pacman.Image = Properties.Resources.pacman_down;
                }

            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Ghost_Click(object sender, EventArgs e)
        {

        }

        private void wall_Click(object sender, EventArgs e)
        {

        }

        private void special_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Specail özelliği çalıştığı anda yapılması gerekenleri tanımlıyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Settings.Special == true)
            {
                //mavi renge dönen hayalet görüntülerini eski hallerine döndürüyor.
                blue_ghost.Image = Properties.Resources.inky;
                pink_ghost.Image = Properties.Resources.pinky;
                red_ghost.Image = Properties.Resources.blinky;
                orange_ghost.Image = Properties.Resources.clyde;
                //timer'ı tekrardan false'a çevirerek bu özelliğin tekrardan kullanılabilmesi sağlıyor.
                Settings.Special = false;
            }
        }

        
        /// <summary>
        /// Hayaletlerin 4 saniye beklemesinin ardından yukarı yöne doğru hareket etmelerini sağlıyor. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ghost_wait_Tick(object sender, EventArgs e)
        {
            if (Settings.ghost_direction == Direction.None)
            {
                Settings.ghost_direction = Direction.Up;
                ghost_wait.Stop();
            }
            
        }

        private void ghost_wait2_Tick(object sender, EventArgs e)
        {
            
            if (Settings.ghost_direction2 == Direction.None)
            {
                Settings.ghost_direction2 = Direction.Up;
                ghost_wait2.Stop();
            }
        }

        private void ghost_wait3_Tick(object sender, EventArgs e)
        {
            if (Settings.ghost_direction3 == Direction.None)
            {
                Settings.ghost_direction3 = Direction.Up;
                ghost_wait3.Stop();
            }
        }

        private void ghost_wait4_Tick(object sender, EventArgs e)
        {

            if (Settings.ghost_direction4 == Direction.None)
            {
                Settings.ghost_direction4 = Direction.Up;
                ghost_wait4.Stop();
            }
        }
    }
}
