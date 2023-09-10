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

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            SetUp();

            MakeBubbles();
        }

        public void SetUp()
        {
            foreach(string backgroundPath in ImageFactory.Backgrounds)
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

        }

        private void MakeBubbles()
        {

        }
    }
}