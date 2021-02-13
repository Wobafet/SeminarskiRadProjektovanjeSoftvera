using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.UserControls
{
    public partial class UCTextBox : UserControl,IGetValue
    {
        public UCTextBox()
        {
            InitializeComponent();
            TextBox = textBox1;
            TextLabel = txtLabel;
            ErrorLabel = errorLabel;

            ErrorProvider = errorProvider1;

        }

        public TextBox TextBox { get; }
        public Label TextLabel { get; }
        public Label ErrorLabel { get; }

        public ErrorProvider ErrorProvider { get; set; }
        public object GetValue()
        {
            return TextBox.Text;
        }

        public void SetErrorProvider(bool set, string message)
        {
            if (set)
                errorProvider1.SetError(TextBox, "");
            else
                errorProvider1.SetError(TextBox, message);
        }

        public void SetLabelName(string name) => TextLabel.Text = name;


        public void SetVisible(bool visible) => ErrorLabel.Visible = visible;
    }
}
