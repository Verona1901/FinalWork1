# ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых либо меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

## 2.
Блок-схема алгоритма находится в папке **BlockDiagram**

## 3.
Описание алгоритма:

Пользователь вводит с клавиатуры желаемый размер массива. Затем сами элементы.

Далее происходит отбор с помощью цикла, подходит ли элемент условию "длина символов <= 3". Если элемент подходит под данное условие, то он добавляется в новый массив, учитывая последовательность заполнения элементами в новом массиве (count++). После прохождения цикла по всем элементам массива, формируется новый массив с учтенными параметрами.

## 4.
В папке **FinaiWork** содержится решение задачи на C# : 

FinalWork/Program.cs /