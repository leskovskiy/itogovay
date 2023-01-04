#Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

#Решение задачи:

1. Задается массив *array* с произвольной длинной;
2. Задается новый массив *NewArray* с длинной равной длинне первого массива(в который будет вкладываться значения первого массива)
3. Задается контейнер **count = 0** в котором будут храниться значемния нового массива
4. В цикле идет проверка длинны массива *array* на соответствие условию **array[i].Length <= 3** , где длинна массива не должна превышать 3 
4. Если условие выполняется, элемент массива *array* заносится в **count**
5. Цикл работает до конца пока соблюдается условие
6. Вывод массива *NewArray* с присвоенными элементами из массива *array*

##Графический алгоритм выполнения задания



