using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    static class Module_resize
    {

        #region  Functions and Constants 

        // Width of the 'resizable border', the area where you can resize.
        public const int BorderWidth = 6;
        public static ResizeDirection _resizeDir = ResizeDirection.None;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTBORDER = 18;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;
        public const int HTBOTTOMRIGHT = 17;
        public const int HTCAPTION = 2;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        #endregion

        public enum ResizeDirection
        {
            None = 0,
            Left = 1,
            TopLeft = 2,
            Top = 3,
            TopRight = 4,
            Right = 5,
            BottomRight = 6,
            Bottom = 7,
            BottomLeft = 8
        }

        public static ResizeDirection get_resizeDir(Form frm)
        {
            return _resizeDir;

        } // Change cursor

        public static void set_resizeDir(Form frm, ResizeDirection value)
        {
            _resizeDir = value;
            switch (value)
            {
                case ResizeDirection.Left:
                    {
                        frm.Cursor = Cursors.SizeWE;
                        break;
                    }

                case ResizeDirection.Right:
                    {
                        frm.Cursor = Cursors.SizeWE;
                        break;
                    }

                case ResizeDirection.Top:
                    {
                        frm.Cursor = Cursors.SizeNS;
                        break;
                    }

                case ResizeDirection.Bottom:
                    {
                        frm.Cursor = Cursors.SizeNS;
                        break;
                    }

                case ResizeDirection.BottomLeft:
                    {
                        frm.Cursor = Cursors.SizeNESW;
                        break;
                    }

                case ResizeDirection.TopRight:
                    {
                        frm.Cursor = Cursors.SizeNESW;
                        break;
                    }

                case ResizeDirection.BottomRight:
                    {
                        frm.Cursor = Cursors.SizeNWSE;
                        break;
                    }

                case ResizeDirection.TopLeft:
                    {
                        frm.Cursor = Cursors.SizeNWSE;
                        break;
                    }

                default:
                    {
                        frm.Cursor = Cursors.Default;
                        break;
                    }
            }
        }

        #region  Moving & Resizing methods 

        public static void MoveForm(Form frm)
        {
            ReleaseCapture();
            SendMessage(frm.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        public static void ResizeForm(Form frm, ResizeDirection direction)
        {
            int dir = -1;

            switch (direction)
            {
                case ResizeDirection.Left:
                    {
                        dir = HTLEFT;
                        break;
                    }
                case ResizeDirection.TopLeft:
                    {
                        dir = HTTOPLEFT;
                        break;
                    }
                case ResizeDirection.Top:
                    {
                        dir = HTTOP;
                        break;
                    }
                case ResizeDirection.TopRight:
                    {
                        dir = HTTOPRIGHT;
                        break;
                    }
                case ResizeDirection.Right:
                    {
                        dir = HTRIGHT;
                        break;
                    }
                case ResizeDirection.BottomRight:
                    {
                        dir = HTBOTTOMRIGHT;
                        break;
                    }
                case ResizeDirection.Bottom:
                    {
                        dir = HTBOTTOM;
                        break;
                    }
                case ResizeDirection.BottomLeft:
                    {
                        dir = HTBOTTOMLEFT;
                        break;
                    }
            }
            if (dir != -1)
            {
                // Resize form
                ReleaseCapture();
                SendMessage(frm.Handle, WM_NCLBUTTONDOWN, dir, 0);

            }
        }

        public static void SetDirection(Form frm)
        {

            var C_Location = frm.PointToClient(Cursor.Position);

            // Calculate which direction to resize based on mouse position
            if (C_Location.X < BorderWidth & C_Location.Y < BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.TopLeft);
            }
            else if (C_Location.X < BorderWidth & C_Location.Y > frm.Height - BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.BottomLeft);
            }
            else if (C_Location.X > frm.Width - BorderWidth & C_Location.Y > frm.Height - BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.BottomRight);
            }
            else if (C_Location.X > frm.Width - BorderWidth & C_Location.Y < BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.TopRight);
            }
            else if (C_Location.X < BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.Left);
            }
            else if (C_Location.X > frm.Width - BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.Right);
            }
            else if (C_Location.Y < BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.Top);
            }
            else if (C_Location.Y > frm.Height - BorderWidth)
            {
                set_resizeDir(frm, ResizeDirection.Bottom);
            }
            else
            {
                set_resizeDir(frm, ResizeDirection.None);
            }

        }

        #endregion

    }
}