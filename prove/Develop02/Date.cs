using System;

class Date
{
    private int _year;
    private int _month;
    private int _day;
    public Date(int _year, int _month, int _day){
        this._year = _year;
        this._month = _month;
        this._day = _day;
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
        return _year;
    }
    public int getMonth(){
        return _month;
    }
    public int getDay(){
        return _day;
    }
    public string toString(){
        return $"{_month}/{_day}/{_year}";
    }
    public void print(){
        Console.WriteLine(toString());
    }
    public bool equals(Date date_comp){
        if(date_comp.getYear() == _year && date_comp.getMonth() == _month && date_comp.getDay() == _day) return true;
        return false;
    }
}