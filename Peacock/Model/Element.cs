namespace Peacock.Model
{
    using Peacock.Model.Structure;
    using System;

    public class Element : IElementBase
    {
        private Decimal xcoord;
        private Decimal ycoord;
        private long zlevel;

        private Decimal height;
        private Decimal width;

        private bool locked;

        public decimal GetX()
        {
            return xcoord;
        }

        public decimal GetY()
        {
            return ycoord;
        }

        public void SetX(decimal x)
        {
            xcoord = x;
        }

        public void SetY(decimal y)
        {
            ycoord = y;
        }

        public long GetZLevel()
        {
            return zlevel;
        }

        public void SetZlevel(long z)
        {
            zlevel = z;
        }

        public decimal GetHeight()
        {
            return height;
        }

        public decimal GetWidth()
        {
            return width;
        }

        public void SetHeight(decimal height)
        {
            this.height = height;
        }

        public void SetWidth(decimal width)
        {
            this.width = width;
        }

        public bool IsLocked()
        {
            return locked;
        }

        public void Lock(bool locked)
        {
            this.locked = locked;
        }
    }
}
