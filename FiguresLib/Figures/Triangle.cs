using System;

namespace InterviewSolution.Models
{
    public class Triangle : Figure
    {
        #region Fields

        private double sideA;

        private double sideB;
        
        private double sideC;

        private readonly Lazy<bool> isRightAngled;

        #endregion

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Стороны должны быть больше нуля");

            sideA = a; 
            sideB = b; 
            sideC = c;

            isRightAngled = new Lazy<bool>(IsRight);
        }

        #region Properties

        public double SideA { set => sideA = value; }

        public double SideB { set => sideB = value; }

        public double SideC { set => sideC = value; }

        public bool IsRightAngled => isRightAngled.Value;

        #endregion

        protected sealed override double Area()
        {
            double semiPerimiter = (sideA + sideB + sideC) / 2;

            double area = Math.Sqrt(semiPerimiter * (semiPerimiter - sideA) * (semiPerimiter - sideB) * (semiPerimiter - sideC));

            return area;
        }


        /// <summary>
        /// является ли треугольник прямоугольным
        /// </summary>        
        private bool IsRight()
        {
            double maxSide = Utilities.Max(sideA, sideB, sideC);

            return maxSide * maxSide == Utilities.SumWithoutMaxElement(sideA, sideB, sideC);
        }
    }
}
