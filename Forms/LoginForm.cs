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
            users = userRead.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\users.json");
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


            //JsonRead<User> userRead = new JsonRead<User>();
            //JsonRead<Product> productRead = new JsonRead<Product>();
            //JsonRead<Invoice> invoiceRead = new JsonRead<Invoice>();
            //JsonRead<Invoiceline> invoiceLineRead = new JsonRead<Invoiceline>();

            //List<User> users = userRead.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\users.json");
            //List<Product> products = productRead.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\products.json");
            //List<Invoice> invoices = invoiceRead.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\invoices.json");
            //List<Invoiceline> invoicelines = invoiceLineRead.Read(@"C:\Users\user\source\repos\ShowInvoice\Data\invoicelines.json");
        }
    }
}
