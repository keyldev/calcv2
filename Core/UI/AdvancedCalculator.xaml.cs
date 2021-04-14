using calculator.Core.Models;
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
    /// Логика взаимодействия для AdvancedCalculator.xaml
    /// </summary>
    public partial class AdvancedCalculator : Page
    {
        List<Point> points = new List<Point>();
        public AdvancedCalculator()
        {
            InitializeComponent();
            //(this.DataContext as MyChartModel).SetPoints(new List<Point> {new Point(3,3), new Point(4,4), new Point(5,5)});
        }

        private void bCalculate_Click(object sender, RoutedEventArgs e)
        {
            Argument x = new Argument("x");
            Argument y = new Argument("y");
            y.setArgumentValue(1);
            x.setArgumentValue(1);
            Expression expression = new Expression(tbInputExpression.Text, x,y);

            for (double z = -Math.PI * 2; z < Math.PI * 2; z++)
                points.Add(new Point(z, Math.Abs(1)));
            double exp1 = new Expression(expression.getExpressionString(), x,y).calculate();
           // points.Add(new Point(exp1,y.getArgumentValue()));
            tbInputExpression.Text = exp1.ToString();
            (this.DataContext as MyChartModel).SetPoints(points);
        }
    }
}
