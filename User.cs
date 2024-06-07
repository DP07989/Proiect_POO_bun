using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proiect_POO_bun
{
    internal class User
    {
        User(String Name, String Password)
        {
            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = users");
        }        
    }
}
