using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;
using FruitFilling = ExamTwoCodeQuestions.Data.FruitFilling;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            Cobbler cob = (Cobbler)DataContext;

            switch (((Button)sender).Name)
            {
                case "Peach":
                    cob.Fruit = FruitFilling.Peach;
                    break;
                case "Cherry":
                    cob.Fruit = FruitFilling.Cherry;
                    break;
                case "Blueberry":
                    cob.Fruit = FruitFilling.Blueberry;
                    break;
                default:
                    throw new NotImplementedException("Unknown Fruit Toggle Button Pressed");
            }
        }
    }
    
    
}
