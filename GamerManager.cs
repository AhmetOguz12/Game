
namespace Game
{
    class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi : " + gamer.GamerName + " " + gamer.GamerSurname);
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.GamerName + " " + gamer.GamerSurname);
        }

        public void UpDate(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + gamer.GamerName + " " + gamer.GamerSurname);
        }
    }
}
