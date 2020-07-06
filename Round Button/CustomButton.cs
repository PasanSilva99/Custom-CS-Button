using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PointOfSalesSystem;

namespace Round_Button
{
    public partial class CustomButton : UserControl
    {
        private Color _defaultBackColor = Color.White;
        private Color _onHoverBackColor = Color.FromArgb(230, 230, 230);
        private Color _onClickBackColor = Color.FromArgb(200, 200, 200);

        private Color _defaultForeColor = Color.Black;
        private Color _onHoverForeColor = Color.Black;
        private Color _onClickForeColor = Color.Black;

        private int _textSize;
        private string _buttonText = "Button";
        private Font _buttonFont = new Font("Century Gothic", 10);
        private float _corenerRadius = 10;

        bool isHovering = false;
        bool isClicked = false;

        //Lets get the settings
        public Font ButtonFont
        {
            get
            {
                return _buttonFont;
            }
            set
            {
                _buttonFont = value;
                this.Invalidate();
            }
        }
        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
                this.Invalidate();
            }
        }
        public int TextSize
        {
            get
            {
                return _textSize;
            }
            set
            {
                _textSize = value;
                this.Invalidate();
            }
        }
        public Color defaultBackColor
        {
            get
            {
                return _defaultBackColor;
            }
            set
            {
                _defaultBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnHoverBackColor
        {
            get
            {
                return _onHoverBackColor;
            }
            set
            {
                _onHoverBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnClickBackColor
        {
            get
            {
                return _onClickBackColor;
            }
            set
            {
                _onClickBackColor = value;
                this.Invalidate();
            }
        }
        public Color defaultForeColor
        {
            get
            {
                return _defaultForeColor;
            }
            set
            {
                _defaultForeColor = value;
                this.Invalidate();
            }
        }
        public Color OnHoverForeColor
        {
            get
            {
                return _onHoverForeColor;
            }
            set
            {
                _onHoverForeColor = value;
                this.Invalidate();
            }
        }
        public Color OnClickForeColor
        {
            get
            {
                return _onClickForeColor;
            }
            set
            {
                _onClickForeColor = value;
                this.Invalidate();
            }
        }
        public float CornerRadius
        {
            get
            {
                return _corenerRadius;
            }
            set
            {
                _corenerRadius = value;
                this.Invalidate();
            }
        }

        public CustomButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Area for the Button Text
            Rectangle rectangle = new Rectangle(5, 5, this.Width - 15, this.Height - 15);

            //The text 
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            if (isHovering)
            {
                if(isClicked)
                {
                    //Base Round Rectangle (Our Button)
                    graphics.FillRoundedRectangle(
      /*Brush*/         new SolidBrush(_onClickBackColor),
      /*X, y*/          5, 5,
      /*Width, Height*/ this.Width - 15, this.Height - 15,
      /*Corner Radius*/ _corenerRadius);

                    graphics.DrawString(_buttonText, _buttonFont, new SolidBrush(_onClickForeColor), rectangle, stringFormat);
                }
                else // This is for Hovering effect
                {
                    graphics.FillRoundedRectangle(new SolidBrush(_onHoverBackColor), 5, 5, this.Width - 15, this.Height - 15, _corenerRadius);
                    graphics.DrawString(_buttonText, _buttonFont, new SolidBrush(_onHoverForeColor), rectangle, stringFormat);
                }
            }
            else // Not Hovering? Default Colors 
            {
                graphics.FillRoundedRectangle(new SolidBrush(_defaultBackColor), 5, 5, this.Width - 15, this.Height - 15, _corenerRadius);
                graphics.DrawString(_buttonText, _buttonFont, new SolidBrush(_defaultForeColor), rectangle, stringFormat);

            }
            
        }

        private void CustomButton_MouseEnter(object sender, EventArgs e)
        {
            isHovering = true;
            this.Invalidate();
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            isHovering = false;
            this.Invalidate();
        }

        private void CustomButton_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            this.Invalidate();
        }

        private void CustomButton_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            this.Invalidate();
        }
    }
}
