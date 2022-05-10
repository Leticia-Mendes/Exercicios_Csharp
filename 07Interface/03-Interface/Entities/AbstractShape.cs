using _03_Interface.Entities.Enums;

namespace _03_Interface.Entities
{
    abstract class AbstractShape : IShape
    {
        public ColorEnum Color { get; set; }

        public abstract double Area();
    }
}
