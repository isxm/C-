namespace _01_04.Structure
{
    public struct Point3D
    {
        // Task 2
        private static readonly Point3D zeroPoint = new Point3D(0, (double)0, (double)0);

        //Task 1
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; } // Task1

        public double Y { get; set; } // Task1

        public double Z { get; set; } // Task1

        public Point3D ZeroPoint
        {
            get
            {
                return zeroPoint;
            }
        }

        public override string ToString()
        {
            return $"[{this.X}, {this.Y}, {this.Z}]";
        }
    }
}