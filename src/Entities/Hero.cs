namespace RPG_POO.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level,int HpA, int HpM ,string HetoType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HpA = HpA;
            this.HpM =HpM;
            this.HetoType = HetoType;
        }

        public Hero()
        {

        }

        public string Name;
        public int Level;

        public int HpA;

        public int HpM;

        public string HetoType;

        public override string ToString()
        {
            return  "| Nome: " + this.Name +  "| Nivel: " + this.Level +"| Hp " +this.HpA +"/" + this.HpM + "| Classe " + this.HetoType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada"; 
        }


    }
}