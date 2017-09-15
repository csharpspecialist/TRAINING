// class HotelRoom has child classes SingleRoom which costs less,
// and Suite which costs more
using static System.Console;
class DebugTen04
{
  public static void TenFour()
   {
      HotelRoom aRoom = new HotelRoom(234);
      SingleRoom aSingle = new SingleRoom(135); 
      Suite aSuite = new Suite(453);
      WriteLine(aRoom.ToString());
      WriteLine(aSingle.ToString());
      WriteLine(aSuite.ToString());//add )
        System.Console.ReadLine();  
    }
}
class HotelRoom
{
   public const double PREMIUM = 30.00;
   public const double STD_RATE = 89.99;
   private int roomNumber; 
   protected double rate; 
   public HotelRoom(int room) //ch double to int
   {
      roomNumber = room;
      rate = STD_RATE;//ch to STD_RATE
    }
   public int RoomNumber
   {
      get
      {
         return roomNumber;
      }
   }
   public double Rate //ch to double from char
   {
      get
      {
         return rate;
      }
   }
    public override string ToString() //ch to public override
   {
      string temp = GetType() + " Room " + RoomNumber + " Rate: " +
        Rate.ToString(("C"));
      return temp; //ch from string to temp
   }
}
class SingleRoom : HotelRoom //ch Inherits from to :
{
   public SingleRoom(int room) : base (room)
   {
      rate -= PREMIUM;
   }   
}
class Suite : HotelRoom //ch Inherits from to :
{
   public Suite(int room) : base (room) //add : base (room)
   {
      rate += PREMIUM;
   }
}
