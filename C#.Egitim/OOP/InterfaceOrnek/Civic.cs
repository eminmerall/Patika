namespace InterfaceOrnek
{
    public class Civic : IOtomobil
    {
        public Renk ArabaRengi()
        {
            return Renk.Gri;
        }

        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public int KacTeker()
        {
            return 4;
        }
    }
}