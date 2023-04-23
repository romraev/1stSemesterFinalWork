# Итоговая контрольная работа
## Подготовил Раевский Р.Ю.

**Задание:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Тест:**

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

**Решение:**

1. Использование генерирующего метода для создания массива строк с заранее задаваемым размером путем поочередного ввода пользователем.
2. Использование генерирующего метода для создания нового массива строк, в который включаются только те строки из первого массива, которые содержат менее 4 символов. Остальные строки остаются пустыми.
3. Вывод данных из обеих массивов (по очереди), игнорируя пустые строки.