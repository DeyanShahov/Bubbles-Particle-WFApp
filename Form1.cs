namespace Bubbles_Particle_WFApp
{
    public partial class Form1 : Form
    {
        List<Bubble> bubbleList = new List<Bubble>();
        List<Image> backgroundList = new List<Image>();

        int backgroundNumber = 0;
        Random random = new Random();
        Image background;

        public Form1()
        {
            InitializeComponent();
      
            SetUp();

            MakeBubbles();
        }

        public void SetUp()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            foreach (string backgroundPath in ImageFactory.Backgrounds)
            {
                Image tempBack = Image.FromFile(backgroundPath);
                backgroundList.Add(tempBack);
            }

            background = backgroundList[backgroundNumber];
            this.BackgroundImage = background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void ParticlesTimerEvent(object sender, EventArgs e)
        {
            foreach (Bubble bubble in bubbleList)
            {
                bubble.MoveBubble();
                bubble.posY -= bubble.speedY;
                bubble.posX += bubble.speedX;

                if (bubble.posY < bubble.topLimit)
                {
                    bubble.posY = 700;
                    bubble.posX = random.Next(0, 800);
                }
            }

            this.Invalidate();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (backgroundNumber < backgroundList.Count - 1) backgroundNumber++;
                else backgroundNumber = 0;

                background = backgroundList[backgroundNumber];
                this.BackgroundImage = background;
            }
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            //Canvas.DrawImage(background, 0, 0, 800, 500);

            foreach (Bubble tempBubble in bubbleList)
            {
                Canvas.DrawImage(tempBubble.bubble, tempBubble.posX, tempBubble.posY,
                    tempBubble.width, tempBubble.height);
            }
        }

        private void MakeBubbles()
        {
            for (int i = 0; i < 300; i++)
            {
                Bubble newBubble = new Bubble();
                bubbleList.Add(newBubble);
            }
        }
    }
}