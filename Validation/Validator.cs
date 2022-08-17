using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.DB;

namespace BookBiz.Validation
{
    class Validator
    {
        static readonly string dbFile = @".\DAL\test.db"; // "\POSystem\POSystem\DAL\test.db"

        public static bool IsValidPass(string input)
        {
            if (input.Length != 5)
            {
                MessageBox.Show("Le mot de passe doit comporter 5 chiffres ou plus", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool IsEmpty(string text)
        {
            if (text == "")
            {
                MessageBox.Show("Informations manquantes, données vides non acceptées", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    /*    public static bool IsExist(string text)
        {
            string existName = "SELECT * FROM users WHERE name = '" + text + "' COLLATE NOCASE";

            DataTable dt = Db_ConnectQueries.Query_Connect_DB(existName);

            if (dt == null)
                return false;
            else
                return true;
        }*/

        public static bool TestConn()
        {
            if (File.Exists(dbFile))
            {
                return true;
            }

            else
                return false;
        }
    }
}
