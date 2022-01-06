using System;

namespace InterviewSolution.Models
{
    public abstract class Figure
    {
        #region Fields
        
        private readonly Lazy<double> square;

        #endregion


        protected Figure()
        {
            square = new Lazy<double>(Area);
        }

        #region Properties

        public double Square => square.Value;

        #endregion


        #region Functions

        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        protected abstract double Area();
        
        #endregion
    }
}
