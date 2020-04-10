using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        private FruitFilling fruit;

        public FruitFilling Fruit
        {
            get { return fruit; }
            set
            {
                fruit = value;
                NotifyOfPropertyChanged("Fruit");
            }
        }

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool withIceCream = true;
        public bool WithIceCream
        {
            get { return withIceCream; }
            set
            {
                withIceCream = value;
                NotifyOfPropertyChanged("WithIceCream");
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        public List<string> Name
        {
            get 
            {
                return new List<string>() { Fruit.ToString() + " Cobbler" };
            }
            
        }

    /// <summary>
    /// Gets any special instructions for preparing this dessert
    /// </summary>
    public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

        /// <summary>
        /// Helper method to notify any changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
