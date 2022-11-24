using System;
using Games.Shared.Util;
using UnityEngine;

namespace Games.KanjiQuiz.UI
{
    public class LineDrawer
    {
        private readonly Action<int, int, Color> setPixelAction;

        public LineDrawer(Action<int, int, Color> setPixelAction)
        {
            this.setPixelAction = setPixelAction;
        }

        public void drawLine_bad(int x1, int y1, int x2, int y2, Color color, int lineWidth)
        {
            var dy = y2 - y1;
            var dx = x2 - x1;

            for (int x = x1; x < x2; x++)
            {
                int y = (int)((float)y1 + dy * (x - x1) / dx);
                for (int w = 0; w < lineWidth; w++)
                {
                    setPixelAction.Invoke(x + w, y, color);
                }
            }
        }

        private void drawPixel(double x, double y, double brightness, Color color)
        {
            var c = color;
            //c.a = (int)brightness.Remap(0.0, 1.0, 0.0, 255.0);
            c.r = (int)(c.r * brightness);
            c.g = (int)(c.g * brightness);
            c.b = (int)(c.b * brightness);
            setPixelAction.Invoke((int)x, (int)y, c);
        }

        public void drawLine_wu(int x0p, int y0p, int x1p, int y1p, Color color, int lineWidth)
        {
            double w = lineWidth;
            if (w < 1)
            {
                w = 1;
            }

            bool steep = Math.Abs(y1p - y0p) > Math.Abs(x1p - x0p);

            double x0 = x0p;
            double y0 = y0p;
            double x1 = x1p;
            double y1 = y1p;
            if (steep)
            {
                x0 = y0p;
                y0 = x0p;
                x1 = y1p;
                y1 = x1p;
            }

            if (x0 > x1)
            {
                x0 = x1;
                y0 = y1;
            }

            double dx = x1 - x0;
            double dy = y1 - y0;
            double gradient;
            if (dx == 0)
            {
                gradient = 1.0;
            }
            else
            {
                gradient = (double)dy / dx;
            }

            // rotate w
            w = w * Math.Sqrt(1 + (gradient * gradient));

            // first endpoint
            double xend = Math.Round(x0);
            double yend = y0 - (w - 1.0) * 0.5 + gradient * (xend - x0);
            double xgap = 1 - (x0 + 0.5 - xend);
            double xpxl1 = xend;
            double ypxl1 = Math.Floor(yend);
            double fpart = yend - Math.Floor(yend);
            double rfpart = 1 - fpart;

            if (steep)
            {
                drawPixel(ypxl1, xpxl1, rfpart * xgap, color);
                for (int i = 0; i < w; i++)
                {
                    drawPixel(ypxl1 + i, xpxl1, 1.0, color);
                }
                drawPixel(ypxl1 + w, xpxl1, fpart * xgap, color);
            }
            else
            {
                drawPixel(xpxl1, ypxl1, rfpart * xgap, color);
                for (int i = 0; i < w; i++)
                {
                    drawPixel(xpxl1, ypxl1 + i, 1.0, color);
                }
                drawPixel(xpxl1, ypxl1 + w, fpart * xgap, color);
            }

            double intery = yend + gradient;

            // second endpoint
            xend = Math.Round(x1);
            yend = y1 - (w - 1.0) * 0.5 + gradient * (xend - x1);
            xgap = 1 - (x1 + 0.5 - xend);
            double xpxl2 = xend;
            double ypxl2 = Math.Floor(yend);
            fpart = yend - Math.Floor(yend);
            rfpart = 1 - fpart;

            if (steep)
            {
                drawPixel(ypxl2, xpxl2, rfpart * xgap, color);
                for (int i = 0; i < w; i++)
                {
                    drawPixel(ypxl2 + i, xpxl2, 1.0, color);
                }
                drawPixel(ypxl2 + w, xpxl2, fpart * xgap, color);
            }
            else
            {
                drawPixel(xpxl2, ypxl2, rfpart * xgap, color);
                for (int i = 0; i < w; i++)
                {
                    drawPixel(xpxl2, ypxl2 + i, 1.0, color);
                }
                drawPixel(xpxl2, ypxl2 + w, fpart * xgap, color);
            }

            // main loop
            if (steep)
            {
                for (int x = (int)xpxl1 + 1; x < xpxl2; x++)
                {
                    fpart = intery - Math.Floor(intery);
                    rfpart = 1 - fpart;
                    double y = Math.Floor(intery);

                    drawPixel(y, x, rfpart, color);
                    for (int i = 0; i < w; i++)
                    {
                        drawPixel(y + i, x, 1.0, color);
                    }
                    drawPixel(y + w, x, fpart, color);

                    intery = intery + gradient;
                }
            }
            else
            {
                for (int x = (int)xpxl1 + 1; x < xpxl2; x++)
                {
                    fpart = intery - Math.Floor(intery);
                    rfpart = 1 - fpart;
                    double y = Math.Floor(intery);

                    drawPixel(x, y, rfpart, color);
                    for (int i = 0; i < w; i++)
                    {
                        drawPixel(x, y + i, 1.0, color);
                    }
                    drawPixel(x, y + w, fpart, color);

                    intery = intery + gradient;
                }
            }
        }
    }

    public class DrawingUtils : MonoBehaviour
    {
        private LineDrawer lineDrawer;
        private CanvasRenderer canvasRenderer;
        private RectTransform rectTransform;
        protected int height;
        protected int width;
        private Texture2D texture;

        // Start is called before the first frame update
        void Start()
        {
            rectTransform = GetComponent<RectTransform>();
            canvasRenderer = GetComponent<CanvasRenderer>();

            lineDrawer = new LineDrawer((x, y, color) => { texture.SetPixel(x, y, color); });
        }

        private void CreateTexture()
        {
            texture = new Texture2D(width, width);
            canvasRenderer.SetTexture(texture);
        }

        protected void DrawLine(int x1, int y1, int x2, int y2, Color color, int lineWidth = 3)
        {
            lineDrawer.drawLine_wu(x1, y1, x2, y2, color, lineWidth);
        }

        protected void Fill(Color color)
        {
            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                {
                    texture.SetPixel(x, y, color);
                }
            }
        }

        protected virtual void Redraw()
        {
            texture.Apply();
        }

        // Update is called once per frame
        void Update()
        {
            var currentHeight = (int)rectTransform.rect.height;
            var currentWidth = (int)rectTransform.rect.width;
            if (currentHeight != height || currentWidth != width)
            {
                height = currentHeight;
                width = currentWidth;
                if (height > 0 && width > 0)
                {
                    CreateTexture();
                    Redraw();
                }
            }
        }
    }

    public class GraphDrawer : DrawingUtils
    {
        protected override void Redraw()
        {
            Fill(Color.black);
            DrawLine(200, 100, width, height, Color.green, lineWidth: 2);
            DrawLine(0, (int)(height / 2.0), width, (int)(height / 2.0), Color.white, lineWidth: 4);
            DrawLine(0, 0, 0, height, Color.white, lineWidth: 4);

            /*
            double prevX = 0.0;
            double prevY = 0.0;
            for (double x = 0; x < width; x+=(width / 50.0))
            {
                double y = Math.Sin((x / width) * Math.PI * 8) * 50 + height;
                if (y > 0)
                {
                    DrawLine((int)prevX, (int)prevY, (int)x, (int)y, Color.red, lineWidth: 4);
                    prevX = x;
                    prevY = y;
                }
            }
            */

            base.Redraw();
        }
    }
}