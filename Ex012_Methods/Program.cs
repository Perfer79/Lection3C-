// Вид 1. Ничего не принимают, **_ничего не возвращают_**.

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1(); // вызов метода
// //Method1 без скобок - ошибка

// Вид2
// void Method2(string msg)
// {
//      Console.WriteLine(msg);
// }
//Method2(msg: "Текст сообщения"); //вызов метода

//вид2, вариант2
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //Памятка: i++ = Инкремент, i-- = Декремент
//     }
// }
// //Method21(msg:"Текст", count: 4);
// Method21(count: 4, msg:"Новый Текст"); //equal. В любом порядке.

//Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3(); // Идетификатор метода Method3()Скобки обязательно. Затем слева через оператор присваивания (=) использовать идентификатор переменной (year) и положить нужное значение в Method3
// Console.WriteLine(year);

// Вид4

// string Method4(int count, string text)
// {
//     int i=0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf ");
// Console.WriteLine(res);

// Вид4 теперь через for
// string Method4(int count, string text)
// {
//     int i=0;
//     string result = String.Empty;
//     for(i = 0; i < count; i++)
//     {
//         result = result + text;     
//     }
//     return result;
// }

// string res = Method4(10, "asdf ");
// Console.WriteLine(res);

