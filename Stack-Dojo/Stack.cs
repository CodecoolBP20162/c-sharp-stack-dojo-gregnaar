using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Dojo
{
    class Stack<T>
    {
        private int Size { get; set; }
        private int Position { get; set; }
        private T[] stack;

        public Stack(int Size)
        {
            this.Size = Size;
            stack = new T[Size];
            Position = 0;
        }

        public void Push(T value)
        {
            try
            {
                stack[Position] = value;
                Position++;
            }
            catch
            {
                throw new ArgumentException("Stack is full!");
            }
        }

        public T Pop()
        {
            if (Position > 0)
            {
                Position--;
                T value = stack[Position];
                return value;
            }
            else
            {
                throw new ArgumentException("No data in the stack");
            }
        }

        public T Peek()
        {
            if (Position > 0)
            {
                Position--;
                T value = stack[Position];
                Position++;
                return value;
            }
            else
            {
               throw new ArgumentException("No data in the stack");
            }
        }

        public int GetSize()
        {
            return Size;
        }

        public int FreeSpaceLeft()
        {
            return Size - Position;
        }

    }
}
