using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ConfiaAdmin
{
    public class Resizer
    {

        // ----------------------------------------------------------
        // ControlInfo
        // Structure of original state of all processed controls
        // ----------------------------------------------------------
        private struct ControlInfo
        {
            public string name;
            public string parentName;
            public double leftOffsetPercent;
            public double topOffsetPercent;
            public double heightPercent;
            public int originalHeight;
            public int originalWidth;
            public double widthPercent;
            public float originalFontSize;
        }

        // -------------------------------------------------------------------------
        // ctrlDict
        // Dictionary of (control name, control info) for all processed controls
        // -------------------------------------------------------------------------
        private Dictionary<string, ControlInfo> ctrlDict = new Dictionary<string, ControlInfo>();

        // ----------------------------------------------------------------------------------------
        // FindAllControls
        // Recursive function to process all controls contained in the initially passed
        // control container and store it in the Control dictionary
        // ----------------------------------------------------------------------------------------
        public void FindAllControls(Control thisCtrl)
        {

            // -- If the current control has a parent, store all original relative position
            // -- and size information in the dictionary.
            // -- Recursively call FindAllControls for each control contained in the
            // -- current Control
            foreach (Control ctl in thisCtrl.Controls)
            {
                try
                {
                    if (!(ctl.Parent == null))
                    {
                        int parentHeight = ctl.Parent.Height;
                        int parentWidth = ctl.Parent.Width;

                        var c = new ControlInfo();
                        c.name = ctl.Name;
                        c.parentName = ctl.Parent.Name;
                        c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight);
                        c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth);
                        c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight);
                        c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth);
                        c.originalFontSize = ctl.Font.Size;
                        c.originalHeight = ctl.Height;
                        c.originalWidth = ctl.Width;
                        ctrlDict.Add(c.name, c);
                    }
                }

                catch (Exception ex)
                {
                    Debug.Print(ex.Message);
                }

                if (ctl.Controls.Count > 0)
                {
                    FindAllControls(ctl);
                }

            } // -- For Each

        }

        // ----------------------------------------------------------------------------------------
        // ResizeAllControls
        // Recursive function to resize and reposition all controls contained in the Control
        // dictionary
        // ----------------------------------------------------------------------------------------
        public void ResizeAllControls(Control thisCtrl)
        {

            float fontRatioW;
            float fontRatioH;
            float fontRatio;
            Font f;

            // -- Resize and reposition all controls in the passed control
            foreach (Control ctl in thisCtrl.Controls)
            {
                try
                {
                    if (!(ctl.Parent == null))
                    {
                        int parentHeight = ctl.Parent.Height;
                        int parentWidth = ctl.Parent.Width;

                        var c = new ControlInfo();

                        bool ret = false;
                        try
                        {
                            // -- Get the current control's info from the control info dictionary
                            ret = ctrlDict.TryGetValue(ctl.Name, out c);

                            // -- If found, adjust the current control based on control relative
                            // -- size and position information stored in the dictionary
                            if (ret)
                            {
                                // -- Size
                                ctl.Width = (int)Math.Round(Conversion.Int(parentWidth * c.widthPercent));
                                ctl.Height = (int)Math.Round(Conversion.Int(parentHeight * c.heightPercent));

                                // -- Position
                                ctl.Top = (int)Math.Round(Conversion.Int(parentHeight * c.topOffsetPercent));
                                ctl.Left = (int)Math.Round(Conversion.Int(parentWidth * c.leftOffsetPercent));

                                // -- Font
                                f = ctl.Font;
                                fontRatioW = (float)(ctl.Width / (double)c.originalWidth);
                                fontRatioH = (float)(ctl.Height / (double)c.originalHeight);
                                fontRatio = (fontRatioW + fontRatioH) / 2f; // -- average change in control Height and Width
                                ctl.Font = new Font(f.FontFamily, c.originalFontSize * fontRatio, f.Style);

                            }
                        }
                        catch
                        {
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                // -- Recursive call for controls contained in the current control
                if (ctl.Controls.Count > 0)
                {
                    ResizeAllControls(ctl);
                }

            } // -- For Each
        }

    }
}