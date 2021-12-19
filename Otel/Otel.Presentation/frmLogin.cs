using Otel.Business.Abstract;
using Otel.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otel.Presentation
{
    public partial class frmLogin : Form
    {
        private readonly ILoginService _loginService;
        public frmLogin(ILoginService loginService)
        {
            _loginService = loginService;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DateTime t = new DateTime();
            var loginResult = _loginService.Login(txtUserName.Text, txtPassword.Text);
        }
    }
}
