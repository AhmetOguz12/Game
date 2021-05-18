
namespace Game
{
    class CampaingManager
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Kampanya Eklendi : " + campaing.CampaingName);
        }
        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya Silindi : " + campaing.CampaingName);
        }
        public void UpDate(Campaing campaing)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaing.CampaingName);
        }
    }
}
