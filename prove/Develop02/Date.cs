using System;

class Date
{
    private int year;
    private int month;
    private int day;
    public Date(int year, int month, int day){
        this.year = year;
        this.month = month;
        this.day = day;
    }
    public static Date stringToDate(string date){
        //unfinished
        int year = 0, month = 0, day = 0;
        string x = "";
        int MDY = 1;
        foreach(char num in date){
            if (num == '/'){
                switch (MDY){
                case 1:
                    month = int.Parse(x);
                    break;
                case 2:
                    day = int.Parse(x);
                    break;
                }
                MDY ++;
                x = "";
            }
            else x = x + num;
        }
        year = int.Parse(x);
        return new Date(year, month, day);
    }
    public static Date getTodayDate(){
        //unfinished
        return new Date(2024, 5, 20);
    }
    public int getYear(){
        return year;
    }
    public int getMonth(){
        return month;
    }
    public int getDay(){
        return day;
    }
    public string toString(){
        return $"{month}/{day}/{year}";
    }
    public void print(){
        Console.WriteLine(toString());
    }
    public bool equals(Date date_comp){
        if(date_comp.getYear() == year && date_comp.getMonth() == month && date_comp.getDay() == day) return true;
        return false;
    }
}