using System;

namespace dotnetconsole
{

    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice; NewPrice = newPrice;
        }
    }   

    public class Stock
    {
        string symbol; decimal price;
        public Stock(string symbol){ this.symbol = symbol;}
        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e){
            PriceChanged?.Invoke(this,e);
        }

        public decimal Price
        {
            get { return price;}
            set {
                if(price==value) return; //exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice,price));                
            }           
        } 
    }
  
}
