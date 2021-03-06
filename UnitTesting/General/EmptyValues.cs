﻿using LiveCharts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.General
{
    public partial class GeneralTest
    {

        //charts should not throw any error when Chart values is empty


        [TestMethod, TestCategory("General")]
        public void EmptyValues()
        {
            var vals = new ChartValues<double>();

            var barChart = new BarChart
            {
                Series = new SeriesCollection
                {
                    new BarSeries {Values = vals},
                    new LineSeries {Values = vals}
                }
            };
            barChart.UnsafeUpdate();

            var lineChart = new LineChart
            {
                Series = new SeriesCollection
                {
                    new LineSeries {Values = vals}
                }
            };
            lineChart.UnsafeUpdate();

            var pieChart = new PieChart
            {
                Series = new SeriesCollection
                {
                    new PieSeries {Values = vals}
                }
            };
            pieChart.UnsafeUpdate();

            //Currently disabled
            //var stackedChart = new StackedBarChart
            //{
            //    Series = new SeriesCollection
            //    {
            //        new StackedBarSeries {Values = vals}
            //    }
            //};
            //stackedChart.UnsafeUpdate();
        }
    }
}
