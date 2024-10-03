//TASK1:
//int number = 185;
//if (number >= 100 && number <= 999)
//{
//    Console.WriteLine("GIVEN NUMBER IS 3 DIGITS");
//}
//int hundred = (number / 100);
//int onluq = (number / 10) - (hundred * 10);
//int single = (number % 10);
//int sum = hundred + onluq + single;
//int residue = sum % 2;
//if (residue == 0)
//{
//    Console.WriteLine("ededlerin cemi cutdur");
//}
//else
//{
//    Console.WriteLine("ededlerin cemi tekdir");
//}
//TASK2:

//int number = 1357;
//int thousand = number / 1000;
//int hundred = (number / 100) - (thousand * 10);
//int onluq = (number / 10) - (thousand * 100) - (hundred * 10);
//int single = number % 10;
//int sum = (thousand + hundred + onluq + single);
//int orta = sum / 4;
//Console.WriteLine(orta);
//TASK3:
//int number = 855;

//int hundred = (number / 100);
//int onluq = (number / 10) - (hundred * 10);
//int single = (number % 10);
//int sum = hundred + onluq + single;
//int uc = sum % 3;
//int bes = sum % 5;
//if (uc == 0 && bes == 0)
//{
//    Console.WriteLine("eded hem 3 hemde 5 bolunur");
//}
//else if (uc == 0 || bes == 0)
//{
//    Console.WriteLine("eded ya 3 yada 5 bolunur");
//}
//else
//{
//    Console.WriteLine("eded ne 3 nede 5 bolunur");
//}
//TASK4:
//int number_1 = 18;
//int number_2 = 35;
//int qaliq1 = number_1 % 2;
//int qaliq2 = number_2 % 2;
//if (qaliq1 == 0 && qaliq2 == 0)
//{
//    Console.WriteLine(number_1 + number_2);
//}
//else
//{
//    Console.WriteLine(number_1 - number_2);
//}
//TASK5:
//int salary = 1500;
//int credit = 15000;
//int annual_salary = salary * 12;
//int percentage = (annual_salary * 60) / 100;
//if (credit > percentage)
//{
//    Console.WriteLine("you can't get a loan");
//}
//else
//{
//    Console.WriteLine("you can take a loan");
//}

float gpa = 79.7f;
switch (gpa)
{
    case float g when (g >= 91):
        Console.WriteLine("A");
        break;
    case float g when (g <= 90) && g >= 81:
        {
            Console.WriteLine("B");
            break;
        }
    case float g when (g <= 80) && g >= 71:
        {
            Console.WriteLine("C");
            break;
        }
    case float g when (g <= 70) && g >= 61:
        {
            Console.WriteLine("D");
            break;
        }
    case float g when (g <= 60) && g >= 51:
        {
            Console.WriteLine("E");
            break;
        }
    case float g when (g <= 50):
        {
            Console.WriteLine("KESILDIN");
            break;
        }
}
