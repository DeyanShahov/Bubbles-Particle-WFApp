namespace Bubbles_Particle_WFApp
{
    internal class Bubble
    {
        public int height;
        public int width;
        public int posX;
        public int posY;
        public int[] sizes = { 10, 20, 30, 40, 50, 60 };
        public int speedX = 1;
        public int speedY;
        public int topLimit;
        public int moveLimit;

        public Image bubble;
        Random random = new Random();

        public Bubble()
        {
            moveLimit = random.Next(50, 200);
            int i = random.Next(0, sizes.Length);
            bubble = ImageFactory.Image;

            height = sizes[i];
            width = sizes[i];

            topLimit = random.Next(10, 100);
            posX = random.Next(-10, 800);
            posY = random.Next(600, 1200);

            speedY = random.Next(1, 5);
        }

        public void MoveBubble()
        {
            moveLimit--;

            if (moveLimit < 1)
            {
                speedX = -speedX;
                moveLimit = random.Next(50, 200);
            }
        }
    }
}
