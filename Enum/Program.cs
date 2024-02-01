


Console.WriteLine((int)Day.Monday);
Console.WriteLine((int)Day.Tuesday);
Console.WriteLine((int)Day.Wednesday);
Console.WriteLine((int)Day.Thursday);
Console.WriteLine((int)Day.Friday);
Console.WriteLine((int)Day.Saturday); 
Console.WriteLine((int)Day.Sunday);






enum Day
{
    Monday = 5,
    Tuesday,
    Wednesday,
    Thursday = 14,
    Friday = Tuesday,
    Saturday,
    Sunday
}