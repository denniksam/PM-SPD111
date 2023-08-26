using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new();
            Assert.IsNotNull(calculator, "Calculator does created");
            Assert.IsTrue(4 == calculator.Add(2, 2), "2 + 2 == 4");
            Assert.IsTrue(4000000000 == calculator.Add(2000000000, 2000000000), "2G + 2G == 4G");
            Assert.IsTrue(0 == calculator.Add(2, -2), "2 + -2 == 0");
            Assert.IsTrue(0 == calculator.Add(-2, 2), "-2 + 2 == 0");
            Assert.IsTrue(-4 == calculator.Add(-2, -2), "-2 + -2 == -4");
            Assert.IsTrue(4000000000 == calculator.Add(3000000000, 1000000000), "3G + 1G == 4G");
            Assert.IsTrue(4000000000 == calculator.Add(1000000000, 3000000000), "1G + 3G == 4G");
        }

        [TestMethod()]
        public void DivTest()
        {
            Calculator calculator = new();
            Assert.IsNotNull(calculator, "Calculator does created");

            // Спадкування виключень не враховується, очікується виключення лише зазначеного типу
            var ex = Assert.ThrowsException<DivideByZeroException>(() =>
            {
                calculator.Div(0, 0);
            });
            // збереження виключення (ех) дозволяє перевірити його на певні параметри
            Assert.IsTrue(ex.Message.Length > 0, "Non empty message in exception");
            // перевіряємо, що у повідомленні є назва параметру 'y'
            string paramName = "'y'"; // назва параметра, яку ми шукаємо
            Assert.IsTrue(ex.Message.Contains(paramName), $"Message should mention parameter '{paramName}'");

            // завершення без виключення - використання ефекту того, що 
            // виключення у методі саме по собі провалить тест
            Assert.IsNotNull(calculator.Div(2, 1), "Виключення");
        }
    }
}
/* Д.З. (Підсумок/Екзамен)
 * Розмістити у репозиторії завдання (issues), на дошці проєкту відобразити їх,
 * встановити для них рубіж (Milestone), призначити виконавців.
 * Скласти модульні тести для усіх операцій калькулятора (розподілити роботу
 * по учасникам проєкту), реалізувати операції, пересвідчитись у проходженні
 * тестів.
 * Прикласти посилання на репозиторій, пересвідчитись у видимості "дошки",
 * її завдань та рубежів
 */