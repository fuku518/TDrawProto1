using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TDrawProto1.Controls
{
    /// <summary>
    /// Entity.xaml の相互作用ロジック
    /// </summary>
    public partial class Entity : UserControl
    {
        public String EntityName
        {
            get { return (String)GetValue(EntityNameProperty); }
            set { SetValue(EntityNameProperty, value); }
        }

        public static readonly DependencyProperty EntityNameProperty =
            DependencyProperty.Register(nameof(EntityName), typeof(String), typeof(Entity), new PropertyMetadata(null));

        public String Left
        {
            get { return (String)GetValue(LeftProperty); }
            set { SetValue(LeftProperty, value); }
        }

        public static readonly DependencyProperty LeftProperty =
            DependencyProperty.Register(nameof(Left), typeof(String), typeof(Entity), new PropertyMetadata(null));

        public String Right
        {
            get { return (String)GetValue(RightProperty); }
            set { SetValue(RightProperty, value); }
        }

        public static readonly DependencyProperty RightProperty =
            DependencyProperty.Register(nameof(Right), typeof(String), typeof(Entity), new PropertyMetadata(null));

        public String TypeName
        {
            get { return (String)GetValue(TypeNameProperty); }
            set { SetValue(TypeNameProperty, value); }
        }

        public static readonly DependencyProperty TypeNameProperty =
            DependencyProperty.Register(nameof(TypeName), typeof(String), typeof(Entity), new PropertyMetadata(null));

        public Entity()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
