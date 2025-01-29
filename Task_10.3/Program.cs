/* Ви отримали рядок, який містить декілька слів, розділених комами.
 * Ваша мета - видалити всі пробіли з цього рядка та вивести результат. */
Console.WriteLine("Завдання 10.3");
var text = "When Alice falls down the rabbit hole, she finds herself in Wonderland where she embarks upon the most bizarre adventure, " +
    "encountering many outlandish creatures as she goes. Some of the best-known characters include the " +
    "White Rabbit with his pocket watch, the grinning Cheshire Cat, the Caterpillar and his hookah, " +
    "the Mad Hatter and the March Hare at their tea party and of course the terrifying despot the " +
    "Queen of Hearts screeching “Off with their Heads!”. These whimsical characters, amongst many others, " +
    "make Alice’s journey into a world of nonsense completely spellbinding.";
Console.WriteLine(text);
//Згідно цього завдання я маю видалити пробіли...
var text_without_spaces = text.Replace(" ", "");
Console.WriteLine(text_without_spaces);
//Можно ще коми прибрати...
var text_line = text_without_spaces.Replace(",", "");
Console.WriteLine(text_line);
// Написав цей код, одразу згадую де цим користуюсь... Майже кожний текстовий редактор - "Знайти та замінити".
// Не тільки символи, а й подвійні пробіли так прибираю, заміна слів, дати та багато чого іншого  
