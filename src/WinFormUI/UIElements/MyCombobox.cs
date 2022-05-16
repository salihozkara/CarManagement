using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI.UIElements
{
    public class MyCombobox:ComboBox
    {
        public MyCombobox()
        {

        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            var obj = Items.OfType<object>().FirstOrDefault(c => c.GetType().GetProperty(DisplayMember)?.GetValue(c)?.ToString() == Text);
            if (obj != null)
            {
                SelectedItem = obj;
                SelectionStart = Text.Length;
            }
            else
            {
                SelectedItem = null;
                
            }
        }
    }
}
