using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {

        private Rectangle[] coloane;
        private matrice_clasa tabla_joc;
        private int tura_jucator;

        public Form1()
        {
            InitializeComponent();
            this.coloane = new Rectangle[7];
            this.tabla_joc = new matrice_clasa();
            tura_jucator = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, 24, 24, 340, 300);
            for (int i=0; i<6; ++i)
            {
                for (int j=0; j<7; ++j)
                {
                    if (i == 0)
                        this.coloane[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
                    tabla_joc.desenare_cerc(i, j, e.Graphics, 0);
                  //  umplere_cerc(i, j, e.Graphics, 0);
                }
            }
        }

        private void umplere_cerc(int i, int j, Graphics e, int culoare)
        {
           
            e.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
        }

        private int cautare_linie(int j)
        {
            int last = -1;
            for (int i=0; i<6; ++i)
            {
                if (tabla_joc.getMat(i,j)==0)
                {
                    last = i;
                }
            }
            return last;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(0);
            int coloana = 0;
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(1);
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                int coloana = 1;
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(2);
            int coloana = 2;
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
            }

        private void btn4_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(3);
            int coloana = 3;
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(4);
            int coloana = 4;
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(5);
            int coloana = 5;
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int linie_disponibila = cautare_linie(6);
            int coloana = 6;
            if (linie_disponibila == -1)
                MessageBox.Show("Linia este completa. Incearca pe alta linie");
            else
            {
                if (tura_jucator % 2 == 0)
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 1);
                else
                    tabla_joc.desenare_cerc(linie_disponibila, coloana, this.CreateGraphics(), 2);
                tura_jucator++;
                if (tura_jucator % 2 == 0)
                    turn.Text = "Tura jucatorului 1";
                else
                    turn.Text = "Tura jucatorului 2";
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            tabla_joc.reset_game();
            tura_jucator = 0;
            turn.Text = "Tura jucatorului 1";
            for (int i=0; i<6; ++i)
            {
                for (int j=0; j<7; ++j)
                {
                    tabla_joc.desenare_cerc(i, j, this.CreateGraphics(), 0);
                }
            }
        }
    }

    public class matrice_clasa
    {
        private int[,] mat = new int[6, 7];

        public int getMat(int i, int j)
        {
            return mat[i, j];
        }

        public void setMat(int i, int j, int val)
        {
            mat[i, j] = val;
        }

        public matrice_clasa()
        {
            for (int i=0; i<6; ++i)
            {
                for (int j = 0; j < 7; ++j)
                    mat[i,j] = 0;
            }
        }

        bool verificare_linie(int l, int c, int val)
        {
            int nr = 0;
            int auxc = c;
            while(auxc<7 && mat[l,auxc]==val)
            {
                auxc++;
                nr++;
            }
            auxc = c - 1;
            while(auxc>=0 && mat[l,auxc]==val)
            {
                auxc--;
                nr++;
            }
            if (nr >= 4)
                return true;
            return false;
        }

        bool verificare_coloana(int l, int c, int val)
        {
            int nr = 0;
            int auxl = l;
            while(auxl<6 && mat[auxl,c]==val)
            {
                auxl++;
                nr++;
            }
            auxl = l - 1;
            while(auxl>=0 && mat[auxl,c]==val)
            {
                auxl--;
                nr++;
            }
            if (nr >= 4)
                return true;
            return false;
        }

        public void reset_game()
        {
            for(int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 7; ++j)
                    mat[i, j] = 0;
            }
        }
        private bool verificare4(int l, int c, int val)
        {
            return verificare_linie(l,c, val) || verificare_coloana(l,c, val);
        }

        public void desenare_cerc(int i, int j, Graphics e, int culoare)
        {
            if (culoare == 0)
            {
                e.FillEllipse(Brushes.White, 32 + 48*j, 32 + 48*i, 32, 32);
           
            }
            else if (culoare==1)
            {
                e.FillEllipse(Brushes.Yellow, 32 + 48 * j, 32 + 48 * i, 32, 32);
                this.mat[i, j] = 1;
                if(verificare4(i,j,1))
                {
                    MessageBox.Show("Jucatorul 1 a castigat");
                }
            }
            else if (culoare==2)
            {
                e.FillEllipse(Brushes.Red, 32 + 48 * j, 32 + 48 * i, 32, 32);
                this.mat[i, j] = 2;
                if (verificare4(i,j,2))
                {
                    MessageBox.Show("Jucatorul 2 a castigat");
                }
               
            }
        }
    }
}
