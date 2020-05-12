using System;

namespace AP.PRACTICAL
{
    public class Cylinder
    {
        private double BaseArea;
        private double LateralArea;
        private double TotalArea;
        private double Voulume;
        
        public void Process(double r, double h)
        {
            BaseArea = r * r * Math.PI;
            LateralArea = 2 * Math.PI * r * h;
            TotalArea = 2 * Math.PI * r * (h + r);
            Voulume = Math.PI * r * r * h;
        }

        public void Result()
        {
            Console.WriteLine("Base: "+this.BaseArea+" |  Latera: "+this.LateralArea+" |  Total: "+this.TotalArea+" |  Volume: "+this.Voulume);
        }
    }
}