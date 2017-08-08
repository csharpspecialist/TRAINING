// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using static System.Console;
class DebugNine1
{
  public  static void NineOne()
   {
      HomeworkAssignment course1 = new HomeworkAssignment();
      HomeworkAssignment course2 = new HomeworkAssignment();
      string entryString;
      int exercises;

      // Get info for first class
      Write("What class do you have homework for? ");
        entryString = ReadLine(); //ch to entrystring
      course1.ClassName = entryString;//ch lower c to upper C
      Write("How many exercises must you complete? ");
      entryString = ReadLine();
      int.TryParse(entryString, out exercises); //added out keyword
        course1.NumberOfExercises = exercises;//reversed exer & c1.numOfEx
      
      // Get info for another class
      Write("What class do you have homework for? ");
      entryString = ReadLine();
      course2.ClassName = entryString; //ch lower c to upper+ corr name for entryString..MUST CHANGE TO COURSE1.CLASSNAME!!!
      Write("How many exercises must you complete? ");
      entryString = ReadLine();
      int.TryParse(entryString, out exercises);//ch to Int.tryparse
      course2.NumberOfExercises = exercises;

      WriteLine("You have {0} minutes of homework for {1}",
            course1.TimeToComplete, course1.ClassName);//ch lower t to upper T      
      WriteLine("and {0} more minutes for {1}",
            course2.TimeToComplete,course2.ClassName); //ch lower t to upper T

       ReadLine();
    }
}
class HomeworkAssignment
{
   private int numberOfExercises;
   private int timeToComplete;
   // 10 minutes to complete each exercise
   private const int TIME_PER_EXERCISE = 10;
   public string ClassName {get; set;} //ch ; + added string
   public int NumberOfExercises
   {
      get
      {
         return numberOfExercises; //named correctly
      }
      set
      {
         numberOfExercises = value; //ch number to value
         CalcCompletionTime();
      }
   }
   public double TimeToComplete
   {
      get
      {
         return timeToComplete;
      }
   }
   private void CalcCompletionTime()
   {
      timeToComplete = numberOfExercises * TIME_PER_EXERCISE;      
   }
}