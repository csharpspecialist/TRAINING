// Interface IReversable defines behavior Reverse()
// Reverse is implemented differently for a Soldier and a PhoneCall
// Main program demonstrates an object of each type
using static System.Console;
class DebugTen03
{
  public static void TenThree()
   {
      Soldier giJoe = new Soldier(266143);
      PhoneCall aCall = new PhoneCall("212", "344-4188");
      WriteLine(giJoe.ToString());
      giJoe.Reverse();
      WriteLine(giJoe.ToString());
      giJoe.Reverse();
      WriteLine(giJoe.ToString());
      WriteLine(aCall.ToString());
      aCall.Reverse();
      WriteLine(aCall.ToString());
        System.Console.ReadLine();
    }
}


public interface IReversable
{
    void Reverse(); //ch to Reverse()
}
class Soldier : IReversable //ch = to :
{
   private int idNum;
   private string facing;
   public Soldier(int id)
   {
      idNum = id; //ch from idNum to id
      facing = "front";
   }
// When a Soldier reverses if the Soldier was facing front, change to back
// If the Soldier was facing back, change to front
   public void Reverse()
   {
      if(facing == "front")
         facing = "front";
      else
         facing = "Back";//ch to "back"
   }
   public override string ToString() //ch void to string LEAVE OVERRIDE ALONE!!!
   {
      string temp = "Soldier #" + idNum + " is facing " + facing;
        return temp; // add return temp as it did not exist
   }
}
class PhoneCall : IReversable
{
   private string areaCode;
   private string number;
   private double charge;
   private string mode;// ch strin to string

   public PhoneCall(string area, string num)
   {
      areaCode = area;
      number = num;
      charge = 0.25;
      mode = "collect";// ch from regular to "collect" as per line 65
   }
// When a phone call reverses, mode becomes collect and charge becomes 0
   public void Reverse()
   {
      mode = "collect";
      charge = 0;
   }
   public override string ToString()
   {
      string temp = "(" + areaCode + ") " + number + " Charge " + charge.ToString("C") +
         " Call is " + mode;
      return temp;
   }
}


