namespace RPG_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level,int HpA,int HpM, string HetoType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpA = HpA;
            this.HpM = HpM;
            this.HetoType = HetoType;
        }
    }
}