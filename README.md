# Описание работы над проектом в рамках итоговой контрольной работы

## Введение. 
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

Итак, прочитав ТЗ и взглянув на пример выполения программы, можно сделать вывод о том, что программа должна:

1) Пробежать массив, состоящий из строк.
2) Посчитать количество символов в каждой строке.
3) Если количество символов в строке окажется меньше или равно 3, то эту строку мы будем записывать в новый массив. Если же количество символов в строке окажется более 3, то эта строка просто останется лежать в исходном массиве.
4) Если строк с количеством символов <=3 больше одной, то будем записывать их в новый массив до тех пор, пока в новом массиве общее количество символов не привысит значение 3. 
5) Соответственно после каждой записи в новый массив мы будем считать в нем общее количество символвов, чтобы понимать, можем ли мы еще что-то записать в него или уже нет.

Так как в основном блоке мы проходили ЯП C#, то и решать задачу будем тоже на нем. 

## Пункт 1. Создание репозитория.
Создаем репозиторий "CWMainBlockOlegPetrov". 
Вяжем его с нашим проектом: 

    git remote add origin https://github.com/Olegnormchel83/CWMainBlockOlegPetrov.git
    git branch -M main
    git push -u origin main

## Пункт 2. Первый и второй этап выполнения работы.
    Пробежать массив, состоящий из строк.

Для этой задачи реализуем функцию *check_words_array()* которая будет принимать строковый массив, считать в нем количество слов, а также количество символов в каждом слове. Также будем запоминать кол-во слов и символов в отдельные переменные, вдруг позже пригодятся.

## Пункт 3. Третий этап выполнения работы.
Создадим отдельную ветку для реализации основного алгоритма и сразу перейдем на нее.

    git branch main_algorithm
    git checkout main_algorithm

