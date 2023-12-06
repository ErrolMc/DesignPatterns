﻿
namespace DesignPatterns.Behavioral.Memento
{
    // Memento
    public class TextMemento
    {
        public string Text { get; }

        public TextMemento(string text)
        {
            Text = text;
        }
    }
}
