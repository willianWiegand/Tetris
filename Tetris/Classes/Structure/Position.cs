namespace Tetris.Classes.Structure {
  public class Position {
    public int Row { get; set; }
    public int Col { get; set; }

    public Position(int row, int column) {
      Row = row;
      Col = column;
    }
  }
}
