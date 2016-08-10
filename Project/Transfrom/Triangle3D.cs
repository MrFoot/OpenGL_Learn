using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Transfrom
{
    class Triangle3D
    {
        private Vector4 a, b, c;
        public Vector4 A, B, C;

        public Triangle3D() { }
        public Triangle3D(Vector4 a, Vector4 b, Vector4 c)
        {
            this.A = this.a = new Vector4(a);
            this.B = this.b = new Vector4(b);
            this.C = this.c = new Vector4(c);
        }

        public void Transfrom(Matrix4x4 m)
        {
            this.a = m.Mul(this.A);
            this.b = m.Mul(this.B);
            this.c = m.Mul(this.C);
        }

        public void Draw(Graphics g)
        {
            g.TranslateTransform(300, 300);
            g.DrawLines(new Pen(Color.Red, 2), this.Get2DPointArr());
        }

        private PointF[] Get2DPointArr()
        {
            PointF[] arr = new PointF[4];
            arr[0] = Get2DPointF(this.a);
            arr[1] = Get2DPointF(this.b);
            arr[2] = Get2DPointF(this.c);
            arr[3] = arr[0];

            return arr;
        }

        private PointF Get2DPointF(Vector4 v)
        {
            PointF p = new PointF();
            p.X = (float)(v.x / v.w);
            p.Y = (float)(v.y / v.w);
            return p;
        }
    }
}
