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
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�ssz�m = 0;
        int hossz = 5;
        int almasz�ml�l� = 0;
        Random rnd = new Random();


        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;



            foreach (K�gy�Elem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;

                }
            }
            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }
            if (l�p�ssz�m % 20 == 0)
            {
                hossz += 1;
                almasz�ml�l� += 1;
                Alma a = new Alma();
                a.Top = rnd.Next(0, ClientRectangle.Width / Alma.M�ret) * Alma.M�ret;
                a.Height = rnd.Next(0, ClientRectangle.Height / Alma.M�ret) * Alma.M�ret;
                Controls.Add(a);


            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                ir�ny_x = -1;
                ir�ny_y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                ir�ny_x = 1;
                ir�ny_y = 0;
            }

        }
    }
}