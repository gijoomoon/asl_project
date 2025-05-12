using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

public class FoodItem
{
    private List<Label> Alllbls;
    private PictureBox foodPBX;
    private PictureBox triggerPBX;         // 캐릭터 또는 트리거 영역
    private PictureBox targetPBX;        // 활성화될 이미지 (예: 먹는 그림)
    private Point originalLocation; // 밥 원래 위치
    private Action onFoodEaten;

    private List<PictureBox> otherFoods;
    private Point mouseOffset;
    private bool isDragging = false;
    public FoodItem(PictureBox foodPBX, PictureBox triggerPBX, PictureBox targetPBX, Action onFoodEaten, List<PictureBox> otherFoods, List<Label> Alllbls)
    {
        this.foodPBX = foodPBX;
        this.triggerPBX = triggerPBX;
        this.targetPBX = targetPBX;
        this.otherFoods = otherFoods;
        this.Alllbls = Alllbls;

        originalLocation = foodPBX.Location;//처음 위치 저장

        foodPBX.MouseDown += FoodPBX_MouseDown;
        foodPBX.MouseMove += FoodPBX_MouseMove;
        foodPBX.MouseUp += FoodPBX_MouseUp;
        this.onFoodEaten = onFoodEaten;
    }

    private void FoodPBX_MouseDown(object sender, MouseEventArgs e)
    {
        isDragging = true;
        mouseOffset = new Point(e.X, e.Y);
    }

    private void FoodPBX_MouseMove(object sender, MouseEventArgs e)
    {
        if (isDragging)
        {
            foodPBX.Left += e.X - mouseOffset.X;
            foodPBX.Top += e.Y - mouseOffset.Y;

            if (IsNear(foodPBX, triggerPBX))
            {
                targetPBX.Visible = true;
                triggerPBX.Visible = false;
                foodPBX.Visible = false;

                foreach(var all in Alllbls)
                {
                    all.Visible = false;
                }

                foreach (var other in otherFoods)
                    other.Visible = false;

                // 3초 후 다시 triggerPBX 보이게
                Timer timer = new Timer();
                timer.Interval = 3000; // 3초
                timer.Tick += (s, args) =>
                {
                    triggerPBX.Visible = true;
                    targetPBX.Visible = false;

                    onFoodEaten?.Invoke();
                    foodPBX.Location = originalLocation; // 원래 위치로 복원

                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();


                // 드래그 중단
                isDragging = false;
            }
        }
    }

    private void FoodPBX_MouseUp(object sender, MouseEventArgs e)
    {
        isDragging = false;
    }

    private bool IsNear(Control a, Control b, int distance = 50)
    {
        int dx = a.Left - b.Left;
        int dy = a.Top - b.Top;
        return Math.Sqrt(dx * dx + dy * dy) < distance;
    }
}
