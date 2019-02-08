
namespace Demo.Shape
{
    enum Products
    {
        Rectangle,
        Triangle,
        Circle,
        None
    }

    class Creator
    {
        Products _pr;

        public void SetProduct(Products pr)
        {
            _pr = pr;
        }

        public Creator(Products pr = Products.None)
        {
            _pr = pr;
        }

        public Shape Create(int x, int y, int width, int heigth)
        {
            switch (_pr)
            {
                case Products.Circle: return new Circle(x, y, width);
                case Products.Rectangle: return new Rectangle(x, y, width, heigth);
                case Products.Triangle: return new Triangle(x, y, width, heigth);
                default: return null;
            }
        }
    }
}
