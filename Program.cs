using Raylib_cs;

namespace game
{
    class RaymarioSharp
    {
        public static void Main(string[] args)
        {
            Raylib.InitWindow(1280, 720, "RAYMario");
            Raylib.SetWindowPosition(8, 33);
            int posX =10;

            Image bg = Raylib.LoadImage("assets/background.png"),
                    player =Raylib.LoadImage("assets/player.png");
            Texture2D texture = Raylib.LoadTextureFromImage(bg),
                        img = Raylib.LoadTextureFromImage(player);
            
            Raylib.UnloadImage(bg);
            Raylib.UnloadImage(player);

            while (!Raylib.WindowShouldClose()) {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.DrawTexture(texture, 0, 0, Color.White);
                Raylib.DrawTexture(img, posX, 720 - 245, Color.White);
                if (Raylib.IsKeyPressed(KeyboardKey.Right)){
                   posX += 40;   
                }else if (Raylib.IsKeyPressed(KeyboardKey.Left))
                {
                    posX -= 40;
                }
                Raylib.EndDrawing();
                
            }
            Raylib.CloseWindow();
        }

    }
}