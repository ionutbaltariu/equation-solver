﻿using CustomExceptions;

namespace CheckVariables
{
    public sealed class CheckVariableUtil
    {
        public static  void checkPopulationSize(int populationSize)
        {
            if (populationSize <= 2)
            {
                throw new NegativeOrZeroNumberException("Population is less than or equal to 2 \r\nMust be a positive integer greater than 2 \r\nIntroduced value: " + populationSize);
            }
        }

        public static void checkNumberOfGenerations(int numberOfGenerations)
        {
            if (numberOfGenerations <= 0)
            {
                throw new NegativeOrZeroNumberException("Number of generations is less than or equal to 0 \r\nMust be a positive integer greater than 0 \r\nIntroduced value: " + numberOfGenerations);
            }
        }

        public static void checkCrossOverRate(double crossOverRate)
        {
            if (crossOverRate < 0 || crossOverRate > 1)
            {
                throw new CrossOverRateException("CrossOver Rate must be between 0 and 1 \r\nIntroduced value: " + crossOverRate);
            }
        }

        public static void checkMotivationRate(double motivationRate)
        {
            if (motivationRate < 0 || motivationRate > 2)
            {
                throw new MotivationRateException("Motivation Rate must be between 0 and 2 \r\nIntroduced value: " + motivationRate);
            }
        }

        public static void checkNumOfGenes(int numOfGenes)
        {
            if (numOfGenes < 1 || numOfGenes > 4)
            {
                throw new NegativeOrZeroNumberException("Number of genes must be between 1 and 4 \r\nIntroduced value: " + numOfGenes);
            }
        }
    }
}
