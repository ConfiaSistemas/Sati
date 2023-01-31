using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ConfiaAdmin.CustomControl
{
    class CheckComboBox : ComboBox
    {

        public class ComboboxData
        {
            private string TotalData;
            private bool _checked;

            public bool Checked
            {
                set
                {
                    _checked = value;
                }
                get
                {
                    return _checked;
                }
            }

            private string _data;

            public string Data
            {
                set
                {
                    _data = value;
                }
                get
                {
                    return _data;
                }
            }

            public ComboboxData(string value, bool ischeck)
            {
                Data = value;
                Checked = ischeck;
            }

            public override string ToString()
            {
                return Data;
            }
        }

        public event EventHandler Checkchanged;

        public CheckComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        public List<ComboboxData> CheckItems
        {
            get
            {
                var newitems = new List<ComboboxData>();

                foreach (var item in Items)
                {

                    if (item is ComboboxData)
                    {
                        newitems.Add(item as ComboboxData);
                    }
                }

                return newitems;
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            ComboboxData data = (ComboboxData)SelectedItem;
            data.Checked = !data.Checked;
            Checkchanged?.Invoke(data, e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }

            if (Items[e.Index] is ComboboxData)
            {
                ComboboxData data = Items[e.Index] as ComboboxData;
                CheckBoxRenderer.RenderMatchingApplicationState = true;
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.X, e.Bounds.Y), e.Bounds, data.Data, Font, (e.State & DrawItemState.Focus) == 0, data.Checked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
            }
            else
            {
                e.Graphics.DrawString(Items[e.Index].ToString(), Font, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
                return;
            }

            base.OnDrawItem(e);
        }
    }
}