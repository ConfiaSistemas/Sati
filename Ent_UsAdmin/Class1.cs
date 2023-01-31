using System;
using System.ComponentModel;
using System.Drawing;
#region  Imports 

using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;

#endregion

// |------DO-NOT-REMOVE------|
// 
// Creator: HazelDev
// Site   : HazelDev.com
// Created: 12.Sep.2014
// Changed: 26.Sep.2014
// Version: 1.0.0
// 
// |------DO-NOT-REMOVE------|

namespace ConfiaAdmin.MonoFlat
{

    #region  RoundRectangle 

    static class RoundRectangle
    {
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            var P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90f);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90f);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0f, 90f);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90f, 90f);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }
    }

    #endregion

    #region  ThemeContainer 

    class MonoFlat_ThemeContainer : ContainerControl
    {

        #region  Enums 

        public enum MouseState : byte
        {
            None = 0,
            Over = 1,
            Down = 2,
            Block = 3
        }

        #endregion
        #region  Variables 

        private Rectangle HeaderRect;
        protected MouseState State;
        private int MoveHeight;
        private Point MouseP = new Point(0, 0);
        private bool Cap = false;
        private bool HasShown;

        #endregion
        #region  Properties 

        private bool _Sizable = true;
        public bool Sizable
        {
            get
            {
                return _Sizable;
            }
            set
            {
                _Sizable = value;
            }
        }

        private bool _SmartBounds = true;
        public bool SmartBounds
        {
            get
            {
                return _SmartBounds;
            }
            set
            {
                _SmartBounds = value;
            }
        }

        private bool _RoundCorners = true;
        public bool RoundCorners
        {
            get
            {
                return _RoundCorners;
            }
            set
            {
                _RoundCorners = value;
                Invalidate();
            }
        }

        private bool _IsParentForm;
        protected bool IsParentForm
        {
            get
            {
                return _IsParentForm;
            }
        }

        protected bool IsParentMdi
        {
            get
            {
                if (Parent is null)
                    return false;
                return Parent.Parent != null;
            }
        }

        private bool _ControlMode;
        protected bool ControlMode
        {
            get
            {
                return _ControlMode;
            }
            set
            {
                _ControlMode = value;
                Invalidate();
            }
        }

        private FormStartPosition _StartPosition;
        public FormStartPosition StartPosition
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.StartPosition;
                else
                    return _StartPosition;
            }
            set
            {
                _StartPosition = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.StartPosition = value;
                }
            }
        }

        #endregion
        #region  EventArgs 

        protected sealed override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (Parent is null)
                return;
            _IsParentForm = Parent is Form;

            if (!_ControlMode)
            {
                InitializeMessages();

                if (_IsParentForm)
                {
                    ParentForm.FormBorderStyle = FormBorderStyle.None;
                    ParentForm.TransparencyKey = Color.Fuchsia;

                    if (!DesignMode)
                    {
                        ParentForm.Shown += FormShown;
                    }
                }
                Parent.BackColor = BackColor;
                // Parent.MinimumSize = New Size(261, 65)
            }
        }

        protected sealed override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (!_ControlMode)
                HeaderRect = new Rectangle(0, 0, Width - 14, MoveHeight - 7);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
            if (e.Button == MouseButtons.Left)
                SetState(MouseState.Down);
            if (!(_IsParentForm && ParentForm.WindowState == FormWindowState.Maximized || _ControlMode))
            {
                if (HeaderRect.Contains(e.Location))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[0]);
                }
                else if (_Sizable && !(Previous == 0))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[Previous]);
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Cap = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (!(_IsParentForm && ParentForm.WindowState == FormWindowState.Maximized))
            {
                if (_Sizable && !_ControlMode)
                    InvalidateMouse();
            }
            if (Cap)
            {
                Parent.Location = MousePosition - (Size)MouseP;
            }
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            ParentForm.Text = Text;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        private void FormShown(object sender, EventArgs e)
        {
            if (_ControlMode || HasShown)
                return;

            if (_StartPosition == FormStartPosition.CenterParent || _StartPosition == FormStartPosition.CenterScreen)
            {
                var SB = Screen.PrimaryScreen.Bounds;
                var CB = ParentForm.Bounds;
                ParentForm.Location = new Point(SB.Width / 2 - CB.Width / 2, SB.Height / 2 - CB.Width / 2);
            }
            HasShown = true;
        }

        #endregion
        #region  Mouse & Size 

        private void SetState(MouseState current)
        {
            State = current;
            Invalidate();
        }

        private Point GetIndexPoint;
        private bool B1x, B2x, B3, B4;
        private int GetIndex()
        {
            GetIndexPoint = PointToClient(MousePosition);
            B1x = GetIndexPoint.X < 7;
            B2x = GetIndexPoint.X > Width - 7;
            B3 = GetIndexPoint.Y < 7;
            B4 = GetIndexPoint.Y > Height - 7;

            if (B1x && B3)
                return 4;
            if (B1x && B4)
                return 7;
            if (B2x && B3)
                return 5;
            if (B2x && B4)
                return 8;
            if (B1x)
                return 1;
            if (B2x)
                return 2;
            if (B3)
                return 3;
            if (B4)
                return 6;
            return 0;
        }

        private int Current, Previous;
        private void InvalidateMouse()
        {
            Current = GetIndex();
            if (Current == Previous)
                return;

            Previous = Current;
            switch (Previous)
            {
                case 0:
                    {
                        Cursor = Cursors.Default;
                        break;
                    }
                case 6:
                    {
                        Cursor = Cursors.SizeNS;
                        break;
                    }
                case 8:
                    {
                        Cursor = Cursors.SizeNWSE;
                        break;
                    }
                case 7:
                    {
                        Cursor = Cursors.SizeNESW;
                        break;
                    }
            }
        }

        private Message[] Messages = new Message[9];
        private void InitializeMessages()
        {
            Messages[0] = Message.Create(Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
            for (int I = 1; I <= 8; I++)
                Messages[I] = Message.Create(Parent.Handle, 161, new IntPtr(I + 9), IntPtr.Zero);
        }

        private void CorrectBounds(Rectangle bounds)
        {
            if (Parent.Width > bounds.Width)
                Parent.Width = bounds.Width;
            if (Parent.Height > bounds.Height)
                Parent.Height = bounds.Height;

            int X = Parent.Location.X;
            int Y = Parent.Location.Y;

            if (X < bounds.X)
                X = bounds.X;
            if (Y < bounds.Y)
                Y = bounds.Y;

            int Width = bounds.X + bounds.Width;
            int Height = bounds.Y + bounds.Height;

            if (X + Parent.Width > Width)
                X = Width - Parent.Width;
            if (Y + Parent.Height > Height)
                Y = Height - Parent.Height;

            Parent.Location = new Point(X, Y);
        }

        private bool WM_LMBUTTONDOWN;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (WM_LMBUTTONDOWN && m.Msg == 513)
            {
                WM_LMBUTTONDOWN = false;

                SetState(MouseState.Over);
                if (!_SmartBounds)
                    return;

                if (IsParentMdi)
                {
                    CorrectBounds(new Rectangle(Point.Empty, Parent.Parent.Size));
                }
                else
                {
                    CorrectBounds(Screen.FromControl(Parent).WorkingArea);
                }
            }
        }

        #endregion

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        public MonoFlat_ThemeContainer()
        {
            SetStyle((ControlStyles)139270, true);
            BackColor = Color.FromArgb(32, 41, 50);
            Padding = new Padding(10, 70, 10, 9);
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            MoveHeight = 66;
            Font = new Font("Segoe UI", 9f);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var G = e.Graphics;

            G.Clear(Color.FromArgb(32, 41, 50));
            G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), new Rectangle(0, 0, Width, 60));

            if (_RoundCorners == true)
            {
                // Draw Left upper corner
                G.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);

                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 1, 3, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 1, 2, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 2, 1, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 3, 1, 1, 1);

                // Draw right upper corner
                G.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1);

                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), Width - 2, 3, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), Width - 2, 2, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), Width - 3, 1, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), Width - 4, 1, 1, 1);

                // Draw Left bottom corner
                G.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, 1, Height - 2, 1, 1);

                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 1, Height - 3, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 1, Height - 4, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 3, Height - 2, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 2, Height - 2, 1, 1);

                // Draw right bottom corner
                G.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 4, Height - 1, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 4, 1, 1);
                G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 2, 1, 1);

                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), Width - 2, Height - 3, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), Width - 2, Height - 4, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), Width - 4, Height - 2, 1, 1);
                G.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), Width - 3, Height - 2, 1, 1);
            }

            G.DrawString(Text, new Font("Microsoft Sans Serif", 12f, FontStyle.Bold), new SolidBrush(Color.FromArgb(255, 254, 255)), new Rectangle(20, 20, Width - 1, Height), new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });
        }
    }

    #endregion
    #region  ControlBox 

    class MonoFlat_ControlBox : Control
    {

        #region  Enums 

        public enum ButtonHoverState
        {
            Minimize,
            Maximize,
            Close,
            None
        }

        #endregion
        #region  Variables 

        private ButtonHoverState ButtonHState = ButtonHoverState.None;

        #endregion
        #region  Properties 

        private bool _EnableMaximize = true;
        public bool EnableMaximizeButton
        {
            get
            {
                return _EnableMaximize;
            }
            set
            {
                _EnableMaximize = value;
                Invalidate();
            }
        }

        private bool _EnableMinimize = true;
        public bool EnableMinimizeButton
        {
            get
            {
                return _EnableMinimize;
            }
            set
            {
                _EnableMinimize = value;
                Invalidate();
            }
        }

        private bool _EnableHoverHighlight = false;
        public bool EnableHoverHighlight
        {
            get
            {
                return _EnableHoverHighlight;
            }
            set
            {
                _EnableHoverHighlight = value;
                Invalidate();
            }
        }

        #endregion
        #region  EventArgs 

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(100, 25);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int X = e.Location.X;
            int Y = e.Location.Y;
            if (Y > 0 && Y < Height - 2)
            {
                if (X > 0 && X < 34)
                {
                    ButtonHState = ButtonHoverState.Minimize;
                }
                else if (X > 33 && X < 65)
                {
                    ButtonHState = ButtonHoverState.Maximize;
                }
                else if (X > 64 && X < Width)
                {
                    ButtonHState = ButtonHoverState.Close;
                }
                else
                {
                    ButtonHState = ButtonHoverState.None;
                }
            }
            else
            {
                ButtonHState = ButtonHoverState.None;
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            switch (ButtonHState)
            {
                case ButtonHoverState.Close:
                    {
                        Parent.FindForm().Close();
                        break;
                    }
                case ButtonHoverState.Minimize:
                    {
                        if (_EnableMinimize == true)
                        {
                            Parent.FindForm().WindowState = FormWindowState.Minimized;
                        }

                        break;
                    }
                case ButtonHoverState.Maximize:
                    {
                        if (_EnableMaximize == true)
                        {
                            if (Parent.FindForm().WindowState == FormWindowState.Normal)
                            {
                                Parent.FindForm().WindowState = FormWindowState.Maximized;
                            }
                            else
                            {
                                Parent.FindForm().WindowState = FormWindowState.Normal;
                            }
                        }

                        break;
                    }
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ButtonHState = ButtonHoverState.None;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        #endregion

        public MonoFlat_ControlBox() : base()
        {
            DoubleBuffered = true;
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            try
            {
                Location = new Point(Parent.Width - 112, 15);
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var G = e.Graphics;
            G.Clear(Color.FromArgb(181, 41, 42));

            if (_EnableHoverHighlight == true)
            {
                switch (ButtonHState)
                {
                    case ButtonHoverState.None:
                        {
                            G.Clear(Color.FromArgb(181, 41, 42));
                            break;
                        }
                    case ButtonHoverState.Minimize:
                        {
                            if (_EnableMinimize == true)
                            {
                                G.FillRectangle(new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(3, 0, 30, Height));
                            }

                            break;
                        }
                    case ButtonHoverState.Maximize:
                        {
                            if (_EnableMaximize == true)
                            {
                                G.FillRectangle(new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(35, 0, 30, Height));
                            }

                            break;
                        }
                    case ButtonHoverState.Close:
                        {
                            G.FillRectangle(new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(66, 0, 35, Height));
                            break;
                        }
                }
            }

            // Close
            G.DrawString("r", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(Width - 16, 8), new StringFormat() { Alignment = StringAlignment.Center });

            // Maximize
            switch (Parent.FindForm().WindowState)
            {
                case FormWindowState.Maximized:
                    {
                        if (_EnableMaximize == true)
                        {
                            G.DrawString("2", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(51, 7), new StringFormat() { Alignment = StringAlignment.Center });
                        }
                        else
                        {
                            G.DrawString("2", new Font("Marlett", 12f), new SolidBrush(Color.LightGray), new Point(51, 7), new StringFormat() { Alignment = StringAlignment.Center });
                        }

                        break;
                    }
                case FormWindowState.Normal:
                    {
                        if (_EnableMaximize == true)
                        {
                            G.DrawString("1", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(51, 7), new StringFormat() { Alignment = StringAlignment.Center });
                        }
                        else
                        {
                            G.DrawString("1", new Font("Marlett", 12f), new SolidBrush(Color.LightGray), new Point(51, 7), new StringFormat() { Alignment = StringAlignment.Center });
                        }

                        break;
                    }
            }

            // Minimize
            if (_EnableMinimize == true)
            {
                G.DrawString("0", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(20, 7), new StringFormat() { Alignment = StringAlignment.Center });
            }
            else
            {
                G.DrawString("0", new Font("Marlett", 12f), new SolidBrush(Color.LightGray), new Point(20, 7), new StringFormat() { Alignment = StringAlignment.Center });
            }
        }
    }

    #endregion
    #region  Button 

    class MonoFlat_Button : Control
    {

        #region  Variables 

        private int MouseState;
        private GraphicsPath Shape;
        private LinearGradientBrush InactiveGB, PressedGB;
        private Rectangle R1;
        private Pen P1, P3;
        private Image _Image;
        private Size _ImageSize;
        private StringAlignment _TextAlignment = StringAlignment.Center;
        private Color _TextColor = Color.FromArgb(150, 150, 150);
        private ContentAlignment _ImageAlign = ContentAlignment.MiddleLeft;

        #endregion
        #region  Image Designer 

        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF MyPoint= new PointF(2f,2f) ;
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    {
                        MyPoint.X = (Area.Width - ImageArea.Width) / 2f;
                        break;
                    }
                case StringAlignment.Near:
                    {
                        MyPoint.X = 2f;
                        break;
                    }
                case StringAlignment.Far:
                    {
                        MyPoint.X = Area.Width - ImageArea.Width - 2f;
                        break;
                    }

            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    {
                        MyPoint.Y = (Area.Height - ImageArea.Height) / 2f;
                        break;
                    }
                case StringAlignment.Near:
                    {
                        MyPoint.Y = 2f;
                        break;
                    }
                case StringAlignment.Far:
                    {
                        MyPoint.Y = Area.Height - ImageArea.Height - 2f;
                        break;
                    }
            }
            return MyPoint;
        }

        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            var SF = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    {
                        SF.LineAlignment = StringAlignment.Center;
                        SF.Alignment = StringAlignment.Center;
                        break;
                    }
                case ContentAlignment.MiddleLeft:
                    {
                        SF.LineAlignment = StringAlignment.Center;
                        SF.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.MiddleRight:
                    {
                        SF.LineAlignment = StringAlignment.Center;
                        SF.Alignment = StringAlignment.Far;
                        break;
                    }
                case ContentAlignment.TopCenter:
                    {
                        SF.LineAlignment = StringAlignment.Near;
                        SF.Alignment = StringAlignment.Center;
                        break;
                    }
                case ContentAlignment.TopLeft:
                    {
                        SF.LineAlignment = StringAlignment.Near;
                        SF.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.TopRight:
                    {
                        SF.LineAlignment = StringAlignment.Near;
                        SF.Alignment = StringAlignment.Far;
                        break;
                    }
                case ContentAlignment.BottomCenter:
                    {
                        SF.LineAlignment = StringAlignment.Far;
                        SF.Alignment = StringAlignment.Center;
                        break;
                    }
                case ContentAlignment.BottomLeft:
                    {
                        SF.LineAlignment = StringAlignment.Far;
                        SF.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.BottomRight:
                    {
                        SF.LineAlignment = StringAlignment.Far;
                        SF.Alignment = StringAlignment.Far;
                        break;
                    }
            }
            return SF;
        }

        #endregion
        #region  Properties 

        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value is null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }

        protected Size ImageSize
        {
            get
            {
                return _ImageSize;
            }
        }

        public ContentAlignment ImageAlign
        {
            get
            {
                return _ImageAlign;
            }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }

        public StringAlignment TextAlignment
        {
            get
            {
                return _TextAlignment;
            }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }

        public override Color ForeColor
        {
            get
            {
                return _TextColor;
            }
            set
            {
                _TextColor = value;
                Invalidate();
            }
        }

        #endregion
        #region  EventArgs 

        protected override void OnMouseUp(MouseEventArgs e)
        {
            MouseState = 0;
            Invalidate();
            base.OnMouseUp(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            MouseState = 1;
            Focus();
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            MouseState = 0;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Invalidate();
            base.OnTextChanged(e);
        }

        #endregion

        public MonoFlat_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);




            BackColor = Color.Transparent;
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12f);
            ForeColor = Color.FromArgb(255, 255, 255);
            Size = new Size(146, 41);
            _TextAlignment = StringAlignment.Center;
            P1 = new Pen(Color.FromArgb(181, 41, 42)); // P1 = Border color
            P3 = new Pen(Color.FromArgb(165, 37, 37));  // P3 = Border color when pressed
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Width > 0 && Height > 0)
            {

                Shape = new GraphicsPath();
                R1 = new Rectangle(0, 0, Width, Height);

                InactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(181, 41, 42), Color.FromArgb(181, 41, 42), 90.0f);
                PressedGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(165, 37, 37), Color.FromArgb(165, 37, 37), 90.0f);
            }

            {
                ref var withBlock = ref Shape;
                withBlock.AddArc(0, 0, 10, 10, 180f, 90f);
                withBlock.AddArc(Width - 11, 0, 10, 10, -90, 90f);
                withBlock.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
                withBlock.AddArc(0, Height - 11, 10, 10, 90f, 90f);
                withBlock.CloseAllFigures();
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            {
                var withBlock = e.Graphics;
                withBlock.SmoothingMode = SmoothingMode.HighQuality;
                var ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);

                switch (MouseState)
                {
                    case 0: // Inactive
                        {
                            withBlock.FillPath(InactiveGB, Shape); // Fill button body with InactiveGB color gradient
                            withBlock.DrawPath(P1, Shape); // Draw button border [InactiveGB]
                            if (Image == null)
                            {
                                withBlock.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat() { Alignment = _TextAlignment, LineAlignment = StringAlignment.Center });
                            }
                            else
                            {
                                withBlock.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);
                                withBlock.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat() { Alignment = _TextAlignment, LineAlignment = StringAlignment.Center });
                            }

                            break;
                        }
                    case 1: // Pressed
                        {
                            withBlock.FillPath(PressedGB, Shape); // Fill button body with PressedGB color gradient
                            withBlock.DrawPath(P3, Shape); // Draw button border [PressedGB]

                            if (Image == null)
                            {
                                withBlock.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat() { Alignment = _TextAlignment, LineAlignment = StringAlignment.Center });
                            }
                            else
                            {
                                withBlock.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);
                                withBlock.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat() { Alignment = _TextAlignment, LineAlignment = StringAlignment.Center });
                            }

                            break;
                        }
                }
            }
            base.OnPaint(e);
        }
    }

    #endregion
    #region  Social Button 

    class MonoFlat_SocialButton : Control
    {

        #region  Variables 

        private Image _Image;
        private Size _ImageSize;
        private Color EllipseColor = Color.FromArgb(66, 76, 85);

        #endregion
        #region  Properties 

        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value is null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }

        protected Size ImageSize
        {
            get
            {
                return _ImageSize;
            }
        }

        #endregion
        #region  EventArgs 

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(54, 54);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            EllipseColor = Color.FromArgb(181, 41, 42);
            Refresh();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            EllipseColor = Color.FromArgb(66, 76, 85);
            Refresh();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            EllipseColor = Color.FromArgb(153, 34, 34);
            Focus();
            Refresh();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            EllipseColor = Color.FromArgb(181, 41, 42);
            Refresh();
        }

        #endregion
        #region  Image Designer 

        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF MyPoint= new PointF(2f,2f);
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    {
                        MyPoint.X = (Area.Width - ImageArea.Width) / 2f;
                        break;
                    }
            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    {
                        MyPoint.Y = (Area.Height - ImageArea.Height) / 2f;
                        break;
                    }
            }
            return MyPoint;
        }

        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            var SF = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    {
                        SF.LineAlignment = StringAlignment.Center;
                        SF.Alignment = StringAlignment.Center;
                        break;
                    }
            }
            return SF;
        }

        #endregion

        public MonoFlat_SocialButton()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var G = e.Graphics;
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;

            var ImgPoint = ImageLocation(GetStringFormat(ContentAlignment.MiddleCenter), Size, ImageSize);
            G.FillEllipse(new SolidBrush(EllipseColor), new Rectangle(0, 0, 53, 53));

            // HINTS:
            // The best size for the drawn image is 32x32\
            // The best matching color of drawn image is (RGB: 31, 40, 49)
            if (Image != null)
            {
                G.DrawImage(_Image, ImgPoint.X, ImgPoint.Y, ImageSize.Width, ImageSize.Height);
            }
        }
    }

    #endregion
    #region  Label 

    class MonoFlat_Label : Label
    {

        public MonoFlat_Label()
        {
            Font = new Font("Segoe UI", 9f);
            ForeColor = Color.FromArgb(116, 125, 132);
            BackColor = Color.Transparent;
        }
    }

    #endregion
    #region  Link Label 
    class MonoFlat_LinkLabel : LinkLabel
    {

        public MonoFlat_LinkLabel()
        {
            Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            BackColor = Color.Transparent;
            LinkColor = Color.FromArgb(181, 41, 42);
            ActiveLinkColor = Color.FromArgb(153, 34, 34);
            VisitedLinkColor = Color.FromArgb(181, 41, 42);
            LinkBehavior = LinkBehavior.NeverUnderline;
        }
    }

    #endregion
    #region  Header Label 

    class MonoFlat_HeaderLabel : Label
    {

        public MonoFlat_HeaderLabel()
        {
            Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            ForeColor = Color.FromArgb(255, 255, 255);
            BackColor = Color.Transparent;
        }
    }

    #endregion
    #region  Toggle Button 

    [DefaultEvent("ToggledChanged")]
    class MonoFlat_Toggle : Control
    {

        #region  Enums 

        public enum _Type
        {
            CheckMark,
            OnOff,
            YesNo,
            IO
        }

        #endregion
        #region  Variables 

        public event ToggledChangedEventHandler ToggledChanged;

        public delegate void ToggledChangedEventHandler();
        private bool _Toggled;
        private _Type ToggleType;
        private Rectangle Bar;
        private int _Width, _Height;

        #endregion
        #region  Properties 

        public bool Toggled
        {
            get
            {
                return _Toggled;
            }
            set
            {
                _Toggled = value;
                Invalidate();
                ToggledChanged?.Invoke();
            }
        }

        public _Type Type
        {
            get
            {
                return ToggleType;
            }
            set
            {
                ToggleType = value;
                Invalidate();
            }
        }

        #endregion
        #region  EventArgs 

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(76, 33);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Toggled = !Toggled;
            Focus();
        }

        #endregion

        public MonoFlat_Toggle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var G = e.Graphics;

            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(Parent.BackColor);
            _Width = Width - 1;
            _Height = Height - 1;

            GraphicsPath GP = new GraphicsPath(), GP2 = new GraphicsPath();
            var BaseRect = new Rectangle(0, 0, _Width, _Height);
            var ThumbRect = new Rectangle(_Width / 2, 0, 38, _Height);

            G.SmoothingMode = (SmoothingMode)2;
            G.PixelOffsetMode = (PixelOffsetMode)2;
            G.TextRenderingHint = (System.Drawing.Text.TextRenderingHint)5;
            G.Clear(BackColor);

            GP = RoundRectangle.RoundRect(BaseRect, 4);
            ThumbRect = new Rectangle(4, 4, 36, _Height - 8);
            GP2 = RoundRectangle.RoundRect(ThumbRect, 4);
            G.FillPath(new SolidBrush(Color.FromArgb(66, 76, 85)), GP);
            G.FillPath(new SolidBrush(Color.FromArgb(32, 41, 50)), GP2);

            if (_Toggled)
            {
                GP = RoundRectangle.RoundRect(BaseRect, 4);
                ThumbRect = new Rectangle(_Width / 2 - 2, 4, 36, _Height - 8);
                GP2 = RoundRectangle.RoundRect(ThumbRect, 4);
                G.FillPath(new SolidBrush(Color.FromArgb(181, 41, 42)), GP);
                G.FillPath(new SolidBrush(Color.FromArgb(32, 41, 50)), GP2);
            }

            // Draw string
            switch (ToggleType)
            {
                case _Type.CheckMark:
                    {
                        if (Toggled)
                        {
                            G.DrawString("ü", new Font("Wingdings", 18f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 18, Bar.Y + 19, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                        else
                        {
                            G.DrawString("r", new Font("Marlett", 14f, FontStyle.Regular), Brushes.DimGray, Bar.X + 59, Bar.Y + 18, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }

                        break;
                    }
                case _Type.OnOff:
                    {
                        if (Toggled)
                        {
                            G.DrawString("ON", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 18, Bar.Y + 16, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                        else
                        {
                            G.DrawString("OFF", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.DimGray, Bar.X + 57, Bar.Y + 16, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }

                        break;
                    }
                case _Type.YesNo:
                    {
                        if (Toggled)
                        {
                            G.DrawString("YES", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 19, Bar.Y + 16, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                        else
                        {
                            G.DrawString("NO", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.DimGray, Bar.X + 56, Bar.Y + 16, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }

                        break;
                    }
                case _Type.IO:
                    {
                        if (Toggled)
                        {
                            G.DrawString("I", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.WhiteSmoke, Bar.X + 18, Bar.Y + 16, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                        else
                        {
                            G.DrawString("O", new Font("Segoe UI", 12f, FontStyle.Regular), Brushes.DimGray, Bar.X + 57, Bar.Y + 16, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }

                        break;
                    }
            }
        }
    }

    #endregion
    #region  CheckBox 

    [DefaultEvent("CheckedChanged")]
    class MonoFlat_CheckBox : Control
    {

        #region  Variables 

        private int X;
        private bool _Checked = false;
        private GraphicsPath Shape;

        #endregion
        #region  Properties 

        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                _Checked = value;
                Invalidate();
            }
        }

        #endregion
        #region  EventArgs 

        public event CheckedChangedEventHandler CheckedChanged;

        public delegate void CheckedChangedEventHandler(object sender);

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            X = e.Location.X;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            _Checked = !_Checked;
            Focus();
            CheckedChanged?.Invoke(this);
            base.OnMouseDown(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Height = 16;

            Shape = new GraphicsPath();
            {
                ref var withBlock = ref Shape;
                withBlock.AddArc(0, 0, 10, 10, 180f, 90f);
                withBlock.AddArc(Width - 11, 0, 10, 10, -90, 90f);
                withBlock.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
                withBlock.AddArc(0, Height - 11, 10, 10, 90f, 90f);
                withBlock.CloseAllFigures();
            }
            Invalidate();
        }

        #endregion

        public MonoFlat_CheckBox()
        {
            Width = 148;
            Height = 16;
            Font = new Font("Microsoft Sans Serif", 9f);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var G = e.Graphics;
            G.Clear(Parent.BackColor);

            if (_Checked)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));
                G.FillRectangle(new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(1, 1, 16 - 2, 16 - 2));
            }
            else
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));
                G.FillRectangle(new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(1, 1, 16 - 2, 16 - 2));
            }

            if (Enabled == true)
            {
                if (_Checked)
                    G.DrawString("a", new Font("Marlett", 16f), new SolidBrush(Color.FromArgb(181, 41, 42)), new Point(-5, -3));
            }
            else if (_Checked)
                G.DrawString("a", new Font("Marlett", 16f), new SolidBrush(Color.Gray), new Point(-5, -3));

            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(116, 125, 132)), new Point(20, 0));
        }
    }
    #endregion
    #region  Radio Button 

    [DefaultEvent("CheckedChanged")]
    class MonoFlat_RadioButton : Control
    {

        #region  Variables 

        private int X;
        private bool _Checked;

        #endregion
        #region  Properties 

        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                _Checked = value;
                InvalidateControls();
                CheckedChanged?.Invoke(this);
                Invalidate();
            }
        }

        #endregion
        #region  EventArgs 

        public event CheckedChangedEventHandler CheckedChanged;

        public delegate void CheckedChangedEventHandler(object sender);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!_Checked)
                Checked = true;
            Focus();
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            X = e.X;
            Invalidate();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            int textSize;
            textSize = (int)Math.Round(CreateGraphics().MeasureString(Text, Font).Width);
            Width = 28 + textSize;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 17;
        }

        #endregion

        public MonoFlat_RadioButton()
        {
            Width = 159;
            Height = 17;
            DoubleBuffered = true;
        }

        private void InvalidateControls()
        {
            if (!IsHandleCreated || !_Checked)
                return;

            foreach (Control _Control in Parent.Controls)
            {
                if (!ReferenceEquals(_Control, this) && _Control is MonoFlat_RadioButton)
                {
                    ((MonoFlat_RadioButton)_Control).Checked = false;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var G = e.Graphics;
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.FillEllipse(new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));

            if (_Checked)
            {
                G.DrawString("a", new Font("Marlett", 15f), new SolidBrush(Color.FromArgb(181, 41, 42)), new Point(-3, -2));
            }

            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(116, 125, 132)), new Point(20, 0));
        }
    }

    #endregion
    #region  TextBox 

    [DefaultEvent("TextChanged")]
    class MonoFlat_TextBox : Control
    {

        #region  Variables 

        public TextBox MonoFlatTB;
        private int _maxchars = 32767;
        private bool _ReadOnly;
        private bool _Multiline;
        private Image _Image;
        private Size _ImageSize;
        private HorizontalAlignment ALNType;
        private bool isPasswordMasked = false;
        private Pen P1;
        private SolidBrush B1;
        private GraphicsPath Shape;

        #endregion
        #region  Properties 

        public new HorizontalAlignment TextAlignment
        {
            get
            {
                return ALNType;
            }
            set
            {
                ALNType = value;
                Invalidate();
            }
        }
        public new int MaxLength
        {
            get
            {
                return _maxchars;
            }
            set
            {
                _maxchars = value;
                MonoFlatTB.MaxLength = MaxLength;
                Invalidate();
            }
        }

        public new bool UseSystemPasswordChar
        {
            get
            {
                return isPasswordMasked;
            }
            set
            {
                MonoFlatTB.UseSystemPasswordChar = UseSystemPasswordChar;
                isPasswordMasked = value;
                Invalidate();
            }
        }
        public bool ReadOnly
        {
            get
            {
                return _ReadOnly;
            }
            set
            {
                _ReadOnly = value;
                if (MonoFlatTB != null)
                {
                    MonoFlatTB.ReadOnly = value;
                }
            }
        }
        public bool Multiline
        {
            get
            {
                return _Multiline;
            }
            set
            {
                _Multiline = value;
                if (MonoFlatTB != null)
                {
                    MonoFlatTB.Multiline = value;

                    if (value)
                    {
                        MonoFlatTB.Height = Height - 23;
                    }
                    else
                    {
                        Height = MonoFlatTB.Height + 23;
                    }
                }
            }
        }

        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value is null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;

                if (Image is null)
                {
                    MonoFlatTB.Location = new Point(8, 10);
                }
                else
                {
                    MonoFlatTB.Location = new Point(35, 11);
                }
                Invalidate();
            }
        }

        protected Size ImageSize
        {
            get
            {
                return _ImageSize;
            }
        }

        #endregion
        #region  EventArgs 

        // Private Sub _Enter(ByVal Obj As Object, ByVal e As EventArgs)
        // P1 = New Pen(Color.FromArgb(181, 41, 42))
        // Refresh()
        // End Sub

        private void _Leave(object Obj, EventArgs e)
        {
            P1 = new Pen(Color.FromArgb(32, 41, 50));
            Refresh();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            MonoFlatTB.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            MonoFlatTB.Font = Font;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void _OnKeyDown(object Obj, KeyEventArgs e)
        {
            // If e.Control AndAlso e.KeyCode = Keys.A Then
            // MonoFlatTB.SelectAll()
            // e.SuppressKeyPress = True
            // End If
            // If e.Control AndAlso e.KeyCode = Keys.C Then
            // MonoFlatTB.Copy()
            // e.SuppressKeyPress = True
            // End If
            if (Name == "txtcontra")
            {
                if (e.KeyCode == Keys.Enter)
                {


                    if (FindForm().Name == "login")
                    {
                        if (My.MyProject.Forms.login.bloqueado)
                        {
                            My.MyProject.Forms.login.passwordBloqueadoAsync();
                        }
                        else
                        {
                            My.MyProject.Forms.login.passwordInicioAsync();
                        }
                    }

                    else if (FindForm().Name == "Autorizacion")
                    {
                        My.MyProject.Forms.Autorizacion.FlowEspere.Visible = true;
                        My.MyProject.Forms.Autorizacion.txtusr.Enabled = false;
                        My.MyProject.Forms.Autorizacion.txtcontra.Enabled = false;
                        My.MyProject.Forms.Autorizacion.MonoFlat_Button1.Enabled = false;
                        My.MyProject.Forms.Autorizacion.MonoFlat_Button2.Enabled = false;
                        My.MyProject.Forms.Autorizacion.BackgroundWorker1.RunWorkerAsync();
                    }
                    else if (FindForm().Name == "AutorizacionRetiro")
                    {
                        My.MyProject.Forms.AutorizacionRetiro.FlowEspere.Visible = true;
                        My.MyProject.Forms.AutorizacionRetiro.txtusr.Enabled = false;
                        My.MyProject.Forms.AutorizacionRetiro.txtcontra.Enabled = false;
                        My.MyProject.Forms.AutorizacionRetiro.MonoFlat_Button1.Enabled = false;
                        My.MyProject.Forms.AutorizacionRetiro.MonoFlat_Button2.Enabled = false;
                        My.MyProject.Forms.AutorizacionRetiro.BackgroundWorker1.RunWorkerAsync();
                    }
                    else if (FindForm().Name == "AutorizacionNotificacion")
                    {
                        My.MyProject.Forms.AutorizacionNotificacion.FlowEspere.Visible = true;
                        My.MyProject.Forms.AutorizacionNotificacion.txtcontra.Enabled = false;
                        My.MyProject.Forms.AutorizacionNotificacion.MonoFlat_Button1.Enabled = false;
                        My.MyProject.Forms.AutorizacionNotificacion.MonoFlat_Button2.Enabled = false;
                        My.MyProject.Forms.AutorizacionNotificacion.BackgroundWorker1.RunWorkerAsync();
                    }
                    else if (FindForm().Name == "AutorizacionNotificacionBuenFin")
                    {
                        My.MyProject.Forms.AutorizacionNotificacionBuenFin.FlowEspere.Visible = true;
                        My.MyProject.Forms.AutorizacionNotificacionBuenFin.txtcontra.Enabled = false;
                        My.MyProject.Forms.AutorizacionNotificacionBuenFin.MonoFlat_Button1.Enabled = false;
                        My.MyProject.Forms.AutorizacionNotificacionBuenFin.MonoFlat_Button2.Enabled = false;
                        My.MyProject.Forms.AutorizacionNotificacionBuenFin.BackgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {



                    }


                }
            }

        }
        // Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        // If e.KeyCode = Keys.Up Then
        // e.Handled = True
        // SendKeys.Send("ESC")
        // Else
        // MyBase.OnKeyDown(e)

        // End If
        // End Sub
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_Multiline)
            {
                MonoFlatTB.Height = Height - 23;
            }
            else
            {
                Height = MonoFlatTB.Height + 23;
            }

            Shape = new GraphicsPath();
            {
                ref var withBlock = ref Shape;
                withBlock.AddArc(0, 0, 10, 10, 180f, 90f);
                withBlock.AddArc(Width - 11, 0, 10, 10, -90, 90f);
                withBlock.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
                withBlock.AddArc(0, Height - 11, 10, 10, 90f, 90f);
                withBlock.CloseAllFigures();
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            MonoFlatTB.Focus();
        }

        public void _TextChanged()
        {
            Text = MonoFlatTB.Text;
        }

        public void _BaseTextChanged()
        {
            MonoFlatTB.Text = Text;
        }

        #endregion

        public void AddTextBox()
        {
            {
                var withBlock = MonoFlatTB;
                withBlock.Location = new Point(8, 10);
                withBlock.Text = string.Empty;
                withBlock.BorderStyle = BorderStyle.None;
                withBlock.TextAlign = HorizontalAlignment.Left;
                withBlock.Font = new Font("Tahoma", 11f);
                withBlock.UseSystemPasswordChar = UseSystemPasswordChar;
                withBlock.Multiline = false;
                withBlock.BackColor = Color.FromArgb(66, 76, 85);
                withBlock.ScrollBars = ScrollBars.None;
            }
            MonoFlatTB.KeyDown += _OnKeyDown;
            // AddHandler MonoFlatTB.Enter, AddressOf _Enter
            MonoFlatTB.Leave += _Leave;

        }

        public MonoFlat_TextBox()
        {
            MonoFlatTB = new TextBox();
            TextChanged += (_, __) => _BaseTextChanged();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            AddTextBox();
            Controls.Add(MonoFlatTB);

            P1 = new Pen(Color.FromArgb(32, 41, 50));
            B1 = new SolidBrush(Color.FromArgb(66, 76, 85));
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(176, 183, 191);

            Text = null;
            Font = new Font("Tahoma", 11f);
            Size = new Size(135, 43);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            var G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.AntiAlias;

            {
                var withBlock = MonoFlatTB;

                if (Image is null)
                {
                    withBlock.Width = Width - 18;
                }
                else
                {
                    withBlock.Width = Width - 45;
                }

                withBlock.TextAlign = TextAlignment;
                withBlock.UseSystemPasswordChar = UseSystemPasswordChar;
            }

            G.Clear(Color.Transparent);

            G.FillPath(B1, Shape);
            G.DrawPath(P1, Shape);

            if (Image != null)
            {
                G.DrawImage(_Image, 5, 8, 24, 24);
                // 24x24 is the perfect size of the image
            }

            e.Graphics.DrawImage(B, (float)0, (float)0);
            G.Dispose();
            B.Dispose();
        }
    }

    #endregion
    #region  Panel 

    class MonoFlat_Panel : ContainerControl
    {

        private GraphicsPath Shape;

        public MonoFlat_Panel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            BackColor = Color.FromArgb(39, 51, 63);
            Size = new Size(187, 117);
            Padding = new Padding(5, 5, 5, 5);
            DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Shape = new GraphicsPath();
            {
                ref var withBlock = ref Shape;
                withBlock.AddArc(0, 0, 10, 10, 180f, 90f);
                withBlock.AddArc(Width - 11, 0, 10, 10, -90, 90f);
                withBlock.AddArc(Width - 11, Height - 11, 10, 10, 0f, 90f);
                withBlock.AddArc(0, Height - 11, 10, 10, 90f, 90f);
                withBlock.CloseAllFigures();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.HighQuality;

            G.Clear(Color.FromArgb(32, 41, 50)); // Set control background to transparent
            G.FillPath(new SolidBrush(Color.FromArgb(39, 51, 63)), Shape); // Draw RTB background
            G.DrawPath(new Pen(Color.FromArgb(39, 51, 63)), Shape); // Draw border

            G.Dispose();
            e.Graphics.DrawImage(B, 0, 0);
            B.Dispose();
        }
    }

    #endregion
    #region  Separator 

    class MonoFlat_Separator : Control
    {

        public MonoFlat_Separator()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            Size = (Size)new Point(120, 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.FromArgb(45, 57, 68)), 0, 5, Width, 5);
        }
    }

    #endregion
    #region  TrackBar 

    [DefaultEvent("ValueChanged")]
    class MonoFlat_TrackBar : Control
    {

        #region  Enums 

        public enum ValueDivisor
        {
            By1 = 1,
            By10 = 10,
            By100 = 100,
            By1000 = 1000
        }

        #endregion
        #region  Variables 

        private Rectangle FillValue, PipeBorder, TrackBarHandleRect;
        private bool Cap;
        private int ValueDrawer;

        private Size ThumbSize = new Size(14, 14);
        private Rectangle TrackThumb;

        private int _Minimum = 0;
        private int _Maximum = 10;
        private int _Value = 0;

        private bool _JumpToMouse = false;
        private ValueDivisor DividedValue = ValueDivisor.By1;

        #endregion
        #region  Properties 

        public int Minimum
        {
            get
            {
                return _Minimum;
            }
            set
            {

                if (value >= _Maximum)
                    value = _Maximum - 10;
                if (_Value < value)
                    _Value = value;

                _Minimum = value;
                Invalidate();
            }
        }

        public int Maximum
        {
            get
            {
                return _Maximum;
            }
            set
            {

                if (value <= _Minimum)
                    value = _Minimum + 10;
                if (_Value > value)
                    _Value = value;

                _Maximum = value;
                Invalidate();
            }
        }

        public event ValueChangedEventHandler ValueChanged;

        public delegate void ValueChangedEventHandler();
        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (_Value != value)
                {
                    if (value < _Minimum)
                    {
                        _Value = _Minimum;
                    }
                    else if (value > _Maximum)
                    {
                        _Value = _Maximum;
                    }
                    else
                    {
                        _Value = value;
                    }
                    Invalidate();
                    ValueChanged?.Invoke();
                }
            }
        }

        public ValueDivisor ValueDivison
        {
            get
            {
                return DividedValue;
            }
            set
            {
                DividedValue = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public float ValueToSet
        {
            get
            {
                return (float)(_Value / (double)DividedValue);
            }
            set
            {
                Value = (int)Math.Round(value * (float)DividedValue);
            }
        }

        public bool JumpToMouse
        {
            get
            {
                return _JumpToMouse;
            }
            set
            {
                _JumpToMouse = value;
                Invalidate();
            }
        }

        #endregion
        #region  EventArgs 

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Cap == true && e.X > -1 && e.X < Width + 1)
            {
                Value = _Minimum + (int)Math.Round((_Maximum - _Minimum) * (e.X / (double)Width));
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ValueDrawer = (int)Math.Round((_Value - _Minimum) / (double)(_Maximum - _Minimum) * (Width - 11));
                TrackBarHandleRect = new Rectangle(ValueDrawer, 0, 25, 25);
                Cap = TrackBarHandleRect.Contains(e.Location);
                Focus();
                if (_JumpToMouse)
                {
                    Value = _Minimum + (int)Math.Round((_Maximum - _Minimum) * (e.X / (double)Width));
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Cap = false;
        }

        #endregion

        public MonoFlat_TrackBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer, true);

            Size = new Size(80, 22);
            MinimumSize = new Size(47, 22);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 22;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var G = e.Graphics;

            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.AntiAlias;
            TrackThumb = new Rectangle(7, 10, Width - 16, 2);
            PipeBorder = new Rectangle(1, 10, Width - 3, 2);

            try
            {
                ValueDrawer = (int)Math.Round((_Value - _Minimum) / (double)(_Maximum - _Minimum) * Width);
            }
            catch (Exception ex)
            {
            }

            TrackBarHandleRect = new Rectangle(ValueDrawer, 0, 3, 20);

            G.FillRectangle(new SolidBrush(Color.FromArgb(124, 131, 137)), PipeBorder);
            FillValue = new Rectangle(0, 10, TrackBarHandleRect.X + TrackBarHandleRect.Width - 4, 3);

            G.ResetClip();

            G.SmoothingMode = SmoothingMode.Default;
            G.DrawRectangle(new Pen(Color.FromArgb(124, 131, 137)), PipeBorder); // Draw pipe border
            G.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), FillValue);

            G.ResetClip();

            G.SmoothingMode = SmoothingMode.HighQuality;
            G.FillEllipse(new SolidBrush(Color.FromArgb(181, 41, 42)), TrackThumb.X + (int)Math.Round(TrackThumb.Width * (Value / (double)Maximum)) - (int)Math.Round(ThumbSize.Width / 2d), TrackThumb.Y + (int)Math.Round(TrackThumb.Height / 2d) - (int)Math.Round(ThumbSize.Height / 2d), ThumbSize.Width, ThumbSize.Height);
            G.DrawEllipse(new Pen(Color.FromArgb(181, 41, 42)), TrackThumb.X + (int)Math.Round(TrackThumb.Width * (Value / (double)Maximum)) - (int)Math.Round(ThumbSize.Width / 2d), TrackThumb.Y + (int)Math.Round(TrackThumb.Height / 2d) - (int)Math.Round(ThumbSize.Height / 2d), ThumbSize.Width, ThumbSize.Height);
        }
    }

    #endregion
    #region  NotificationBox 

    class MonoFlat_NotificationBox : Control
    {

        #region  Variables 

        private Point CloseCoordinates;
        private bool IsOverClose;
        private int _BorderCurve = 8;
        private GraphicsPath CreateRoundPath;
        private string NotificationText = null;
        private Type _NotificationType;
        private bool _RoundedCorners;
        private bool _ShowCloseButton;
        private Image _Image;
        private Size _ImageSize;

        #endregion
        #region  Enums 

        // Create a list of Notification Types
        public enum Type
        {
            Notice,
            Success,
            Warning,
            Error
        }

        #endregion
        #region  Custom Properties 

        // Create a NotificationType property and add the Type enum to it
        public Type NotificationType
        {
            get
            {
                return _NotificationType;
            }
            set
            {
                _NotificationType = value;
                Invalidate();
            }
        }
        // Boolean value to determine whether the control should use border radius
        public bool RoundCorners
        {
            get
            {
                return _RoundedCorners;
            }
            set
            {
                _RoundedCorners = value;
                Invalidate();
            }
        }
        // Boolean value to determine whether the control should draw the close button
        public bool ShowCloseButton
        {
            get
            {
                return _ShowCloseButton;
            }
            set
            {
                _ShowCloseButton = value;
                Invalidate();
            }
        }
        // Integer value to determine the curve level of the borders
        public int BorderCurve
        {
            get
            {
                return _BorderCurve;
            }
            set
            {
                _BorderCurve = value;
                Invalidate();
            }
        }
        // Image value to determine whether the control should draw an image before the header
        public Image Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if (value is null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }
        // Size value - returns the image size
        protected Size ImageSize
        {
            get
            {
                return _ImageSize;
            }
        }

        #endregion
        #region  EventArgs 

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // Decides the location of the drawn ellipse. If mouse is over the correct coordinates, "IsOverClose" boolean will be triggered to draw the ellipse
            if (e.X >= Width - 19 && e.X <= Width - 10 && e.Y > CloseCoordinates.Y && e.Y < CloseCoordinates.Y + 12)
            {
                IsOverClose = true;
            }
            else
            {
                IsOverClose = false;
            }
            // Updates the control   
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Disposes the control when the close button is clicked
            if (_ShowCloseButton == true)
            {
                if (IsOverClose)
                {
                    Dispose();
                }
            }
        }

        #endregion

        internal GraphicsPath CreateRoundRect(Rectangle r, int curve)
        {
            // Draw a border radius
            try
            {
                CreateRoundPath = new GraphicsPath(FillMode.Winding);
                CreateRoundPath.AddArc(r.X, r.Y, curve, curve, 180.0f, 90.0f);
                CreateRoundPath.AddArc(r.Right - curve, r.Y, curve, curve, 270.0f, 90.0f);
                CreateRoundPath.AddArc(r.Right - curve, r.Bottom - curve, curve, curve, 0.0f, 90.0f);
                CreateRoundPath.AddArc(r.X, r.Bottom - curve, curve, curve, 90.0f, 90.0f);
                CreateRoundPath.CloseFigure();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Constants.vbNewLine + Constants.vbNewLine + "Value must be either '1' or higher", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Return to the default border curve if the parameter is less than "1"
                _BorderCurve = 8;
                BorderCurve = 8;
            }
            return CreateRoundPath;
        }

        public MonoFlat_NotificationBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            Font = new Font("Tahoma", 9f);
            MinimumSize = new Size(100, 40);
            RoundCorners = false;
            ShowCloseButton = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Declare Graphics to draw the control
            var GFX = e.Graphics;
            // Declare Color to paint the control's Text, Background and Border
            Color ForeColor = Color.White, BackgroundColor =Color.White , BorderColor = Color.White;
            // Determine the header Notification Type font
            var TypeFont = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // Decalre a new rectangle to draw the control inside it
            var MainRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            // Declare a GraphicsPath to create a border radius
            var CrvBorderPath = CreateRoundRect(MainRectangle, _BorderCurve);

            GFX.SmoothingMode = SmoothingMode.HighQuality;
            GFX.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            GFX.Clear(Parent.BackColor);

            switch (_NotificationType)
            {
                case Type.Notice:
                    {
                        BackgroundColor = Color.FromArgb(51, 0, 204);
                        BorderColor = Color.FromArgb(111, 177, 199);
                        ForeColor = Color.White;
                        break;
                    }
                case Type.Success:
                    {
                        BackgroundColor = Color.FromArgb(91, 195, 162);
                        BorderColor = Color.FromArgb(91, 195, 162);
                        ForeColor = Color.White;
                        break;
                    }
                case Type.Warning:
                    {
                        BackgroundColor = Color.FromArgb(254, 209, 108);
                        BorderColor = Color.FromArgb(254, 209, 108);
                        ForeColor = Color.DimGray;
                        break;
                    }
                case Type.Error:
                    {
                        BackgroundColor = Color.FromArgb(217, 103, 93);
                        BorderColor = Color.FromArgb(217, 103, 93);
                        ForeColor = Color.White;
                        break;
                    }
            }

            if (_RoundedCorners == true)
            {
                GFX.FillPath(new SolidBrush(BackgroundColor), CrvBorderPath);
                GFX.DrawPath(new Pen(BorderColor), CrvBorderPath);
            }
            else
            {
                GFX.FillRectangle(new SolidBrush(BackgroundColor), MainRectangle);
                GFX.DrawRectangle(new Pen(BorderColor), MainRectangle);
            }

            switch (_NotificationType)
            {
                case Type.Notice:
                    {
                        NotificationText = "NOTIFICACIONES";
                        break;
                    }
                case Type.Success:
                    {
                        NotificationText = "SUCCESS";
                        break;
                    }
                case Type.Warning:
                    {
                        NotificationText = "WARNING";
                        break;
                    }
                case Type.Error:
                    {
                        NotificationText = "ERROR";
                        break;
                    }
            }

            if (Image == null)
            {
                GFX.DrawString(NotificationText, TypeFont, new SolidBrush(ForeColor), new Point(10, 5));
                GFX.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(10, 21, Width - 17, Height - 5));
            }
            else
            {
                GFX.DrawImage(_Image, 12, 4, 16, 16);
                GFX.DrawString(NotificationText, TypeFont, new SolidBrush(ForeColor), new Point(30, 5));
                GFX.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(10, 21, Width - 17, Height - 5));
            }

            CloseCoordinates = new Point(Width - 26, 4);

            if (_ShowCloseButton == true)
            {
                // Draw the close button
                GFX.DrawString("r", new Font("Marlett", 7f, FontStyle.Regular), new SolidBrush(Color.FromArgb(130, 130, 130)), new Rectangle(Width - 20, 10, Width, Height), new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });
            }

            CrvBorderPath.Dispose();
        }
    }

    #endregion

}