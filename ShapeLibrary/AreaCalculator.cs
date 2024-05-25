using System;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary
{
    // Этот класс создал для высичления площади фигура который наследствует от нашего интерфейса IShape
    // "Вычисление площади фигуры без знания типа фигуры в compile-time" - для этой инструкции
    // Но, кажется тут неполная инструкция. Может имели ввиду разрешать пользователю вводить или выбрать фигур

    public static class AreaCalculator
	{
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}

