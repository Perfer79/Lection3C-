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
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count);
    {
        Console.WriteLine(msg);
        i++; //Памятка: i++ = Инкремент, i-- = Декремент
    }
}
Method21("Текст", 4);