# Тестовое задание для MindBox
**Задание №1:**

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

:white_check_mark: Юнит-тесты 
 >> Написано 10 юнит-тестов.
 
-:white_check_mark: Легкость добавления других фигур
>> Чтобы добавить класс новой фигуры достаточно реализовать интерфейс IFigure и метод GetArea().

:white_check_mark: Вычисление площади фигуры без знания типа фигуры в compile-time
>> Выполнено, так как класс круга (Tcircle) и треугольника (TTriangle) реализуют интерфейс IFigure и метод GetArea().

:white_check_mark: Проверку на то, является ли треугольник прямоугольным
>> В классе треугольника TTriangle присутствует метод RightTriangle()

**Вопрос №2**

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
По возможности — положите ответ рядом с кодом из первого вопроса.
>> Решение лежит  впапке SQL
