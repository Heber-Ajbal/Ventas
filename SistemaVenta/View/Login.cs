using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVenta.Model;

namespace SistemaVenta.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                using (DBSistemVentaEntities db = new DBSistemVentaEntities())
                {
                    

                    Users user = db.Users.Where(u => u.Document == txtDocument.Text && u.Password == txtPassoword.Text).FirstOrDefault();

                    if (user != null)
                    {
                        Menu mainMenu = new Menu();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("DOCUMENTO O CONTRASEÑA INCORRECTA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            


            

        }

        #region Logic

        

        #endregion


    }
}
