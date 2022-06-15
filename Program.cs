using System;

namespace Abs
{
    abstract class Shape{
        public abstract int calculateSurface(int width,int height);

    }

    class Rectangle : Shape{
        public override int calculateSurface(int width,int height){
            return height*width;
        }

    }

    class Triangle:Shape{
        public override int calculateSurface(int width,int height){
            return (height*width)/2;
        }
    }




       abstract class circleArea{
           public abstract int Area();
       }
       class Circle:circleArea{
           int width = 0;
           int height = 0;
           int raduis = 0;

           public Circle(int w,int h,int r){
               width =w;
               height =h;
               raduis = r;
           }
           public override int Area(){
               return width*height*raduis;
           }
       }
    

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();
            Triangle myTriangle = new Triangle();
            // Console.WriteLine(myRectangle.calculateSurface(2,1));
            // Console.WriteLine(myTriangle.calculateSurface(2,3));
            Console.Write("Enter shape:");
            string enter = Console.ReadLine();
            string[] type = {"Rectangle","Triangle","Circle"};
            foreach(string shapes in type){
                if(enter == "Rectangle"){
                        Console.WriteLine("TO get the area of the Rectangle");
                        Console.Write("Enter first number:");
                        int firstNum = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number:");
                        int secondNum = int.Parse(Console.ReadLine());
                        int recArea = myRectangle.calculateSurface(firstNum,secondNum);
                        Console.WriteLine("The area of the rectangle is:" + recArea);
                        Console.WriteLine("***************************************************************************************");

                }else if(enter == "Triangle"){
                        Console.WriteLine("To get the area of the Triangle");           
                        Console.Write("Enter first number:");
                        int Num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number:");
                        int Num2 = int.Parse(Console.ReadLine());
                        int TriArea = myTriangle.calculateSurface(Num1,Num2);
                        Console.WriteLine("The area of the Triangle is:" + TriArea);
                        Console.WriteLine("***************************************************************************************");
                        break;
                }else if(enter == "Circle"){
                        Circle myCircle = new Circle(5,3,2);
                        Console.WriteLine("The Area of the circle is:"+myCircle.Area());

                }else{
                    Console.WriteLine("This shape does not exist");
                }
            }
          
            
            
           
            
           




            //    Console.WriteLine(myCircle.circleArea());
            //    myCircle.calculateSurface();


            // Circle myCircle = new Circle();
            // Console.WriteLine(myCircle.calculateSurface(2,3,4));




        }
    }
}



