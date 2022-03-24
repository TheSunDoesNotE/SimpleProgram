using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH
{
    public partial class Form2 : Form // класс, реализующий игру в "Кто хочет стать миллионером
    {
        public Form2(string name)
        {
            InitializeComponent();
            Player = name;
        }
        public string Player;// переменная для хранения имя игрока, была передана из Form1
        List<int> past; // Лист для хранения вопросов, которые уже появились
        int cnt; // Переменная для счетчика правильных ответов
       
        string path = @"Records.txt"; //путь к файлу с рекордами
        
      
        private void button1_Click(object sender, EventArgs e) // метод,срабатывающий при нажатии на кнопку1 и проверяющий был ли правильный ответ в данной кнопке
        {
            if (button1.Text == Class1.RightAnswer[Class1.qq]) //реализация проверки условия правильности ответа
            {
                cnt = cnt + 1; // прибавление счетку единицы при правильном ответе
                if (cnt == 0) // далее идут условия для изменения индикаторов текущего вопроса
                {

                    button8.BackColor = Color.Green;
                }


                if (cnt == 1)
                {
                    button8.BackColor = Color.Gray;
                    button9.BackColor = Color.Green;
                }


                if (cnt == 2)
                {
                    button9.BackColor = Color.Gray;
                    button10.BackColor = Color.Green;
                }


                if (cnt == 3)
                {
                    button10.BackColor = Color.Gray;
                    button11.BackColor = Color.Green;
                }


                if (cnt == 4)
                {
                    button11.BackColor = Color.Gray;
                    button12.BackColor = Color.Green;
                }


                if (cnt == 5)
                {
                    button12.BackColor = Color.Gray;
                    button13.BackColor = Color.Green;
                }


                if (cnt == 6)
                {
                    button13.BackColor = Color.Gray;
                    button14.BackColor = Color.Green;
                }


                if (cnt == 7)
                {
                    button14.BackColor = Color.Gray;
                    button15.BackColor = Color.Green;
                }


                if (cnt == 8)
                {
                    button15.BackColor = Color.Gray;
                    button16.BackColor = Color.Green;
                }



                if (cnt == 9)
                {
                    button16.BackColor = Color.Gray;
                    button17.BackColor = Color.Green;
                }


                if (cnt == 10)
                {
                    button17.BackColor = Color.Gray;
                    button18.BackColor = Color.Green;
                }

                if (cnt == 11)
                {
                    button18.BackColor = Color.Gray;
                    button19.BackColor = Color.Green;
                }


                if (cnt == 12)
                {
                    button19.BackColor = Color.Gray;
                    button20.BackColor = Color.Green;
                }


                if (cnt == 13)
                {
                    button20.BackColor = Color.Gray;
                    button21.BackColor = Color.Green;
                }
                if (cnt == 14)
                {
                    button21.BackColor = Color.Gray;
                    button22.BackColor = Color.Green;
                }                                     // конец условий для индикации текущего вопроса

                
                MessageBox.Show("Ответ Верный!");// Демонстрация пользователю ,что ответ на вопрос был верный
                
                Random random = new Random(); //выбор следующего вопроса рандомно
                int a = random.Next(0, 14);
                    
                    

                if (past.Count < 15) // Условие необходимое для продолжения игры
                {


                    for (int i = 0; i < past.Count; i++) // реализация того, что вопросы, которые были до этого, не повторяться
                    {
                        if (past[i] == a)
                        {
                            a = random.Next(0, 15);
                            i = 0;
                        }

                    }
                  
                    past.Add(a);// добавление вопроса в List
                    Class1.qq = a;
                   
                        label1.Text = Class1.Quest[a];//Вывод нового вопроса
                        button1.Text = Class1.Answer[a * 4];//вывод новых ответов к новому вопросу в кнопки
                        button2.Text = Class1.Answer[a * 4 + 1];
                        button3.Text = Class1.Answer[a * 4 + 2];
                        button4.Text = Class1.Answer[a * 4 + 3];//Конец вывода
                    
                   
                    
                }
                else // условие победы
                {
                    MessageBox.Show("Вы выйграли миллион");// пользователь победил
                    using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default)) //записывание рекорда пользователя в файл "Records"
                    {
                        writer.WriteLine(Player + "  " + cnt);
                    }

                }

            }
            else //При неверном ответе
            {
                MessageBox.Show("Ответ неверный. Количество правильных ответов: " + cnt); //Демонстрация пользователю, что ответ был неверным + количество верных ответов до этого
                using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default)) // запись рекорда пользователя
                {
                    writer.WriteLine(Player + "  " + cnt);
                }
                    Close();// закрытие текущей игры
                Form Looser = new Form1();// запуск меню
                Looser.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            button8.BackColor = Color.Green; // изменение индикации первого вопроса
            cnt = 0; // обнуление счетчика верных ответов
            Random random = new Random();
            int a = random.Next(0, 14);
            Class1.qq = a;

            past = new List<int>();
            past.Add(a);
           
                     

          
                label1.Text = Class1.Quest[a];
                button1.Text = Class1.Answer[a * 4];
                button2.Text = Class1.Answer[a * 4 + 1];
                button3.Text = Class1.Answer[a * 4 + 2];
                button4.Text = Class1.Answer[a * 4 + 3];
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == Class1.RightAnswer[Class1.qq])
            {
                cnt = cnt + 1;
                if (cnt == 0)
                {

                    button8.BackColor = Color.Green;
                }


                if (cnt == 1)
                {
                    button8.BackColor = Color.Gray;
                    button9.BackColor = Color.Green;
                }


                if (cnt == 2)
                {
                    button9.BackColor = Color.Gray;
                    button10.BackColor = Color.Green;
                }


                if (cnt == 3)
                {
                    button10.BackColor = Color.Gray;
                    button11.BackColor = Color.Green;
                }


                if (cnt == 4)
                {
                    button11.BackColor = Color.Gray;
                    button12.BackColor = Color.Green;
                }


                if (cnt == 5)
                {
                    button12.BackColor = Color.Gray;
                    button13.BackColor = Color.Green;
                }


                if (cnt == 6)
                {
                    button13.BackColor = Color.Gray;
                    button14.BackColor = Color.Green;
                }


                if (cnt == 7)
                {
                    button14.BackColor = Color.Gray;
                    button15.BackColor = Color.Green;
                }


                if (cnt == 8)
                {
                    button15.BackColor = Color.Gray;
                    button16.BackColor = Color.Green;
                }



                if (cnt == 9)
                {
                    button16.BackColor = Color.Gray;
                    button17.BackColor = Color.Green;
                }


                if (cnt == 10)
                {
                    button17.BackColor = Color.Gray;
                    button18.BackColor = Color.Green;
                }

                if (cnt == 11)
                {
                    button18.BackColor = Color.Gray;
                    button19.BackColor = Color.Green;
                }


                if (cnt == 12)
                {
                    button19.BackColor = Color.Gray;
                    button20.BackColor = Color.Green;
                }


                if (cnt == 13)
                {
                    button20.BackColor = Color.Gray;
                    button21.BackColor = Color.Green;
                }
                if (cnt == 14)
                {
                    button21.BackColor = Color.Gray;
                    button22.BackColor = Color.Green;
                }

               
                MessageBox.Show("Ответ Верный!");
                
                Random random = new Random();
                int a = random.Next(0, 14);
                 
                if (past.Count < 15)
                {


                    for (int i = 0; i < past.Count; i++)
                    {
                        if (past[i] == a)
                        {
                            a = random.Next(0, 15);
                            i = 0;
                        }

                   }
                   
                    past.Add(a);
                    Class1.qq = a;
                   
                    
                        label1.Text = Class1.Quest[a];
                        button1.Text = Class1.Answer[a * 4];
                        button2.Text = Class1.Answer[a * 4 + 1];
                        button3.Text = Class1.Answer[a * 4 + 2];
                        button4.Text = Class1.Answer[a * 4 + 3];
                    
                  
                    
                }
                else
                {
                    MessageBox.Show("Вы выйграли миллион");
                    using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        writer.WriteLine(Player + "  " + cnt);
                    }
                }

            }
            else
            {
                MessageBox.Show("Ответ неверный. Количество правильных ответов: " + cnt);

                using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    writer.WriteLine(Player + "  " + cnt);
                }

                Close();
                Form Looser = new Form1();
                Looser.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == Class1.RightAnswer[Class1.qq])
            {
                cnt = cnt + 1;
                if (cnt == 0)
                {

                    button8.BackColor = Color.Green;
                }


                if (cnt == 1)
                {
                    button8.BackColor = Color.Gray;
                    button9.BackColor = Color.Green;
                }


                if (cnt == 2)
                {
                    button9.BackColor = Color.Gray;
                    button10.BackColor = Color.Green;
                }


                if (cnt == 3)
                {
                    button10.BackColor = Color.Gray;
                    button11.BackColor = Color.Green;
                }


                if (cnt == 4)
                {
                    button11.BackColor = Color.Gray;
                    button12.BackColor = Color.Green;
                }


                if (cnt == 5)
                {
                    button12.BackColor = Color.Gray;
                    button13.BackColor = Color.Green;
                }


                if (cnt == 6)
                {
                    button13.BackColor = Color.Gray;
                    button14.BackColor = Color.Green;
                }


                if (cnt == 7)
                {
                    button14.BackColor = Color.Gray;
                    button15.BackColor = Color.Green;
                }


                if (cnt == 8)
                {
                    button15.BackColor = Color.Gray;
                    button16.BackColor = Color.Green;
                }



                if (cnt == 9)
                {
                    button16.BackColor = Color.Gray;
                    button17.BackColor = Color.Green;
                }


                if (cnt == 10)
                {
                    button17.BackColor = Color.Gray;
                    button18.BackColor = Color.Green;
                }

                if (cnt == 11)
                {
                    button18.BackColor = Color.Gray;
                    button19.BackColor = Color.Green;
                }


                if (cnt == 12)
                {
                    button19.BackColor = Color.Gray;
                    button20.BackColor = Color.Green;
                }


                if (cnt == 13)
                {
                    button20.BackColor = Color.Gray;
                    button21.BackColor = Color.Green;
                }
                if (cnt == 14)
                {
                    button21.BackColor = Color.Gray;
                    button22.BackColor = Color.Green;
                }

                
                MessageBox.Show("Ответ Верный!");
               
                Random random = new Random();
                int a = random.Next(0, 14);
                   
                    
                if (past.Count < 15)
                {


                    for (int i = 0; i < past.Count; i++)
                    {
                        if (past[i] == a)
                        {
                            a = random.Next(0, 15);
                            i = 0;
                        }

                    }
                   
                    past.Add(a);
                    Class1.qq = a;
                   
                    
                        label1.Text = Class1.Quest[a];
                        button1.Text = Class1.Answer[a * 4];
                        button2.Text = Class1.Answer[a * 4 + 1];
                        button3.Text = Class1.Answer[a * 4 + 2];
                        button4.Text = Class1.Answer[a * 4 + 3];
                    
                   
                    
                }
                else
                {
                    MessageBox.Show("Вы выйграли миллион");
                    using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        writer.WriteLine(Player + "  " + cnt);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Ответ неверный. Количество правильных ответов: " + cnt);
                using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    writer.WriteLine(Player + "  " + cnt);
                }
                Close();
                Form Looser = new Form1();
                Looser.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == Class1.RightAnswer[Class1.qq])
            {
                cnt = cnt + 1;
                if (cnt == 0)
                {

                    button8.BackColor = Color.Green;
                }


                if (cnt == 1)
                {
                    button8.BackColor = Color.Gray;
                    button9.BackColor = Color.Green;
                }


                if (cnt == 2)
                {
                    button9.BackColor = Color.Gray;
                    button10.BackColor = Color.Green;
                }


                if (cnt == 3)
                {
                    button10.BackColor = Color.Gray;
                    button11.BackColor = Color.Green;
                }


                if (cnt == 4)
                {
                    button11.BackColor = Color.Gray;
                    button12.BackColor = Color.Green;
                }


                if (cnt == 5)
                {
                    button12.BackColor = Color.Gray;
                    button13.BackColor = Color.Green;
                }


                if (cnt == 6)
                {
                    button13.BackColor = Color.Gray;
                    button14.BackColor = Color.Green;
                }


                if (cnt == 7)
                {
                    button14.BackColor = Color.Gray;
                    button15.BackColor = Color.Green;
                }


                if (cnt == 8)
                {
                    button15.BackColor = Color.Gray;
                    button16.BackColor = Color.Green;
                }



                if (cnt == 9)
                {
                    button16.BackColor = Color.Gray;
                    button17.BackColor = Color.Green;
                }


                if (cnt == 10)
                {
                    button17.BackColor = Color.Gray;
                    button18.BackColor = Color.Green;
                }

                if (cnt == 11)
                {
                    button18.BackColor = Color.Gray;
                    button19.BackColor = Color.Green;
                }


                if (cnt == 12)
                {
                    button19.BackColor = Color.Gray;
                    button20.BackColor = Color.Green;
                }


                if (cnt == 13)
                {
                    button20.BackColor = Color.Gray;
                    button21.BackColor = Color.Green;
                }
                if (cnt == 14)
                {
                    button21.BackColor = Color.Gray;
                    button22.BackColor = Color.Green;
                }

                
                MessageBox.Show("Ответ Верный!");
                
                Random random = new Random();
                int a = random.Next(0, 14);
                    
                    
                if (past.Count < 15)
                {


                    for (int i = 0; i < past.Count; i++)
                    {
                        if (past[i] == a)
                        {
                            a = random.Next(0, 15);
                            i = 0;
                        }

                    }
                  
                    past.Add(a);
                    Class1.qq = a;
                    
                    
                        label1.Text = Class1.Quest[a];
                        button1.Text = Class1.Answer[a * 4];
                        button2.Text = Class1.Answer[a * 4 + 1];
                        button3.Text = Class1.Answer[a * 4 + 2];
                        button4.Text = Class1.Answer[a * 4 + 3];
                    
                    
                   
                }
                else
                {
                    MessageBox.Show("Вы выйграли миллион");
                    using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        writer.WriteLine(Player + "  " + cnt);
                    }
                }


            }
            else
            {
                MessageBox.Show("Ответ неверный. Количество правильных ответов: " + cnt);
                using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    writer.WriteLine(Player +"  " + cnt);
                }
                Close();
                Form Looser = new Form1();
                Looser.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
        
        }

        private void button12_Click(object sender, EventArgs e)
        {
      
        }

        private void button13_Click(object sender, EventArgs e)
        {
      
        }

        private void button14_Click(object sender, EventArgs e)
        {
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
        
        }

        private void button18_Click(object sender, EventArgs e)
        {
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
       
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
          
        }

        private void button22_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
