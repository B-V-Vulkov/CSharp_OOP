namespace P01.ClassBoxData.Models
{
    using System;
    using System.Text;
    using Exceptions;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        (ExceptionMessages.lenghtZeroOrNegativExcprion);
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        (ExceptionMessages.widthZeroOrNegativExcprion);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        (ExceptionMessages.heightZeroOrNegativExcprion);
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double result = (2 * this.Length * this.Width) +
                (2 * this.Length * this.Height) + 
                (2 * this.Width * this.Height);

            return result;
        }

        public double LateralSurfaceArea()
        {
            double result = (2 * this.length * this.height) +
                (2 * this.width * this.height);

            return result;
        }

        public double Volume()
        {
            double result = this.length * this.width * this.height;

            return result;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Surface Area - {SurfaceArea():f2}");
            st.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            st.AppendLine($"Volume - {Volume():f2}");

            return st.ToString().TrimEnd();
        }
    }
}
