namespace RPG_POO.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level,int HpA, int HpM ,string HetoType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpA = HpA;
            this.HpM =HpM;
            this.HetoType = HetoType;
        }

        public virtual string Attack()
        {
            return this.Name + " Jogou sua shuriken"; 
        }
    }
}