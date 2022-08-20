using System.Windows.Forms;
using Abp.Dependency;
using Castle.MicroKernel.Registration;
using DevExpress.XtraBars.Ribbon;
using TGrant.Awe.Core.Widget.Contracts.View;

namespace TGrant.Awe.Custom.Platform.Win.View.MainFormView
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm, IMainFormView, ISingletonDependency
    {
        public MainForm()
        {
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

            IocManager.Instance.IocContainer.Register(
                Component.For<RibbonControl>().Instance(ribbonControl1)
            );

            WindowState = FormWindowState.Maximized;
            KeyPreview = true;
        }
    }
}
