using System;
class Program {
public static double calculatecharge(double hrs)
{
  double chrg =0;
  double basechrg = 2;

  double addfee = .50 * hrs;
  
    

  if (hrs <= 3)
    chrg = 2.00;
  else if (hrs > 3)
    chrg = basechrg + (hrs-3) * .50;
  else if (chrg >= 10.00)
chrg = 10.00;
  return chrg;
  }



  public static void Main (string[] args) {
   
   
    double chrg =0;
    
       
    
    Console.WriteLine ("Please input hours parked");
 double hrs = Convert.ToDouble(Console.ReadLine());

chrg = calculatecharge(hrs);
    Console.WriteLine("Your parking charge is $"+ chrg);
  }
}