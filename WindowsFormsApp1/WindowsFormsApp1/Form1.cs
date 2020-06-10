using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    enum EstadoActual { seleccionando, rectangulo, elipse, linea,borrando,cambiarcolor }

    public partial class Paint : Form
    {
        List<Figura> figura;
        EstadoActual estado = EstadoActual.cambiarcolor;
        bool dibujando = false;
        int tempx, tempy;
        private bool m;
        private bool b;
        private bool a;
        private bool v;
        private bool w;
        private bool t;

        public Paint()
        {
            InitializeComponent();
            figura = new List<Figura>();

        }
        Figura GetFigura(int X, int Y)
        {
            foreach (Figura f in figura)
            {
                if (f.contenido(X, Y))
                { return f; }
            }

            return null;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            this.Coordenadas.Text = string.Format("X={0}  Y={1}", e.X, e.Y);

          
        
            if (e.Button == MouseButtons.Left && this.estado == EstadoActual.cambiarcolor)
            {

                Figura cambiarblack = null;
                cambiarblack = GetFigura(e.X, e.Y);


                if (cambiarblack != null)
                {
                    
                    
                        if (  m==true )

                        {
                            cambiarblack.color = Color.Red;
                            m = false;
                       

                        }
                        else if ( b==true )
                        {
                         cambiarblack.color = Color.Black;
                         b = false;
                         
                        }
                         else if (a == true)
                            {
                            cambiarblack.color = Color.Blue;
                            a = false;

                            }
                          else if (v == true)
                            {
                              cambiarblack.color = Color.Green;
                               v = false;

                            }
                            else if (w == true)
                             {
                             cambiarblack.color = Color.White;
                              w = false;

                             }
                            else if (t == true)
                            {
                              cambiarblack.color = Color.Transparent;
                              t = false;

                              }





                }
            }
            


            if (e.Button == MouseButtons.Left && this.estado == EstadoActual.seleccionando)
            {
                Figura seleccionada = null;
                seleccionada = GetFigura(e.X, e.Y);


                if (seleccionada != null)
                {
                    
                   

                        MessageBox.Show(seleccionada.color.ToString());
                
                    

                    

                }
            }

                if (this.estado == EstadoActual.borrando)
                {
                    figura.Clear();
                }
        }
        


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figura)

                f.Dibuja(this);

        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (estado == EstadoActual.rectangulo && dibujando == true)
            {



                rectangulo r = new rectangulo(tempx, tempy, e.X - tempx, e.Y - tempy);
                dibujando = false;
                r.Dibuja(this);
                figura.Add(r);


            }
            else if (estado == EstadoActual.elipse && dibujando == true)
            {
                elipse c = new elipse(tempx, tempy, e.X - tempx, e.Y - tempy);
                dibujando = false;
                c.Dibuja(this);
                figura.Add(c);


            }
            else if (estado == EstadoActual.linea && dibujando == true)
            {
                dibujando = false;
                this.label1.Text = string.Format("X={0}  Y={1}", tempx, tempy);
                linea l = new linea(tempx, tempy, e.X, e.Y);
                l.Dibuja(this);
                figura.Add(l);

            }
        }

        private void rectangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.rectangulo;

        }

        private void elipcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.elipse;
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.linea;
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.seleccionando;
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.borrando;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.cambiarcolor;
           b = true;
        }
        public void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.cambiarcolor;
            
            m = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.cambiarcolor;

            a = true;

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.cambiarcolor;

            v = true;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.cambiarcolor;

            w = true;
        }

        private void transparenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.cambiarcolor;

            t = true;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (estado == EstadoActual.rectangulo && dibujando == false)
            {
                dibujando = true;
                tempx = e.X;
                tempy = e.Y;

            }
            else if (estado == EstadoActual.elipse && dibujando == false)
            {
                dibujando = true;
                tempx = e.X;
                tempy = e.Y;



            }
            else if (estado == EstadoActual.linea && dibujando == false)
            {
                dibujando = true;
                tempx = e.X;
                tempy = e.Y;

            }
          
        }
    }
}


