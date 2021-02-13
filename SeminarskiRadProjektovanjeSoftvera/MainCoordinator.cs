using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera
{
   public  class MainCoordinator
    {
        public Teacher Teacher { get; internal set; }
        public Admin Admin { get; internal set; }


        private static  MainCoordinator instance;

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }


        private MainCoordinator()
        {

        }

        
        public void OpenForm(Form form,Form formClosing)
        {
            form.Show();
            formClosing.Dispose();
          
        }
       

        
    }
}
