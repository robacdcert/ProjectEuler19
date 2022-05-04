//Project euler 19
//How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

int day = 0;
int weekday;
string[] week = { "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Monday" };
int sundays = 0;
int year = 1901;

while (year <= 2000)
{
    //Jan
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    //Feb
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    if (year % 4 == 0)
    {
        day = day + 29;
    }
    else
    {
        day = day + 28;
    }

    //March
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    //April
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 30;

    //May
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    //June
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 30;

    //July
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    //August
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    //September
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 30;

    //October
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    //November
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 30;

    //December
    if (week[(day + 1) % 7] == "Sunday")
    {
        sundays++;
    }
    day = day + 31;

    year++;
}

Console.WriteLine("Sundays: " + sundays);