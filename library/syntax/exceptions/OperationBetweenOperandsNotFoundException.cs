﻿using library.tokens;

namespace library.syntax.exceptions
{
    internal class OperationBetweenOperandsNotFoundException : Exception
    {
        public OperandToken FirstOperand { get; }
        public OperandToken SecondOperand { get; }
        public int Position { get; }

        public OperationBetweenOperandsNotFoundException(OperandToken firstOperand, OperandToken secondOperand, int position)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Position = position;
        }
    }
}
