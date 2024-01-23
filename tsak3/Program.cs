Student student = new Student();
student.Name = "Nurullo";
student.GradeLevel = 11;
System.Console.WriteLine();


public class Student{
    public string Name;
    public int GradeLevel ;

    public int [] Scores = new  int [5];
    public int GetAverage(){
        int sum=0;
        for(int i=0;i<5;i++){
             sum+=Scores[i];
        }
       

        return sum/5;
    }


}

