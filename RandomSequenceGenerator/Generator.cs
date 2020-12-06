using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSequenceGenerator
{
    public static class Generator
    {
        public const int ALPHABET_POWER = 15; // Мощность алфавита


        public static int[] CreateSequence(GeneratorParameters genParams)
        {
            return CreateSequence(genParams.length, genParams.x0, genParams.a, genParams.c);
        }
        public static int[] CreateSequence(int length, int x0, int a, int c)
        {
            if (length < 0 || x0 < 0 || a <= 0 || c < 0 ||
                              x0 > ALPHABET_POWER - 1 || a > ALPHABET_POWER - 1 || c > ALPHABET_POWER - 1)
            {
                throw new Exception("Incorrect data!");
            }
            int[] sequence = new int[length];

            sequence[0] = x0;
            for (int i = 1; i < length; i++)
            {
                sequence[i] = (a * sequence[i - 1] + c) % ALPHABET_POWER;
            }

            return sequence;
        }
        public static bool IsPearson(int[] sequence)
        {
            double[] h2 = new double[] { 3.841, 5.991, 7.815, 9.488, 11.070,
                                        12.592, 14.067, 15.507, 16.919, 18.307,
                                        19.675, 21.026, 22.362, 23.685, 24.996,
                                        26.296, 27.587, 28.869, 30.144, 31.41 };

            double res = 0; // результат

            int K = Convert.ToInt32(5 * Math.Log10(sequence.Length)); // количество интервалов

            double[] intervals = new double[K + 1]; // интервалы

            for (int i = 0; i < K; i++)
            {
                intervals[i] = (double)ALPHABET_POWER / K * i;
            }
            intervals[K] = ALPHABET_POWER + 1;
            double P = 1 / (double)K; // вероятность (интервалы одинаковые)

            for (int i = 0; i < K; i++)
            {
                int Vi = 0; // количество элементов последовательности в интервале

                for (int j = 0; j < sequence.Length; j++)
                {
                    if (sequence[j] < intervals[i + 1] && sequence[j] >= intervals[i])
                    {
                        Vi++;
                    }
                }
                res += Math.Pow(((double)Vi / sequence.Length - P), 2) / P;
            }
            res *= sequence.Length;

            if (res > h2[K])
                return false;
            else
                return true;
        }
        public static string GetPeriod(int[] sequence, out int periodLength)
        {
            periodLength = 1;
            string period = "";

            period += " " + sequence[0];
            for (int i = 1; i < sequence.Length; i++) // поиск периода
            {
                string tmp = "";

                for (int j = 0; j + i < sequence.Length && j < periodLength; j++)
                    tmp += " " + sequence[i + j];

                if (period == tmp)
                    return period;

                periodLength++;
                period += " " + sequence[i];
            }

            return period;
        }
    }
}
