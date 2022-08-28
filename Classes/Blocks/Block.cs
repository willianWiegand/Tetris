using System.Collections.Generic;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Blocks {
  public abstract class Block {
    protected abstract Position[][] Tiles { get; }
    protected abstract Position StartOffset { get; }
    public abstract int Id { get; }

    private int _rotation;
    private Position _offset;

    // Inicializa o bloco em sua posição inicial
    public Block() {
      _offset = new Position(StartOffset.Row, StartOffset.Col);
    }

    // Retorna todas as posições que o bloco pode ocupar dentro do seu grid de rotação
    public IEnumerable<Position> TilePositions() {
      foreach (var p in Tiles[_rotation]) {
        yield return new Position(p.Row + _offset.Row, p.Col + _offset.Col);
      }
    }

    // Rotaciona o bloco no sentido horário, alterando o seu estado atual de orientação
    public void RotateCW() {
      if (_rotation == Tiles.Length - 1) {
        _rotation = 0;
      }
      else {
        _rotation++;
      }
    }

    // Rotaciona o bloco no sentido antihorário, alterando o seu estado atual de orientação
    public void RotateCCW() {
      if (_rotation == 0) {
        _rotation = Tiles.Length - 1;
      }
      else {
        _rotation--;
      }
    }

    // Movimenta o bloco dentro do grid uma quantidade tal de linhas e colunas
    public void Move(int rows, int columns) {
      _offset.Row += rows;
      _offset.Col += columns;
    }

    // Reseta o bloco para sua condição inicial de rotação e posição
    public void Reset() {
      _rotation = 0;
      _offset = StartOffset;
    }
  }
}
