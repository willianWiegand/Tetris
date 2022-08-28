<<<<<<< HEAD
﻿using Tetris.Classes.Blocks;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Structure
{
    public class TetrisState
    {
        private Block _currentBlock;
        public Block CurrentBlock
        {
            get => _currentBlock;
            private set
            {
                _currentBlock = value;
                _currentBlock.Reset();
            }
        }
        public int Score { get; private set; }
        public int Lines { get; private set; }
        public int Level { get; private set; }
        public Difficulty DifficultyLevel { get; private set; }
        private int[] scorePoint;
        public TetrisGrid Grid { get; }
        public BlockQueue BlockQueue { get; }
        public bool GameOver { get; private set; }
        private const int _rows = 22;
        private const int _columns = 10;
        private const int _width = 28;
        private const int _height = 28;

        // Inicializa o grid, a fila de blocos e atualiza o próximo bloco gerado randomicamente
        public TetrisState(Difficulty difficulty)
        {
            Grid = new TetrisGrid(_rows, _columns, _width, _height);
            BlockQueue = new BlockQueue();
            CurrentBlock = BlockQueue.GetAndUpdate();
            Score = 0;
            Lines = 0;
            Level = 1;
            DifficultyLevel = difficulty;
            // Definição do Array de valores de pontuação dependendo da quantidade de linhas que foram limpas, específico para cada dificuldade


            switch (difficulty)
            {
                case Difficulty.Easy:
                    scorePoint = new int[] { 0, 10, 30, 50, 80 };
                    break;

                case Difficulty.Meddium:
                    scorePoint = new int[] { 0, 30, 50, 80, 130 };
                    break;

                case Difficulty.Hard:
                    scorePoint = new int[] { 0, 50, 80, 130, 210};
                break;
            }
        }

        // Verifica se todas as posições do bloco estão contidas em posições vazias do grid
        private bool BlockFits()
        {
            foreach (var p in CurrentBlock.TilePositions())
            {
                if (!Grid.IsTileEmpty(p.Row, p.Col))
                {
                    return false;
                }
            }

            return true;
        }

        // Rotaciona o bloco no sentido horário, desde que ele esteja contido no grid
        public void RotateBlockCW()
        {
            CurrentBlock.RotateCW();

            if (!BlockFits())
            {
                CurrentBlock.RotateCCW();
            }
        }

        // Rotaciona o bloco no sentido antihorário, desde que ele esteja contido no grid
        public void RotateBlockCCW()
        {
            CurrentBlock.RotateCCW();

            if (!BlockFits())
            {
                CurrentBlock.RotateCW();
            }
        }

        // Movimenta o bloco para direita, desde que ele esteja contido no grid
        public void MoveBlockRight()
        {
            CurrentBlock.Move(0, 1);

            if (!BlockFits())
            {
                CurrentBlock.Move(0, -1);
            }
        }

        // Movimenta o bloco para esquerda, desde que ele esteja contido no grid
        public void MoveBlockLeft()
        {
            CurrentBlock.Move(0, -1);

            if (!BlockFits())
            {
                CurrentBlock.Move(0, 1);
            }
        }

        // Movimenta o bloco para baixo até que ele colida com alguma coisa
        public void MoveBlockDown()
        {
            CurrentBlock.Move(1, 0);

            if (!BlockFits())
            {
                CurrentBlock.Move(-1, 0);
                BlockOnPlace(DifficultyLevel);
            }
        }

        // Grava no grid a posição final do bloco, verifica todas as linhas completas e se o jogo deu game over, do
        // contrário, pega a próxima peça e sorteia a peça seguinte
        private void BlockOnPlace(Difficulty difficulty)
        {
            int cleareadRows;
            int levelUpScore = 210;

            switch (difficulty)
            {
                case Difficulty.Easy:
                    levelUpScore = 210;
                    break;

                case Difficulty.Meddium:
                    levelUpScore = 340;
                    break;

                case Difficulty.Hard:
                    levelUpScore = 550;
                    break;
            }


            foreach (var p in CurrentBlock.TilePositions())
            {
                Grid[p.Row, p.Col] = CurrentBlock.Id;
            }

            cleareadRows = Grid.ClearAllRows();
            Score += scorePoint[cleareadRows] * Level;
            Lines += cleareadRows;
            Level = Score / levelUpScore + 1;

            if (IsGameOver())
            {
                GameOver = true;
            }
            else
            {
                CurrentBlock = BlockQueue.GetAndUpdate();
            }
        }

        // Verifica se as duas primeiras linhas do topo do grid não estão vazias, se não estiverem, o jogo finaliza
        private bool IsGameOver()
        {
            return !(Grid.IsRowEmpty(0) && Grid.IsRowEmpty(1));
        }

        // Verifica a quantidade de tiles abaixo do bloco atual até colidir com um bloco já encaixado
        private int TileDropDistance(Position p)
        {
            int drop = 0;

            while (Grid.IsTileEmpty(p.Row + drop + 1, p.Col))
            {
                drop++;
            }

            return drop;
        }

        // Verifica a menor distancia entre o bloco atual e os blocos encaixados abaixo
        public int BlockDropDistance()
        {
            int drop = Grid.Rows;

            foreach (Position p in CurrentBlock.TilePositions())
            {
                drop = System.Math.Min(drop, TileDropDistance(p));
            }

            return drop;
        }

    }
}
=======
﻿using Tetris.Classes.Blocks;
using Tetris.Classes.Structure;

namespace Tetris.Classes.Structure
{
    public class TetrisState
    {
        private Block _currentBlock;
        public Block CurrentBlock
        {
            get => _currentBlock;
            private set
            {
                _currentBlock = value;
                _currentBlock.Reset();
            }
        }
        public int Score { get; private set; }
        public int Lines { get; private set; }
        public int Level { get; private set; }
        public Difficulty DifficultyLevel { get; private set; }
        private int[] scorePoint;
        public TetrisGrid Grid { get; }
        public BlockQueue BlockQueue { get; }
        public bool GameOver { get; private set; }
        private const int _rows = 22;
        private const int _columns = 10;
        private const int _width = 28;
        private const int _height = 28;

        // Inicializa o grid, a fila de blocos e atualiza o próximo bloco gerado randomicamente
        public TetrisState(Difficulty difficulty)
        {
            Grid = new TetrisGrid(_rows, _columns, _width, _height);
            BlockQueue = new BlockQueue();
            CurrentBlock = BlockQueue.GetAndUpdate();
            Score = 0;
            Lines = 0;
            Level = 1;
            DifficultyLevel = difficulty;
            // Definição do Array de valores de pontuação dependendo da quantidade de linhas que foram limpas, específico para cada dificuldade


            switch (difficulty)
            {
                case Difficulty.Easy:
                    scorePoint = new int[] { 0, 10, 30, 50, 80 };
                    break;

                case Difficulty.Meddium:
                    scorePoint = new int[] { 0, 30, 50, 80, 130 };
                    break;

                case Difficulty.Hard:
                    scorePoint = new int[] { 0, 50, 80, 130, 210};
                break;
            }
        }

        // Verifica se todas as posições do bloco estão contidas em posições vazias do grid
        private bool BlockFits()
        {
            foreach (var p in CurrentBlock.TilePositions())
            {
                if (!Grid.IsTileEmpty(p.Row, p.Col))
                {
                    return false;
                }
            }

            return true;
        }

        // Rotaciona o bloco no sentido horário, desde que ele esteja contido no grid
        public void RotateBlockCW()
        {
            CurrentBlock.RotateCW();

            if (!BlockFits())
            {
                CurrentBlock.RotateCCW();
            }
        }

        // Rotaciona o bloco no sentido antihorário, desde que ele esteja contido no grid
        public void RotateBlockCCW()
        {
            CurrentBlock.RotateCCW();

            if (!BlockFits())
            {
                CurrentBlock.RotateCW();
            }
        }

        // Movimenta o bloco para direita, desde que ele esteja contido no grid
        public void MoveBlockRight()
        {
            CurrentBlock.Move(0, 1);

            if (!BlockFits())
            {
                CurrentBlock.Move(0, -1);
            }
        }

        // Movimenta o bloco para esquerda, desde que ele esteja contido no grid
        public void MoveBlockLeft()
        {
            CurrentBlock.Move(0, -1);

            if (!BlockFits())
            {
                CurrentBlock.Move(0, 1);
            }
        }

        // Movimenta o bloco para baixo até que ele colida com alguma coisa
        public void MoveBlockDown()
        {
            CurrentBlock.Move(1, 0);

            if (!BlockFits())
            {
                CurrentBlock.Move(-1, 0);
                BlockOnPlace(DifficultyLevel);
            }
        }

        // Grava no grid a posição final do bloco, verifica todas as linhas completas e se o jogo deu game over, do
        // contrário, pega a próxima peça e sorteia a peça seguinte
        private void BlockOnPlace(Difficulty difficulty)
        {
            int cleareadRows;
            int levelUpScore = 210;

            switch (difficulty)
            {
                case Difficulty.Easy:
                    levelUpScore = 210;
                    break;

                case Difficulty.Meddium:
                    levelUpScore = 340;
                    break;

                case Difficulty.Hard:
                    levelUpScore = 550;
                    break;
            }


            foreach (var p in CurrentBlock.TilePositions())
            {
                Grid[p.Row, p.Col] = CurrentBlock.Id;
            }

            cleareadRows = Grid.ClearAllRows();
            Score += scorePoint[cleareadRows] * Level;
            Lines += cleareadRows;
            Level = Score / levelUpScore + 1;

            if (IsGameOver())
            {
                GameOver = true;
            }
            else
            {
                CurrentBlock = BlockQueue.GetAndUpdate();
            }
        }

        // Verifica se as duas primeiras linhas do topo do grid não estão vazias, se não estiverem, o jogo finaliza
        private bool IsGameOver()
        {
            return !(Grid.IsRowEmpty(0) && Grid.IsRowEmpty(1));
        }

        // Verifica a quantidade de tiles abaixo do bloco atual até colidir com um bloco já encaixado
        private int TileDropDistance(Position p)
        {
            int drop = 0;

            while (Grid.IsTileEmpty(p.Row + drop + 1, p.Col))
            {
                drop++;
            }

            return drop;
        }

        // Verifica a menor distancia entre o bloco atual e os blocos encaixados abaixo
        public int BlockDropDistance()
        {
            int drop = Grid.Rows;

            foreach (Position p in CurrentBlock.TilePositions())
            {
                drop = System.Math.Min(drop, TileDropDistance(p));
            }

            return drop;
        }

    }
}
>>>>>>> 18821ee0da2450dcfdfee11013fd72780ef4029f
