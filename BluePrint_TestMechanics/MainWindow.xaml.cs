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
using System.IO;
using BluePrint_TestMechanics.TypeCourier;

namespace BluePrint_TestMechanics
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool flag = false;

        public int Count = 0;

        #region

        Knight Player = (new Knight()
        {   HP = 100,
            Atk = 20
        });

        Knight Enemy = (new Knight()
        {
            HP = 150,
            Atk = 15
        });

        #endregion

        public static int[] EnemyDefenseSettings()
        {
            int[] EnemyActions = new int[4] { 1, 2, 3, 4 };
            return EnemyActions;
        }

        public MainWindow()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("TextResourse.txt", true))
            {
                string Vault = sr.ReadToEnd();
                string[] BattleBegin = Vault.Split('#');
                string Helper = "";

                if (Count <= BattleBegin.Length - 1)
                {
                    Helper = BattleBegin[Count];
                    FightDescriotions.Text += Helper;
                    Count++;
                }
            }
            DefenseOptions.Visibility = System.Windows.Visibility.Hidden;
            ExitFromBattle.Visibility = System.Windows.Visibility.Hidden;
        }

        

        private void AttackAction1_Click(object sender, RoutedEventArgs e)  //System.EventArgs e (а счём чёрт не шутит?)
        {
                                                                            //AttackAction1.Click += new RoutedEventHandler(AttackAction1_Click);
            flag = true;
            bool Attack = true;
            Random EnemyDefense = new Random();
            int[] NewDefenseSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewDefenseSettings[EnemyDefense.Next(NewDefenseSettings.Length)];
            }
                                                                            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Attack == true && Def == 1)
            {
                FightDescriotions.Text = "Противник заблокировал ваш удар!";
            }
            else
            {
                Enemy.HP = Enemy.HP - Player.Atk + 5;

                using (StreamReader sr = new StreamReader("TextResourse_Attack_On_Head.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)];    // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }

        #region
        private void AttackAction2_Click(object sender, RoutedEventArgs e)
        {
            flag = true;
            bool Attack = true;
            Random EnemyDefense = new Random();
            int[] NewDefenseSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewDefenseSettings[EnemyDefense.Next(NewDefenseSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Attack == true && Def == 2)
            {
                FightDescriotions.Text = "Противник заблокировал ваш удар!";
            }
            else
            {
                Enemy.HP = Enemy.HP - Player.Atk;

                using (StreamReader sr = new StreamReader("TextResourse_Attack_On_Body.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion

        #region
        private void AttackAction3_Click(object sender, RoutedEventArgs e)
        {
            flag = true;
            bool Attack = true;
            Random EnemyDefense = new Random();
            int[] NewDefenseSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewDefenseSettings[EnemyDefense.Next(NewDefenseSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Attack == true && Def == 3)
            {
                FightDescriotions.Text = "Противник заблокировал ваш удар!";
            }
            else
            {
                Enemy.HP = Enemy.HP - Player.Atk;

                using (StreamReader sr = new StreamReader("TextResourse_Attack_On_Legs.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion

        #region
        private void AttackAction4_Click(object sender, RoutedEventArgs e)
        {
            flag = true;
            bool Attack = true;
            Random EnemyDefense = new Random();
            int[] NewDefenseSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewDefenseSettings[EnemyDefense.Next(NewDefenseSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Attack == true && Def == 4)
            {
                FightDescriotions.Text = "Противник заблокировал ваш удар!";
            }
            else
            {
                Enemy.HP = Enemy.HP - Player.Atk * 3;

                using (StreamReader sr = new StreamReader("TextResourse_Web_Attack.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion

        #region
        private void DenenseAction1_Click(object sender, RoutedEventArgs e)
        {
            bool Block = true;
            Random EnemyAttack = new Random();
            int[] NewAttackSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewAttackSettings[EnemyAttack.Next(NewAttackSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Block == true && Def == 1)
            {
                FightDescriotions.Text = "Вы успешно ушли от атаки!";
            }
            else
            {
                Player.HP = Player.HP - Enemy.Atk + 5;

                using (StreamReader sr = new StreamReader("TextResourse_Block_Head.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion

        #region
        private void DenenseAction2_Click(object sender, RoutedEventArgs e)
        {
            bool Block = true;
            Random EnemyAttack = new Random();
            int[] NewAttackSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewAttackSettings[EnemyAttack.Next(NewAttackSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Block == true && Def == 2)
            {
                FightDescriotions.Text = "Вы успешно ушли от атаки!";
            }
            else
            {
                Player.HP = Player.HP - Enemy.Atk + 5;

                using (StreamReader sr = new StreamReader("TextResourse_Block_Body.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion

        #region
        private void DenenseAction3_Click(object sender, RoutedEventArgs e)
        {
            bool Block = true;
            Random EnemyAttack = new Random();
            int[] NewAttackSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewAttackSettings[EnemyAttack.Next(NewAttackSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Block == true && Def == 3)
            {
                FightDescriotions.Text = "Вы успешно ушли от атаки!";
            }
            else
            {
                Player.HP = Player.HP - Enemy.Atk + 5;

                using (StreamReader sr = new StreamReader("TextResourse_Block_Legs.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion

        #region
        private void DenenseAction4_Click(object sender, RoutedEventArgs e)
        {
            bool Block = true;
            Random EnemyAttack = new Random();
            int[] NewAttackSettings = EnemyDefenseSettings();
            int Def = 0;
            for (int i = 0; i < 1; i++)
            {
                Def = NewAttackSettings[EnemyAttack.Next(NewAttackSettings.Length)];
            }
            //FightDescriotions.Text = Convert.ToString(Def); // Выводил данные для проверки
            if (Block == true && Def == 4)
            {
                FightDescriotions.Text = "Вы успешно ушли от атаки!";
            }
            else
            {
                Player.HP = Player.HP - Enemy.Atk + 5;

                using (StreamReader sr = new StreamReader("TextResourse_Block_Head.txt", true))
                {
                    Random rnd = new Random();
                    string Vault = sr.ReadToEnd();
                    string Helper = "";
                    string[] BattleBegin = Vault.Split('#');
                    Helper += BattleBegin[rnd.Next(BattleBegin.Length)]; // Вывод описание одного и того же действия
                    FightDescriotions.Text = Helper;
                }
            }
        }
        #endregion


        public void Turn()
        {
            while (Player.HP > 0 & Enemy.HP > 0)
            {
                if (flag == true)
                {
                    flag = false;
                    AttackOptions.Visibility = System.Windows.Visibility.Hidden;
                    DefenseOptions.Visibility = System.Windows.Visibility.Visible;

                    FightDescriotions.Text = "Противник готовится атаковать, нужно защититься!";


                }
                else
                {

                }
            }
        }
    }
}
