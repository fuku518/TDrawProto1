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
using TDrawProto1.Controls;
using TDrawProto1.Models;

namespace TDrawProto1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Document doc = new Document();
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
            Loaded += OnMainWindowLoaded;
        }

        private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            CreateView(doc);
        }

        private void CreateView(Document doc)
        {
            for (var i = 0; i < doc.Entities.Count; i++)
            {
                var ei = doc.Entities[i];
                var ent = CreateEntity(ei);
                Canvas.SetLeft(ent, ei.X);
                Canvas.SetTop(ent, ei.Y);
                canvas.Children.Add(ent);
            }
        }

        private Entity CreateEntity(EntityInfo ei)
        {
            var ent = new Entity
            {
                Width = ei.Width,
                Height = ei.Height,
                Left = ei.Left,
                Right = ei.Right,
                EntityName = ei.Name,
                TypeName = ei.EntityType,
            };
            return ent;
        }

        private void Initialize()
        {
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                var ent = new EntityInfo
                {
                    Name = "商品",
                    EntityType = "R",
                    X = rnd.Next() % 800,
                    Y = rnd.Next() % 400,
                    Left = "商品コード",
                    Right = "商品名称" + Environment.NewLine + "商品価格",
                    Height = 100,
                    Width = 100,
                };
                doc.Entities.Add(ent);
            }
        }
    }
}
