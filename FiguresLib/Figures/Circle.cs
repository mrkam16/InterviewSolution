using System;

namespace InterviewSolution.Models
{
    public class Circle : Figure
    {
        #region Fields

        private double radius;

        #endregion
               
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException();

            this.radius = radius;
        }

        #region Properties
        
        public double Radius { set => radius = value; }

        #endregion


        #region Functions
        
        protected override double Area()
        {
           return Math.PI * this.radius * this.radius;
        }
       
        #endregion
    }
}
