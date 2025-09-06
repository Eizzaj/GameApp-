using GameApp.Libraries.Interface;

namespace GameApp.Libraries.Abstract{

    public abstract class GameItem : IGameItem{
      public String Name;

      public GameItem(String Name){
        this.Name = Name;
  
      }
      public void ShowInfo(){
        Console.WriteLine("Item: " + this.Name);
      }
      public abstract void UseItem();

      

    }


}