// This program computes net weekly pay
// based on hours worked, rate per hour,
// and 15% withholding
using System;
using static System.Console;
class DebugTwo3
{
    static void Debug23()
    {
	  const double WITHHOLDING_RATE = 5;
	  string hoursAsString, rateAsString;
	  double hours, rate;
	  double gross, net;
	  Write("Enter the number of hours you worked this week ");
	  hoursAsString = ReadLine();
	  Write("Enter your hourly rate ");
		rateAsString = ReadLine();

	  hours = Convert.ToDouble(hoursAsString);
	  rate = Convert. ToDouble(rateAsString);
	  gross = hours * rate;
	  net = gross - WITHHOLDING_RATE;
	  WriteLine("You worked {0} hours at {1} per hour",
	 hours, rate.ToString("C"));
	  WriteLine("Gross pay is {0}", gross.ToString("C"));
	  WriteLine("Net pay is {0}", net.ToString("C")); 
   }
}
