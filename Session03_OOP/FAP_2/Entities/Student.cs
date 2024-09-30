using System;
public class Student
{
    private string _id;    //id   :________
    private string _name;  //name :________
    private int _yob;      //yob  :________
    private double _gpa;   //gpa  :________

    //CODE CONTRUCTOR GET SET 100% GIỐNG JAVA
    //TUY NHIÊN TA SẼ HỌC THÊM CẢ ĐIỀU KHÁC BIỆT
    //class như cái form, cái khuôn, BLUE-PRINT để từ đó ta CLONE INFO vào
    //để có được 1 object cụ thể

    //CONSTRUCTOR: Hàm đặt biệt đóng vai trò cái phễu hứng vật liệu đầu vào
    public Student(string id, string name, int yob, double gpa)
    {
        _id = id;
        _name = name;
        _yob = yob;
        _gpa = gpa;
    }

    //các hành động còn lại của object
    public void PrintInfo()
    {
        Console.WriteLine($"ID: {_id}, Name: {_name}, YOB: {_yob}, GPA: {_gpa}");
    }




}