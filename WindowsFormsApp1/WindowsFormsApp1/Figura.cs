using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    abstract class Figura
    {
        protected Pen pluma;
        private Color _color;
        public Color color
            
            {
            get => _color;
            set 
             { _color = value;
             brocha.Color = value;
            }

            }
        protected SolidBrush brocha;
        protected int X, Y, ancho, alto;

        public Figura(int x, int y, int ancho, int alto)
        {
            this.X = x;
            this.Y = y;
            this.ancho = ancho;
            this.alto = alto;
            _color = Color.White ;
            pluma = new Pen(Color.Black);
            brocha = new SolidBrush(color);

        }

        abstract public void Dibuja(Form forma);
        public bool contenido(int a, int b)
        {
            return (a >= X && a <= X + ancho) && (b >= Y && b <= Y + alto);

        }
    }
    class rectangulo:Figura
    {


        public rectangulo(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
        {
           
            
        }
        class Pluma
        {
           // pluma = new Pen(Color.Black);
        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();
            //pen, brush ,color
           
            graphics.FillRectangle(brocha, X, Y, ancho, alto);
            graphics.DrawRectangle(pluma, X, Y, ancho, alto);


        }




    }
    class elipse:Figura
    {
        public elipse(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
        {


        }
        class Pluma
        {
            // pluma = new Pen(Color.Black);
        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();
            //pen, brush ,color

            graphics.FillEllipse(brocha, X, Y, ancho, alto);
            graphics.DrawEllipse(pluma, X, Y, ancho, alto);


        }

    }
    class linea:Figura
    {
        public linea(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
        {


        }
        class Pluma
        {
            // pluma = new Pen(Color.Black);
        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();
            //pen, brush ,color

            graphics.DrawLine(pluma, X, Y, ancho, alto);

        }

    }
}
