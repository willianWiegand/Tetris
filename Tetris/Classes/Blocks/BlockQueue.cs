using System;

namespace Tetris.Classes.Blocks {
  public class BlockQueue {
    private readonly Block[] _blocks = new Block[] {
      new IBlock(),
      new JBlock(),
      new LBlock(),
      new OBlock(),
      new SBlock(),
      new TBlock(),
      new ZBlock()
    };
    
    private readonly Random _randomSeed = new Random();
    public Block NextBlock { get; private set; }

    // Construtor cria o próximo bloco
    public BlockQueue() {
      NextBlock = RandomizeBlock();
    }

    // Método de sorteio da próxima peça
    private Block RandomizeBlock() {
      return _blocks[_randomSeed.Next(_blocks.Length)];
    }

    // Método que atualiza a próxima peça e solicita novo sorteio
    public Block GetAndUpdate() {
      var block = NextBlock;

      do {
        NextBlock = RandomizeBlock();
      } while (block.Id == NextBlock.Id);

      return block;
    }
  }
}
