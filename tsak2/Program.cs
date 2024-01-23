
Rectangle masohat = new Rectangle();
masohat.Width = 5;
masohat.Height = 3;
System.Console.WriteLine(masohat.GetArea());


public class Rectangle{
    public int Width;
    public int Height;
   public  int GetArea(){
         return Height* Width;
    }   
}