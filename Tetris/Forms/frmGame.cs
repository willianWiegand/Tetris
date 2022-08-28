using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.Classes.Blocks;
using Tetris.Classes.DataBase;
using Tetris.Classes.Structure;

namespace Tetris.Forms
{
    public partial class frmGame : Form
    {
        // Array de imagens dos tiles de 0 a 7
        private readonly Image[] tileImages = new Image[] {
      Properties.Resources.img_EmptyBlock,
      Properties.Resources.img_CyanTile,
      Properties.Resources.img_BlueTile,
      Properties.Resources.img_OrangeTile,
      Properties.Resources.img_YellowTile,
      Properties.Resources.img_GreenTile,
      Properties.Resources.img_PurpleTile,
      Properties.Resources.img_RedTile,
    };
        // Array de imagens dos blocks de 0 a 7
        private readonly Image[] blockImages = new Image[] {
      Properties.Resources.img_EmptyBlock,
      Properties.Resources.img_IBlock,
      Properties.Resources.img_JBlock,
      Properties.Resources.img_LBlock,
      Properties.Resources.img_OBlock,
      Properties.Resources.img_SBlock,
      Properties.Resources.img_TBlock,
      Properties.Resources.img_ZBlock,
    };
        private readonly Image[,] imageControls;
        //private readonly int maxDelay = 600;
        //private readonly int minDelay = 100;
        //private readonly int delayDecrease = 50;
        private int maxDelay;
        private int minDelay;
        private int delayDecrease;
        private bool pauseGame = false;
        private TetrisState tetrisState = new TetrisState(Difficulty.Easy);

        public frmGame()
        {
            InitializeComponent();
            this.Size = new Size(570, 678);
            this.Visible = true;
            imageControls = Setup(tetrisState.Grid);

            pnlNewGame.Location = new Point(0, 0);
            pnlNewGame.BringToFront();

            pnlGameOver.Location = new Point(0, 0);
            pnlGameOver.BringToFront();

            pnlGamePaused.Location = new Point(this.Width / 2 - pnlGamePaused.Width / 2,
                                               this.Height / 2 - pnlGamePaused.Height / 2);
            pnlGamePaused.BringToFront();

            pnlRanking.Location = new Point(0, 0);
            pnlRanking.BringToFront();
        }

        // Efetua o setup do Tetris preenchendo todas as posições do grid com o tile vazio
        public Image[,] Setup(TetrisGrid grid)
        {
            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            Image image = Properties.Resources.img_EmptyBlock;

            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {

                    imageControls[r, c] = image;
                }
            }

            return imageControls;
        }

        // Tarefa de execução do jogo
        private async Task GameLoop()
        {
            pbxGame.Refresh();
            var d = lbxSelectDifficulty.SelectedItem;
            switch (d)
            {
                case Difficulty.Easy:                     
                    maxDelay = 600;
                    minDelay = 200;
                    delayDecrease = 50;
                    break;
                case Difficulty.Meddium:
                    maxDelay = 525;
                    minDelay = 150;
                    delayDecrease = 75;
                    break;
                case Difficulty.Hard:
                    maxDelay = 450;
                    minDelay = 50;
                    delayDecrease = 100;
                    break;
            }
            
            while (!tetrisState.GameOver)
            {
                int delay = Math.Max(minDelay, maxDelay - (tetrisState.Level - 1) * delayDecrease);
                await Task.Delay(delay);

                if (!pauseGame)
                {
                    pnlGamePaused.Visible = false;
                    tetrisState.MoveBlockDown();
                    pbxGame.Refresh();
                }
                else
                {
                    pnlGamePaused.Visible = true;
                }
            }

            pnlGameOver.Visible = true;
            txtFinalScore.Text = $"{tetrisState.Score}";
            var p = new Player();

            try
            {
                p.Id = p.SearchLast();
                p.Score = tetrisState.Score;
                p.EditScore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Mensagem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Desenha o grid na tela. Quando uma peça é encaixada, ela passa a fazer parte do grid
        private void DrawGrid(Graphics g, TetrisGrid grid)
        {
            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {
                    int id = grid[r, c];
                    imageControls[r, c] = tileImages[id];

                    g.DrawImage(imageControls[r, c],
                                c * grid.Width,
                                r * grid.Height,
                                grid.Width, grid.Height);
                }
            }
        }

        // Desenha o bloco atual no grid na sua posição atual
        private void DrawBlock(Graphics g, TetrisGrid grid, Block block)
        {
            foreach (Position p in block.TilePositions())
            {
                imageControls[p.Row, p.Col] = tileImages[block.Id];

                g.DrawImage(imageControls[p.Row, p.Col],
                            p.Col * grid.Height,
                            p.Row * grid.Width,
                            grid.Width, grid.Height);
            }
        }

        private void DrawGhostBlock(Graphics g, TetrisGrid grid, Block block)
        {
            int dropDistance = tetrisState.BlockDropDistance();

            foreach (Position p in block.TilePositions())
            {
                imageControls[p.Row + dropDistance, p.Col] = Properties.Resources.img_GhostTile;

                g.DrawImage(imageControls[p.Row + dropDistance, p.Col],
                            p.Col * grid.Height,
                            (p.Row + dropDistance) * grid.Width,
                            grid.Width, grid.Height);
            }
        }

        // Desenha o próximo bloco que irá aparecer na tela
        private void DrawNextBlock(BlockQueue blockQueue)
        {
            Block next = blockQueue.NextBlock;
            pbxNextBlock.Image = blockImages[next.Id];
            pbxNextBlock.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Chama todos os métodos de desenho
        private void Draw(Graphics g, TetrisState tetrisState)
        {
            DrawGrid(g, tetrisState.Grid);
            DrawGhostBlock(g, tetrisState.Grid, tetrisState.CurrentBlock);
            DrawBlock(g, tetrisState.Grid, tetrisState.CurrentBlock);
            DrawNextBlock(tetrisState.BlockQueue);
            txtScore.Text = $"{tetrisState.Score}";
            txtLines.Text = $"{tetrisState.Lines}";
            txtLevel.Text = $"{tetrisState.Level}";
        }

        // Evento de redesenho do picture box
        // Toda vez que é necessário atualizar o grid e desenhar na tela, é necessário
        // efetuar o método de Refresh() da picture box
        private void pbxGame_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics, tetrisState);
        }

        // Evento de carregamento do formulário
        // Quando o jogo inicializa é solicitado o nome do novo jogador
        private void frmGame_Load(object sender, EventArgs e)
        {
            pnlNewGame.Visible = true;
            //pnlNewGame.BringToFront();
        }

        // Evento de tecla descida
        // Verifica que tipo de ação foi solicitado para o jogo
        // Ao final da execução do comando, força um evento de Refresh() da picture box
        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (tetrisState.GameOver)
            {
                return;
            }

            switch (e.KeyData)
            {
                case Keys.Left when !pauseGame:
                    tetrisState.MoveBlockLeft();
                    break;
                case Keys.Right when !pauseGame:
                    tetrisState.MoveBlockRight();
                    break;
                case Keys.Down when !pauseGame:
                    tetrisState.MoveBlockDown();
                    break;
                case Keys.Up when !pauseGame:
                    tetrisState.RotateBlockCW();
                    break;
                case Keys.P:
                    pauseGame = true;
                    break;
                case Keys.R:
                    pauseGame = false;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    return;
            }

            pbxGame.Refresh();
        }

        // Evento de clique no botão de Play Again
        // Quando o jogo finaliza, o jogador tem a opção de iniciar um novo jogo
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            pnlGameOver.Visible = false;
            pnlNewGame.Visible = true;
        }
  
        // Evento de clique no botão New Game
        // Ao clicar, é gerado uma nova instância do jogo
        // O jogador já é cadastrado no banco de dados com sua pontuação zerada
        // Inicializa a tarefa do jogo
        private async void btnNewGame_Click(object sender, EventArgs e)
        {
            var p = new Player();

            try
            {
                p.Id = p.SearchLast();
            }
            catch (Exception)
            {
                p.Id = 0;
            }
            finally
            {
                p.Id++;
            }

            p.Name = txtNewPlayer.Text;
            p.Score = tetrisState.Score;

            try
            {
                p.AddPlayer();
                tetrisState = new TetrisState((Difficulty)lbxSelectDifficulty.SelectedItem);
                pnlNewGame.Visible = false;
                this.Focus();
                await GameLoop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Mensagem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Evento de clique no botão de Ranking
        // Ao clicar, é feita uma consulta no banco de dados procurando o Top 10
        // jogadores com melhor score em ordem decrescente
        // Com a lista recuperada do banco de dados, somente é feito a escrita em tela na mesma ordem
        private void btnRanking_Click(object sender, EventArgs e)
        {
            pnlGameOver.Visible = false;
            pnlRanking.Visible = true;
            txtRanking.Text = "";

            var p = new Player();
            var listRanking = p.SearchTop10();

            for (int r = 0; r < listRanking.Count; r++)
            {
                txtRanking.AppendText($"{listRanking[r][0]} - ");
                txtRanking.AppendText($"{listRanking[r][1]}\n");
                txtRanking.AppendText("\r\n");
            }
        }

        // Evento de clique no botão Back
        // Ao clicar, retorna para a tela de Game Over
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRanking.Visible = false;
            pnlGameOver.Visible = true;
        }

       
    }
}
