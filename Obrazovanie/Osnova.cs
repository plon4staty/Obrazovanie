using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obrazovanie
{
    public partial class Osnova : Form
    {
        private readonly CheckUsers _user; 

        public Osnova(CheckUsers user)
        {
            InitializeComponent();
            _user = user;
        }
        private void Isadmin() 
        {

        }

        private void Osnova_Load(object sender, EventArgs e)
        {

        }
    }
}
