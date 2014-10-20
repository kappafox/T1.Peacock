
namespace Peacock.Model.Structure
{
    public interface IElementBase
    {
        decimal GetX();
        decimal GetY();
        void SetX(decimal x);
        void SetY(decimal y);

        long GetZLevel();
        void SetZlevel(long z);

        decimal GetHeight();
        decimal GetWidth();
        void SetHeight(decimal height);
        void SetWidth(decimal width);

        bool IsLocked();
        void Lock(bool locked);


    }
}
