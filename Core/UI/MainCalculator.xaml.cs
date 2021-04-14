using org.mariuszgromada.math.mxparser;
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
using Expression = org.mariuszgromada.math.mxparser.Expression;
namespace calculator.Core.UI
{
    /// <summary>
    /// Логика взаимодействия для MainCalculator.xaml
    /// </summary>
    public partial class MainCalculator : Page
    {
        public MainCalculator()
        {
            InitializeComponent();
            _RedefineButtons();
        }

        private void _RedefineButtons()
        {
            bClearAll.Click += (o, e) => resultLabel.Content = "0"; // удаление результатов
            bDiv.Click += (o, e) => resultLabel.Content += "/"; // деление
            bDot.Click += (o, e) => resultLabel.Content += "."; // запятая
            bFact.Click += (o, e) => resultLabel.Content += "!"; // факториал
            bLBracket.Click += (o, e) => resultLabel.Content += "("; // левая скобка
            bLn.Click += (o, e) => resultLabel.Content += "ln"; // натуральный логарифм
            bLog.Click += (o, e) => resultLabel.Content += "log"; // логарифм
            bMinus.Click += (o, e) => resultLabel.Content += "-"; // минус
            bPlus.Click += (o, e) => resultLabel.Content += "+"; // плюс
            bRightBracket.Click += (o, e) => resultLabel.Content += ")"; // левая скобка
            bSquare.Click += (o, e) => resultLabel.Content += "^2"; // возведение в квадрат
            bMultiply.Click += (o, e) => resultLabel.Content += "*"; // умножение
            bNumExp.Click += (o, e) => resultLabel.Content += "2,78"; // число e
            bNumPi.Click += (o, e) => resultLabel.Content += Math.PI.ToString(); 
            bAbsNum.Click += (o, e) => resultLabel.Content += "ne rabotate";
            ///////цифры
            bNumOne.Click += (o, e) => resultLabel.Content += "1";
            bNumTwo.Click += (o, e) => resultLabel.Content += "2";
            bNumThree.Click += (o, e) => resultLabel.Content += "3";
            bNumFour.Click += (o, e) => resultLabel.Content += "4";
            bNumFive.Click += (o, e) => resultLabel.Content += "5";
            bNumSix.Click += (o, e) => resultLabel.Content += "6";
            bNumSeven.Click += (o, e) => resultLabel.Content += "7";
            bNumEight.Click += (o, e) => resultLabel.Content += "8";
            bNumNine.Click += (o, e) => resultLabel.Content += "9";
            bNumZero.Click += (o, e) => resultLabel.Content += "0";
        }

        private double _CalculateResult(Expression f)
        {
            return (new Expression(f.getExpressionString(), new Argument("x")).calculate());
        }

        private void bResultEqual_Click(object sender, RoutedEventArgs e)
        {
            Expression expression = new Expression(resultLabel.Content.ToString(), new Argument("x"));
           resultLabel.Content = _CalculateResult(expression);
        }
    }
}
