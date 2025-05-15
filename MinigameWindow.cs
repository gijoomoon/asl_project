using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asl_project
{
    public partial class MinigameWindow : Form
    {
        //[DllImport("kernel32.dll")]
        //static extern bool AllocConsole();

        private bool isLoaded = false;

        private Maze maze;
        // wallImage, groundImage, characterImage, destImage의 이미지 크기는 모두 같은 크기여야 한다
        private readonly Image wallImage;
        private readonly Image groundImage;
        private readonly Image destImage;
        private readonly Image characterImage;
        private readonly int mazeSize;

        private int charPosX, charPosY;

        //private PictureBox[,] mazePbGrid;
        private PictureBox character;
        private PictureBox destination;

        public bool MinigameResult { get; private set; }

        public enum MapSize
        {
            Default = 15,
            Hard = 25
        }

        public enum TimeLimit
        {
            // in milliseconds
            Default = 180000,    // 3분
            Hard = 180000        // 3분
        }

        public MinigameWindow(MapSize difficulty)
        {
            InitializeComponent();
            //AllocConsole(); // Creates a console window

            // 성장도에 따른 미로 크기, 시간 제한 설정
            mazeSize = (int)difficulty;
            switch (difficulty)
            {
                case MapSize.Hard:
                    progressBarTime.Maximum = (int)TimeLimit.Hard;
                    progressBarTime.Value = progressBarTime.Maximum;
                    break;
                case MapSize.Default:
                default:
                    progressBarTime.Maximum = (int)TimeLimit.Default;
                    progressBarTime.Value = progressBarTime.Maximum;
                    break;
            }
            progressBarTime.Step = tmr100Millisecond.Interval * -1;

            // 이미지 로드
            wallImage = Properties.Resources.wall;
            groundImage = Properties.Resources.ground;
            destImage = Properties.Resources.destination;
            characterImage = Properties.Resources.character;

            // 미로 생성
            maze = new Maze(mazeSize, mazeSize, (int)DateTime.Now.Ticks & 0x0000FFFF); // 현재 시간을 시드로 설정 

            charPosX = maze.SpawnX;
            charPosY = maze.SpawnY;

            // 창 크기 변경시 화면 다시 그리기
            this.Resize += (s, e) => panelMazeView.Invalidate();

            // 화면 깜박거림 방지
            typeof(Panel)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(panelMazeView, true, null);
            //typeof(System.Windows.Forms.ProgressBar)
            //    .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            //    ?.SetValue(progressBarTime, true, null);

            // 미니게임 결과 초기화
            MinigameResult = false;

            tmr100Millisecond.Start();
        }

        private void MinigameWindow_Load(object sender, EventArgs e)
        {
            isLoaded = true;
        }

        private void panelMazeView_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 화면 사이즈에 따른 타일 크기
            int gridSize = Math.Min(panelMazeView.Width, panelMazeView.Height - progressBarTime.Height) / mazeSize;

            // 수평 중앙 오프셋
            int offsetX = (panelMazeView.Width - gridSize * mazeSize) / 2;

            // 미로 그리기
            for (int row = 0; row < mazeSize; row++)
            {
                for (int col = 0; col < mazeSize; col++)
                {
                    int x = col * gridSize + offsetX;
                    int y = row * gridSize; // + progressBarTime.Height;
                    if (maze.GetMazeTile(col, row) == MazeTileType.Wall)
                        g.DrawImage(wallImage, new Rectangle(x, y, gridSize, gridSize));
                    else
                        g.DrawImage(groundImage, new Rectangle(x, y, gridSize, gridSize));

                }
            }

            // 도착점 그리기
            g.DrawImage(destImage, new Rectangle(maze.DestX * gridSize + offsetX, maze.DestY * gridSize, gridSize, gridSize));

            // 캐릭터 그리기
            g.DrawImage(characterImage, new Rectangle(charPosX * gridSize + offsetX, charPosY * gridSize, gridSize, gridSize));
        }

        private void tmr100Millisecond_Tick(object sender, EventArgs e)
        {
            //if (progressBarTime.Value - tmr100Millisecond.Interval <= 0) this.Close();
            //else progressBarTime.Value -= tmr100Millisecond.Interval;
            progressBarTime.PerformStep();
            if (progressBarTime.Value == 0) this.Close();
        }

        private bool IsAtDest()
        {
            if ((charPosX, charPosY) == (maze.DestX, maze.DestY)) return true;
            else return false;
        }

        private bool IsValidMovement(int offsetX, int offsetY)
        {
            int moveDestX = charPosX + offsetX;
            int moveDestY = charPosY + offsetY;

            Console.WriteLine(maze.GetMazeTile(moveDestX, moveDestY).ToString());

            // check if movement destination is even within bound (unlikely)
            if (moveDestX <= 0 || moveDestX >= maze.Width - 1 || moveDestY <= 0 || moveDestY >= maze.Height - 1) return false;
            // check if movement destination is a wall
            else if (maze.GetMazeTile(moveDestX, moveDestY) == MazeTileType.Wall) return false;
            else return true;
        }

        private void MinigameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            // 화면 사이즈에 따른 타일 크기
            int gridSize = Math.Min(panelMazeView.Width, panelMazeView.Height - progressBarTime.Height) / mazeSize;

            // 수평 중앙 오프셋
            int offsetX = (panelMazeView.Width - gridSize * mazeSize) / 2;

            Rectangle regionToUpdate;

            switch (e.KeyCode)
            {
                case (Keys.Up):
                    if (IsValidMovement(0, -1))
                    {
                        charPosY -= 1;
                        regionToUpdate = new Rectangle(charPosX * gridSize + offsetX, charPosY * gridSize, gridSize, gridSize * 2);
                        panelMazeView.Invalidate(regionToUpdate);
                    }
                    break;
                case (Keys.Down):
                    if (IsValidMovement(0, 1))
                    {
                        charPosY += 1;
                        regionToUpdate = new Rectangle(charPosX * gridSize + offsetX, charPosY * gridSize - gridSize, gridSize, gridSize * 2);
                        panelMazeView.Invalidate(regionToUpdate);
                    }
                    break;
                case (Keys.Left):
                    if (IsValidMovement(-1, 0))
                    {
                        charPosX -= 1;
                        regionToUpdate = new Rectangle(charPosX * gridSize + offsetX, charPosY * gridSize, gridSize * 2, gridSize);
                        panelMazeView.Invalidate(regionToUpdate);
                    }
                    break;
                case (Keys.Right):
                    if (IsValidMovement(1, 0))
                    {
                        charPosX += 1;
                        regionToUpdate = new Rectangle(charPosX * gridSize + offsetX - gridSize, charPosY * gridSize, gridSize * 2, gridSize);
                        panelMazeView.Invalidate(regionToUpdate);
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("Character at   " + charPosX.ToString() + ", " + charPosY.ToString());

            if (IsAtDest())
            {
                MinigameResult = true;
                if (MessageBox.Show("산책을 성공적으로 마쳤습니다!", "산책 성공", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void MinigameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    public enum MazeTileType { Ground, Wall }

    public class Maze
    {
        // 미로 크기
        public int Width { get; private set; }
        public int Height { get; private set; }
        // 미로 생성시 사용되는 시드
        public int Seed { get; private set; }
        // 미로 출발점
        public int SpawnX { get; private set; }
        public int SpawnY { get; private set; }
        // 미로 도착점
        public int DestX { get; private set; }
        public int DestY { get; private set; }
        // 미로 정보
        private MazeTileType[,] maze;

        private static readonly (int dx, int dy)[] Directions = new (int, int)[]
        {
            (0, -2), // 상
            (2, 0),  // 우
            (0, 2),  // 하
            (-2, 0) // 좌
        };

        public Maze(int width, int height, int seed)
        {
            if (width % 2 == 0 || height % 2 == 0)
                throw new ArgumentException("Width and Height must be odd integers.");
            this.Width = width;
            this.Height = height;
            this.Seed = seed;
            maze = new MazeTileType[Width, Height];
            GenerateMaze();
        }

        public MazeTileType[,] GetMazeCopy()
        {
            MazeTileType[,] copy = new MazeTileType[Width, Height];
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    copy[i, j] = maze[i, j];
            return copy;
        }

        public MazeTileType GetMazeTile(int x, int y)
        {
            return maze[x, y];
        }

        private void GenerateMaze()
        {
            // 미로 초기화
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    maze[i, j] = MazeTileType.Wall;

            Random rng = new Random(Seed);
            Stack<((int x, int y) pos, int depth)> stack = new Stack<((int, int), int)>();

            // 무작위 홀수 좌표 타일에서 시작, 그리고 이 지점을 스폰 지점으로 설정
            int startX = SpawnX = DestX = rng.Next(Width / 2) * 2 + 1;
            int startY = SpawnY = DestY = rng.Next(Height / 2) * 2 + 1;
            int maxDepth = 0;

            System.Diagnostics.Debug.WriteLine("Spawn Point is " + SpawnX.ToString() + ", " + SpawnY.ToString());
            maze[startX, startY] = MazeTileType.Ground;
            stack.Push(((startX, startY), 0));

            // DFS backtracking 미로생성 알고리즘
            while (stack.Count > 0)
            {
                var ((x, y), depth) = stack.Peek();
                List<(int nx, int ny, int wallX, int wallY)> neighbors = new List<(int, int, int, int)>();

                foreach (var (dx, dy) in Directions)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx > 0 && nx < Width - 1 && ny > 0 && ny < Height - 1 && maze[nx, ny] == MazeTileType.Wall)
                    {
                        int wallX = x + dx / 2;
                        int wallY = y + dy / 2;
                        neighbors.Add((nx, ny, wallX, wallY));
                    }
                }

                if (neighbors.Count > 0)
                {
                    var (nx, ny, wallX, wallY) = neighbors[rng.Next(neighbors.Count)];
                    maze[wallX, wallY] = MazeTileType.Ground;
                    maze[nx, ny] = MazeTileType.Ground;
                    stack.Push(((nx, ny), depth + 1));

                    // 지금까지 가장 먼 지점을 도착점으로 갱신
                    if (depth + 1 > maxDepth)
                    {
                        maxDepth = depth + 1;
                        DestX = nx;
                        DestY = ny;
                    }
                }
                else
                {
                    stack.Pop();
                }
            }
        }
    }

}
