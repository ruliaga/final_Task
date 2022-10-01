# Описание решения #

## *Задача* ##

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## *Решение* ##

* Строка вводится в консоль с клавиатуры
* Введенная строка преобразуется в массив строк через команду Split и разделитель "пробел"
* Создается две функции:
1. **NewArray**. функция принимает на вход массив строк. В теле функции создается новый массив со случайным количеством элементов от 0 до 3. Затем цикл for проходит по всем элементам нового массива и присваевает случайное значение начального массива startArray.
2. **PrintArray**. Функция способна вывести в консоль массив строк. В программе функция сначала выводит вводимый массив строк startArray, затем выводит новый массив newArray

## <p style="text-align: center;"> Спасибо за внимание!</p> ##