using System;

namespace InterviewSolution.Models
{
    /// <summary>
    /// пример добавления фигуры
    /// </summary>
    class RectangleDemo : Figure
    {
        #region Fields
        
        private double width;
        private double height;

        #endregion

        public RectangleDemo(double h, double w)
        {
            if (h < 0 || w < 0)
                throw new ArgumentOutOfRangeException();

            height = h;
            width = w;
        }

        #region Properties
        
        public double Width { set => width = value;  }
        public double Height { set => height = value; }

        #endregion


        #region Functions
        
        protected sealed override double Area()
        {
            return this.width * this.height;
        }
        
        #endregion
    }
}
