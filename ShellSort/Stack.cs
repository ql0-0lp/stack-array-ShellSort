using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T>
{
    private readonly int _Size;
    private readonly int[] _Array;
    private int _Top;

    public Stack(int Size)
    {
        this._Size = Size;
        this._Top = 0;
        this._Array = new int[this._Size];
    }

    public int Top
    {
        get
        {
            return this._Top;
        }
    }

    public int Size
    {
        get
        {
            return this._Size;
        }
    }
    public int Count
    {
        get
        {
            return this._Top;
        }
    }

    public bool IsFull()
    {
        return this._Top == this._Size;
    }
    
    public bool IsEmpty() // Проверить пустой ли стек
    {
        return this._Top == 0;
    }

    public void Push(int Element)
    {
        if (this.IsFull())
            throw new Exception();
        this._Array[this._Top++] = Element;
    }
    
    public int Peek() // Вернуть верхний элемент
    {
        return this._Array[this._Top - 1];
    }
    
    public int Pop() // Считывание из стека верхнего элемента
    {
        return this._Array[--this._Top];
    }

    public int Get(int index) // Геттер
    {
        Stack<string> temp = new Stack<string>(Size - index - 1);

        for (int i = 0; i < Size - index - 1; i++)
        {
            temp.Push(this.Pop());
        }
        int value = this.Peek();
        for (int i = 0; i < Size - index - 1; i++)
        {
            this.Push(temp.Pop());
        }
        return value;
    }

    public void Set(int index, int value) // Сеттер
    {
        Stack<string> temp = new Stack<string>(Size - index - 1);

        for (int i = 0; i < Size - index - 1; i++)
        {
            temp.Push(Pop());
        }
        this.Pop();
        this.Push(value);
        for (int i = 0; i < Size - index - 1; i++)
        {
            this.Push(temp.Pop());
        }
    }

    public IEnumerator<int> GetEnumerator() // Вывод стека
    {
        if (this.IsEmpty())
            throw new Exception("Стек не заполнен.");
        for (int i = this._Top; i > 0; i--)
            yield return _Array[i - 1];
    }
}