namespace InterfaceOrnek
{
    public class Corolla : IOtomobil
    {
        public Renk ArabaRengi()
        {
            return Renk.Beyaz;
        }

        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public int KacTeker()
        {
            return 4;
        }
    }
}
