using TowerDefense_Projektas.Units;

namespace TowerDefense_Projektas.ParentClass
{
    class Tower:Unit
    {
        protected int X;
        protected int Y;
        protected int Id;
        public Tower(int id,int x, int y):base(x,y)
        {
            X = x;
            Y = y;
            Id = id;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
