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
using Triangle;

namespace SQRTriangle
{
    //Программа поиска площади прямоугольного треугольника.
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Вычисление 
        private void findSquare(object sender, RoutedEventArgs e)
        {
            TriangleHandler triangle = new TriangleHandler(fieldSideA.Text, fieldSideB.Text, fieldSideC.Text);
            textBlockAnswer.Text = triangle.FindingSquare();
        }
    }
}

namespace Triangle
{
    class TriangleHandler
    {
        //Блок полей
        private double a;
        private double b;
        private double c;
        private double answer;
        private string tempA;
        private string tempB;
        private string tempC;

        //Конструктор
        public TriangleHandler(string a, string b, string c)
        {
            this.tempA = a;
            this.tempB = b;
            this.tempC = c;
        }
        //Метод экземпляра
        //Можно организовать через множества,но их синтаксис не проходил в C# еще. 
        public string FindingSquare()
        {
            try
            {
                if ((this.tempA.Length<=5)&&((tempB.Length<=5)&&(tempC.Length<=5))) //Количество знаков в поле
                {
                    this.a = double.Parse(this.tempA);
                    this.b = double.Parse(this.tempB);
                    this.c = double.Parse(this.tempC);
                    if ((this.a > 0 && this.b > 0) && (this.c > 0)) //Проверка арифметики
                    {
                        if ((this.a < this.c) && (this.b < this.c)) //Поиск гипотенузы
                        {
                            if ((this.a * this.a + this.b * this.b) == (this.c * this.c)) //Проверка прямоугольника
                            {
                                this.answer = this.a * this.b / 2;
                                return $"S={this.answer} Сторона С - гипотенуза";
                            }
                            else
                            {
                                return $"Данный треугольник не прямоугльный";
                            }

                        }
                        else if ((this.b < this.a) && (this.c < this.a))
                        {
                            if ((this.b * this.b + this.c * this.c) == (this.a * this.a))
                            {
                                this.answer = this.b * this.c / 2;
                                return $"S={this.answer} Сторона А - гипотенуза";
                            }
                            else
                            {
                                return $"Данный треугольник не прямоугольный";
                            }

                        }
                        else if ((this.a < this.b) && (this.c < this.b))
                        {
                            if ((this.a * this.a + this.c * this.c) == (this.b * this.b))
                            {
                                this.answer = this.a * this.c / 2;
                                return $"S={this.answer} Сторона Б - гипотенуза";
                            }
                            else
                            {
                                return $"Треугольник не прямоугольный";
                            }

                        }
                        else
                        {
                            return $"Треугольник не прямоугольный";
                        }
                    }
                    else
                    {
                        return $"Сторона треугольника не может быть отрицательной и равной 0 ";
                    }
                }
                else
                {
                    return $"В каждом поле должно быть не больше 5 знаков";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
           
        }
    }
}
