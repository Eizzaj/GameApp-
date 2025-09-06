using GameApp.Libraries.Interface;
namespace GameApp.Item
{
   public class Program
   {
    public static void Main(String[] args){
        Shield item1 = new Shield("Shield ",100);
        item1.ShowInfo();
        item1.UseItem();

        Potion item2 = new Potion("Health Potion ",50);
        item2.ShowInfo();
        item2.UseItem();
        

    }

   }
}