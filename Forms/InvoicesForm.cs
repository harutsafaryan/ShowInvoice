using ShowInvoice.Cache;
using ShowInvoice.Mappers;
using ShowInvoice.Models;
using ShowInvoice.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowInvoice.Forms
{
    public partial class InvoicesForm : Form
    {
        private readonly IAppCache _appCache;
        private readonly IInvoiceRepo _invoiceRepo;
        private readonly IProductRepo _productRepo;
        private readonly IInvoicelineRepo _invoicelineRepo;
        public InvoicesForm(IAppCache appCache, 
                            IInvoiceRepo invoiceRepo,
                            IProductRepo productRepo,
                            IInvoicelineRepo invoicelineRepo)
        {
            _appCache = appCache;
            _invoiceRepo = invoiceRepo;
            _productRepo = productRepo;
            _invoicelineRepo = invoicelineRepo;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Guid userId = (Guid)_appCache.ViewBag["userId"];
            List<Invoice> invoices = _invoiceRepo.GetAll().Where(i => i.UserId == userId).ToList();

            List<Product> products = _productRepo.GetAll();

            grdInvoices.DataSource = invoices.MapInvoiceToVoewModel(_invoicelineRepo.GetAll(), _productRepo.GetAll());

            base.OnLoad(e);
        }
        
        private void grdInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Product> products = _productRepo.GetAll();
            Guid guid = Guid.Parse("e57a082b-f835-402b-a7c4-baf9ebb42483");
            grdProducts.DataSource = products.MapProductToVoewModel(guid , _invoicelineRepo.GetAll());
        }
    }
}
