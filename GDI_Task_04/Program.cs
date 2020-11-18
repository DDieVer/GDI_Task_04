using System;

namespace GDI_Task_04
{
    class Program
    {
        static int monsterHelth;
        static int PlayerHelth = 1000;
        static int Dificult;
        static int mhp;
        static Random rnd = new Random();
        static int damage = 0;
        static int bonus = 0;
        static int LimitS = 0;
        static int LimitM = 0;
        static int LimitP = 0;
        static int Time;
        static int Invent;
        static int maxAt;

        static void MonsterAtack()//Стандартная атака монстра
        {
            int a = rnd.Next(1, maxAt) * (2 + damage);
            PlayerHelth -= a;
            Console.WriteLine($"Монстр накинулся на вас!\t\t\t(Вы потеряли {a} HP)\n");
        }

        static void Rage()//Стандартная атака монстра
        {
            damage += 1;
            Console.WriteLine($"Монстр в ярости, берегитесь!!!\t\t\t(Урон монстра уеличен)\n");
        }

        static void PlayerAtack()//стандартная атака игрока
        {
            int a = rnd.Next(1, 50) * (2 + bonus);
            monsterHelth -= a;
            Console.WriteLine($"Вы берёте свой меч и идёте в атаку\t\t\t(Монстр потерял {a} HP)\n");
        }

        static void shield()//лечение и защита игрока
        {
            int a = rnd.Next(1, 30) * (2 + bonus);
            PlayerHelth += a;
            if(damage > 0) damage = -1;
            LimitS -= Time; 
            Console.WriteLine($"Вы скрываетесь за щитом чтобы превести дух.\t\t\t(Вы востановили {a} HP, монстру сложнее по вам попасть)\n");
        }

        static void PowerUp()//лечение и защита игрока
        {
            bonus = 3;
            Console.WriteLine($"Вы вспоминаете родные края, это придаёт вам сил!\t\t\t(Вы получили бонус ко всем действиям +3)\n");
            LimitP -= 2 + Time;
        }

        static void heal()//лечение и защита игрока
        {
            PlayerHelth += 100;
            Console.WriteLine($"Вы выхватываете бутылёк из-за пазухи и выпиваете его.\t\t\t(Вы востановили 100 HP)\n");
            Invent--;
        }

        static void magic()//лечение и защита игрока
        {
            int a = rnd.Next(1, 100) * (2 + bonus);
            monsterHelth -= a;
            LimitM -= Time;
            Console.WriteLine($"Вы насылаете на чудище лучь магического света!\t\t\t(Монстр потерял {a} HP)\n");
        }
    





        static void monFace(int monType)//Вывод монстра на экран 
        {
            if(monType == 2)
            {
                Console.WriteLine("██████████▀▀▀▀▀▀▀▀▀▀▀▀▀██████████");
                Console.WriteLine("█████▀▀░░░░░░░░░░░░░░░░░░░▀▀█████");
                Console.WriteLine("███▀░░░░░░░░░░░░░░░░░░░░░░░░░▀███\t\tКоманды");
                Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██\t\t/ - Обычная атака(2d50)");
                Console.WriteLine("█░░░░░░▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░█\t\t- - Лечение(2d30) и увеличение защиты(1d)");
                Console.WriteLine("█░░░▄██▀░░░▀██░░░░░░██▀░░░▀██▄░░█\t\t^ - Бонус к любому дйствию (3d) с каждым ходом ументшается на 1");
                Console.WriteLine("█░░░██▄░░▀░░▄█░░░░░░█▄░░▀░░▄██░░█\t\t* - магическая атака (2d100)");
                Console.WriteLine("██░░░▀▀█▄▄▄██░░░██░░░██▄▄▄█▀▀░░██\t\t+ - лечение (100) запас ограничен");
                Console.WriteLine("███░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░███");
                Console.WriteLine("██░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░██");
                Console.WriteLine("██░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░██");
                Console.WriteLine("███░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░███");
                Console.WriteLine("████▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄████");
                Console.WriteLine("███████▄▄▄▄░░░░░░░░░░░░▄▄▄███████");
            }
            else if(monType == 3)
            {
                Console.WriteLine("████████████████████████████████");
                Console.WriteLine("████▀░█████▀▀▀▀▀▀▀▀▀▀█████░▀████");
                Console.WriteLine("██▀░░███▀░░░░░░░░░░░░░░▀███░░▀██");
                Console.WriteLine("██░░░▀░░░░░░░░░░░░░░░░░░░░▀░░░██\t\tКоманды");
                Console.WriteLine("██▄░░░░░░░░░░░░░░░░░░░░░░░░░░▄██\t\t/ - Обычная атака(2d50)");
                Console.WriteLine("███▄░░░░░▄█▄░░░░░░░░▄█▄░░░░░▄███\t\t- - Лечение(2d30) и увеличение защиты(1d)");
                Console.WriteLine("███░░░░░░█▀▀█▄░░░░▄█▀▀█░░░░░░███\t\t^ - Бонус к любому дйствию (3d) с каждым ходом ументшается на 1");
                Console.WriteLine("███░░░░░░▀███▀▀░░▀▀███▀░░░░░░███\t\t* - магическая атака (2d100)");
                Console.WriteLine("███░░░░░░░░░░░░░░░░░░░░░░░░░░███\t\t+ - лечение (100) запас ограничен");
                Console.WriteLine("████░░░░░░░░░░░░░░░░░░░░░░░░████");
                Console.WriteLine("████▄░░░░░░░░░▄██▄░░░░░░░░░▄████");
                Console.WriteLine("█████▄░░░░░░░░░░░░░░░░░░░░▄█████");
                Console.WriteLine("███████░░░░█▀░▄░░▄░▀█░░░░███████");
                Console.WriteLine("████████░░░▀░░█░░█░░▀░░░████████");
                Console.WriteLine("█████████░░░░░░░░░░░░░░█████████");
                Console.WriteLine("██████████░░░░░░░░░░░░██████████");
                Console.WriteLine("███████████▄▄░░░░░░▄▄███████████");
                Console.WriteLine("████████████████████████████████");
            }else if(monType == 1)
            {
                Console.WriteLine("░░░░░░▄▄▄░░▄██▄░░░░░░"); 
                Console.WriteLine("░░░░░▐▀█▀▌░░░░▀█▄░░░░");
                Console.WriteLine("░░░░░▐█▄█▌░░░░░░▀█▄░░\t\tКоманды");
                Console.WriteLine("░░░░░░▀▄▀░░░▄▄▄▄▄▀▀░░\t\t/ - Обычная атака(2d50)");
                Console.WriteLine("░░░░▄▄▄██▀▀▀▀░░░░░░░░\t\t- - Лечение(2d30) и увеличение защиты(1d)");
                Console.WriteLine("░░░█▀▄▄▄█░▀▀░░░░░░░░░\t\t^ - Бонус к любому дйствию (3d) с каждым ходом ументшается на 1");
                Console.WriteLine("░░░▌░▄▄▄▐▌▀▀▀░░░░░░░░\t\t* - магическая атака (2d100)");
                Console.WriteLine("▄░▐░░░▄▄░█░▀▀ ░░░░░░░\t\t+ - лечение (100) запас ограничен");
                Console.WriteLine("▀█▌░░░▄░▀█▀░▀ ░░░░░░░");
                Console.WriteLine("░░░░░░░▄▄▐▌▄▄░░░░░░░░");
                Console.WriteLine("░░░░░░░▀███▀█░▄░░░░░░");
                Console.WriteLine("░░░░░░▐▌▀▄▀▄▀▐▄░░░░░░");
                Console.WriteLine("░░░░░░▐▀░░░░░░▐▌░░░░░");
                Console.WriteLine("░░░░░░█░░░░░░░░█░░░░░");
            }
            
        }

        static void monDificult(int chek)//Определение сложности
        {
            if (chek == 3)
            {
                monsterHelth = 1750;
                damage = 5;
                Time = 4;
                Invent = 2;
                maxAt = 75;
            }
            else if (chek == 2)
            {
                monsterHelth = 2500;
                damage = 4;
                Time = 3;
                Invent = 3;
                maxAt = 50;
            }
            else
            {
                monsterHelth = 1000;
                damage = 3;
                Time = 2;
                Invent = 4;
                maxAt = 25;
            }
        }

        static void monAction()//Действия монстра в этом ходу
        {
            int a = rnd.Next(1, 10);
            if (a == 1)
            {
                Rage();
            }
            else MonsterAtack();
        }

        static void HP_map()//Битва с монстром
        {
            Console.Write("HP игрока: ");
            for (int i = 0; i < PlayerHelth / 100; i++)
            {
                Console.Write('█');
            }

            if (PlayerHelth < 1000)
            {
                for (int i = 0; i < 10 - (PlayerHelth / 100); i++)
                {
                    Console.Write('_');
                }
            }
            else if (PlayerHelth > 1000) Console.Write('+');



            Console.Write('\t');

            Console.Write("HP монстра: ");
            for (int i = 0; i < monsterHelth / (mhp / 10); i++)
            {
                Console.Write('█');
            }

            if (monsterHelth < mhp)
            {
                for (int i = 0; i < 10 - monsterHelth / (mhp / 10); i++)
                {
                    Console.Write('_');
                }
            }
        }

        static void Fight()//бой
        {
            do
            {
                string action;
                Console.Clear();

                HP_map();

                Console.Write('\n');
                Console.Write('\n');

                monFace(Dificult);
                
                Console.Write('\n');
                Console.Write('\n');

                Console.WriteLine("Бой начинается!\n");
                monAction();

                Console.WriteLine("Что вы будете делать?");
                Console.Write("> ");
                action = Convert.ToString(Console.ReadLine());

                if (action == "/")
                {
                    PlayerAtack();
                }
                else if (action == "-")
                {
                    if (LimitS == 0)
                    {
                        shield();
                    }
                    else Console.WriteLine("Вы ещё слабы - щит валится из рук.\t\t\t(Перезарядка не завершенна, вы пропускаете ход.\n)");
                }
                else if (action == "^")
                {
                    if (LimitP == 0)
                    {
                        PowerUp();
                    }
                    else Console.WriteLine("Вы увлечены боем, нет времени отвлекаться!\t\t\t(Перезарядка не завершенна, вы пропускаете ход.\n)");
                }
                else if (action == "*")
                {
                    if (LimitM == 0)
                    {
                        magic();
                    }
                    else Console.WriteLine("Ваши силы ещё не востановились, магия вам не поддаётся!.\t\t\t(Перезарядка не завершенна, вы пропускаете ход.\n)");
                }
                else if (action == "+")
                {
                    if (Invent > 0)
                    {
                        heal();
                    }
                    else Console.WriteLine("Вы пускаете руку за пазуху, но похоже зелий там больше нет\t\t\t(Ваши флаконы с зельем закончились, вы пропускаете ход.\n)");
                }
                else if (((Dificult == 1) && (action == "Вергилий")) || ((Dificult == 2) && (action == "Times New Roman")) || ((Dificult == 3) && (action == "Я пришёл договориться")))
                {
                    Console.WriteLine("Невозможно!!!\nВы нащупали слабое место врага!!!\nОн повержен!!!\n");
                    monsterHelth = 0;
                }
                else
                {
                    Console.WriteLine("В разгар битвы вы замешкались и ничего не смогли сделать\t\t\t(Ваша команда не ясна, вы пропускаете ход)\n");
                }


                if (LimitS < 0) LimitS++;
                if (LimitP < 0) LimitP++;
                if (LimitM < 0) LimitM++;
                if (bonus > 0) bonus--;




                Console.ReadKey();
            } while ((monsterHelth > 0)&&(PlayerHelth > 0));

            if(monsterHelth <= 0)
            {
                Console.WriteLine("Эта битва была не из простых, но вы справились!");
                Console.WriteLine("Поздраляем! Вы победитель!");
            }else if(PlayerHelth <= 0)
            {
                Console.WriteLine("Эта битва была не из простых, никто не осудит ваш побег...");
                Console.WriteLine("В этот раз вам повезло выжить, будте аккуратнее.");
                Console.WriteLine("В следующий раз фортуна улыбнётся и вам.");
            }
            
        }



        static void Main(string[] args)
        {

        diff:
            Console.WriteLine("Выберите номер демона с которым хотите сразиться:");
            Console.WriteLine("1 Dante (низкая сложность)");
            Console.WriteLine("2 Diablo (средняя сложность)");
            Console.WriteLine("3 Dormamu (высокая сложность)");

            Dificult = Convert.ToInt32(Console.ReadLine());

            if ((Dificult < 1) || (Dificult > 3)) goto diff;
            monDificult(Dificult);

            mhp = monsterHelth;

            Fight();

        }
    }
}
