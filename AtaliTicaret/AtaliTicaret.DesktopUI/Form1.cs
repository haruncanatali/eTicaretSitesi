using AtaliTicaret.Business.Abstract;
using AtaliTicaret.Business.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtaliTicaret.DesktopUI
{
    public partial class Form1 : Form
    {

        IProductService _productService;
        ICategoryService _categoryService;
        IDealerService _dealerService;

        public Form1()
        {
            InitializeComponent();

            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _dealerService = InstanceFactory.GetInstance<IDealerService>();

        }

        private void btnsClick(object sender, EventArgs e)
        {

            if(bilgiPanel.Visible == true)
            {
                bilgiPanel.Visible = false;
            }

            Button b = (Button)sender;

            switch (b.Text)
            {
                case "Ürünleri Görüntüle":
                    tabloDgv.DataSource = _productService.GetEntities(null);
                    tabloDgv.Refresh();
                    break;
                case "Kategorileri Görüntüle":
                    tabloDgv.DataSource = _categoryService.GetEntities(null);
                    tabloDgv.Refresh();
                    break;
                case "Satıcıları Görüntüle":
                    tabloDgv.DataSource = _dealerService.GetEntities(null);
                    tabloDgv.Refresh();
                    break;
            }
        }
    }
}
