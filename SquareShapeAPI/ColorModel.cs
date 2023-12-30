using System;

namespace SquareShapeAPI
{
    public class ColorModel
    {
        public string ColorName { get; set; }
    }

    public class ColorResponse : ColorModel
    {
        public string Message { get; set; }
    }
}
