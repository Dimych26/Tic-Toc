using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class XO
    {
        public bool GameOver = false;
        private int[,] field = new int[3, 3];
        private char[,] field1 = new char[3, 3];
        public int numbers = 0;
        private int temp = 0;
        private char chooseOfAi = 'o';
        private int choose;
        Random random = new Random();

        public void DrawInstructions()
        {
            int m = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j] = m;
                    m++;
                    Console.Write(field[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public void ChooseOfPlayer()
        {
            Console.WriteLine("Введите позицию на поле");

            if (!int.TryParse(Console.ReadLine(), out choose) || (choose < 1 || choose > 9))
            {
                Console.WriteLine("Неправильно введенная позиция! Попробуйте снова...(Нажмите Enter)");
                Console.ReadKey();
                Console.Clear();
                DrawInstructions();
                DrawField();
                ChooseOfPlayer();
            }
            DrawField();
        }
        public void DrawField()
        {
           
            if (temp == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        field1[i, j] = ' ';
                        Console.Write(field1[i, j] + " " + "|");
                    }
                    Console.WriteLine();
                }
                temp = 1;
            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                   
                    for (int j = 0; j < 3; j++)
                    {
                        if (field1[i, j] == ' ')
                        {
                            if (field[i, j] == choose)
                            {
                                field1[i, j] = 'x';
                            }
                        }
                        Console.Write(field1[i, j] + " "+"|");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine(numbers);
        }
        public void ChooseOfAI()
        {
          
            int tempI = random.Next(3);
            int tempJ = random.Next(3);

            if (field1[tempI, tempJ] == ' ')
            {
                field1[tempI, tempJ] = chooseOfAi;
                DrawField();
            }
            else 
            {
                ChooseOfAI();
            }
          
        }
        public void GameOverAll()
        {
            for (int i = 0; i < 3; i++)
            {

                if ((field1[i, 0] == field1[i, 1]) && (field1[i, 1] == field1[i, 2]) && (field1[i, 0] != ' '))
                {
                    Console.Clear();
                    DrawInstructions();
                    DrawField();
                    Console.WriteLine("Победили  " + field1[i, 0]);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    GameOver = true;
                    break;
                }
                else if ((field1[0, i] == field1[1, i]) && (field1[1, i] == field1[2, i]) && (field1[0, i] != ' '))
                {
                    Console.Clear();
                    DrawInstructions();
                    DrawField();
                    Console.WriteLine("Победили  " + field1[0,i]);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    GameOver = true;
                    break;
                }
                else if ((field1[0, 0] == field1[1, 1]) && (field1[1, 1] == field1[2, 2]) && (field1[0, 0] != ' '))
                {
                    Console.Clear();
                    DrawInstructions();
                    DrawField();
                    Console.WriteLine("Победили  " + field1[0, 0]);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    GameOver = true;
                    break;
                }
                else if ((field1[0, 2] == field1[1, 1]) && (field1[1, 1] == field1[2, 0]) && (field1[0, 2] != ' '))
                {
                    Console.Clear();
                    DrawInstructions();
                    DrawField();
                    Console.WriteLine("Победили  " + field1[0, 2]);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    GameOver = true;
                    break;
                }
                else if(numbers==9)
                {
                    Console.Clear();
                    DrawInstructions();
                    DrawField();
                    Console.WriteLine("Ничья" );
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    GameOver = true;
                    break;
                }
                
                
            }
           

        }

    }
}
   
