using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    { 
        static void Main(string[] args)
        {
            
            MainMenu();

            Console.Write("Choose a calculator: ");
            char calculatorOption = Convert.ToChar(Console.ReadLine());
            switch (calculatorOption)
            {
                case 'A'://calculate force given pressure and area
                    Console.Write("Enter pressure(psi): ");
                    double cylPressure = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter cylinder piston area(square inches): ");
                    double cylArea = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(cylinderForce(cylPressure, cylArea));
                    break;
                case 'B'://calculate pressure given force and area
                    Console.Write("Enter cylinder force(lbs.): ");
                    double cylForce = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter cylinder piston area(square inches): ");
                    double cylArea2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(cylinderPressure(cylForce, cylArea2));
                    break;
                case 'C'://Calculate cylinder piston area given force and pressure
                    Console.Write("Enter cylinder force(lbs.): ");
                    double cylForce2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter pressure(psi): ");
                    double cylPressure2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(cylinderArea(cylForce2, cylPressure2));
                    break;
                case 'D'://Calculate cylinder area given diameter
                    Console.Write("Enter cylinder bore diameter: ");
                    double diameter = Convert.ToDouble(Console.ReadLine());                    
                    Console.WriteLine(cylinderArea2(diameter));
                    break;
                case 'E': //Calculate annular area given piston and rod diameter
                    Console.Write("Enter cylinder bore diameter: ");
                    double boreDia = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter cylinder rod diameter: ");
                    double rodDia = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(annularArea(boreDia, rodDia));
                    break;
                case 'F': //Find velocity of a cylinder extending given stroke and time
                    Console.Write("Enter stroke(inches): ");
                    double cylStroke = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter time to extend or retract(seconds): ");
                    double extendTime = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(velocity1(cylStroke, extendTime));
                    break;
                case 'G': //flow requirment cylinder extending
                    Console.Write("Enter velocity(inches/minutes): ");
                    double cylVelocity = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter bore size(inches): ");
                    double boreDia2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter stroke(inches): ");
                    double cylStroke2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(cylinderFlow1(cylVelocity, boreDia2, cylStroke2));
                    break;
                case 'H'://flow requirement cylinder retracting
                    Console.Write("Enter velocity(inches/minutes): ");
                    double cylVelocity2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter rod diameter(inches): ");
                    double rodDia2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter bore size(inches): ");
                    double boreDia3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter stroke(inches): ");
                    double cylStroke3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(cylinderFlow2(cylVelocity2, rodDia2, boreDia3, cylStroke3));
                    break;
                case 'I':
                    //Calculate horsepower provided pressure and flow
                    Console.Write("Enter pressure(psi): ");
                    double aPressure = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter flow: ");
                    double aFlow = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Horsepower(aPressure, aFlow));
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
                    Console.ReadLine();
            
        }
        static void MainMenu()
        {

            Console.WriteLine("Main Menu:");
            Console.WriteLine("   (A) - Calculate force given pressure and area.");
            Console.WriteLine("   (B) - Calculate pressure given force and area.");
            Console.WriteLine("   (C) - Calculate area given force and pressure.");
            Console.WriteLine("   (D) - Calculate area of a cylinder given diameter.");
            Console.WriteLine("   (E) - Calculate annular area of a cylinder.");
            Console.WriteLine("   (F) - Calculate cylinder velocity extending or retracting.");
            Console.WriteLine("   (G) - Calculate cylinder flow requirement given cylinder area and velocity(Extending)");
            Console.WriteLine("   (H) - Calculate cylinder flow requirement given cylinder area and velocity(Retracting).");
            Console.WriteLine("   (I) - Calculate hydraulic horsepower given pressure and flow.");

        }
        //function for calculating force given pressure and area
        static double cylinderForce(double pressure, double area)
        {
            double force = pressure * area;
            return force;
        }
        //function for calculating pressure given force and area
        static double cylinderPressure(double force2, double area2)
        {
            double pressure2 = force2 / area2;
            return pressure2;
        }
        //function for calculating pistion area given force and pressure

        static double cylinderArea(double force3, double pressure3)
        {
            double area3 = force3 / pressure3;
            return area3;
        }
        //function for area given diameter
        static double cylinderArea2(double diameter)
        {
            double area4 = diameter * diameter * .7854;
            return area4;
        }
        //calculate annular area
        static double annularArea(double boreDiameter, double rodDiameter)
        {
            double boreArea = boreDiameter * boreDiameter * .7854;
            double rodArea = rodDiameter * rodDiameter * .7854;
            double annArea = boreArea - rodArea;
            return annArea;
        }
        //Function for cylinder velocity extending or extending
        static double velocity1(double stroke, double time)
        {
            double velocity = stroke * (60 / time);
            return velocity;

        }
        //Function for flow requirement given cylinder velocity and area(extending)

        static double cylinderFlow1(double velocity2, double boreDiameter2, double stroke2)
        {
            double boreArea = boreDiameter2 * boreDiameter2 * .7854;
            double area4 = stroke2 * boreArea;
            double flow = (velocity2 * area4) / 231;
            return flow;

        }

        //Function for flow requirement given cylinder velocity and area(retracting)

        static double cylinderFlow2(double velocity3, double rodDiameter2, double boreDiameter3, double stroke3)
        {

            double areaBore2 = boreDiameter3 * boreDiameter3 * .7854;
            double areaRod2 = rodDiameter2 * rodDiameter2 * .7854;
            double annArea2 = areaBore2 - areaRod2;
            double area5 = stroke3 * annArea2;
            double flow2 = (velocity3 * area5) / 231;
            return flow2;

        }
        //function for calculating hydraulic horsepower
        static double Horsepower(double pressure4, double flow3)
        {
            double result = (pressure4 * flow3) / 1714;
            return result;
        }

       


    }
}
