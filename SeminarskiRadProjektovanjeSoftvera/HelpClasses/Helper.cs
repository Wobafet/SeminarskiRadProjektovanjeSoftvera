using SeminarskiRadProjektovanjeSoftvera.Controller;
using SeminarskiRadProjektovanjeSoftvera.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.HelpClasses
{
    public class Helper
    {
        public Label Empty;


        
      //  public static bool EmptyField(Control control, Control label) => (string.IsNullOrWhiteSpace(control.Text)) ? label.Visible = true : label.Visible = false;

        public static bool RadioButtonChecked(RadioButton radioButton) => radioButton.Checked;
        public static bool EmailCheck(IGetValue email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email.GetValue().ToString());
            email.SetErrorProvider(match.Success, "Email is not valid !");
            return match.Success;
               
        }

        public static void  SchoolClassCheck(IGetValue schoolClass)
        {
            bool returnValue = false;
            string[] romanNumbers = new string [] { "I", "II", "III", "IV", "V", "VI","VII","VIII","IX" };

            string sc = schoolClass.GetValue().ToString();
            string help = "";
            for (int i = 0; i < romanNumbers.Length; i++)
            {

                if (sc.StartsWith(romanNumbers[i]))
                {
                    help = romanNumbers[i];
                    returnValue = true;
                    break;
                }

            }

            if (!returnValue)
            {
                schoolClass.SetErrorProvider(returnValue, "School class name contain roman numbers and arabic number. Example : VIII2");
                throw new ValidationException();
            }
             sc = sc.Substring(help.Length);

            if(sc.Any(s=> !char.IsDigit(s)))
            {
                returnValue = false;
            }


            schoolClass.SetErrorProvider(returnValue, "School class name contain roman numbers and arabic number. Example : VIII2");
         


        }

        public static bool PasswordCheck(IGetValue value)
        {
            string password = value.GetValue().ToString();

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password)
                && hasSymbols.IsMatch(password))
            {
                value.SetErrorProvider(true, "");
                return true;
            }

            else
            {
                value.SetErrorProvider(false, "Password is not correct. Must contain digit,uppercase(lowercase) letter and one special character");
                return false;
            }

        }

      


        public static void  EmptyField(params IGetValue[] users)
        {
            bool isEmpty = false;
            users.ToList().ForEach(u =>
            {
                if (string.IsNullOrWhiteSpace(u.GetValue().ToString()))
                {
                    isEmpty = true;
                    u.SetVisible(true);
                }
                else
                    u.SetVisible(false);
                    
            });
           
            if(isEmpty)
                throw new ValidationException();
            
          
        }
    }
}
