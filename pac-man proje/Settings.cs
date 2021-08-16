using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pac_man_proje
{
    public enum Direction 
    {
        None,
        Up, 
        Down, 
        Left, 
        Right
    };
    class Settings
    {
        public static int PacmanSpeed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static bool GameWin { get; set; }
        public static bool Special { get; set; }
        public static bool Wait { get; set; }
        public static Direction direction { get; set; }
        public static Direction ghost_direction { get; set; }
        public static Direction ghost_direction2 { get; set; }
        public static Direction ghost_direction3 { get; set; }
        public static Direction ghost_direction4 { get; set; }
        public Settings()
        {
            PacmanSpeed = 1000;
            Score = 0;
            Points = 0;
            GameOver = false;
            GameWin = false;
            Special = false;
            Wait = false;
            direction = Direction.Right;
            ghost_direction = Direction.Up;
            ghost_direction2 = Direction.Up;
            ghost_direction3 = Direction.Up;
            ghost_direction4 = Direction.Up;

        }
    }
}
