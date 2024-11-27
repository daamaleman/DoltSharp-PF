using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoltSharp.Services;

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


        private void BttnGuardarConfig_Click(object sender, EventArgs e)
        {
            SaveTheme();

            // Devuelve al form de MainPage
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }

        private void SaveTheme()
        {
            // Guarda el tema seleccionado
            AppConfigServices appConfigServices = new AppConfigServices();
            appConfigServices.MyDarkMode = TglDark.Checked;
            appConfigServices.MyStyle = CmbStyle.SelectedItem.ToString();
            appConfigServices.SaveConfigFile();
        }
    }
}
