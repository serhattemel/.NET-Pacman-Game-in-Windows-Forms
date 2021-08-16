
namespace pac_man_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_score = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.Ghost_loop = new System.Windows.Forms.Timer(this.components);
            this.special_timer = new System.Windows.Forms.Timer(this.components);
            this.ghost_wait = new System.Windows.Forms.Timer(this.components);
            this.ghost_wait2 = new System.Windows.Forms.Timer(this.components);
            this.ghost_wait3 = new System.Windows.Forms.Timer(this.components);
            this.ghost_wait4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.special = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.blue_ghost = new System.Windows.Forms.PictureBox();
            this.orange_ghost = new System.Windows.Forms.PictureBox();
            this.pink_ghost = new System.Windows.Forms.PictureBox();
            this.red_ghost = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.pictureBox186 = new System.Windows.Forms.PictureBox();
            this.pictureBox185 = new System.Windows.Forms.PictureBox();
            this.pictureBox205 = new System.Windows.Forms.PictureBox();
            this.pictureBox202 = new System.Windows.Forms.PictureBox();
            this.pictureBox204 = new System.Windows.Forms.PictureBox();
            this.pictureBox201 = new System.Windows.Forms.PictureBox();
            this.pictureBox203 = new System.Windows.Forms.PictureBox();
            this.pictureBox200 = new System.Windows.Forms.PictureBox();
            this.pictureBox183 = new System.Windows.Forms.PictureBox();
            this.pictureBox199 = new System.Windows.Forms.PictureBox();
            this.pictureBox184 = new System.Windows.Forms.PictureBox();
            this.pictureBox182 = new System.Windows.Forms.PictureBox();
            this.pictureBox176 = new System.Windows.Forms.PictureBox();
            this.pictureBox146 = new System.Windows.Forms.PictureBox();
            this.pictureBox159 = new System.Windows.Forms.PictureBox();
            this.pictureBox193 = new System.Windows.Forms.PictureBox();
            this.pictureBox197 = new System.Windows.Forms.PictureBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.pictureBox196 = new System.Windows.Forms.PictureBox();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.pictureBox145 = new System.Windows.Forms.PictureBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox144 = new System.Windows.Forms.PictureBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.pictureBox142 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox141 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox140 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox139 = new System.Windows.Forms.PictureBox();
            this.pictureBox138 = new System.Windows.Forms.PictureBox();
            this.pictureBox99 = new System.Windows.Forms.PictureBox();
            this.pictureBox103 = new System.Windows.Forms.PictureBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.pictureBox126 = new System.Windows.Forms.PictureBox();
            this.pictureBox130 = new System.Windows.Forms.PictureBox();
            this.pictureBox134 = new System.Windows.Forms.PictureBox();
            this.pictureBox133 = new System.Windows.Forms.PictureBox();
            this.pictureBox132 = new System.Windows.Forms.PictureBox();
            this.pictureBox131 = new System.Windows.Forms.PictureBox();
            this.pictureBox129 = new System.Windows.Forms.PictureBox();
            this.pictureBox128 = new System.Windows.Forms.PictureBox();
            this.pictureBox127 = new System.Windows.Forms.PictureBox();
            this.pictureBox102 = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.pictureBox101 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pictureBox177 = new System.Windows.Forms.PictureBox();
            this.pictureBox181 = new System.Windows.Forms.PictureBox();
            this.pictureBox178 = new System.Windows.Forms.PictureBox();
            this.pictureBox175 = new System.Windows.Forms.PictureBox();
            this.pictureBox167 = new System.Windows.Forms.PictureBox();
            this.pictureBox172 = new System.Windows.Forms.PictureBox();
            this.pictureBox118 = new System.Windows.Forms.PictureBox();
            this.pictureBox180 = new System.Windows.Forms.PictureBox();
            this.pictureBox179 = new System.Windows.Forms.PictureBox();
            this.pictureBox166 = new System.Windows.Forms.PictureBox();
            this.pictureBox117 = new System.Windows.Forms.PictureBox();
            this.pictureBox169 = new System.Windows.Forms.PictureBox();
            this.pictureBox116 = new System.Windows.Forms.PictureBox();
            this.pictureBox168 = new System.Windows.Forms.PictureBox();
            this.pictureBox115 = new System.Windows.Forms.PictureBox();
            this.pictureBox114 = new System.Windows.Forms.PictureBox();
            this.pictureBox113 = new System.Windows.Forms.PictureBox();
            this.pictureBox112 = new System.Windows.Forms.PictureBox();
            this.pictureBox137 = new System.Windows.Forms.PictureBox();
            this.pictureBox136 = new System.Windows.Forms.PictureBox();
            this.pictureBox135 = new System.Windows.Forms.PictureBox();
            this.pictureBox111 = new System.Windows.Forms.PictureBox();
            this.pictureBox110 = new System.Windows.Forms.PictureBox();
            this.pictureBox109 = new System.Windows.Forms.PictureBox();
            this.pictureBox108 = new System.Windows.Forms.PictureBox();
            this.pictureBox198 = new System.Windows.Forms.PictureBox();
            this.pictureBox100 = new System.Windows.Forms.PictureBox();
            this.pictureBox95 = new System.Windows.Forms.PictureBox();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox107 = new System.Windows.Forms.PictureBox();
            this.pictureBox124 = new System.Windows.Forms.PictureBox();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.pictureBox106 = new System.Windows.Forms.PictureBox();
            this.pictureBox123 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox174 = new System.Windows.Forms.PictureBox();
            this.pictureBox165 = new System.Windows.Forms.PictureBox();
            this.pictureBox171 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox122 = new System.Windows.Forms.PictureBox();
            this.pictureBox105 = new System.Windows.Forms.PictureBox();
            this.pictureBox125 = new System.Windows.Forms.PictureBox();
            this.pictureBox121 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.pictureBox173 = new System.Windows.Forms.PictureBox();
            this.pictureBox164 = new System.Windows.Forms.PictureBox();
            this.pictureBox170 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox120 = new System.Windows.Forms.PictureBox();
            this.pictureBox104 = new System.Windows.Forms.PictureBox();
            this.pictureBox119 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox154 = new System.Windows.Forms.PictureBox();
            this.pictureBox153 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox152 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox151 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox195 = new System.Windows.Forms.PictureBox();
            this.pictureBox150 = new System.Windows.Forms.PictureBox();
            this.pictureBox192 = new System.Windows.Forms.PictureBox();
            this.pictureBox163 = new System.Windows.Forms.PictureBox();
            this.pictureBox191 = new System.Windows.Forms.PictureBox();
            this.pictureBox206 = new System.Windows.Forms.PictureBox();
            this.pictureBox162 = new System.Windows.Forms.PictureBox();
            this.pictureBox158 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox194 = new System.Windows.Forms.PictureBox();
            this.pictureBox190 = new System.Windows.Forms.PictureBox();
            this.pictureBox149 = new System.Windows.Forms.PictureBox();
            this.pictureBox161 = new System.Windows.Forms.PictureBox();
            this.pictureBox157 = new System.Windows.Forms.PictureBox();
            this.pictureBox189 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox148 = new System.Windows.Forms.PictureBox();
            this.pictureBox160 = new System.Windows.Forms.PictureBox();
            this.pictureBox156 = new System.Windows.Forms.PictureBox();
            this.pictureBox188 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox147 = new System.Windows.Forms.PictureBox();
            this.pictureBox155 = new System.Windows.Forms.PictureBox();
            this.pictureBox187 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox143 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox186)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox185)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox205)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox202)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox204)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox201)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox203)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox199)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox176)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox146)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox159)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox193)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox142)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox140)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox139)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox138)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox130)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox133)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox132)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox131)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox129)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox177)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox181)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox178)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox175)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox172)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox118)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox180)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox179)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox166)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox117)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox169)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox116)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox168)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox115)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox114)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox113)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox112)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox137)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox136)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox108)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox107)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox124)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox106)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox174)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox165)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox171)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox121)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox173)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox164)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox170)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox120)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox154)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox152)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox195)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox150)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox192)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox163)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox191)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox206)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox162)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox158)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox194)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox190)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox149)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox161)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox157)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox189)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox148)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox160)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox156)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox188)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox147)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox155)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox187)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_score
            // 
            this.txt_score.AutoSize = true;
            this.txt_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_score.Location = new System.Drawing.Point(5, 17);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(55, 20);
            this.txt_score.TabIndex = 1;
            this.txt_score.Text = "Score:";
            this.txt_score.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblscore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblscore.Location = new System.Drawing.Point(72, 17);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 20);
            this.lblscore.TabIndex = 2;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGameOver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGameOver.Location = new System.Drawing.Point(59, 230);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(109, 39);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "label1";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // Ghost_loop
            // 
            this.Ghost_loop.Enabled = true;
            this.Ghost_loop.Tick += new System.EventHandler(this.Ghost_loop_Tick);
            // 
            // special_timer
            // 
            this.special_timer.Tag = "special_timer";
            this.special_timer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ghost_wait
            // 
            this.ghost_wait.Tag = "wait";
            this.ghost_wait.Tick += new System.EventHandler(this.ghost_wait_Tick);
            // 
            // ghost_wait2
            // 
            this.ghost_wait2.Tick += new System.EventHandler(this.ghost_wait2_Tick);
            // 
            // ghost_wait3
            // 
            this.ghost_wait3.Tick += new System.EventHandler(this.ghost_wait3_Tick);
            // 
            // ghost_wait4
            // 
            this.ghost_wait4.Tick += new System.EventHandler(this.ghost_wait4_Tick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::pac_man_proje.Properties.Resources.circle;
            this.pictureBox13.Location = new System.Drawing.Point(622, 64);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(33, 33);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 9;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "special";
            this.pictureBox13.Click += new System.EventHandler(this.special_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::pac_man_proje.Properties.Resources.circle;
            this.pictureBox11.Location = new System.Drawing.Point(15, 64);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 33);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "special";
            this.pictureBox11.Click += new System.EventHandler(this.special_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::pac_man_proje.Properties.Resources.circle;
            this.pictureBox12.Location = new System.Drawing.Point(21, 520);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 33);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 9;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "special";
            this.pictureBox12.Click += new System.EventHandler(this.special_Click);
            // 
            // special
            // 
            this.special.BackColor = System.Drawing.Color.Transparent;
            this.special.Image = global::pac_man_proje.Properties.Resources.circle;
            this.special.Location = new System.Drawing.Point(622, 520);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(33, 33);
            this.special.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.special.TabIndex = 9;
            this.special.TabStop = false;
            this.special.Tag = "special";
            this.special.Click += new System.EventHandler(this.special_Click);
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox53.Location = new System.Drawing.Point(-40, 283);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(10, 67);
            this.pictureBox53.TabIndex = 8;
            this.pictureBox53.TabStop = false;
            this.pictureBox53.Tag = "teleport";
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox52.Location = new System.Drawing.Point(713, 283);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(10, 67);
            this.pictureBox52.TabIndex = 8;
            this.pictureBox52.TabStop = false;
            this.pictureBox52.Tag = "teleport";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox15.Location = new System.Drawing.Point(395, 281);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(10, 91);
            this.pictureBox15.TabIndex = 7;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "wall";
            this.pictureBox15.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox14.Location = new System.Drawing.Point(258, 281);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(10, 91);
            this.pictureBox14.TabIndex = 7;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "wall";
            this.pictureBox14.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox10.Location = new System.Drawing.Point(277, 378);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(114, 10);
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "wall";
            this.pictureBox10.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox20.Location = new System.Drawing.Point(458, 149);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(10, 137);
            this.pictureBox20.TabIndex = 7;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "wall";
            this.pictureBox20.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox51.Location = new System.Drawing.Point(196, 348);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(10, 87);
            this.pictureBox51.TabIndex = 7;
            this.pictureBox51.TabStop = false;
            this.pictureBox51.Tag = "wall";
            this.pictureBox51.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox24.Location = new System.Drawing.Point(458, 348);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(10, 87);
            this.pictureBox24.TabIndex = 7;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "wall";
            this.pictureBox24.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox47.Location = new System.Drawing.Point(530, 511);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(10, 61);
            this.pictureBox47.TabIndex = 7;
            this.pictureBox47.TabStop = false;
            this.pictureBox47.Tag = "wall";
            this.pictureBox47.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox21.Location = new System.Drawing.Point(127, 511);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(10, 61);
            this.pictureBox21.TabIndex = 7;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "wall";
            this.pictureBox21.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox17.Location = new System.Drawing.Point(196, 149);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(10, 137);
            this.pictureBox17.TabIndex = 7;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "wall";
            this.pictureBox17.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox19.Location = new System.Drawing.Point(417, 217);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(40, 10);
            this.pictureBox19.TabIndex = 7;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "wall";
            this.pictureBox19.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox32.Location = new System.Drawing.Point(207, 566);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(10, 64);
            this.pictureBox32.TabIndex = 7;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Tag = "wall";
            this.pictureBox32.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox30.Location = new System.Drawing.Point(447, 566);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(10, 64);
            this.pictureBox30.TabIndex = 7;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Tag = "wall";
            this.pictureBox30.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox28.Location = new System.Drawing.Point(329, 573);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(10, 67);
            this.pictureBox28.TabIndex = 7;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Tag = "wall";
            this.pictureBox28.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox23.Location = new System.Drawing.Point(329, 449);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(10, 40);
            this.pictureBox23.TabIndex = 7;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "wall";
            this.pictureBox23.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox39.Location = new System.Drawing.Point(530, 149);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(72, 10);
            this.pictureBox39.TabIndex = 7;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Tag = "wall";
            this.pictureBox39.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox43.Location = new System.Drawing.Point(533, 348);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(138, 101);
            this.pictureBox43.TabIndex = 7;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.Tag = "wall";
            this.pictureBox43.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox42.Location = new System.Drawing.Point(11, 348);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(126, 101);
            this.pictureBox42.TabIndex = 7;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.Tag = "wall";
            this.pictureBox42.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox40.Location = new System.Drawing.Point(9, 217);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(126, 69);
            this.pictureBox40.TabIndex = 7;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Tag = "wall";
            this.pictureBox40.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox41.Location = new System.Drawing.Point(530, 217);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(138, 69);
            this.pictureBox41.TabIndex = 7;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Tag = "wall";
            this.pictureBox41.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox36.Location = new System.Drawing.Point(66, 149);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(72, 10);
            this.pictureBox36.TabIndex = 7;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Tag = "wall";
            this.pictureBox36.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox38.Location = new System.Drawing.Point(530, 60);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(72, 37);
            this.pictureBox38.TabIndex = 7;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Tag = "wall";
            this.pictureBox38.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox35.Location = new System.Drawing.Point(66, 60);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(72, 37);
            this.pictureBox35.TabIndex = 7;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.Tag = "wall";
            this.pictureBox35.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox37.Location = new System.Drawing.Point(396, 60);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(72, 37);
            this.pictureBox37.TabIndex = 7;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Tag = "wall";
            this.pictureBox37.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox34.Location = new System.Drawing.Point(194, 60);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(72, 37);
            this.pictureBox34.TabIndex = 7;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Tag = "wall";
            this.pictureBox34.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox33.Location = new System.Drawing.Point(329, 0);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(10, 74);
            this.pictureBox33.TabIndex = 7;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Tag = "wall";
            this.pictureBox33.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox16.Location = new System.Drawing.Point(331, 159);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(10, 40);
            this.pictureBox16.TabIndex = 7;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "wall";
            this.pictureBox16.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox18.Location = new System.Drawing.Point(207, 217);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(40, 10);
            this.pictureBox18.TabIndex = 7;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "wall";
            this.pictureBox18.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox50.Location = new System.Drawing.Point(194, 500);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(72, 10);
            this.pictureBox50.TabIndex = 7;
            this.pictureBox50.TabStop = false;
            this.pictureBox50.Tag = "wall";
            this.pictureBox50.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox26.Location = new System.Drawing.Point(396, 500);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(72, 10);
            this.pictureBox26.TabIndex = 7;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Tag = "wall";
            this.pictureBox26.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox45.Location = new System.Drawing.Point(619, 562);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(49, 10);
            this.pictureBox45.TabIndex = 7;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.Tag = "wall";
            this.pictureBox45.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox46.Location = new System.Drawing.Point(541, 500);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(61, 10);
            this.pictureBox46.TabIndex = 7;
            this.pictureBox46.TabStop = false;
            this.pictureBox46.Tag = "wall";
            this.pictureBox46.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox44.Location = new System.Drawing.Point(11, 562);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(49, 10);
            this.pictureBox44.TabIndex = 7;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.Tag = "wall";
            this.pictureBox44.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox25.Location = new System.Drawing.Point(66, 500);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(61, 10);
            this.pictureBox25.TabIndex = 7;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "wall";
            this.pictureBox25.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox31.Location = new System.Drawing.Point(66, 630);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(202, 10);
            this.pictureBox31.TabIndex = 7;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Tag = "wall";
            this.pictureBox31.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox29.Location = new System.Drawing.Point(396, 630);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(207, 10);
            this.pictureBox29.TabIndex = 7;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Tag = "wall";
            this.pictureBox29.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox27.Location = new System.Drawing.Point(277, 562);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(111, 10);
            this.pictureBox27.TabIndex = 7;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "wall";
            this.pictureBox27.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox22.Location = new System.Drawing.Point(277, 439);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(111, 10);
            this.pictureBox22.TabIndex = 7;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "wall";
            this.pictureBox22.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox7.Location = new System.Drawing.Point(279, 149);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(111, 10);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "wall";
            this.pictureBox7.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox49.Location = new System.Drawing.Point(670, 348);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(10, 364);
            this.pictureBox49.TabIndex = 7;
            this.pictureBox49.TabStop = false;
            this.pictureBox49.Tag = "wall";
            this.pictureBox49.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox9.Location = new System.Drawing.Point(668, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 286);
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "wall";
            this.pictureBox9.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox48.Location = new System.Drawing.Point(-1, -78);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(10, 364);
            this.pictureBox48.TabIndex = 7;
            this.pictureBox48.TabStop = false;
            this.pictureBox48.Tag = "wall";
            this.pictureBox48.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox6.Location = new System.Drawing.Point(1, 348);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 364);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            this.pictureBox6.Click += new System.EventHandler(this.wall_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox8.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(679, 10);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "wall";
            this.pictureBox8.Click += new System.EventHandler(this.wall_Click);
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wall.Location = new System.Drawing.Point(1, 702);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(679, 10);
            this.wall.TabIndex = 7;
            this.wall.TabStop = false;
            this.wall.Tag = "wall";
            this.wall.Click += new System.EventHandler(this.wall_Click);
            // 
            // pacman
            // 
            this.pacman.Image = global::pac_man_proje.Properties.Resources.pacman_right;
            this.pacman.Location = new System.Drawing.Point(316, 393);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(40, 40);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 0;
            this.pacman.TabStop = false;
            this.pacman.Click += new System.EventHandler(this.pacman_Click);
            // 
            // blue_ghost
            // 
            this.blue_ghost.Image = global::pac_man_proje.Properties.Resources.inky;
            this.blue_ghost.Location = new System.Drawing.Point(277, 281);
            this.blue_ghost.Name = "blue_ghost";
            this.blue_ghost.Size = new System.Drawing.Size(40, 40);
            this.blue_ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blue_ghost.TabIndex = 6;
            this.blue_ghost.TabStop = false;
            this.blue_ghost.Tag = "ghost";
            this.blue_ghost.Click += new System.EventHandler(this.Ghost_Click);
            // 
            // orange_ghost
            // 
            this.orange_ghost.Image = global::pac_man_proje.Properties.Resources.clyde;
            this.orange_ghost.Location = new System.Drawing.Point(348, 281);
            this.orange_ghost.Name = "orange_ghost";
            this.orange_ghost.Size = new System.Drawing.Size(40, 40);
            this.orange_ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orange_ghost.TabIndex = 6;
            this.orange_ghost.TabStop = false;
            this.orange_ghost.Tag = "ghost";
            this.orange_ghost.Click += new System.EventHandler(this.Ghost_Click);
            // 
            // pink_ghost
            // 
            this.pink_ghost.Image = global::pac_man_proje.Properties.Resources.pinky;
            this.pink_ghost.Location = new System.Drawing.Point(348, 332);
            this.pink_ghost.Name = "pink_ghost";
            this.pink_ghost.Size = new System.Drawing.Size(40, 40);
            this.pink_ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pink_ghost.TabIndex = 6;
            this.pink_ghost.TabStop = false;
            this.pink_ghost.Tag = "ghost";
            this.pink_ghost.Click += new System.EventHandler(this.Ghost_Click);
            // 
            // red_ghost
            // 
            this.red_ghost.Image = global::pac_man_proje.Properties.Resources.blinky;
            this.red_ghost.Location = new System.Drawing.Point(277, 332);
            this.red_ghost.Name = "red_ghost";
            this.red_ghost.Size = new System.Drawing.Size(40, 40);
            this.red_ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red_ghost.TabIndex = 6;
            this.red_ghost.TabStop = false;
            this.red_ghost.Tag = "ghost";
            this.red_ghost.Click += new System.EventHandler(this.Ghost_Click);
            // 
            // pictureBox78
            // 
            this.pictureBox78.BackColor = System.Drawing.Color.White;
            this.pictureBox78.Location = new System.Drawing.Point(490, 185);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(14, 14);
            this.pictureBox78.TabIndex = 3;
            this.pictureBox78.TabStop = false;
            this.pictureBox78.Tag = "coin";
            this.pictureBox78.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox186
            // 
            this.pictureBox186.BackColor = System.Drawing.Color.White;
            this.pictureBox186.Location = new System.Drawing.Point(362, 83);
            this.pictureBox186.Name = "pictureBox186";
            this.pictureBox186.Size = new System.Drawing.Size(14, 14);
            this.pictureBox186.TabIndex = 3;
            this.pictureBox186.TabStop = false;
            this.pictureBox186.Tag = "coin";
            this.pictureBox186.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox185
            // 
            this.pictureBox185.BackColor = System.Drawing.Color.White;
            this.pictureBox185.Location = new System.Drawing.Point(362, 52);
            this.pictureBox185.Name = "pictureBox185";
            this.pictureBox185.Size = new System.Drawing.Size(14, 14);
            this.pictureBox185.TabIndex = 3;
            this.pictureBox185.TabStop = false;
            this.pictureBox185.Tag = "coin";
            this.pictureBox185.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox205
            // 
            this.pictureBox205.BackColor = System.Drawing.Color.White;
            this.pictureBox205.Location = new System.Drawing.Point(420, 184);
            this.pictureBox205.Name = "pictureBox205";
            this.pictureBox205.Size = new System.Drawing.Size(14, 14);
            this.pictureBox205.TabIndex = 3;
            this.pictureBox205.TabStop = false;
            this.pictureBox205.Tag = "coin";
            this.pictureBox205.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox202
            // 
            this.pictureBox202.BackColor = System.Drawing.Color.White;
            this.pictureBox202.Location = new System.Drawing.Point(303, 184);
            this.pictureBox202.Name = "pictureBox202";
            this.pictureBox202.Size = new System.Drawing.Size(14, 14);
            this.pictureBox202.TabIndex = 3;
            this.pictureBox202.TabStop = false;
            this.pictureBox202.Tag = "coin";
            this.pictureBox202.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox204
            // 
            this.pictureBox204.BackColor = System.Drawing.Color.White;
            this.pictureBox204.Location = new System.Drawing.Point(385, 184);
            this.pictureBox204.Name = "pictureBox204";
            this.pictureBox204.Size = new System.Drawing.Size(14, 14);
            this.pictureBox204.TabIndex = 3;
            this.pictureBox204.TabStop = false;
            this.pictureBox204.Tag = "coin";
            this.pictureBox204.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox201
            // 
            this.pictureBox201.BackColor = System.Drawing.Color.White;
            this.pictureBox201.Location = new System.Drawing.Point(268, 184);
            this.pictureBox201.Name = "pictureBox201";
            this.pictureBox201.Size = new System.Drawing.Size(14, 14);
            this.pictureBox201.TabIndex = 3;
            this.pictureBox201.TabStop = false;
            this.pictureBox201.Tag = "coin";
            this.pictureBox201.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox203
            // 
            this.pictureBox203.BackColor = System.Drawing.Color.White;
            this.pictureBox203.Location = new System.Drawing.Point(350, 184);
            this.pictureBox203.Name = "pictureBox203";
            this.pictureBox203.Size = new System.Drawing.Size(14, 14);
            this.pictureBox203.TabIndex = 3;
            this.pictureBox203.TabStop = false;
            this.pictureBox203.Tag = "coin";
            this.pictureBox203.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox200
            // 
            this.pictureBox200.BackColor = System.Drawing.Color.White;
            this.pictureBox200.Location = new System.Drawing.Point(233, 184);
            this.pictureBox200.Name = "pictureBox200";
            this.pictureBox200.Size = new System.Drawing.Size(14, 14);
            this.pictureBox200.TabIndex = 3;
            this.pictureBox200.TabStop = false;
            this.pictureBox200.Tag = "coin";
            this.pictureBox200.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox183
            // 
            this.pictureBox183.BackColor = System.Drawing.Color.White;
            this.pictureBox183.Location = new System.Drawing.Point(291, 83);
            this.pictureBox183.Name = "pictureBox183";
            this.pictureBox183.Size = new System.Drawing.Size(14, 14);
            this.pictureBox183.TabIndex = 3;
            this.pictureBox183.TabStop = false;
            this.pictureBox183.Tag = "coin";
            this.pictureBox183.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox199
            // 
            this.pictureBox199.BackColor = System.Drawing.Color.White;
            this.pictureBox199.Location = new System.Drawing.Point(233, 153);
            this.pictureBox199.Name = "pictureBox199";
            this.pictureBox199.Size = new System.Drawing.Size(14, 14);
            this.pictureBox199.TabIndex = 3;
            this.pictureBox199.TabStop = false;
            this.pictureBox199.Tag = "coin";
            this.pictureBox199.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox184
            // 
            this.pictureBox184.BackColor = System.Drawing.Color.White;
            this.pictureBox184.Location = new System.Drawing.Point(362, 23);
            this.pictureBox184.Name = "pictureBox184";
            this.pictureBox184.Size = new System.Drawing.Size(14, 14);
            this.pictureBox184.TabIndex = 3;
            this.pictureBox184.TabStop = false;
            this.pictureBox184.Tag = "coin";
            this.pictureBox184.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox182
            // 
            this.pictureBox182.BackColor = System.Drawing.Color.White;
            this.pictureBox182.Location = new System.Drawing.Point(291, 52);
            this.pictureBox182.Name = "pictureBox182";
            this.pictureBox182.Size = new System.Drawing.Size(14, 14);
            this.pictureBox182.TabIndex = 3;
            this.pictureBox182.TabStop = false;
            this.pictureBox182.Tag = "coin";
            this.pictureBox182.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox176
            // 
            this.pictureBox176.BackColor = System.Drawing.Color.White;
            this.pictureBox176.Location = new System.Drawing.Point(291, 23);
            this.pictureBox176.Name = "pictureBox176";
            this.pictureBox176.Size = new System.Drawing.Size(14, 14);
            this.pictureBox176.TabIndex = 3;
            this.pictureBox176.TabStop = false;
            this.pictureBox176.Tag = "coin";
            this.pictureBox176.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox146
            // 
            this.pictureBox146.BackColor = System.Drawing.Color.White;
            this.pictureBox146.Location = new System.Drawing.Point(165, 185);
            this.pictureBox146.Name = "pictureBox146";
            this.pictureBox146.Size = new System.Drawing.Size(14, 14);
            this.pictureBox146.TabIndex = 3;
            this.pictureBox146.TabStop = false;
            this.pictureBox146.Tag = "coin";
            this.pictureBox146.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox159
            // 
            this.pictureBox159.BackColor = System.Drawing.Color.White;
            this.pictureBox159.Location = new System.Drawing.Point(165, 120);
            this.pictureBox159.Name = "pictureBox159";
            this.pictureBox159.Size = new System.Drawing.Size(14, 14);
            this.pictureBox159.TabIndex = 3;
            this.pictureBox159.TabStop = false;
            this.pictureBox159.Tag = "coin";
            this.pictureBox159.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox193
            // 
            this.pictureBox193.BackColor = System.Drawing.Color.White;
            this.pictureBox193.Location = new System.Drawing.Point(490, 23);
            this.pictureBox193.Name = "pictureBox193";
            this.pictureBox193.Size = new System.Drawing.Size(14, 14);
            this.pictureBox193.TabIndex = 3;
            this.pictureBox193.TabStop = false;
            this.pictureBox193.Tag = "coin";
            this.pictureBox193.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox197
            // 
            this.pictureBox197.BackColor = System.Drawing.Color.White;
            this.pictureBox197.Location = new System.Drawing.Point(490, 52);
            this.pictureBox197.Name = "pictureBox197";
            this.pictureBox197.Size = new System.Drawing.Size(14, 14);
            this.pictureBox197.TabIndex = 3;
            this.pictureBox197.TabStop = false;
            this.pictureBox197.Tag = "coin";
            this.pictureBox197.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox79
            // 
            this.pictureBox79.BackColor = System.Drawing.Color.White;
            this.pictureBox79.Location = new System.Drawing.Point(490, 120);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(14, 14);
            this.pictureBox79.TabIndex = 3;
            this.pictureBox79.TabStop = false;
            this.pictureBox79.Tag = "coin";
            this.pictureBox79.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox196
            // 
            this.pictureBox196.BackColor = System.Drawing.Color.White;
            this.pictureBox196.Location = new System.Drawing.Point(491, 83);
            this.pictureBox196.Name = "pictureBox196";
            this.pictureBox196.Size = new System.Drawing.Size(14, 14);
            this.pictureBox196.TabIndex = 3;
            this.pictureBox196.TabStop = false;
            this.pictureBox196.Tag = "coin";
            this.pictureBox196.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox77
            // 
            this.pictureBox77.BackColor = System.Drawing.Color.White;
            this.pictureBox77.Location = new System.Drawing.Point(490, 152);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(14, 14);
            this.pictureBox77.TabIndex = 3;
            this.pictureBox77.TabStop = false;
            this.pictureBox77.Tag = "coin";
            this.pictureBox77.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox76
            // 
            this.pictureBox76.BackColor = System.Drawing.Color.White;
            this.pictureBox76.Location = new System.Drawing.Point(491, 229);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(14, 14);
            this.pictureBox76.TabIndex = 3;
            this.pictureBox76.TabStop = false;
            this.pictureBox76.Tag = "coin";
            this.pictureBox76.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox145
            // 
            this.pictureBox145.BackColor = System.Drawing.Color.White;
            this.pictureBox145.Location = new System.Drawing.Point(165, 152);
            this.pictureBox145.Name = "pictureBox145";
            this.pictureBox145.Size = new System.Drawing.Size(14, 14);
            this.pictureBox145.TabIndex = 3;
            this.pictureBox145.TabStop = false;
            this.pictureBox145.Tag = "coin";
            this.pictureBox145.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox75
            // 
            this.pictureBox75.BackColor = System.Drawing.Color.White;
            this.pictureBox75.Location = new System.Drawing.Point(491, 270);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(14, 14);
            this.pictureBox75.TabIndex = 3;
            this.pictureBox75.TabStop = false;
            this.pictureBox75.Tag = "coin";
            this.pictureBox75.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox144
            // 
            this.pictureBox144.BackColor = System.Drawing.Color.White;
            this.pictureBox144.Location = new System.Drawing.Point(165, 229);
            this.pictureBox144.Name = "pictureBox144";
            this.pictureBox144.Size = new System.Drawing.Size(14, 14);
            this.pictureBox144.TabIndex = 3;
            this.pictureBox144.TabStop = false;
            this.pictureBox144.Tag = "coin";
            this.pictureBox144.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox74
            // 
            this.pictureBox74.BackColor = System.Drawing.Color.White;
            this.pictureBox74.Location = new System.Drawing.Point(491, 309);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(14, 14);
            this.pictureBox74.TabIndex = 3;
            this.pictureBox74.TabStop = false;
            this.pictureBox74.Tag = "coin";
            this.pictureBox74.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox142
            // 
            this.pictureBox142.BackColor = System.Drawing.Color.White;
            this.pictureBox142.Location = new System.Drawing.Point(165, 270);
            this.pictureBox142.Name = "pictureBox142";
            this.pictureBox142.Size = new System.Drawing.Size(14, 14);
            this.pictureBox142.TabIndex = 3;
            this.pictureBox142.TabStop = false;
            this.pictureBox142.Tag = "coin";
            this.pictureBox142.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(491, 348);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 14);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            this.pictureBox5.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox141
            // 
            this.pictureBox141.BackColor = System.Drawing.Color.White;
            this.pictureBox141.Location = new System.Drawing.Point(165, 309);
            this.pictureBox141.Name = "pictureBox141";
            this.pictureBox141.Size = new System.Drawing.Size(14, 14);
            this.pictureBox141.TabIndex = 3;
            this.pictureBox141.TabStop = false;
            this.pictureBox141.Tag = "coin";
            this.pictureBox141.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(491, 384);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 14);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "coin";
            this.pictureBox4.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox140
            // 
            this.pictureBox140.BackColor = System.Drawing.Color.White;
            this.pictureBox140.Location = new System.Drawing.Point(165, 348);
            this.pictureBox140.Name = "pictureBox140";
            this.pictureBox140.Size = new System.Drawing.Size(14, 14);
            this.pictureBox140.TabIndex = 3;
            this.pictureBox140.TabStop = false;
            this.pictureBox140.Tag = "coin";
            this.pictureBox140.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(491, 421);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 14);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            this.pictureBox3.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox139
            // 
            this.pictureBox139.BackColor = System.Drawing.Color.White;
            this.pictureBox139.Location = new System.Drawing.Point(165, 384);
            this.pictureBox139.Name = "pictureBox139";
            this.pictureBox139.Size = new System.Drawing.Size(14, 14);
            this.pictureBox139.TabIndex = 3;
            this.pictureBox139.TabStop = false;
            this.pictureBox139.Tag = "coin";
            this.pictureBox139.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox138
            // 
            this.pictureBox138.BackColor = System.Drawing.Color.White;
            this.pictureBox138.Location = new System.Drawing.Point(165, 421);
            this.pictureBox138.Name = "pictureBox138";
            this.pictureBox138.Size = new System.Drawing.Size(14, 14);
            this.pictureBox138.TabIndex = 3;
            this.pictureBox138.TabStop = false;
            this.pictureBox138.Tag = "coin";
            this.pictureBox138.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox99
            // 
            this.pictureBox99.BackColor = System.Drawing.Color.White;
            this.pictureBox99.Location = new System.Drawing.Point(303, 496);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(14, 14);
            this.pictureBox99.TabIndex = 3;
            this.pictureBox99.TabStop = false;
            this.pictureBox99.Tag = "coin";
            this.pictureBox99.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox103
            // 
            this.pictureBox103.BackColor = System.Drawing.Color.White;
            this.pictureBox103.Location = new System.Drawing.Point(303, 528);
            this.pictureBox103.Name = "pictureBox103";
            this.pictureBox103.Size = new System.Drawing.Size(14, 14);
            this.pictureBox103.TabIndex = 3;
            this.pictureBox103.TabStop = false;
            this.pictureBox103.Tag = "coin";
            this.pictureBox103.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox98
            // 
            this.pictureBox98.BackColor = System.Drawing.Color.White;
            this.pictureBox98.Location = new System.Drawing.Point(454, 528);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(14, 14);
            this.pictureBox98.TabIndex = 3;
            this.pictureBox98.TabStop = false;
            this.pictureBox98.Tag = "coin";
            this.pictureBox98.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox126
            // 
            this.pictureBox126.BackColor = System.Drawing.Color.White;
            this.pictureBox126.Location = new System.Drawing.Point(268, 528);
            this.pictureBox126.Name = "pictureBox126";
            this.pictureBox126.Size = new System.Drawing.Size(14, 14);
            this.pictureBox126.TabIndex = 3;
            this.pictureBox126.TabStop = false;
            this.pictureBox126.Tag = "coin";
            this.pictureBox126.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox130
            // 
            this.pictureBox130.BackColor = System.Drawing.Color.White;
            this.pictureBox130.Location = new System.Drawing.Point(291, 626);
            this.pictureBox130.Name = "pictureBox130";
            this.pictureBox130.Size = new System.Drawing.Size(14, 14);
            this.pictureBox130.TabIndex = 3;
            this.pictureBox130.TabStop = false;
            this.pictureBox130.Tag = "coin";
            this.pictureBox130.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox134
            // 
            this.pictureBox134.BackColor = System.Drawing.Color.White;
            this.pictureBox134.Location = new System.Drawing.Point(406, 562);
            this.pictureBox134.Name = "pictureBox134";
            this.pictureBox134.Size = new System.Drawing.Size(14, 14);
            this.pictureBox134.TabIndex = 3;
            this.pictureBox134.TabStop = false;
            this.pictureBox134.Tag = "coin";
            this.pictureBox134.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox133
            // 
            this.pictureBox133.BackColor = System.Drawing.Color.White;
            this.pictureBox133.Location = new System.Drawing.Point(406, 595);
            this.pictureBox133.Name = "pictureBox133";
            this.pictureBox133.Size = new System.Drawing.Size(14, 14);
            this.pictureBox133.TabIndex = 3;
            this.pictureBox133.TabStop = false;
            this.pictureBox133.Tag = "coin";
            this.pictureBox133.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox132
            // 
            this.pictureBox132.BackColor = System.Drawing.Color.White;
            this.pictureBox132.Location = new System.Drawing.Point(362, 595);
            this.pictureBox132.Name = "pictureBox132";
            this.pictureBox132.Size = new System.Drawing.Size(14, 14);
            this.pictureBox132.TabIndex = 3;
            this.pictureBox132.TabStop = false;
            this.pictureBox132.Tag = "coin";
            this.pictureBox132.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox131
            // 
            this.pictureBox131.BackColor = System.Drawing.Color.White;
            this.pictureBox131.Location = new System.Drawing.Point(362, 626);
            this.pictureBox131.Name = "pictureBox131";
            this.pictureBox131.Size = new System.Drawing.Size(14, 14);
            this.pictureBox131.TabIndex = 3;
            this.pictureBox131.TabStop = false;
            this.pictureBox131.Tag = "coin";
            this.pictureBox131.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox129
            // 
            this.pictureBox129.BackColor = System.Drawing.Color.White;
            this.pictureBox129.Location = new System.Drawing.Point(291, 595);
            this.pictureBox129.Name = "pictureBox129";
            this.pictureBox129.Size = new System.Drawing.Size(14, 14);
            this.pictureBox129.TabIndex = 3;
            this.pictureBox129.TabStop = false;
            this.pictureBox129.Tag = "coin";
            this.pictureBox129.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox128
            // 
            this.pictureBox128.BackColor = System.Drawing.Color.White;
            this.pictureBox128.Location = new System.Drawing.Point(252, 595);
            this.pictureBox128.Name = "pictureBox128";
            this.pictureBox128.Size = new System.Drawing.Size(14, 14);
            this.pictureBox128.TabIndex = 3;
            this.pictureBox128.TabStop = false;
            this.pictureBox128.Tag = "coin";
            this.pictureBox128.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox127
            // 
            this.pictureBox127.BackColor = System.Drawing.Color.White;
            this.pictureBox127.Location = new System.Drawing.Point(252, 562);
            this.pictureBox127.Name = "pictureBox127";
            this.pictureBox127.Size = new System.Drawing.Size(14, 14);
            this.pictureBox127.TabIndex = 3;
            this.pictureBox127.TabStop = false;
            this.pictureBox127.Tag = "coin";
            this.pictureBox127.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox102
            // 
            this.pictureBox102.BackColor = System.Drawing.Color.White;
            this.pictureBox102.Location = new System.Drawing.Point(238, 528);
            this.pictureBox102.Name = "pictureBox102";
            this.pictureBox102.Size = new System.Drawing.Size(14, 14);
            this.pictureBox102.TabIndex = 3;
            this.pictureBox102.TabStop = false;
            this.pictureBox102.Tag = "coin";
            this.pictureBox102.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox97
            // 
            this.pictureBox97.BackColor = System.Drawing.Color.White;
            this.pictureBox97.Location = new System.Drawing.Point(417, 528);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(14, 14);
            this.pictureBox97.TabIndex = 3;
            this.pictureBox97.TabStop = false;
            this.pictureBox97.Tag = "coin";
            this.pictureBox97.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox101
            // 
            this.pictureBox101.BackColor = System.Drawing.Color.White;
            this.pictureBox101.Location = new System.Drawing.Point(208, 528);
            this.pictureBox101.Name = "pictureBox101";
            this.pictureBox101.Size = new System.Drawing.Size(14, 14);
            this.pictureBox101.TabIndex = 3;
            this.pictureBox101.TabStop = false;
            this.pictureBox101.Tag = "coin";
            this.pictureBox101.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox96
            // 
            this.pictureBox96.BackColor = System.Drawing.Color.White;
            this.pictureBox96.Location = new System.Drawing.Point(382, 528);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(14, 14);
            this.pictureBox96.TabIndex = 3;
            this.pictureBox96.TabStop = false;
            this.pictureBox96.Tag = "coin";
            this.pictureBox96.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox177
            // 
            this.pictureBox177.BackColor = System.Drawing.Color.White;
            this.pictureBox177.Location = new System.Drawing.Point(136, 23);
            this.pictureBox177.Name = "pictureBox177";
            this.pictureBox177.Size = new System.Drawing.Size(14, 14);
            this.pictureBox177.TabIndex = 3;
            this.pictureBox177.TabStop = false;
            this.pictureBox177.Tag = "coin";
            this.pictureBox177.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox181
            // 
            this.pictureBox181.BackColor = System.Drawing.Color.White;
            this.pictureBox181.Location = new System.Drawing.Point(164, 83);
            this.pictureBox181.Name = "pictureBox181";
            this.pictureBox181.Size = new System.Drawing.Size(14, 14);
            this.pictureBox181.TabIndex = 3;
            this.pictureBox181.TabStop = false;
            this.pictureBox181.Tag = "coin";
            this.pictureBox181.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox178
            // 
            this.pictureBox178.BackColor = System.Drawing.Color.White;
            this.pictureBox178.Location = new System.Drawing.Point(165, 52);
            this.pictureBox178.Name = "pictureBox178";
            this.pictureBox178.Size = new System.Drawing.Size(14, 14);
            this.pictureBox178.TabIndex = 3;
            this.pictureBox178.TabStop = false;
            this.pictureBox178.Tag = "coin";
            this.pictureBox178.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox175
            // 
            this.pictureBox175.BackColor = System.Drawing.Color.White;
            this.pictureBox175.Location = new System.Drawing.Point(165, 23);
            this.pictureBox175.Name = "pictureBox175";
            this.pictureBox175.Size = new System.Drawing.Size(14, 14);
            this.pictureBox175.TabIndex = 3;
            this.pictureBox175.TabStop = false;
            this.pictureBox175.Tag = "coin";
            this.pictureBox175.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox167
            // 
            this.pictureBox167.BackColor = System.Drawing.Color.White;
            this.pictureBox167.Location = new System.Drawing.Point(58, 120);
            this.pictureBox167.Name = "pictureBox167";
            this.pictureBox167.Size = new System.Drawing.Size(14, 14);
            this.pictureBox167.TabIndex = 3;
            this.pictureBox167.TabStop = false;
            this.pictureBox167.Tag = "coin";
            this.pictureBox167.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox172
            // 
            this.pictureBox172.BackColor = System.Drawing.Color.White;
            this.pictureBox172.Location = new System.Drawing.Point(58, 184);
            this.pictureBox172.Name = "pictureBox172";
            this.pictureBox172.Size = new System.Drawing.Size(14, 14);
            this.pictureBox172.TabIndex = 3;
            this.pictureBox172.TabStop = false;
            this.pictureBox172.Tag = "coin";
            this.pictureBox172.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox118
            // 
            this.pictureBox118.BackColor = System.Drawing.Color.White;
            this.pictureBox118.Location = new System.Drawing.Point(58, 460);
            this.pictureBox118.Name = "pictureBox118";
            this.pictureBox118.Size = new System.Drawing.Size(14, 14);
            this.pictureBox118.TabIndex = 3;
            this.pictureBox118.TabStop = false;
            this.pictureBox118.Tag = "coin";
            this.pictureBox118.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox180
            // 
            this.pictureBox180.BackColor = System.Drawing.Color.White;
            this.pictureBox180.Location = new System.Drawing.Point(23, 40);
            this.pictureBox180.Name = "pictureBox180";
            this.pictureBox180.Size = new System.Drawing.Size(14, 14);
            this.pictureBox180.TabIndex = 3;
            this.pictureBox180.TabStop = false;
            this.pictureBox180.Tag = "coin";
            this.pictureBox180.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox179
            // 
            this.pictureBox179.BackColor = System.Drawing.Color.White;
            this.pictureBox179.Location = new System.Drawing.Point(23, 83);
            this.pictureBox179.Name = "pictureBox179";
            this.pictureBox179.Size = new System.Drawing.Size(14, 14);
            this.pictureBox179.TabIndex = 3;
            this.pictureBox179.TabStop = false;
            this.pictureBox179.Tag = "coin";
            this.pictureBox179.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox166
            // 
            this.pictureBox166.BackColor = System.Drawing.Color.White;
            this.pictureBox166.Location = new System.Drawing.Point(23, 120);
            this.pictureBox166.Name = "pictureBox166";
            this.pictureBox166.Size = new System.Drawing.Size(14, 14);
            this.pictureBox166.TabIndex = 3;
            this.pictureBox166.TabStop = false;
            this.pictureBox166.Tag = "coin";
            this.pictureBox166.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox117
            // 
            this.pictureBox117.BackColor = System.Drawing.Color.White;
            this.pictureBox117.Location = new System.Drawing.Point(23, 460);
            this.pictureBox117.Name = "pictureBox117";
            this.pictureBox117.Size = new System.Drawing.Size(14, 14);
            this.pictureBox117.TabIndex = 3;
            this.pictureBox117.TabStop = false;
            this.pictureBox117.Tag = "coin";
            this.pictureBox117.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox169
            // 
            this.pictureBox169.BackColor = System.Drawing.Color.White;
            this.pictureBox169.Location = new System.Drawing.Point(23, 152);
            this.pictureBox169.Name = "pictureBox169";
            this.pictureBox169.Size = new System.Drawing.Size(14, 14);
            this.pictureBox169.TabIndex = 3;
            this.pictureBox169.TabStop = false;
            this.pictureBox169.Tag = "coin";
            this.pictureBox169.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox116
            // 
            this.pictureBox116.BackColor = System.Drawing.Color.White;
            this.pictureBox116.Location = new System.Drawing.Point(23, 496);
            this.pictureBox116.Name = "pictureBox116";
            this.pictureBox116.Size = new System.Drawing.Size(14, 14);
            this.pictureBox116.TabIndex = 3;
            this.pictureBox116.TabStop = false;
            this.pictureBox116.Tag = "coin";
            this.pictureBox116.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox168
            // 
            this.pictureBox168.BackColor = System.Drawing.Color.White;
            this.pictureBox168.Location = new System.Drawing.Point(23, 184);
            this.pictureBox168.Name = "pictureBox168";
            this.pictureBox168.Size = new System.Drawing.Size(14, 14);
            this.pictureBox168.TabIndex = 3;
            this.pictureBox168.TabStop = false;
            this.pictureBox168.Tag = "coin";
            this.pictureBox168.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox115
            // 
            this.pictureBox115.BackColor = System.Drawing.Color.White;
            this.pictureBox115.Location = new System.Drawing.Point(23, 528);
            this.pictureBox115.Name = "pictureBox115";
            this.pictureBox115.Size = new System.Drawing.Size(14, 14);
            this.pictureBox115.TabIndex = 3;
            this.pictureBox115.TabStop = false;
            this.pictureBox115.Tag = "coin";
            this.pictureBox115.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox114
            // 
            this.pictureBox114.BackColor = System.Drawing.Color.White;
            this.pictureBox114.Location = new System.Drawing.Point(60, 528);
            this.pictureBox114.Name = "pictureBox114";
            this.pictureBox114.Size = new System.Drawing.Size(14, 14);
            this.pictureBox114.TabIndex = 3;
            this.pictureBox114.TabStop = false;
            this.pictureBox114.Tag = "coin";
            this.pictureBox114.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox113
            // 
            this.pictureBox113.BackColor = System.Drawing.Color.White;
            this.pictureBox113.Location = new System.Drawing.Point(96, 528);
            this.pictureBox113.Name = "pictureBox113";
            this.pictureBox113.Size = new System.Drawing.Size(14, 14);
            this.pictureBox113.TabIndex = 3;
            this.pictureBox113.TabStop = false;
            this.pictureBox113.Tag = "coin";
            this.pictureBox113.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox112
            // 
            this.pictureBox112.BackColor = System.Drawing.Color.White;
            this.pictureBox112.Location = new System.Drawing.Point(96, 562);
            this.pictureBox112.Name = "pictureBox112";
            this.pictureBox112.Size = new System.Drawing.Size(14, 14);
            this.pictureBox112.TabIndex = 3;
            this.pictureBox112.TabStop = false;
            this.pictureBox112.Tag = "coin";
            this.pictureBox112.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox137
            // 
            this.pictureBox137.BackColor = System.Drawing.Color.White;
            this.pictureBox137.Location = new System.Drawing.Point(23, 626);
            this.pictureBox137.Name = "pictureBox137";
            this.pictureBox137.Size = new System.Drawing.Size(14, 14);
            this.pictureBox137.TabIndex = 3;
            this.pictureBox137.TabStop = false;
            this.pictureBox137.Tag = "coin";
            this.pictureBox137.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox136
            // 
            this.pictureBox136.BackColor = System.Drawing.Color.White;
            this.pictureBox136.Location = new System.Drawing.Point(23, 595);
            this.pictureBox136.Name = "pictureBox136";
            this.pictureBox136.Size = new System.Drawing.Size(14, 14);
            this.pictureBox136.TabIndex = 3;
            this.pictureBox136.TabStop = false;
            this.pictureBox136.Tag = "coin";
            this.pictureBox136.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox135
            // 
            this.pictureBox135.BackColor = System.Drawing.Color.White;
            this.pictureBox135.Location = new System.Drawing.Point(64, 595);
            this.pictureBox135.Name = "pictureBox135";
            this.pictureBox135.Size = new System.Drawing.Size(14, 14);
            this.pictureBox135.TabIndex = 3;
            this.pictureBox135.TabStop = false;
            this.pictureBox135.Tag = "coin";
            this.pictureBox135.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox111
            // 
            this.pictureBox111.BackColor = System.Drawing.Color.White;
            this.pictureBox111.Location = new System.Drawing.Point(96, 595);
            this.pictureBox111.Name = "pictureBox111";
            this.pictureBox111.Size = new System.Drawing.Size(14, 14);
            this.pictureBox111.TabIndex = 3;
            this.pictureBox111.TabStop = false;
            this.pictureBox111.Tag = "coin";
            this.pictureBox111.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox110
            // 
            this.pictureBox110.BackColor = System.Drawing.Color.White;
            this.pictureBox110.Location = new System.Drawing.Point(136, 595);
            this.pictureBox110.Name = "pictureBox110";
            this.pictureBox110.Size = new System.Drawing.Size(14, 14);
            this.pictureBox110.TabIndex = 3;
            this.pictureBox110.TabStop = false;
            this.pictureBox110.Tag = "coin";
            this.pictureBox110.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox109
            // 
            this.pictureBox109.BackColor = System.Drawing.Color.White;
            this.pictureBox109.Location = new System.Drawing.Point(165, 595);
            this.pictureBox109.Name = "pictureBox109";
            this.pictureBox109.Size = new System.Drawing.Size(14, 14);
            this.pictureBox109.TabIndex = 3;
            this.pictureBox109.TabStop = false;
            this.pictureBox109.Tag = "coin";
            this.pictureBox109.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox108
            // 
            this.pictureBox108.BackColor = System.Drawing.Color.White;
            this.pictureBox108.Location = new System.Drawing.Point(165, 562);
            this.pictureBox108.Name = "pictureBox108";
            this.pictureBox108.Size = new System.Drawing.Size(14, 14);
            this.pictureBox108.TabIndex = 3;
            this.pictureBox108.TabStop = false;
            this.pictureBox108.Tag = "coin";
            this.pictureBox108.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox198
            // 
            this.pictureBox198.BackColor = System.Drawing.Color.White;
            this.pictureBox198.Location = new System.Drawing.Point(165, 496);
            this.pictureBox198.Name = "pictureBox198";
            this.pictureBox198.Size = new System.Drawing.Size(14, 14);
            this.pictureBox198.TabIndex = 3;
            this.pictureBox198.TabStop = false;
            this.pictureBox198.Tag = "coin";
            this.pictureBox198.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox100
            // 
            this.pictureBox100.BackColor = System.Drawing.Color.White;
            this.pictureBox100.Location = new System.Drawing.Point(165, 528);
            this.pictureBox100.Name = "pictureBox100";
            this.pictureBox100.Size = new System.Drawing.Size(14, 14);
            this.pictureBox100.TabIndex = 3;
            this.pictureBox100.TabStop = false;
            this.pictureBox100.Tag = "coin";
            this.pictureBox100.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox95
            // 
            this.pictureBox95.BackColor = System.Drawing.Color.White;
            this.pictureBox95.Location = new System.Drawing.Point(350, 528);
            this.pictureBox95.Name = "pictureBox95";
            this.pictureBox95.Size = new System.Drawing.Size(14, 14);
            this.pictureBox95.TabIndex = 3;
            this.pictureBox95.TabStop = false;
            this.pictureBox95.Tag = "coin";
            this.pictureBox95.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox94
            // 
            this.pictureBox94.BackColor = System.Drawing.Color.White;
            this.pictureBox94.Location = new System.Drawing.Point(350, 496);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(14, 14);
            this.pictureBox94.TabIndex = 3;
            this.pictureBox94.TabStop = false;
            this.pictureBox94.Tag = "coin";
            this.pictureBox94.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox93
            // 
            this.pictureBox93.BackColor = System.Drawing.Color.White;
            this.pictureBox93.Location = new System.Drawing.Point(350, 460);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(14, 14);
            this.pictureBox93.TabIndex = 3;
            this.pictureBox93.TabStop = false;
            this.pictureBox93.Tag = "coin";
            this.pictureBox93.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox92
            // 
            this.pictureBox92.BackColor = System.Drawing.Color.White;
            this.pictureBox92.Location = new System.Drawing.Point(382, 460);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(14, 14);
            this.pictureBox92.TabIndex = 3;
            this.pictureBox92.TabStop = false;
            this.pictureBox92.Tag = "coin";
            this.pictureBox92.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(417, 460);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            this.pictureBox2.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox107
            // 
            this.pictureBox107.BackColor = System.Drawing.Color.White;
            this.pictureBox107.Location = new System.Drawing.Point(23, 665);
            this.pictureBox107.Name = "pictureBox107";
            this.pictureBox107.Size = new System.Drawing.Size(14, 14);
            this.pictureBox107.TabIndex = 3;
            this.pictureBox107.TabStop = false;
            this.pictureBox107.Tag = "coin";
            this.pictureBox107.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox124
            // 
            this.pictureBox124.BackColor = System.Drawing.Color.White;
            this.pictureBox124.Location = new System.Drawing.Point(164, 460);
            this.pictureBox124.Name = "pictureBox124";
            this.pictureBox124.Size = new System.Drawing.Size(14, 14);
            this.pictureBox124.TabIndex = 3;
            this.pictureBox124.TabStop = false;
            this.pictureBox124.Tag = "coin";
            this.pictureBox124.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox91
            // 
            this.pictureBox91.BackColor = System.Drawing.Color.White;
            this.pictureBox91.Location = new System.Drawing.Point(165, 665);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(14, 14);
            this.pictureBox91.TabIndex = 3;
            this.pictureBox91.TabStop = false;
            this.pictureBox91.Tag = "coin";
            this.pictureBox91.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox106
            // 
            this.pictureBox106.BackColor = System.Drawing.Color.White;
            this.pictureBox106.Location = new System.Drawing.Point(60, 665);
            this.pictureBox106.Name = "pictureBox106";
            this.pictureBox106.Size = new System.Drawing.Size(14, 14);
            this.pictureBox106.TabIndex = 3;
            this.pictureBox106.TabStop = false;
            this.pictureBox106.Tag = "coin";
            this.pictureBox106.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox123
            // 
            this.pictureBox123.BackColor = System.Drawing.Color.White;
            this.pictureBox123.Location = new System.Drawing.Point(201, 460);
            this.pictureBox123.Name = "pictureBox123";
            this.pictureBox123.Size = new System.Drawing.Size(14, 14);
            this.pictureBox123.TabIndex = 3;
            this.pictureBox123.TabStop = false;
            this.pictureBox123.Tag = "coin";
            this.pictureBox123.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackColor = System.Drawing.Color.White;
            this.pictureBox90.Location = new System.Drawing.Point(202, 665);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(14, 14);
            this.pictureBox90.TabIndex = 3;
            this.pictureBox90.TabStop = false;
            this.pictureBox90.Tag = "coin";
            this.pictureBox90.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox174
            // 
            this.pictureBox174.BackColor = System.Drawing.Color.White;
            this.pictureBox174.Location = new System.Drawing.Point(202, 23);
            this.pictureBox174.Name = "pictureBox174";
            this.pictureBox174.Size = new System.Drawing.Size(14, 14);
            this.pictureBox174.TabIndex = 3;
            this.pictureBox174.TabStop = false;
            this.pictureBox174.Tag = "coin";
            this.pictureBox174.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox165
            // 
            this.pictureBox165.BackColor = System.Drawing.Color.White;
            this.pictureBox165.Location = new System.Drawing.Point(95, 120);
            this.pictureBox165.Name = "pictureBox165";
            this.pictureBox165.Size = new System.Drawing.Size(14, 14);
            this.pictureBox165.TabIndex = 3;
            this.pictureBox165.TabStop = false;
            this.pictureBox165.Tag = "coin";
            this.pictureBox165.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox171
            // 
            this.pictureBox171.BackColor = System.Drawing.Color.White;
            this.pictureBox171.Location = new System.Drawing.Point(95, 184);
            this.pictureBox171.Name = "pictureBox171";
            this.pictureBox171.Size = new System.Drawing.Size(14, 14);
            this.pictureBox171.TabIndex = 3;
            this.pictureBox171.TabStop = false;
            this.pictureBox171.Tag = "coin";
            this.pictureBox171.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox73
            // 
            this.pictureBox73.BackColor = System.Drawing.Color.White;
            this.pictureBox73.Location = new System.Drawing.Point(417, 665);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(14, 14);
            this.pictureBox73.TabIndex = 3;
            this.pictureBox73.TabStop = false;
            this.pictureBox73.Tag = "coin";
            this.pictureBox73.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox122
            // 
            this.pictureBox122.BackColor = System.Drawing.Color.White;
            this.pictureBox122.Location = new System.Drawing.Point(95, 460);
            this.pictureBox122.Name = "pictureBox122";
            this.pictureBox122.Size = new System.Drawing.Size(14, 14);
            this.pictureBox122.TabIndex = 3;
            this.pictureBox122.TabStop = false;
            this.pictureBox122.Tag = "coin";
            this.pictureBox122.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox105
            // 
            this.pictureBox105.BackColor = System.Drawing.Color.White;
            this.pictureBox105.Location = new System.Drawing.Point(96, 665);
            this.pictureBox105.Name = "pictureBox105";
            this.pictureBox105.Size = new System.Drawing.Size(14, 14);
            this.pictureBox105.TabIndex = 3;
            this.pictureBox105.TabStop = false;
            this.pictureBox105.Tag = "coin";
            this.pictureBox105.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox125
            // 
            this.pictureBox125.BackColor = System.Drawing.Color.White;
            this.pictureBox125.Location = new System.Drawing.Point(268, 460);
            this.pictureBox125.Name = "pictureBox125";
            this.pictureBox125.Size = new System.Drawing.Size(14, 14);
            this.pictureBox125.TabIndex = 3;
            this.pictureBox125.TabStop = false;
            this.pictureBox125.Tag = "coin";
            this.pictureBox125.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox121
            // 
            this.pictureBox121.BackColor = System.Drawing.Color.White;
            this.pictureBox121.Location = new System.Drawing.Point(237, 460);
            this.pictureBox121.Name = "pictureBox121";
            this.pictureBox121.Size = new System.Drawing.Size(14, 14);
            this.pictureBox121.TabIndex = 3;
            this.pictureBox121.TabStop = false;
            this.pictureBox121.Tag = "coin";
            this.pictureBox121.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox89
            // 
            this.pictureBox89.BackColor = System.Drawing.Color.White;
            this.pictureBox89.Location = new System.Drawing.Point(238, 665);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(14, 14);
            this.pictureBox89.TabIndex = 3;
            this.pictureBox89.TabStop = false;
            this.pictureBox89.Tag = "coin";
            this.pictureBox89.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox173
            // 
            this.pictureBox173.BackColor = System.Drawing.Color.White;
            this.pictureBox173.Location = new System.Drawing.Point(242, 23);
            this.pictureBox173.Name = "pictureBox173";
            this.pictureBox173.Size = new System.Drawing.Size(14, 14);
            this.pictureBox173.TabIndex = 3;
            this.pictureBox173.TabStop = false;
            this.pictureBox173.Tag = "coin";
            this.pictureBox173.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox164
            // 
            this.pictureBox164.BackColor = System.Drawing.Color.White;
            this.pictureBox164.Location = new System.Drawing.Point(135, 120);
            this.pictureBox164.Name = "pictureBox164";
            this.pictureBox164.Size = new System.Drawing.Size(14, 14);
            this.pictureBox164.TabIndex = 3;
            this.pictureBox164.TabStop = false;
            this.pictureBox164.Tag = "coin";
            this.pictureBox164.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox170
            // 
            this.pictureBox170.BackColor = System.Drawing.Color.White;
            this.pictureBox170.Location = new System.Drawing.Point(135, 184);
            this.pictureBox170.Name = "pictureBox170";
            this.pictureBox170.Size = new System.Drawing.Size(14, 14);
            this.pictureBox170.TabIndex = 3;
            this.pictureBox170.TabStop = false;
            this.pictureBox170.Tag = "coin";
            this.pictureBox170.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox72
            // 
            this.pictureBox72.BackColor = System.Drawing.Color.White;
            this.pictureBox72.Location = new System.Drawing.Point(454, 665);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(14, 14);
            this.pictureBox72.TabIndex = 3;
            this.pictureBox72.TabStop = false;
            this.pictureBox72.Tag = "coin";
            this.pictureBox72.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox120
            // 
            this.pictureBox120.BackColor = System.Drawing.Color.White;
            this.pictureBox120.Location = new System.Drawing.Point(135, 460);
            this.pictureBox120.Name = "pictureBox120";
            this.pictureBox120.Size = new System.Drawing.Size(14, 14);
            this.pictureBox120.TabIndex = 3;
            this.pictureBox120.TabStop = false;
            this.pictureBox120.Tag = "coin";
            this.pictureBox120.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox104
            // 
            this.pictureBox104.BackColor = System.Drawing.Color.White;
            this.pictureBox104.Location = new System.Drawing.Point(136, 665);
            this.pictureBox104.Name = "pictureBox104";
            this.pictureBox104.Size = new System.Drawing.Size(14, 14);
            this.pictureBox104.TabIndex = 3;
            this.pictureBox104.TabStop = false;
            this.pictureBox104.Tag = "coin";
            this.pictureBox104.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox119
            // 
            this.pictureBox119.BackColor = System.Drawing.Color.White;
            this.pictureBox119.Location = new System.Drawing.Point(303, 460);
            this.pictureBox119.Name = "pictureBox119";
            this.pictureBox119.Size = new System.Drawing.Size(14, 14);
            this.pictureBox119.TabIndex = 3;
            this.pictureBox119.TabStop = false;
            this.pictureBox119.Tag = "coin";
            this.pictureBox119.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox88
            // 
            this.pictureBox88.BackColor = System.Drawing.Color.White;
            this.pictureBox88.Location = new System.Drawing.Point(278, 665);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(14, 14);
            this.pictureBox88.TabIndex = 3;
            this.pictureBox88.TabStop = false;
            this.pictureBox88.Tag = "coin";
            this.pictureBox88.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox71
            // 
            this.pictureBox71.BackColor = System.Drawing.Color.White;
            this.pictureBox71.Location = new System.Drawing.Point(490, 665);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(14, 14);
            this.pictureBox71.TabIndex = 3;
            this.pictureBox71.TabStop = false;
            this.pictureBox71.Tag = "coin";
            this.pictureBox71.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox87
            // 
            this.pictureBox87.BackColor = System.Drawing.Color.White;
            this.pictureBox87.Location = new System.Drawing.Point(316, 665);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(14, 14);
            this.pictureBox87.TabIndex = 3;
            this.pictureBox87.TabStop = false;
            this.pictureBox87.Tag = "coin";
            this.pictureBox87.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox70
            // 
            this.pictureBox70.BackColor = System.Drawing.Color.White;
            this.pictureBox70.Location = new System.Drawing.Point(530, 665);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(14, 14);
            this.pictureBox70.TabIndex = 3;
            this.pictureBox70.TabStop = false;
            this.pictureBox70.Tag = "coin";
            this.pictureBox70.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox86
            // 
            this.pictureBox86.BackColor = System.Drawing.Color.White;
            this.pictureBox86.Location = new System.Drawing.Point(350, 665);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(14, 14);
            this.pictureBox86.TabIndex = 3;
            this.pictureBox86.TabStop = false;
            this.pictureBox86.Tag = "coin";
            this.pictureBox86.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox69
            // 
            this.pictureBox69.BackColor = System.Drawing.Color.White;
            this.pictureBox69.Location = new System.Drawing.Point(568, 665);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(14, 14);
            this.pictureBox69.TabIndex = 3;
            this.pictureBox69.TabStop = false;
            this.pictureBox69.Tag = "coin";
            this.pictureBox69.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox85
            // 
            this.pictureBox85.BackColor = System.Drawing.Color.White;
            this.pictureBox85.Location = new System.Drawing.Point(382, 665);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(14, 14);
            this.pictureBox85.TabIndex = 3;
            this.pictureBox85.TabStop = false;
            this.pictureBox85.Tag = "coin";
            this.pictureBox85.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox68
            // 
            this.pictureBox68.BackColor = System.Drawing.Color.White;
            this.pictureBox68.Location = new System.Drawing.Point(602, 665);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(14, 14);
            this.pictureBox68.TabIndex = 3;
            this.pictureBox68.TabStop = false;
            this.pictureBox68.Tag = "coin";
            this.pictureBox68.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox67
            // 
            this.pictureBox67.BackColor = System.Drawing.Color.White;
            this.pictureBox67.Location = new System.Drawing.Point(634, 665);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(14, 14);
            this.pictureBox67.TabIndex = 3;
            this.pictureBox67.TabStop = false;
            this.pictureBox67.Tag = "coin";
            this.pictureBox67.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox66
            // 
            this.pictureBox66.BackColor = System.Drawing.Color.White;
            this.pictureBox66.Location = new System.Drawing.Point(634, 626);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(14, 14);
            this.pictureBox66.TabIndex = 3;
            this.pictureBox66.TabStop = false;
            this.pictureBox66.Tag = "coin";
            this.pictureBox66.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackColor = System.Drawing.Color.White;
            this.pictureBox65.Location = new System.Drawing.Point(634, 595);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(14, 14);
            this.pictureBox65.TabIndex = 3;
            this.pictureBox65.TabStop = false;
            this.pictureBox65.Tag = "coin";
            this.pictureBox65.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox64
            // 
            this.pictureBox64.BackColor = System.Drawing.Color.White;
            this.pictureBox64.Location = new System.Drawing.Point(602, 595);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(14, 14);
            this.pictureBox64.TabIndex = 3;
            this.pictureBox64.TabStop = false;
            this.pictureBox64.Tag = "coin";
            this.pictureBox64.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.Color.White;
            this.pictureBox63.Location = new System.Drawing.Point(568, 595);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(14, 14);
            this.pictureBox63.TabIndex = 3;
            this.pictureBox63.TabStop = false;
            this.pictureBox63.Tag = "coin";
            this.pictureBox63.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox62
            // 
            this.pictureBox62.BackColor = System.Drawing.Color.White;
            this.pictureBox62.Location = new System.Drawing.Point(568, 562);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(14, 14);
            this.pictureBox62.TabIndex = 3;
            this.pictureBox62.TabStop = false;
            this.pictureBox62.Tag = "coin";
            this.pictureBox62.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox154
            // 
            this.pictureBox154.BackColor = System.Drawing.Color.White;
            this.pictureBox154.Location = new System.Drawing.Point(533, 184);
            this.pictureBox154.Name = "pictureBox154";
            this.pictureBox154.Size = new System.Drawing.Size(14, 14);
            this.pictureBox154.TabIndex = 3;
            this.pictureBox154.TabStop = false;
            this.pictureBox154.Tag = "coin";
            this.pictureBox154.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox153
            // 
            this.pictureBox153.BackColor = System.Drawing.Color.White;
            this.pictureBox153.Location = new System.Drawing.Point(568, 184);
            this.pictureBox153.Name = "pictureBox153";
            this.pictureBox153.Size = new System.Drawing.Size(14, 14);
            this.pictureBox153.TabIndex = 3;
            this.pictureBox153.TabStop = false;
            this.pictureBox153.Tag = "coin";
            this.pictureBox153.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.Color.White;
            this.pictureBox61.Location = new System.Drawing.Point(568, 528);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(14, 14);
            this.pictureBox61.TabIndex = 3;
            this.pictureBox61.TabStop = false;
            this.pictureBox61.Tag = "coin";
            this.pictureBox61.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox152
            // 
            this.pictureBox152.BackColor = System.Drawing.Color.White;
            this.pictureBox152.Location = new System.Drawing.Point(602, 184);
            this.pictureBox152.Name = "pictureBox152";
            this.pictureBox152.Size = new System.Drawing.Size(14, 14);
            this.pictureBox152.TabIndex = 3;
            this.pictureBox152.TabStop = false;
            this.pictureBox152.Tag = "coin";
            this.pictureBox152.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.Color.White;
            this.pictureBox60.Location = new System.Drawing.Point(602, 528);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(14, 14);
            this.pictureBox60.TabIndex = 3;
            this.pictureBox60.TabStop = false;
            this.pictureBox60.Tag = "coin";
            this.pictureBox60.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox151
            // 
            this.pictureBox151.BackColor = System.Drawing.Color.White;
            this.pictureBox151.Location = new System.Drawing.Point(634, 184);
            this.pictureBox151.Name = "pictureBox151";
            this.pictureBox151.Size = new System.Drawing.Size(14, 14);
            this.pictureBox151.TabIndex = 3;
            this.pictureBox151.TabStop = false;
            this.pictureBox151.Tag = "coin";
            this.pictureBox151.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackColor = System.Drawing.Color.White;
            this.pictureBox59.Location = new System.Drawing.Point(634, 528);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(14, 14);
            this.pictureBox59.TabIndex = 3;
            this.pictureBox59.TabStop = false;
            this.pictureBox59.Tag = "coin";
            this.pictureBox59.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox195
            // 
            this.pictureBox195.BackColor = System.Drawing.Color.White;
            this.pictureBox195.Location = new System.Drawing.Point(634, 83);
            this.pictureBox195.Name = "pictureBox195";
            this.pictureBox195.Size = new System.Drawing.Size(14, 14);
            this.pictureBox195.TabIndex = 3;
            this.pictureBox195.TabStop = false;
            this.pictureBox195.Tag = "coin";
            this.pictureBox195.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox150
            // 
            this.pictureBox150.BackColor = System.Drawing.Color.White;
            this.pictureBox150.Location = new System.Drawing.Point(634, 152);
            this.pictureBox150.Name = "pictureBox150";
            this.pictureBox150.Size = new System.Drawing.Size(14, 14);
            this.pictureBox150.TabIndex = 3;
            this.pictureBox150.TabStop = false;
            this.pictureBox150.Tag = "coin";
            this.pictureBox150.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox192
            // 
            this.pictureBox192.BackColor = System.Drawing.Color.White;
            this.pictureBox192.Location = new System.Drawing.Point(448, 23);
            this.pictureBox192.Name = "pictureBox192";
            this.pictureBox192.Size = new System.Drawing.Size(14, 14);
            this.pictureBox192.TabIndex = 3;
            this.pictureBox192.TabStop = false;
            this.pictureBox192.Tag = "coin";
            this.pictureBox192.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox163
            // 
            this.pictureBox163.BackColor = System.Drawing.Color.White;
            this.pictureBox163.Location = new System.Drawing.Point(454, 120);
            this.pictureBox163.Name = "pictureBox163";
            this.pictureBox163.Size = new System.Drawing.Size(14, 14);
            this.pictureBox163.TabIndex = 3;
            this.pictureBox163.TabStop = false;
            this.pictureBox163.Tag = "coin";
            this.pictureBox163.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox191
            // 
            this.pictureBox191.BackColor = System.Drawing.Color.White;
            this.pictureBox191.Location = new System.Drawing.Point(406, 23);
            this.pictureBox191.Name = "pictureBox191";
            this.pictureBox191.Size = new System.Drawing.Size(14, 14);
            this.pictureBox191.TabIndex = 3;
            this.pictureBox191.TabStop = false;
            this.pictureBox191.Tag = "coin";
            this.pictureBox191.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox206
            // 
            this.pictureBox206.BackColor = System.Drawing.Color.White;
            this.pictureBox206.Location = new System.Drawing.Point(420, 152);
            this.pictureBox206.Name = "pictureBox206";
            this.pictureBox206.Size = new System.Drawing.Size(14, 14);
            this.pictureBox206.TabIndex = 3;
            this.pictureBox206.TabStop = false;
            this.pictureBox206.Tag = "coin";
            this.pictureBox206.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox162
            // 
            this.pictureBox162.BackColor = System.Drawing.Color.White;
            this.pictureBox162.Location = new System.Drawing.Point(417, 120);
            this.pictureBox162.Name = "pictureBox162";
            this.pictureBox162.Size = new System.Drawing.Size(14, 14);
            this.pictureBox162.TabIndex = 3;
            this.pictureBox162.TabStop = false;
            this.pictureBox162.Tag = "coin";
            this.pictureBox162.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox158
            // 
            this.pictureBox158.BackColor = System.Drawing.Color.White;
            this.pictureBox158.Location = new System.Drawing.Point(309, 120);
            this.pictureBox158.Name = "pictureBox158";
            this.pictureBox158.Size = new System.Drawing.Size(14, 14);
            this.pictureBox158.TabIndex = 3;
            this.pictureBox158.TabStop = false;
            this.pictureBox158.Tag = "coin";
            this.pictureBox158.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.Color.White;
            this.pictureBox58.Location = new System.Drawing.Point(634, 496);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(14, 14);
            this.pictureBox58.TabIndex = 3;
            this.pictureBox58.TabStop = false;
            this.pictureBox58.Tag = "coin";
            this.pictureBox58.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox194
            // 
            this.pictureBox194.BackColor = System.Drawing.Color.White;
            this.pictureBox194.Location = new System.Drawing.Point(109, 23);
            this.pictureBox194.Name = "pictureBox194";
            this.pictureBox194.Size = new System.Drawing.Size(14, 14);
            this.pictureBox194.TabIndex = 3;
            this.pictureBox194.TabStop = false;
            this.pictureBox194.Tag = "coin";
            this.pictureBox194.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox190
            // 
            this.pictureBox190.BackColor = System.Drawing.Color.White;
            this.pictureBox190.Location = new System.Drawing.Point(634, 23);
            this.pictureBox190.Name = "pictureBox190";
            this.pictureBox190.Size = new System.Drawing.Size(14, 14);
            this.pictureBox190.TabIndex = 3;
            this.pictureBox190.TabStop = false;
            this.pictureBox190.Tag = "coin";
            this.pictureBox190.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox149
            // 
            this.pictureBox149.BackColor = System.Drawing.Color.White;
            this.pictureBox149.Location = new System.Drawing.Point(634, 120);
            this.pictureBox149.Name = "pictureBox149";
            this.pictureBox149.Size = new System.Drawing.Size(14, 14);
            this.pictureBox149.TabIndex = 3;
            this.pictureBox149.TabStop = false;
            this.pictureBox149.Tag = "coin";
            this.pictureBox149.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox161
            // 
            this.pictureBox161.BackColor = System.Drawing.Color.White;
            this.pictureBox161.Location = new System.Drawing.Point(382, 120);
            this.pictureBox161.Name = "pictureBox161";
            this.pictureBox161.Size = new System.Drawing.Size(14, 14);
            this.pictureBox161.TabIndex = 3;
            this.pictureBox161.TabStop = false;
            this.pictureBox161.Tag = "coin";
            this.pictureBox161.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox157
            // 
            this.pictureBox157.BackColor = System.Drawing.Color.White;
            this.pictureBox157.Location = new System.Drawing.Point(277, 120);
            this.pictureBox157.Name = "pictureBox157";
            this.pictureBox157.Size = new System.Drawing.Size(14, 14);
            this.pictureBox157.TabIndex = 3;
            this.pictureBox157.TabStop = false;
            this.pictureBox157.Tag = "coin";
            this.pictureBox157.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox189
            // 
            this.pictureBox189.BackColor = System.Drawing.Color.White;
            this.pictureBox189.Location = new System.Drawing.Point(602, 23);
            this.pictureBox189.Name = "pictureBox189";
            this.pictureBox189.Size = new System.Drawing.Size(14, 14);
            this.pictureBox189.TabIndex = 3;
            this.pictureBox189.TabStop = false;
            this.pictureBox189.Tag = "coin";
            this.pictureBox189.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.Color.White;
            this.pictureBox57.Location = new System.Drawing.Point(634, 460);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(14, 14);
            this.pictureBox57.TabIndex = 3;
            this.pictureBox57.TabStop = false;
            this.pictureBox57.Tag = "coin";
            this.pictureBox57.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox148
            // 
            this.pictureBox148.BackColor = System.Drawing.Color.White;
            this.pictureBox148.Location = new System.Drawing.Point(602, 120);
            this.pictureBox148.Name = "pictureBox148";
            this.pictureBox148.Size = new System.Drawing.Size(14, 14);
            this.pictureBox148.TabIndex = 3;
            this.pictureBox148.TabStop = false;
            this.pictureBox148.Tag = "coin";
            this.pictureBox148.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox160
            // 
            this.pictureBox160.BackColor = System.Drawing.Color.White;
            this.pictureBox160.Location = new System.Drawing.Point(348, 120);
            this.pictureBox160.Name = "pictureBox160";
            this.pictureBox160.Size = new System.Drawing.Size(14, 14);
            this.pictureBox160.TabIndex = 3;
            this.pictureBox160.TabStop = false;
            this.pictureBox160.Tag = "coin";
            this.pictureBox160.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox156
            // 
            this.pictureBox156.BackColor = System.Drawing.Color.White;
            this.pictureBox156.Location = new System.Drawing.Point(243, 120);
            this.pictureBox156.Name = "pictureBox156";
            this.pictureBox156.Size = new System.Drawing.Size(14, 14);
            this.pictureBox156.TabIndex = 3;
            this.pictureBox156.TabStop = false;
            this.pictureBox156.Tag = "coin";
            this.pictureBox156.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox188
            // 
            this.pictureBox188.BackColor = System.Drawing.Color.White;
            this.pictureBox188.Location = new System.Drawing.Point(568, 23);
            this.pictureBox188.Name = "pictureBox188";
            this.pictureBox188.Size = new System.Drawing.Size(14, 14);
            this.pictureBox188.TabIndex = 3;
            this.pictureBox188.TabStop = false;
            this.pictureBox188.Tag = "coin";
            this.pictureBox188.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox80
            // 
            this.pictureBox80.BackColor = System.Drawing.Color.White;
            this.pictureBox80.Location = new System.Drawing.Point(602, 460);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(14, 14);
            this.pictureBox80.TabIndex = 3;
            this.pictureBox80.TabStop = false;
            this.pictureBox80.Tag = "coin";
            this.pictureBox80.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox147
            // 
            this.pictureBox147.BackColor = System.Drawing.Color.White;
            this.pictureBox147.Location = new System.Drawing.Point(568, 120);
            this.pictureBox147.Name = "pictureBox147";
            this.pictureBox147.Size = new System.Drawing.Size(14, 14);
            this.pictureBox147.TabIndex = 3;
            this.pictureBox147.TabStop = false;
            this.pictureBox147.Tag = "coin";
            this.pictureBox147.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox155
            // 
            this.pictureBox155.BackColor = System.Drawing.Color.White;
            this.pictureBox155.Location = new System.Drawing.Point(208, 120);
            this.pictureBox155.Name = "pictureBox155";
            this.pictureBox155.Size = new System.Drawing.Size(14, 14);
            this.pictureBox155.TabIndex = 3;
            this.pictureBox155.TabStop = false;
            this.pictureBox155.Tag = "coin";
            this.pictureBox155.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox187
            // 
            this.pictureBox187.BackColor = System.Drawing.Color.White;
            this.pictureBox187.Location = new System.Drawing.Point(533, 23);
            this.pictureBox187.Name = "pictureBox187";
            this.pictureBox187.Size = new System.Drawing.Size(14, 14);
            this.pictureBox187.TabIndex = 3;
            this.pictureBox187.TabStop = false;
            this.pictureBox187.Tag = "coin";
            this.pictureBox187.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox56
            // 
            this.pictureBox56.BackColor = System.Drawing.Color.White;
            this.pictureBox56.Location = new System.Drawing.Point(568, 460);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(14, 14);
            this.pictureBox56.TabIndex = 3;
            this.pictureBox56.TabStop = false;
            this.pictureBox56.Tag = "coin";
            this.pictureBox56.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox143
            // 
            this.pictureBox143.BackColor = System.Drawing.Color.White;
            this.pictureBox143.Location = new System.Drawing.Point(533, 120);
            this.pictureBox143.Name = "pictureBox143";
            this.pictureBox143.Size = new System.Drawing.Size(14, 14);
            this.pictureBox143.TabIndex = 3;
            this.pictureBox143.TabStop = false;
            this.pictureBox143.Tag = "coin";
            this.pictureBox143.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(533, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            this.pictureBox1.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox84
            // 
            this.pictureBox84.BackColor = System.Drawing.Color.White;
            this.pictureBox84.Location = new System.Drawing.Point(530, 595);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(14, 14);
            this.pictureBox84.TabIndex = 3;
            this.pictureBox84.TabStop = false;
            this.pictureBox84.Tag = "coin";
            this.pictureBox84.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox83
            // 
            this.pictureBox83.BackColor = System.Drawing.Color.White;
            this.pictureBox83.Location = new System.Drawing.Point(490, 595);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(14, 14);
            this.pictureBox83.TabIndex = 3;
            this.pictureBox83.TabStop = false;
            this.pictureBox83.Tag = "coin";
            this.pictureBox83.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox82
            // 
            this.pictureBox82.BackColor = System.Drawing.Color.White;
            this.pictureBox82.Location = new System.Drawing.Point(490, 562);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(14, 14);
            this.pictureBox82.TabIndex = 3;
            this.pictureBox82.TabStop = false;
            this.pictureBox82.Tag = "coin";
            this.pictureBox82.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox81
            // 
            this.pictureBox81.BackColor = System.Drawing.Color.White;
            this.pictureBox81.Location = new System.Drawing.Point(490, 528);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(14, 14);
            this.pictureBox81.TabIndex = 3;
            this.pictureBox81.TabStop = false;
            this.pictureBox81.Tag = "coin";
            this.pictureBox81.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.Color.White;
            this.pictureBox55.Location = new System.Drawing.Point(490, 496);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(14, 14);
            this.pictureBox55.TabIndex = 3;
            this.pictureBox55.TabStop = false;
            this.pictureBox55.Tag = "coin";
            this.pictureBox55.Click += new System.EventHandler(this.coin_Click);
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackColor = System.Drawing.Color.White;
            this.pictureBox54.Location = new System.Drawing.Point(490, 460);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(14, 14);
            this.pictureBox54.TabIndex = 3;
            this.pictureBox54.TabStop = false;
            this.pictureBox54.Tag = "coin";
            this.pictureBox54.Click += new System.EventHandler(this.coin_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.White;
            this.coin.Location = new System.Drawing.Point(454, 460);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(14, 14);
            this.coin.TabIndex = 3;
            this.coin.TabStop = false;
            this.coin.Tag = "coin";
            this.coin.Click += new System.EventHandler(this.coin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(679, 710);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox53);
            this.Controls.Add(this.pictureBox52);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox51);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox50);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox46);
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.blue_ghost);
            this.Controls.Add(this.orange_ghost);
            this.Controls.Add(this.pink_ghost);
            this.Controls.Add(this.red_ghost);
            this.Controls.Add(this.pictureBox78);
            this.Controls.Add(this.pictureBox186);
            this.Controls.Add(this.pictureBox185);
            this.Controls.Add(this.pictureBox205);
            this.Controls.Add(this.pictureBox202);
            this.Controls.Add(this.pictureBox204);
            this.Controls.Add(this.pictureBox201);
            this.Controls.Add(this.pictureBox203);
            this.Controls.Add(this.pictureBox200);
            this.Controls.Add(this.pictureBox183);
            this.Controls.Add(this.pictureBox199);
            this.Controls.Add(this.pictureBox184);
            this.Controls.Add(this.pictureBox182);
            this.Controls.Add(this.pictureBox176);
            this.Controls.Add(this.pictureBox146);
            this.Controls.Add(this.pictureBox159);
            this.Controls.Add(this.pictureBox193);
            this.Controls.Add(this.pictureBox197);
            this.Controls.Add(this.pictureBox79);
            this.Controls.Add(this.pictureBox196);
            this.Controls.Add(this.pictureBox77);
            this.Controls.Add(this.pictureBox76);
            this.Controls.Add(this.pictureBox145);
            this.Controls.Add(this.pictureBox75);
            this.Controls.Add(this.pictureBox144);
            this.Controls.Add(this.pictureBox74);
            this.Controls.Add(this.pictureBox142);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox141);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox140);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox139);
            this.Controls.Add(this.pictureBox138);
            this.Controls.Add(this.pictureBox99);
            this.Controls.Add(this.pictureBox103);
            this.Controls.Add(this.pictureBox98);
            this.Controls.Add(this.pictureBox126);
            this.Controls.Add(this.pictureBox130);
            this.Controls.Add(this.pictureBox134);
            this.Controls.Add(this.pictureBox133);
            this.Controls.Add(this.pictureBox132);
            this.Controls.Add(this.pictureBox131);
            this.Controls.Add(this.pictureBox129);
            this.Controls.Add(this.pictureBox128);
            this.Controls.Add(this.pictureBox127);
            this.Controls.Add(this.pictureBox102);
            this.Controls.Add(this.pictureBox97);
            this.Controls.Add(this.pictureBox101);
            this.Controls.Add(this.pictureBox96);
            this.Controls.Add(this.pictureBox177);
            this.Controls.Add(this.pictureBox181);
            this.Controls.Add(this.pictureBox178);
            this.Controls.Add(this.pictureBox175);
            this.Controls.Add(this.pictureBox167);
            this.Controls.Add(this.pictureBox172);
            this.Controls.Add(this.pictureBox118);
            this.Controls.Add(this.pictureBox180);
            this.Controls.Add(this.pictureBox166);
            this.Controls.Add(this.pictureBox117);
            this.Controls.Add(this.pictureBox169);
            this.Controls.Add(this.pictureBox116);
            this.Controls.Add(this.pictureBox168);
            this.Controls.Add(this.pictureBox115);
            this.Controls.Add(this.pictureBox114);
            this.Controls.Add(this.pictureBox113);
            this.Controls.Add(this.pictureBox112);
            this.Controls.Add(this.pictureBox137);
            this.Controls.Add(this.pictureBox136);
            this.Controls.Add(this.pictureBox135);
            this.Controls.Add(this.pictureBox111);
            this.Controls.Add(this.pictureBox110);
            this.Controls.Add(this.pictureBox109);
            this.Controls.Add(this.pictureBox108);
            this.Controls.Add(this.pictureBox198);
            this.Controls.Add(this.pictureBox100);
            this.Controls.Add(this.pictureBox95);
            this.Controls.Add(this.pictureBox94);
            this.Controls.Add(this.pictureBox93);
            this.Controls.Add(this.pictureBox92);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox107);
            this.Controls.Add(this.pictureBox124);
            this.Controls.Add(this.pictureBox91);
            this.Controls.Add(this.pictureBox106);
            this.Controls.Add(this.pictureBox123);
            this.Controls.Add(this.pictureBox90);
            this.Controls.Add(this.pictureBox174);
            this.Controls.Add(this.pictureBox165);
            this.Controls.Add(this.pictureBox171);
            this.Controls.Add(this.pictureBox73);
            this.Controls.Add(this.pictureBox122);
            this.Controls.Add(this.pictureBox105);
            this.Controls.Add(this.pictureBox125);
            this.Controls.Add(this.pictureBox121);
            this.Controls.Add(this.pictureBox89);
            this.Controls.Add(this.pictureBox173);
            this.Controls.Add(this.pictureBox164);
            this.Controls.Add(this.pictureBox170);
            this.Controls.Add(this.pictureBox72);
            this.Controls.Add(this.pictureBox120);
            this.Controls.Add(this.pictureBox104);
            this.Controls.Add(this.pictureBox119);
            this.Controls.Add(this.pictureBox88);
            this.Controls.Add(this.pictureBox71);
            this.Controls.Add(this.pictureBox87);
            this.Controls.Add(this.pictureBox70);
            this.Controls.Add(this.pictureBox86);
            this.Controls.Add(this.pictureBox69);
            this.Controls.Add(this.pictureBox85);
            this.Controls.Add(this.pictureBox68);
            this.Controls.Add(this.pictureBox67);
            this.Controls.Add(this.pictureBox66);
            this.Controls.Add(this.pictureBox65);
            this.Controls.Add(this.pictureBox64);
            this.Controls.Add(this.pictureBox63);
            this.Controls.Add(this.pictureBox62);
            this.Controls.Add(this.pictureBox154);
            this.Controls.Add(this.pictureBox153);
            this.Controls.Add(this.pictureBox61);
            this.Controls.Add(this.pictureBox152);
            this.Controls.Add(this.pictureBox60);
            this.Controls.Add(this.pictureBox151);
            this.Controls.Add(this.pictureBox150);
            this.Controls.Add(this.pictureBox192);
            this.Controls.Add(this.pictureBox163);
            this.Controls.Add(this.pictureBox191);
            this.Controls.Add(this.pictureBox206);
            this.Controls.Add(this.pictureBox162);
            this.Controls.Add(this.pictureBox158);
            this.Controls.Add(this.pictureBox58);
            this.Controls.Add(this.pictureBox194);
            this.Controls.Add(this.pictureBox190);
            this.Controls.Add(this.pictureBox149);
            this.Controls.Add(this.pictureBox161);
            this.Controls.Add(this.pictureBox157);
            this.Controls.Add(this.pictureBox189);
            this.Controls.Add(this.pictureBox57);
            this.Controls.Add(this.pictureBox148);
            this.Controls.Add(this.pictureBox160);
            this.Controls.Add(this.pictureBox156);
            this.Controls.Add(this.pictureBox188);
            this.Controls.Add(this.pictureBox80);
            this.Controls.Add(this.pictureBox147);
            this.Controls.Add(this.pictureBox155);
            this.Controls.Add(this.pictureBox187);
            this.Controls.Add(this.pictureBox56);
            this.Controls.Add(this.pictureBox143);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox84);
            this.Controls.Add(this.pictureBox83);
            this.Controls.Add(this.pictureBox82);
            this.Controls.Add(this.pictureBox81);
            this.Controls.Add(this.pictureBox55);
            this.Controls.Add(this.pictureBox54);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.special);
            this.Controls.Add(this.pictureBox59);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox195);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox179);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAC-MAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox186)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox185)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox205)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox202)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox204)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox201)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox203)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox199)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox176)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox146)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox159)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox193)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox142)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox140)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox139)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox138)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox130)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox133)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox132)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox131)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox129)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox177)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox181)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox178)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox175)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox172)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox118)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox180)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox179)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox166)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox117)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox169)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox116)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox168)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox115)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox114)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox113)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox112)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox137)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox136)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox108)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox107)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox124)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox106)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox174)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox165)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox171)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox121)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox173)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox164)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox170)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox120)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox154)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox152)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox195)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox150)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox192)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox163)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox191)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox206)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox162)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox158)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox194)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox190)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox149)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox161)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox157)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox189)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox148)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox160)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox156)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox188)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox147)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox155)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox187)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.Label txt_score;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox red_ghost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pink_ghost;
        private System.Windows.Forms.PictureBox orange_ghost;
        private System.Windows.Forms.PictureBox blue_ghost;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pictureBox46;
        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.PictureBox pictureBox50;
        private System.Windows.Forms.PictureBox pictureBox51;
        private System.Windows.Forms.PictureBox pictureBox52;
        private System.Windows.Forms.PictureBox pictureBox54;
        private System.Windows.Forms.PictureBox pictureBox55;
        private System.Windows.Forms.PictureBox pictureBox56;
        private System.Windows.Forms.PictureBox pictureBox57;
        private System.Windows.Forms.PictureBox pictureBox58;
        private System.Windows.Forms.PictureBox pictureBox59;
        private System.Windows.Forms.PictureBox pictureBox60;
        private System.Windows.Forms.PictureBox pictureBox61;
        private System.Windows.Forms.PictureBox pictureBox62;
        private System.Windows.Forms.PictureBox pictureBox63;
        private System.Windows.Forms.PictureBox pictureBox64;
        private System.Windows.Forms.PictureBox pictureBox65;
        private System.Windows.Forms.PictureBox pictureBox66;
        private System.Windows.Forms.PictureBox pictureBox67;
        private System.Windows.Forms.PictureBox pictureBox68;
        private System.Windows.Forms.PictureBox pictureBox69;
        private System.Windows.Forms.PictureBox pictureBox70;
        private System.Windows.Forms.PictureBox pictureBox71;
        private System.Windows.Forms.PictureBox pictureBox72;
        private System.Windows.Forms.PictureBox pictureBox73;
        private System.Windows.Forms.PictureBox pictureBox53;
        private System.Windows.Forms.PictureBox pictureBox80;
        private System.Windows.Forms.PictureBox pictureBox81;
        private System.Windows.Forms.PictureBox pictureBox82;
        private System.Windows.Forms.PictureBox pictureBox83;
        private System.Windows.Forms.PictureBox pictureBox84;
        private System.Windows.Forms.PictureBox pictureBox85;
        private System.Windows.Forms.PictureBox pictureBox86;
        private System.Windows.Forms.PictureBox pictureBox87;
        private System.Windows.Forms.PictureBox pictureBox88;
        private System.Windows.Forms.PictureBox pictureBox89;
        private System.Windows.Forms.PictureBox pictureBox90;
        private System.Windows.Forms.PictureBox pictureBox91;
        private System.Windows.Forms.PictureBox pictureBox92;
        private System.Windows.Forms.PictureBox pictureBox93;
        private System.Windows.Forms.PictureBox pictureBox94;
        private System.Windows.Forms.PictureBox pictureBox95;
        private System.Windows.Forms.PictureBox pictureBox96;
        private System.Windows.Forms.PictureBox pictureBox97;
        private System.Windows.Forms.PictureBox pictureBox98;
        private System.Windows.Forms.PictureBox pictureBox100;
        private System.Windows.Forms.PictureBox pictureBox101;
        private System.Windows.Forms.PictureBox pictureBox102;
        private System.Windows.Forms.PictureBox pictureBox103;
        private System.Windows.Forms.PictureBox pictureBox104;
        private System.Windows.Forms.PictureBox pictureBox105;
        private System.Windows.Forms.PictureBox pictureBox106;
        private System.Windows.Forms.PictureBox pictureBox107;
        private System.Windows.Forms.PictureBox pictureBox108;
        private System.Windows.Forms.PictureBox pictureBox109;
        private System.Windows.Forms.PictureBox pictureBox110;
        private System.Windows.Forms.PictureBox pictureBox111;
        private System.Windows.Forms.PictureBox pictureBox112;
        private System.Windows.Forms.PictureBox pictureBox113;
        private System.Windows.Forms.PictureBox pictureBox114;
        private System.Windows.Forms.PictureBox pictureBox115;
        private System.Windows.Forms.PictureBox pictureBox116;
        private System.Windows.Forms.PictureBox pictureBox117;
        private System.Windows.Forms.PictureBox pictureBox118;
        private System.Windows.Forms.PictureBox pictureBox119;
        private System.Windows.Forms.PictureBox pictureBox120;
        private System.Windows.Forms.PictureBox pictureBox121;
        private System.Windows.Forms.PictureBox pictureBox122;
        private System.Windows.Forms.PictureBox pictureBox123;
        private System.Windows.Forms.PictureBox pictureBox124;
        private System.Windows.Forms.PictureBox pictureBox99;
        private System.Windows.Forms.PictureBox pictureBox125;
        private System.Windows.Forms.PictureBox pictureBox126;
        private System.Windows.Forms.PictureBox pictureBox127;
        private System.Windows.Forms.PictureBox pictureBox128;
        private System.Windows.Forms.PictureBox pictureBox129;
        private System.Windows.Forms.PictureBox pictureBox130;
        private System.Windows.Forms.PictureBox pictureBox131;
        private System.Windows.Forms.PictureBox pictureBox132;
        private System.Windows.Forms.PictureBox pictureBox133;
        private System.Windows.Forms.PictureBox pictureBox134;
        private System.Windows.Forms.PictureBox pictureBox135;
        private System.Windows.Forms.PictureBox pictureBox136;
        private System.Windows.Forms.PictureBox pictureBox137;
        private System.Windows.Forms.PictureBox pictureBox138;
        private System.Windows.Forms.PictureBox pictureBox139;
        private System.Windows.Forms.PictureBox pictureBox140;
        private System.Windows.Forms.PictureBox pictureBox141;
        private System.Windows.Forms.PictureBox pictureBox142;
        private System.Windows.Forms.PictureBox pictureBox144;
        private System.Windows.Forms.PictureBox pictureBox145;
        private System.Windows.Forms.PictureBox pictureBox146;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox74;
        private System.Windows.Forms.PictureBox pictureBox75;
        private System.Windows.Forms.PictureBox pictureBox76;
        private System.Windows.Forms.PictureBox pictureBox77;
        private System.Windows.Forms.PictureBox pictureBox78;
        private System.Windows.Forms.PictureBox pictureBox79;
        private System.Windows.Forms.PictureBox pictureBox143;
        private System.Windows.Forms.PictureBox pictureBox147;
        private System.Windows.Forms.PictureBox pictureBox148;
        private System.Windows.Forms.PictureBox pictureBox149;
        private System.Windows.Forms.PictureBox pictureBox150;
        private System.Windows.Forms.PictureBox pictureBox151;
        private System.Windows.Forms.PictureBox pictureBox152;
        private System.Windows.Forms.PictureBox pictureBox153;
        private System.Windows.Forms.PictureBox pictureBox154;
        private System.Windows.Forms.PictureBox pictureBox155;
        private System.Windows.Forms.PictureBox pictureBox156;
        private System.Windows.Forms.PictureBox pictureBox157;
        private System.Windows.Forms.PictureBox pictureBox158;
        private System.Windows.Forms.PictureBox pictureBox159;
        private System.Windows.Forms.PictureBox pictureBox160;
        private System.Windows.Forms.PictureBox pictureBox161;
        private System.Windows.Forms.PictureBox pictureBox162;
        private System.Windows.Forms.PictureBox pictureBox163;
        private System.Windows.Forms.PictureBox pictureBox164;
        private System.Windows.Forms.PictureBox pictureBox165;
        private System.Windows.Forms.PictureBox pictureBox166;
        private System.Windows.Forms.PictureBox pictureBox167;
        private System.Windows.Forms.PictureBox pictureBox168;
        private System.Windows.Forms.PictureBox pictureBox169;
        private System.Windows.Forms.PictureBox pictureBox170;
        private System.Windows.Forms.PictureBox pictureBox171;
        private System.Windows.Forms.PictureBox pictureBox172;
        private System.Windows.Forms.PictureBox pictureBox173;
        private System.Windows.Forms.PictureBox pictureBox174;
        private System.Windows.Forms.PictureBox pictureBox175;
        private System.Windows.Forms.PictureBox pictureBox176;
        private System.Windows.Forms.PictureBox pictureBox177;
        private System.Windows.Forms.PictureBox pictureBox179;
        private System.Windows.Forms.PictureBox pictureBox180;
        private System.Windows.Forms.PictureBox pictureBox178;
        private System.Windows.Forms.PictureBox pictureBox181;
        private System.Windows.Forms.PictureBox pictureBox182;
        private System.Windows.Forms.PictureBox pictureBox183;
        private System.Windows.Forms.PictureBox pictureBox184;
        private System.Windows.Forms.PictureBox pictureBox185;
        private System.Windows.Forms.PictureBox pictureBox186;
        private System.Windows.Forms.PictureBox pictureBox187;
        private System.Windows.Forms.PictureBox pictureBox188;
        private System.Windows.Forms.PictureBox pictureBox189;
        private System.Windows.Forms.PictureBox pictureBox190;
        private System.Windows.Forms.PictureBox pictureBox191;
        private System.Windows.Forms.PictureBox pictureBox192;
        private System.Windows.Forms.PictureBox pictureBox193;
        private System.Windows.Forms.PictureBox pictureBox194;
        private System.Windows.Forms.PictureBox pictureBox195;
        private System.Windows.Forms.PictureBox pictureBox196;
        private System.Windows.Forms.PictureBox pictureBox197;
        private System.Windows.Forms.PictureBox pictureBox198;
        private System.Windows.Forms.PictureBox pictureBox199;
        private System.Windows.Forms.PictureBox pictureBox200;
        private System.Windows.Forms.PictureBox pictureBox201;
        private System.Windows.Forms.PictureBox pictureBox202;
        private System.Windows.Forms.PictureBox pictureBox203;
        private System.Windows.Forms.PictureBox pictureBox204;
        private System.Windows.Forms.PictureBox pictureBox205;
        private System.Windows.Forms.PictureBox pictureBox206;
        private System.Windows.Forms.Timer Ghost_loop;
        private System.Windows.Forms.Timer special_timer;
        private System.Windows.Forms.PictureBox special;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Timer ghost_wait;
        private System.Windows.Forms.Timer ghost_wait2;
        private System.Windows.Forms.Timer ghost_wait3;
        private System.Windows.Forms.Timer ghost_wait4;
    }
}

