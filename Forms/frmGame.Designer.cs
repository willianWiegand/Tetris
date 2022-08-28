
namespace Tetris.Forms {
  partial class frmGame {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.pbxGame = new System.Windows.Forms.PictureBox();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.btnRanking = new System.Windows.Forms.Button();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.txtFinalScore = new System.Windows.Forms.TextBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pbxNextBlock = new System.Windows.Forms.PictureBox();
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.lblRotateKey = new System.Windows.Forms.Label();
            this.lblRightKey = new System.Windows.Forms.Label();
            this.lblLeftKey = new System.Windows.Forms.Label();
            this.lblDownKey = new System.Windows.Forms.Label();
            this.lblPauseKey = new System.Windows.Forms.Label();
            this.lblResumeKey = new System.Windows.Forms.Label();
            this.lblExitKey = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblMoveDown = new System.Windows.Forms.Label();
            this.lblMoveLeft = new System.Windows.Forms.Label();
            this.lblMoveRight = new System.Windows.Forms.Label();
            this.lblRotate = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.txtLines = new System.Windows.Forms.TextBox();
            this.pnlGamePaused = new System.Windows.Forms.Panel();
            this.lblRtoResume = new System.Windows.Forms.Label();
            this.lblGamePaused = new System.Windows.Forms.Label();
            this.pnlNewGame = new System.Windows.Forms.Panel();
            this.txtNewPlayer = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblNewPlayer = new System.Windows.Forms.Label();
            this.pnlRanking = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.lblRanking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).BeginInit();
            this.pnlGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextBlock)).BeginInit();
            this.pnlCommands.SuspendLayout();
            this.pnlGamePaused.SuspendLayout();
            this.pnlNewGame.SuspendLayout();
            this.pnlRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(298, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(144, 37);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "SCORE:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(298, 46);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(132, 37);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "LEVEL:";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(298, 122);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(117, 37);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "NEXT:";
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(448, 9);
            this.txtScore.MaxLength = 99999;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 37);
            this.txtScore.TabIndex = 3;
            this.txtScore.TabStop = false;
            this.txtScore.Text = "00000";
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Enabled = false;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(448, 46);
            this.txtLevel.MaxLength = 99;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 37);
            this.txtLevel.TabIndex = 4;
            this.txtLevel.TabStop = false;
            this.txtLevel.Text = "00";
            // 
            // pbxGame
            // 
            this.pbxGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxGame.Location = new System.Drawing.Point(12, 11);
            this.pbxGame.Name = "pbxGame";
            this.pbxGame.Size = new System.Drawing.Size(286, 622);
            this.pbxGame.TabIndex = 5;
            this.pbxGame.TabStop = false;
            this.pbxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxGame_Paint);
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.BackColor = System.Drawing.Color.Black;
            this.pnlGameOver.Controls.Add(this.btnRanking);
            this.pnlGameOver.Controls.Add(this.pnlNewGame);
            this.pnlGameOver.Controls.Add(this.lblFinalScore);
            this.pnlGameOver.Controls.Add(this.btnPlayAgain);
            this.pnlGameOver.Controls.Add(this.txtFinalScore);
            this.pnlGameOver.Controls.Add(this.lblGameOver);
            this.pnlGameOver.Location = new System.Drawing.Point(600, 0);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(554, 639);
            this.pnlGameOver.TabIndex = 6;
            this.pnlGameOver.Visible = false;
            // 
            // btnRanking
            // 
            this.btnRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRanking.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRanking.FlatAppearance.BorderSize = 0;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRanking.Location = new System.Drawing.Point(154, 303);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRanking.Size = new System.Drawing.Size(246, 50);
            this.btnRanking.TabIndex = 5;
            this.btnRanking.Text = "RANKING";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFinalScore.Location = new System.Drawing.Point(170, 189);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(125, 31);
            this.lblFinalScore.TabIndex = 2;
            this.lblFinalScore.Text = "SCORE:";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayAgain.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlayAgain.Location = new System.Drawing.Point(154, 245);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(246, 50);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // txtFinalScore
            // 
            this.txtFinalScore.BackColor = System.Drawing.Color.Black;
            this.txtFinalScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalScore.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFinalScore.Location = new System.Drawing.Point(300, 189);
            this.txtFinalScore.Name = "txtFinalScore";
            this.txtFinalScore.Size = new System.Drawing.Size(86, 31);
            this.txtFinalScore.TabIndex = 3;
            this.txtFinalScore.Text = "00000";
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGameOver.Location = new System.Drawing.Point(151, 124);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(253, 42);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxNextBlock
            // 
            this.pbxNextBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxNextBlock.Location = new System.Drawing.Point(305, 162);
            this.pbxNextBlock.Name = "pbxNextBlock";
            this.pbxNextBlock.Size = new System.Drawing.Size(120, 120);
            this.pbxNextBlock.TabIndex = 7;
            this.pbxNextBlock.TabStop = false;
            // 
            // pnlCommands
            // 
            this.pnlCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCommands.Controls.Add(this.lblRotateKey);
            this.pnlCommands.Controls.Add(this.lblRightKey);
            this.pnlCommands.Controls.Add(this.lblLeftKey);
            this.pnlCommands.Controls.Add(this.lblDownKey);
            this.pnlCommands.Controls.Add(this.lblPauseKey);
            this.pnlCommands.Controls.Add(this.lblResumeKey);
            this.pnlCommands.Controls.Add(this.lblExitKey);
            this.pnlCommands.Controls.Add(this.lblExit);
            this.pnlCommands.Controls.Add(this.lblResume);
            this.pnlCommands.Controls.Add(this.lblPause);
            this.pnlCommands.Controls.Add(this.lblMoveDown);
            this.pnlCommands.Controls.Add(this.lblMoveLeft);
            this.pnlCommands.Controls.Add(this.lblMoveRight);
            this.pnlCommands.Controls.Add(this.lblRotate);
            this.pnlCommands.Location = new System.Drawing.Point(305, 291);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(220, 186);
            this.pnlCommands.TabIndex = 8;
            // 
            // lblRotateKey
            // 
            this.lblRotateKey.AutoSize = true;
            this.lblRotateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotateKey.Location = new System.Drawing.Point(130, 4);
            this.lblRotateKey.Name = "lblRotateKey";
            this.lblRotateKey.Size = new System.Drawing.Size(60, 20);
            this.lblRotateKey.TabIndex = 13;
            this.lblRotateKey.Text = "Up Key";
            this.lblRotateKey.UseMnemonic = false;
            // 
            // lblRightKey
            // 
            this.lblRightKey.AutoSize = true;
            this.lblRightKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightKey.Location = new System.Drawing.Point(130, 29);
            this.lblRightKey.Name = "lblRightKey";
            this.lblRightKey.Size = new System.Drawing.Size(77, 20);
            this.lblRightKey.TabIndex = 12;
            this.lblRightKey.Text = "Right Key";
            this.lblRightKey.UseMnemonic = false;
            // 
            // lblLeftKey
            // 
            this.lblLeftKey.AutoSize = true;
            this.lblLeftKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftKey.Location = new System.Drawing.Point(130, 54);
            this.lblLeftKey.Name = "lblLeftKey";
            this.lblLeftKey.Size = new System.Drawing.Size(67, 20);
            this.lblLeftKey.TabIndex = 11;
            this.lblLeftKey.Text = "Left Key";
            this.lblLeftKey.UseMnemonic = false;
            // 
            // lblDownKey
            // 
            this.lblDownKey.AutoSize = true;
            this.lblDownKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownKey.Location = new System.Drawing.Point(130, 80);
            this.lblDownKey.Name = "lblDownKey";
            this.lblDownKey.Size = new System.Drawing.Size(80, 20);
            this.lblDownKey.TabIndex = 10;
            this.lblDownKey.Text = "Down Key";
            this.lblDownKey.UseMnemonic = false;
            // 
            // lblPauseKey
            // 
            this.lblPauseKey.AutoSize = true;
            this.lblPauseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseKey.Location = new System.Drawing.Point(130, 102);
            this.lblPauseKey.Name = "lblPauseKey";
            this.lblPauseKey.Size = new System.Drawing.Size(49, 20);
            this.lblPauseKey.TabIndex = 9;
            this.lblPauseKey.Text = "P Key";
            this.lblPauseKey.UseMnemonic = false;
            // 
            // lblResumeKey
            // 
            this.lblResumeKey.AutoSize = true;
            this.lblResumeKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumeKey.Location = new System.Drawing.Point(130, 127);
            this.lblResumeKey.Name = "lblResumeKey";
            this.lblResumeKey.Size = new System.Drawing.Size(51, 20);
            this.lblResumeKey.TabIndex = 8;
            this.lblResumeKey.Text = "R Key";
            this.lblResumeKey.UseMnemonic = false;
            // 
            // lblExitKey
            // 
            this.lblExitKey.AutoSize = true;
            this.lblExitKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitKey.Location = new System.Drawing.Point(130, 151);
            this.lblExitKey.Name = "lblExitKey";
            this.lblExitKey.Size = new System.Drawing.Size(66, 20);
            this.lblExitKey.TabIndex = 7;
            this.lblExitKey.Text = "Esc Key";
            this.lblExitKey.UseMnemonic = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(4, 151);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(87, 20);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "Exit Game:";
            this.lblExit.UseMnemonic = false;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(4, 127);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(121, 20);
            this.lblResume.TabIndex = 5;
            this.lblResume.Text = "Resume Game:";
            this.lblResume.UseMnemonic = false;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(4, 102);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(106, 20);
            this.lblPause.TabIndex = 4;
            this.lblPause.Text = "Pause Game:";
            this.lblPause.UseMnemonic = false;
            // 
            // lblMoveDown
            // 
            this.lblMoveDown.AutoSize = true;
            this.lblMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveDown.Location = new System.Drawing.Point(4, 80);
            this.lblMoveDown.Name = "lblMoveDown";
            this.lblMoveDown.Size = new System.Drawing.Size(90, 20);
            this.lblMoveDown.TabIndex = 3;
            this.lblMoveDown.Text = "Down Fast:";
            this.lblMoveDown.UseMnemonic = false;
            // 
            // lblMoveLeft
            // 
            this.lblMoveLeft.AutoSize = true;
            this.lblMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveLeft.Location = new System.Drawing.Point(4, 54);
            this.lblMoveLeft.Name = "lblMoveLeft";
            this.lblMoveLeft.Size = new System.Drawing.Size(83, 20);
            this.lblMoveLeft.TabIndex = 2;
            this.lblMoveLeft.Text = "Move Left:";
            this.lblMoveLeft.UseMnemonic = false;
            // 
            // lblMoveRight
            // 
            this.lblMoveRight.AutoSize = true;
            this.lblMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveRight.Location = new System.Drawing.Point(4, 29);
            this.lblMoveRight.Name = "lblMoveRight";
            this.lblMoveRight.Size = new System.Drawing.Size(93, 20);
            this.lblMoveRight.TabIndex = 1;
            this.lblMoveRight.Text = "Move Right:";
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotate.Location = new System.Drawing.Point(4, 4);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(62, 20);
            this.lblRotate.TabIndex = 0;
            this.lblRotate.Text = "Rotate:";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLines.Location = new System.Drawing.Point(298, 83);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(124, 37);
            this.lblLines.TabIndex = 9;
            this.lblLines.Text = "LINES:";
            // 
            // txtLines
            // 
            this.txtLines.BackColor = System.Drawing.SystemColors.Control;
            this.txtLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLines.Enabled = false;
            this.txtLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLines.Location = new System.Drawing.Point(448, 83);
            this.txtLines.MaxLength = 999;
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(100, 37);
            this.txtLines.TabIndex = 10;
            this.txtLines.TabStop = false;
            this.txtLines.Text = "000";
            // 
            // pnlGamePaused
            // 
            this.pnlGamePaused.BackColor = System.Drawing.Color.Black;
            this.pnlGamePaused.Controls.Add(this.lblRtoResume);
            this.pnlGamePaused.Controls.Add(this.lblGamePaused);
            this.pnlGamePaused.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlGamePaused.Location = new System.Drawing.Point(717, 667);
            this.pnlGamePaused.Name = "pnlGamePaused";
            this.pnlGamePaused.Size = new System.Drawing.Size(320, 180);
            this.pnlGamePaused.TabIndex = 7;
            this.pnlGamePaused.Visible = false;
            // 
            // lblRtoResume
            // 
            this.lblRtoResume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRtoResume.AutoSize = true;
            this.lblRtoResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtoResume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRtoResume.Location = new System.Drawing.Point(30, 102);
            this.lblRtoResume.Name = "lblRtoResume";
            this.lblRtoResume.Size = new System.Drawing.Size(266, 31);
            this.lblRtoResume.TabIndex = 1;
            this.lblRtoResume.Text = "Press R to Resume";
            this.lblRtoResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamePaused
            // 
            this.lblGamePaused.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGamePaused.AutoSize = true;
            this.lblGamePaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePaused.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGamePaused.Location = new System.Drawing.Point(12, 44);
            this.lblGamePaused.Name = "lblGamePaused";
            this.lblGamePaused.Size = new System.Drawing.Size(303, 42);
            this.lblGamePaused.TabIndex = 0;
            this.lblGamePaused.Text = "GAME PAUSED";
            this.lblGamePaused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNewGame
            // 
            this.pnlNewGame.BackColor = System.Drawing.Color.Black;
            this.pnlNewGame.Controls.Add(this.txtNewPlayer);
            this.pnlNewGame.Controls.Add(this.btnNewGame);
            this.pnlNewGame.Controls.Add(this.lblNewPlayer);
            this.pnlNewGame.Location = new System.Drawing.Point(444, 25);
            this.pnlNewGame.Name = "pnlNewGame";
            this.pnlNewGame.Size = new System.Drawing.Size(554, 639);
            this.pnlNewGame.TabIndex = 7;
            // 
            // txtNewPlayer
            // 
            this.txtNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPlayer.Location = new System.Drawing.Point(154, 182);
            this.txtNewPlayer.Name = "txtNewPlayer";
            this.txtNewPlayer.Size = new System.Drawing.Size(246, 38);
            this.txtNewPlayer.TabIndex = 4;
            this.txtNewPlayer.Text = "Name";
            this.txtNewPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGame.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.Location = new System.Drawing.Point(154, 245);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(246, 50);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblNewPlayer
            // 
            this.lblNewPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPlayer.AutoSize = true;
            this.lblNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNewPlayer.Location = new System.Drawing.Point(188, 124);
            this.lblNewPlayer.Name = "lblNewPlayer";
            this.lblNewPlayer.Size = new System.Drawing.Size(172, 42);
            this.lblNewPlayer.TabIndex = 0;
            this.lblNewPlayer.Text = "PLAYER";
            this.lblNewPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRanking
            // 
            this.pnlRanking.BackColor = System.Drawing.Color.Black;
            this.pnlRanking.Controls.Add(this.btnBack);
            this.pnlRanking.Controls.Add(this.txtRanking);
            this.pnlRanking.Controls.Add(this.lblRanking);
            this.pnlRanking.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlRanking.Location = new System.Drawing.Point(1719, 0);
            this.pnlRanking.Name = "pnlRanking";
            this.pnlRanking.Size = new System.Drawing.Size(554, 639);
            this.pnlRanking.TabIndex = 8;
            this.pnlRanking.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(154, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack.Size = new System.Drawing.Size(246, 50);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRanking
            // 
            this.txtRanking.BackColor = System.Drawing.Color.Black;
            this.txtRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanking.Enabled = false;
            this.txtRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanking.ForeColor = System.Drawing.Color.White;
            this.txtRanking.Location = new System.Drawing.Point(152, 57);
            this.txtRanking.Multiline = true;
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.ReadOnly = true;
            this.txtRanking.Size = new System.Drawing.Size(250, 477);
            this.txtRanking.TabIndex = 5;
            this.txtRanking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRanking
            // 
            this.lblRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRanking.Location = new System.Drawing.Point(180, 11);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(194, 42);
            this.lblRanking.TabIndex = 0;
            this.lblRanking.Text = "RANKING";
            this.lblRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlRanking);
            this.Controls.Add(this.pnlGamePaused);
            this.Controls.Add(this.txtLines);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.pnlCommands);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.pbxGame);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbxNextBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TETRIS";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGame)).EndInit();
            this.pnlGameOver.ResumeLayout(false);
            this.pnlGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextBlock)).EndInit();
            this.pnlCommands.ResumeLayout(false);
            this.pnlCommands.PerformLayout();
            this.pnlGamePaused.ResumeLayout(false);
            this.pnlGamePaused.PerformLayout();
            this.pnlNewGame.ResumeLayout(false);
            this.pnlNewGame.PerformLayout();
            this.pnlRanking.ResumeLayout(false);
            this.pnlRanking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label lblNext;
    private System.Windows.Forms.TextBox txtScore;
    private System.Windows.Forms.TextBox txtLevel;
    private System.Windows.Forms.PictureBox pbxGame;
    private System.Windows.Forms.Panel pnlGameOver;
    private System.Windows.Forms.Button btnPlayAgain;
    private System.Windows.Forms.Label lblFinalScore;
    private System.Windows.Forms.TextBox txtFinalScore;
    private System.Windows.Forms.Label lblGameOver;
    private System.Windows.Forms.PictureBox pbxNextBlock;
    private System.Windows.Forms.Panel pnlCommands;
    private System.Windows.Forms.Label lblMoveDown;
    private System.Windows.Forms.Label lblMoveLeft;
    private System.Windows.Forms.Label lblMoveRight;
    private System.Windows.Forms.Label lblRotate;
    private System.Windows.Forms.Label lblLines;
    private System.Windows.Forms.TextBox txtLines;
    private System.Windows.Forms.Label lblPauseKey;
    private System.Windows.Forms.Label lblResumeKey;
    private System.Windows.Forms.Label lblExitKey;
    private System.Windows.Forms.Label lblExit;
    private System.Windows.Forms.Label lblResume;
    private System.Windows.Forms.Label lblPause;
    private System.Windows.Forms.Label lblRotateKey;
    private System.Windows.Forms.Label lblRightKey;
    private System.Windows.Forms.Label lblLeftKey;
    private System.Windows.Forms.Label lblDownKey;
    private System.Windows.Forms.Panel pnlGamePaused;
    private System.Windows.Forms.Label lblRtoResume;
    private System.Windows.Forms.Label lblGamePaused;
    private System.Windows.Forms.Panel pnlNewGame;
    private System.Windows.Forms.TextBox txtNewPlayer;
    private System.Windows.Forms.Button btnNewGame;
    private System.Windows.Forms.Label lblNewPlayer;
    private System.Windows.Forms.Panel pnlRanking;
    private System.Windows.Forms.Label lblRanking;
    private System.Windows.Forms.Button btnRanking;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.TextBox txtRanking;
  }
}

