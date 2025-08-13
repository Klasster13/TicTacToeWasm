using TicTacToe.Common.Enums;

namespace TicTacToe.Domain.Models;

public class Field
{
    private const int DefaultSize = 3;
    public List<List<Cell>> Board { get; set; } = null!;

    public Field()
    {
        Board = Enumerable.Range(0, DefaultSize)
            .Select(_ => Enumerable.Repeat(Cell.None, DefaultSize).ToList())
            .ToList();
    }

    public static int Size => DefaultSize;

    public Cell this[int y, int x]
    {
        get => Board[y][x];
        set => Board[y][x] = value;
    }

    //public Field Clone()
    //{
    //    var clone = new Field();

    //    for (int i = 0; i < DefaultSize; i++)
    //    {
    //        for (int j = 0; j < DefaultSize; j++)
    //        {
    //            clone.Board[i][j] = Board[i][j];
    //        }
    //    }

    //    return clone;
    //}

    public void Clear()
    {
        foreach (var row in Board)
        {
            for (int i = 0; i < row.Count; i++)
            {
                row[i] = Cell.None;
            }
        }
    }
}