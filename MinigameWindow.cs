using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asl_project
{
    public partial class MinigameWindow : Form
    {
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
            Default = 25,
            Hard = 35
        }

        public MinigameWindow(MapSize difficulty)
        {
            InitializeComponent();

            // 성장도에 따라 미로 크기 설정
            mazeSize = (int)difficulty;

            // 이미지 로드
            wallImage = Properties.Resources.wall;
            groundImage = Properties.Resources.ground;
            destImage = Properties.Resources.destination;
            characterImage = Properties.Resources.character;

            // 미로 생성
            maze = new Maze(mazeSize, mazeSize, 111); // (임시) 현재 시간을 시드로 설정 (int)DateTime.Now.Ticks & 0x0000FFFF

            // 화면 그리기
            this.Resize += (s, e) => panelMazeView.Invalidate();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            // 미로 그리기
            //mazePbGrid = new PictureBox[mazeSize, mazeSize];
            //for (int row = 0; row < mazeSize; row++)
            //{
            //    for (int col = 0; col < mazeSize; col++)
            //    {
            //        mazePbGrid[row, col] = new PictureBox
            //        {
            //            Width = wallImage.Size.Width,
            //            Height = wallImage.Size.Height,
            //            Image = maze.GetMazeTile(row, col) == MazeTileType.Wall ? wallImage : groundImage,
            //            Left = col * wallImage.Size.Width,
            //            Top = row * wallImage.Size.Height + progressBarTime.Size.Height
            //        };
            //        this.Controls.Add(mazePbGrid[row, col]);
            //    }
            //}

            // 캐릭터, 목표지점 그리기
            character = new PictureBox();
            character.Image = characterImage;
            this.Controls.Add(character);
            destination = new PictureBox();
            destination.Image = destImage;
            this.Controls.Add(destination);

            // 미니게임 결과 초기화
            MinigameResult = false;

        }

        //private void ResizeGrid()
        //{
        //    int gridSize = this.ClientSize.Width / mazeSize;
        //    for (int row = 0; row < mazeSize; row++)
        //    {
        //        for (int col = 0; col < mazeSize; col++)
        //        {
        //            PictureBox pb = mazePbGrid[row, col];
        //            pb.Width = pb.Height = gridSize;
        //            pb.Left = col * gridSize;
        //            pb.Top = row * gridSize + progressBarTime.Height;
        //        }
        //    }
        //}

        private void MinigameWindow_Resize(object sender, EventArgs e)
        {

        }

        private void MinigameWindow_Load(object sender, EventArgs e)
        {
            isLoaded = true;
        }

        private void panelMazeView_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 화면 사이즈에 따른 타일 크기
            int gridSize = Math.Min(this.ClientSize.Width, this.ClientSize.Height - progressBarTime.Height) / mazeSize;

            // 수평 중앙 오프셋
            int offsetX = (panelMazeView.Width - gridSize * mazeSize) / 2;

            // 미로 그리기
            for (int row = 0; row < mazeSize; row++)
            {
                for (int col = 0; col < mazeSize; col++)
                {
                    int x = col * gridSize + offsetX;
                    int y = row * gridSize; // + progressBarTime.Height;
                    if (maze.GetMazeTile(row, col) == MazeTileType.Wall)
                        g.DrawImage(wallImage, new Rectangle(x, y, gridSize, gridSize));
                    else
                        g.DrawImage(groundImage, new Rectangle(x, y, gridSize, gridSize));

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
            // TODO - set spawn and dest
            // 임시
            SpawnX = 1; SpawnY = 1;
            DestX = Width - 2; DestY = Height - 2;

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
            Stack<(int x, int y)> stack = new Stack<(int x, int y)>();

            // 무작위 홀수 좌표 타일에서 시작
            int startX = rng.Next(Width / 2) * 2 + 1;
            int startY = rng.Next(Height / 2) * 2 + 1;
            maze[startX, startY] = MazeTileType.Ground;
            stack.Push((startX, startY));

            // DFS backtracking 미로생성 알고리즘
            while (stack.Count > 0)
            {
                var (x, y) = stack.Peek();
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
                    stack.Push((nx, ny));
                }
                else
                {
                    stack.Pop();
                }
            }
        }
    }

}
