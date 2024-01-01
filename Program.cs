//hafta kunlari
string operation = Console.ReadLine();

string dushanba = "monday";
string seshanba = "tuesday";
string chorshanba = "wednesday";
string payshanba = "thursday";
string juma = "friday";
string shanba = "saturday";
string yakshanba = "sunday";


string result = operation switch 

{
    "dushanba" => $"{dushanba}",
    "seshanba" => $"{seshanba}",
    "chorshanba" => $"{chorshanba}",
    "payshanba" => $"{payshanba}",
    "juma" => $"{juma}",
    "shanba" => $"{shanba}",
    "yakshanba" => $"{yakshanba}",
         _ => "Operation Not Found!"
};

System.Console.WriteLine(result);
