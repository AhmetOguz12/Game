 class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.GamerName = "Ahmet";
            gamer1.GamerSurname = "Bilgin";
            gamer1.GamerId = "1";
            gamer1.GamerLevel = 12;

            Gamer gamer2 = new Gamer();
            gamer2.GamerName = "O�uzhan";
            gamer2.GamerSurname = "Bilgin";
            gamer2.GamerId = "2";
            gamer2.GamerLevel = 14;

            Gamer gamer3 = new Gamer();
            gamer3.GamerName = "Engin";
            gamer3.GamerSurname = "Demiro�";
            gamer3.GamerId = "3";
            gamer3.GamerLevel = 4;

            Campaing campaing1 = new Campaing();
            campaing1.CampaingName = "Oyuncu �ndirimi";

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing1);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.UpDate(gamer3);

            if (gamer1.GamerLevel >= 10)
            {
                Console.WriteLine("Sat�� Yap�ld�  " );
            }
            else
            {
                Console.WriteLine("Sat�� Yap�lamad�");
            }

            if (gamer2.GamerLevel >= 10)
            {
                Console.WriteLine("Sat�� Yap�ld�  ");
            }
            else
            {
                Console.WriteLine("Sat�� Yap�lamad�");
            }

            if (gamer3.GamerLevel >= 10)
            {
                Console.WriteLine("Sat�� Yap�ld�  ");
            }
            else
            {
                Console.WriteLine("Sat�� Yap�lamad�");
            }



        }
    }
}
