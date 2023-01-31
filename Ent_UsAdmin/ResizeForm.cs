using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    public class clsResizeForm
    {
        private float f_HeightRatio = new float();
        private float f_WidthRatio = new float();
        public void ResizeForm(Form ObjForm, int DesignerWidth, int DesignerHeight)
        {
            int i_StandardHeight = DesignerHeight;
            int i_StandardWidth = DesignerWidth;
            int i_PresentHeight = Screen.PrimaryScreen.Bounds.Height;
            int i_PresentWidth = Screen.PrimaryScreen.Bounds.Width;
            f_HeightRatio = i_PresentHeight / (float)i_StandardHeight;
            f_WidthRatio = i_PresentWidth / (float)i_StandardWidth;
            ObjForm.AutoScaleMode = AutoScaleMode.None;
            ObjForm.Scale(new SizeF(f_WidthRatio, f_HeightRatio));
            foreach (Control c in ObjForm.Controls)
            {
                if (c.HasChildren)
                {
                    ResizeControlStore(c);
                }
                else
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size * f_HeightRatio, c.Font.Style, c.Font.Unit, 0);
                }
                if (c is FlowLayoutPanel)
                {
                    foreach (Control cr in c.Controls)
                    {
                        if (cr.HasChildren)
                        {
                            ResizeControlStore(cr);
                        }
                        else
                        {
                            cr.Font = new Font(cr.Font.FontFamily, cr.Font.Size * f_HeightRatio, cr.Font.Style, cr.Font.Unit, 0);
                        }
                    }
                }
            }
            ObjForm.Font = new Font(ObjForm.Font.FontFamily, ObjForm.Font.Size * f_HeightRatio, ObjForm.Font.Style, ObjForm.Font.Unit, 0);
        }
        private void ResizeControlStore(Control objCtl)
        {
            if (objCtl.HasChildren)
            {
                foreach (Control cChildren in objCtl.Controls)
                {
                    if (cChildren.HasChildren)
                    {
                        ResizeControlStore(cChildren);
                    }
                    else
                    {
                        cChildren.Font = new Font(cChildren.Font.FontFamily, cChildren.Font.Size * f_HeightRatio, cChildren.Font.Style, cChildren.Font.Unit, 0);
                    }
                }
                objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, 0);
            }
            else
            {
                objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, 0);
            }
        }
    }
}