using System.ComponentModel;
using System.Windows.Forms;
using Dark.Net;

namespace ThemeForm
{
    public partial class DarkForm : Form
    {
        public DarkForm(Theme theme)
            : base()
        {
            DarkNet.Instance.SetWindowThemeForms(this, theme);
            Invalidate();
        }

        public DarkForm()
            : this(Theme.Auto)
        {
        }

        public DarkForm(IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
