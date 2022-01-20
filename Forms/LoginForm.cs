using ShowInvoice.Cache;
using ShowInvoice.Forms;
using ShowInvoice.JsonManager;
using ShowInvoice.Models;
using ShowInvoice.Repo;
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
        private readonly IUserRepo _userRepo;
        private readonly List<User> users;
        private readonly IAppCache _appCache;
        private readonly InvoicesForm _invoicesForm;
        public LoginForm(InvoicesForm invoicesForm, IUserRepo userRepo, IAppCache appCache)
        {
            _invoicesForm = invoicesForm;
            _userRepo = userRepo;
            _appCache = appCache;

            JsonRead<User> userRead = new JsonRead<User>();
            users = _userRepo.GetAll();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;

            foreach (var user in _userRepo.GetAll())
            {
                if (user.Name == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    isValidUser = true;
                    _appCache.ViewBag.Add("userId", user.UserId);
                    break;
                }
            }
            if (isValidUser)
            {
                _invoicesForm.Show();
            }
            else
            {
                MessageBox.Show("Invalis user");
            }
        }
    }
}
