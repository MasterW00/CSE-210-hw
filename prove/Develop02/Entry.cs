using System;

class Entry
{
    private Date date;
    private string paragraph;
    public Entry(Date date, string paragraph){
        this.date = date;
        this.paragraph = paragraph;
    }
    public void edit_paragraph(string newparagraph){
        this.paragraph = newparagraph;
    }
    public string get_paragraph(){
        return this.paragraph;
    }
    public Date get_date(){
        return this.date;
    }
    public void print(){
        this.date.print();
        Console.WriteLine(this.paragraph);
    }
    public static string give_me_a_prompt(){
        string prompt = "Did anything unexpected happen today?";
        Console.WriteLine($"{prompt}");
        return prompt;
    }
}