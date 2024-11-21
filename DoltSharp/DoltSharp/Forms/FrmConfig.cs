using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoltSharp
{
    public partial class FrmConfig : MetroFramework.Forms.MetroForm
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Hide();
        }

       
    }
}
