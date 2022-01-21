using ShowInvoice.Cache;
using ShowInvoice.Forms;
using ShowInvoice.JsonManager;
using ShowInvoice.Models;
using ShowInvoice.Repo;
using ShowInvoice.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowInvoice
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IAppCache _appCache;
        private readonly InvoicesForm _invoicesForm;
        public LoginForm(InvoicesForm invoicesForm, IUserService userService, IAppCache appCache)
        {
            _invoicesForm = invoicesForm;
            _userService = userService;
            _appCache = appCache;
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;

            foreach (var user in _userService.GetAll())
            {
                if (user.Name == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    isValidUser = true;
                    _appCache.ViewBag.Add("userId", user.UserId);
                    _appCache.ViewBag.Add("userName", user.Name);
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    break;
                }
            }
            if (isValidUser)
            {
                _invoicesForm.ShowDialog();
                _invoicesForm.Activate();
            }
            else
            {
                MessageBox.Show("Invalid user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
