using ShowInvoice.Cache;
using ShowInvoice.Mappers;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowInvoice.Forms
{
    public partial class InvoicesForm : Form
    {
        private readonly IAppCache _appCache;
        private readonly IProductService _productService;
        private readonly IInvoiceLineService _invoiceLineService;
        private readonly IInvoiceService _invoiceService;

        public InvoicesForm(IAppCache appCache,
                            IProductService productService,
                            IInvoiceLineService invoiceLineService,
                            IInvoiceService invoiceService)
        {
            _appCache = appCache;
            _productService = productService;
            _invoiceLineService = invoiceLineService;
            _invoiceService = invoiceService;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            lblUser.Text = _appCache.ViewBag["userName"].ToString();
            Guid userId = (Guid)_appCache.ViewBag["userId"];
            List<Invoice> invoices = _invoiceService.GetInvoicesByUserId(userId);
            grdInvoices.DataSource = invoices.MapInvoiceToVoewModel(_invoiceLineService.GetAll(), _productService.GetAll());
            grdInvoices.Columns["InvoiceId"].Visible = false;
        }

        private void GrdInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid guid = (Guid)grdInvoices.Rows[e.RowIndex].Cells["InvoiceId"].Value;
            List<Product> products = _productService.GetProductsByInvoiceId(guid);
            List<Invoiceline> invoicelines = _invoiceLineService.GetInvoicelinesByInvoiceId(guid);
            grdProducts.DataSource = products.MapProductToVoewModel(guid, invoicelines);
        }

        protected override void OnClosed(EventArgs e)
        {
            _appCache.ViewBag.Remove("userName");
            _appCache.ViewBag.Remove("userId");
        }
    }
}
