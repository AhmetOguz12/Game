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
            gamer2.GamerName = "Oðuzhan";
            gamer2.GamerSurname = "Bilgin";
            gamer2.GamerId = "2";
            gamer2.GamerLevel = 14;

            Gamer gamer3 = new Gamer();
            gamer3.GamerName = "Engin";
            gamer3.GamerSurname = "Demiroð";
            gamer3.GamerId = "3";
            gamer3.GamerLevel = 4;

            Campaing campaing1 = new Campaing();
            campaing1.CampaingName = "Oyuncu Ýndirimi";

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing1);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.UpDate(gamer3);

            if (gamer1.GamerLevel >= 10)
            {
                Console.WriteLine("Satýþ Yapýldý  " );
            }
            else
            {
                Console.WriteLine("Satýþ Yapýlamadý");
            }

            if (gamer2.GamerLevel >= 10)
            {
                Console.WriteLine("Satýþ Yapýldý  ");
            }
            else
            {
                Console.WriteLine("Satýþ Yapýlamadý");
            }

            if (gamer3.GamerLevel >= 10)
            {
                Console.WriteLine("Satýþ Yapýldý  ");
            }
            else
            {
                Console.WriteLine("Satýþ Yapýlamadý");
            }



        }
    }
}
