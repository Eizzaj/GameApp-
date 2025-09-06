using GameApp.Libraries.Abstract;

namespace GameApp.Item{

public class Potion : GameItem{
 public int HealAmount;

 public Potion(String name, int HealAmount):base(name){
    this.HealAmount = HealAmount;
 }
 public override void UseItem(){
    Console.WriteLine("You drank " + this.Name + " Restored " + this.HealAmount + " HP");
 }



}
}