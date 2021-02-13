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
    public partial class UCComboBox : UserControl,IGetValue
    {
        public UCComboBox()
        {
            InitializeComponent();
            ComboBox = cb;
            TextLabel = txtLabel;
            ErrorLabel = errorLabel;
            ErrorProvider = errorProvider1;
        }

        public ErrorProvider ErrorProvider { get; set; }
        public ComboBox ComboBox { get; set; }
        public Label TextLabel { get; set; }
        public Label ErrorLabel { get; set; }

        public object GetValue()
        {
            return ComboBox.Text;
        }

        public void SetErrorProvider(bool set, string message)
        {
            throw new NotImplementedException();
        }



        public void SetLabelName(string name)
        {
            TextLabel.Text = name;
        }

        public void SetVisible(bool visible) => ErrorLabel.Visible = visible;
    }
}
