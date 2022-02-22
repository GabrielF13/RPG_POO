namespace RPG_POO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level,int HpA, int HpM ,string HetoType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpA = HpA;
            this.HpM =HpM;
            this.HetoType = HetoType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com Magia Negra"; 
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