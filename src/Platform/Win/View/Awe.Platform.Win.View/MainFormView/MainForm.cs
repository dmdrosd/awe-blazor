using System.Windows.Forms;
using Awe.Core.Widget.Contracts.View.MainForm;
using Volo.Abp.DependencyInjection;
using RibbonControl = DevExpress.XtraBars.Ribbon.RibbonControl;

namespace Awe.Platform.Win.View.MainFormView
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm, 
        IMainFormView, 
        ISingletonDependency
    {
        public MainForm()
        {
            InitializeComponent();

            WindowPropsInit();
        }
        public MainForm(RibbonControl ribbonControl)
        {
            ribbonControl1 = ribbonControl;
            InitializeComponent();

            WindowPropsInit();
        }

        public string Caption
        {
            get => Text;
            set => Text = value;
        }

        private void WindowPropsInit()
        {
            if (DesignMode)
            {
                return;
            }

            WindowState = FormWindowState.Maximized;
            KeyPreview = true;
        }
    }
}
