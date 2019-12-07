using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0);
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestMyFunctionNonZeros()
        {
            var res = Program.MyFunction(0.0, 0.0);
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(1, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.28, 1.36, 2.47, 3.68, 4.56 };
            var res = Program.TaskB(1.6, x);
            var expy = new double[] { 2.54483385166692, 2.5615887682505, 11.2873629585646, 363.108837198182, 10971.2863691829 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA0()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            var expy = new double[] { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA1()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            var expy = new double[] { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA2()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            var expy = new double[] { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
