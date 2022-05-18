namespace InterfaceOrnek
{
    public class Focus : IOtomobil
    {
        public Renk ArabaRengi()
        {
            return Renk.Mavi;
        }

        public Marka HangiMarka()
        {
            return Marka.Ford;
        }

        public int KacTeker()
        {
            return 4;
        }
    }
}