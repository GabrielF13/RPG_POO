namespace RPG_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level,int HpA, int HpM ,string HetoType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpA = HpA;
            this.HpM =HpM;
            this.HetoType = HetoType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia"; 
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia SuperEfetiva com bonus de  "+ Bonus ;   
            }
            else
            {
                return this.Name + " Lançou Magia com força fraca com bonus de  "+ Bonus ;   
            }


        }
        
    }
}