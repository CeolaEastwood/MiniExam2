using System;

class MainClass {

public static double CylinderVolume(double rad, double htlog)
  {  
    int volume =  3.14*rad*rad*htlog ;
    
    return CylinderVolume;
   
  }

public static void Main (string[] args);

  Console.WriteLine("How many volumes to calculate?");
  double n = Convert.ToDouble(Console.ReadLine());

  for (i=0; i<n;i++)
  {
  Console.WriteLine("What is the radius?");
  double r = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("What is the height?");
  double h = Convert.ToDouble(Console.ReadLine());

  cvolume = CylinderVolume(r, h);

  Console.WriteLine("The volume of the cylinder is" + cvolume );
  }
  
   
  }
}