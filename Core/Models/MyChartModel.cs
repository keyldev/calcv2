using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace calculator.Core.Models
{
    class MyChartModel
    {
        public MyChartModel()
        {
            ChartCreate();
        }
        public IList<DataPoint> PointsMinus { get; private set; }
        public PlotModel MyModel { get; private set; }
        public IList<DataPoint> PointsPlus { get; private set; }
        public void SetPoints(List<Point> points)
        {
            PointsPlus.Clear();
            PointsMinus.Clear();
            foreach (Point p in points)
            {
                if (p.Y == 0)
                {
                    this.PointsPlus.Add(new DataPoint(p.X, p.Y));
                    this.PointsMinus.Add(new DataPoint(p.X, p.Y));
                }
                else if (p.Y > 0)
                {
                    this.PointsPlus.Add(new DataPoint(p.X, p.Y));
                }
                else
                {
                    this.PointsMinus.Add(new DataPoint(p.X, p.Y));
                }
            }
            this.MyModel.ResetAllAxes();
            this.MyModel.InvalidatePlot(true);

        }
        void ChartCreate()
        {
            MyModel = new PlotModel { Title = "График", PlotType = PlotType.Cartesian, };
            PointsPlus = new List<DataPoint>();
            PointsMinus = new List<DataPoint>();
            MyModel.Series.Add(new AreaSeries
            {
                Color = OxyColors.Green,
                ItemsSource = PointsPlus,
                LineStyle = LineStyle.None,
                StrokeThickness = 0.1f
            });

            MyModel.Series.Add(new AreaSeries
            {
                Color = OxyColors.Blue,
                ItemsSource = PointsMinus,
                LineStyle = LineStyle.None,
                StrokeThickness = 0.1f
            });
        }
    }
}
