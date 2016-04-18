namespace LiveChartsCore
{
    public enum AxisPosition
    {
        LeftBottom, RightTop
    }

    public enum SeparationState
    {
        Remove,
        Keep,
        InitialAdd
    }

    public enum ZoomingOptions
    {
        None,
        X,
        Y,
        Xy
    }

    public enum LegendLocation
    {
        None,
        Top,
        Bottom,
        Left,
        Right
    }

    public struct LvcPoint
    {
        public LvcPoint(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public static LvcPoint operator +(LvcPoint p1, LvcPoint p2)
        {
            return new LvcPoint(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static LvcPoint operator -(LvcPoint p1, LvcPoint p2)
        {
            return new LvcPoint(p1.X - p2.X, p1.Y - p2.Y);
        }
    }

    public struct LvcSize
    {
        public LvcSize(double width, double heigth) : this()
        {
            Width = width;
            Height = heigth;
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }

    public struct LvcRectangle
    {
        public LvcRectangle(double x, double y, double width, double height) : this()
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public interface IChartUpdater
    {
        IChartModel Chart { get; }
        void Run(bool restartsAnimations = false);
        void Cancel();
    }
}