using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLayer
    {
        public static string[] GetAllText()
        {
            //tekknisk sett er ikke trengt og du kunne kalt fra DBLayer direkte, men dette vedlikeholder ordentlig Three Layered Architecture
            DBLayer dbl = new DBLayer();
            return dbl.GetAllText(); 
        }

        public static void UpdateText(string text, string slot)
        {
            DBLayer dbl = new DBLayer();
            dbl.UpdateText(text, slot);
        }

        public int GetAllFromLogIn(string userName, string passWord)
        {
            DBLayer dbl = new DBLayer();
            return dbl.GetAllFromLogIn(userName, passWord); 
        }

        public void ResetPassword(string userName, string passWord)
        {
            DBLayer dbl = new DBLayer();
            dbl.ResetPassword(userName, passWord);   
        }
    }
}
