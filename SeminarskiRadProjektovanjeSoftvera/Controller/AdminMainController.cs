using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using SeminarskiRadProjektovanjeSoftvera.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    public class AdminMainController
    {
        private AdminMainForm adminMainForm;
     

        public AdminMainController(AdminMainForm adminMainForm)
        {
            this.adminMainForm = adminMainForm;
        }


        internal void OpenForm(Form form)
        {
            MainCoordinator.Instance.OpenForm(form, adminMainForm);
        }

        internal void CloseAdminMainForm()
        {
            Communication.Instance.Disconnect();
            MainCoordinator.Instance.OpenForm(new LoginForm(), adminMainForm);
            
        }


        
    }
}
