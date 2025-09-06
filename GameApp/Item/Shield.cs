using GameApp.Libraries.Abstract;

namespace GameApp.Item{

public class Shield : GameItem{
 public int Defense;

 public Shield(String name,int Defense):base(name){
    this.Defense = Defense;
 }
 public override void UseItem(){
    Console.WriteLine("You equipped " + this.Name + " Defense increased by " + this.Defense);
 }



}
}