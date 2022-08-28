namespace Tetris.Classes.Structure {
  public class TetrisGrid {
    public readonly int[,] grid;
    public int Rows { get; }
    public int Columns { get; }
    public int Width { get; }
    public int Height { get; }

    public int this[int r, int c] {
      get => grid[r, c];
      set => grid[r, c] = value;
    }

    // Construtor do grid
    public TetrisGrid(int rows, int columns, int width, int height) {
      Rows = rows;
      Columns = columns;
      grid = new int[rows, columns];
      Width = width;
      Height = height;
    }

    // Verifica se determinada linha e coluna estão dentro do grid
    public bool IsOnGrid(int r, int c) {
      return r >= 0 && r < Rows &&
             c >= 0 && c < Columns;
    }

    // Verifica se determinada posição no grid está vazia
    public bool IsTileEmpty(int r, int c) {
      return IsOnGrid(r, c) && grid[r, c] == 0;
    }

    // Verifica se determinada linha está completa
    public bool IsRowFull(int r) {
      for (int c = 0; c < Columns; c++) {
        if (grid[r, c] == 0) {
          return false;
        }
      }

      return true;
    }

    // Verifica se determinada linha está vazia
    public bool IsRowEmpty(int r) {
      for (int c = 0; c < Columns; c++) {
        if (grid[r, c] != 0) {
          return false;
        }
      }

      return true;
    }

    // Limpa determinada linha
    public void ClearRow(int r) {
      for (int c = 0; c < Columns; c++) {
        grid[r, c] = 0;
      }
    }

    // Move uma linha para baixo a quantidade de vezes igual ao número de linhas completas até o momento
    private void MoveDownRow(int r, int nRows) {
      for (int c = 0; c < Columns; c++) {
        grid[r + nRows, c] = grid[r, c];
        grid[r, c] = 0;
      }
    }

    // Verifica todo o grid limpando as linhas completas
    public int ClearAllRows() {
      int clearedRows = 0;

      for (int r = Rows - 1; r >= 0; r--) {
        if (IsRowFull(r)) {
          ClearRow(r);
          clearedRows++;
        }
        else if (clearedRows > 0) {
          MoveDownRow(r, clearedRows);
        }
      }

      return clearedRows;
    }
  }
}
