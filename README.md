# nunitGeometric

В таком виде проект не работает. Саму библиотеку не прицепила в проект, ее нужно закинуть в файлы проекта.

тесты в таком виде лучше не дать

[Test, TestCaseSource("SquareCases")]
public void TestMethod(int side, int area, int length)
{
Square square = new Square(side);
Assert.AreEqual(area, square.getAreaSquare());
Assert.AreEqual(length, square.getLengthSquare());
}
Если упадет метод Assert.AreEqual(area, square.getAreaSquare()); До шага проверки длины мы вообще не дойдем, А может быть так, что одна часть работает, вторая нет. Нужно проверять отдельно. Ну или использовать тип проверки который не останавливает тест.

В целом работа верно выполнена
