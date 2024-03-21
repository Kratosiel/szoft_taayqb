namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám = 0;
        int hossz = 5;
        int almaszámláló = 0;
        Random rnd = new Random();


        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;



            foreach (KígyóElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;

                }
            }
            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }
            if (lépésszám % 20 == 0)
            {
                hossz += 1;
                almaszámláló += 1;
                Alma a = new Alma();
                a.Top = rnd.Next(0, ClientRectangle.Width / Alma.Méret) * Alma.Méret;
                a.Height = rnd.Next(0, ClientRectangle.Height / Alma.Méret) * Alma.Méret;
                Controls.Add(a);


            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_x = -1;
                irány_y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_x = 1;
                irány_y = 0;
            }

        }
    }
}