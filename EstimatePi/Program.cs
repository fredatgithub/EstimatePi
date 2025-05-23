﻿using System;

namespace EstimatePi
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine("Estimating Pi using the Monte Carlo method...");
      Console.WriteLine("This program generates random points in a unit square and counts how many fall inside a unit circle.");
      Console.WriteLine("The ratio of points inside the circle to total points is used to estimate Pi.");
      Console.WriteLine("The more points generated, the more accurate the estimate will be.");
      Console.WriteLine("Please wait ...");
      // Set the number of iterations
      int iterations = int.MaxValue;
      // Initialize the random number generator
      Random random = new Random();
      // Initialize the count of points inside the circle
      int insideCircle = 0;
      // Loop through the number of iterations
      for (int i = 0; i < iterations; i++)
      {
        // Generate a random point (x, y) in the unit square
        double x = random.NextDouble();
        double y = random.NextDouble();
        // Check if the point is inside the unit circle
        if (x * x + y * y <= 1)
        {
          insideCircle++;
        }
      }
      // Estimate Pi using the ratio of points inside the circle to total points
      double piEstimate = (double)insideCircle / iterations * 4;
      // Print the estimated value of Pi
      Console.WriteLine($"Estimated value of Pi: {piEstimate}");
      // Print the actual value of Pi for comparison
      Console.WriteLine($"Actual value of Pi: {Math.PI}");
      // Calculate the error
      double error = Math.Abs(piEstimate - Math.PI);
      // Print the error
      Console.WriteLine($"Error: {error}");
      // Wait for user input before closing
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
